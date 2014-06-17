using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Google.GData.Client;
using Google.GData.Extensions;
using Google.GData.YouTube;
using Google.GData.Extensions.MediaRss;
using System.Drawing.Drawing2D;
using System.Net;
using System.Reflection;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Text.RegularExpressions;
using HSToolKit.MessagesWin32;
using System.Web;
using TubeQueue;
using SS.YoutubeDownloader;




namespace Form1
{
    public partial class TubeQueue : Form
    {

        
        // UPDATE ON RELEASE!!!!

        String version_number = "1.68";
        String release_date = "6/16/2014";


        // generic tooltip we will use for help messages

        ToolTip ttHelp;


        private bool keyHandled;
        bool first_run = true;
        


        /*
         *  Start WaitBoxDialog unmanaged imports
         */
           
        [DllImport("user32.dll")]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X,
            int Y, int cx, int cy, uint uFlags);

        static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
        static readonly IntPtr HWND_TOP = new IntPtr(0);

        const UInt32 SWP_NOSIZE = 0x0001;
        const UInt32 SWP_NOMOVE = 0x0002;
        const UInt32 SWP_NOZORDER = 0x0004;
        const UInt32 SWP_NOREDRAW = 0x0008;
        const UInt32 SWP_NOACTIVATE = 0x0010;
        const UInt32 SWP_FRAMECHANGED = 0x0020;  /* The frame changed: send WM_NCCALCSIZE */
        const UInt32 SWP_SHOWWINDOW = 0x0040;
        const UInt32 SWP_HIDEWINDOW = 0x0080;
        const UInt32 SWP_NOCOPYBITS = 0x0100;
        const UInt32 SWP_NOOWNERZORDER = 0x0200;  /* Don't do owner Z ordering */
        const UInt32 SWP_NOSENDCHANGING = 0x0400;  /* Don't send WM_WINDOWPOSCHANGING */

        const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;


        [DllImport("USER32.DLL")]
        public static extern bool BringWindowToTop(IntPtr hWnd);

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("USER32.DLL")]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("USER32.DLL")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        /*
         *  End WaitBoxDialog unmanaged imports
         */


        string current_working_directory = Application.StartupPath;
        YouTubeService service = new YouTubeService("example app", "ytapi-Home-TubeMaster-crfa4nq4-0", "AI39si60sOIidV7Wz5LjiRA-duTZy7JnZ0s98SmVj1ueAn8YS_8q4fRG_aAUDTL0r20F6V5nAPBlKv7EPoJOEn2Hh6jR2LJAIA");
        private List<DownloaderTask> dwnTasks = new List<DownloaderTask>();

        public static Form mul_urls = null;

        String manually_added_URLs = "";

        string temp_path;
        string conv_video_path;

        bool searchList_focus = true;
        bool queue_focus = true;
        bool processingQueue_focus = true;

        String selectedVideos;
        Form preview = new Form();
        TabControl tabs = new TabControl();
        int queue_iteration = 1;
        int queue_sync_iteration = 0;

        int image_iter = 0;
        bool runIt = true;
        bool viewCountRunOnce = false;
        int global_start = 0;
        int global_stop = 25;

        System.IntPtr appWin = IntPtr.Zero;
        System.Diagnostics.Process progressWin = null;

        int originalDescriptionColumnWidth = 0;
        int originalTitleColumnWidth = 0;

        public TubeQueue()
        {
            InitializeComponent(); //required by designer

            searchList.View = View.Details;
            initListView();
            searchList.HideSelection = false;
            PreviewMode.Checked = true;
            StyleHelper.DisableFlicker(lvDownloads);
            sortByRelevance.Checked = true;
            SearchTermTextbox.Focus();

            loadSettings();

            progressWin = System.Diagnostics.Process.Start(current_working_directory + "\\WaitDialogBox.exe");

            progressWin.PriorityClass = System.Diagnostics.ProcessPriorityClass.AboveNormal;
            
            if (!WaitForForm(progressWin, ref appWin))
            {
                return;
            }

            ShowWindow(appWin, (int)Win32.SW_HIDE);

            ChangeWindowToToolWindow(appWin);

        }

        #region Wait Dialog supporting code
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        // FUNCTION:    WaitForForm
        // PURPOSE:     See code.
        // NOTES:       None.
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        private bool WaitForForm(
                System.Diagnostics.Process arg_p,
            ref IntPtr arg_appwin)
        {
            bool bResult = true;
            arg_appwin = IntPtr.Zero;
            int iRefreshes = 0;
            bool bInternalError = false;
            while (arg_appwin == IntPtr.Zero)
            {
                arg_p.WaitForInputIdle();
                // Process.MainWindowHandle caches the window handle that it gets
                // the first time it's called. For some apps, a delay is needed
                // or we'll get the wrong window.  More specifically, on
                // 10/03/2007 I discovered that MainWindowHandle may not be set
                // right away and that it is not enough to do the WaitForInputIdle()
                // call above: we also need to do a Refresh()!
                arg_p.Refresh();
                iRefreshes++;
                if (iRefreshes > 1)
                {
                    Thread.Sleep(100);
                }
                arg_appwin = arg_p.MainWindowHandle;
                if (iRefreshes > 100) // 10 or more seconds transpired
                {
                    bInternalError = true;
                    break;
                }
            }
            if (bInternalError)
            {
                MessageBox.Show(
                    "Internal Error: too many refreshes (" +
                    iRefreshes + ") to get MainWindowhandle.  Please report" +
                    "to Harry Stein." + Environment.NewLine + "Application will close when you click OK");
                Application.Exit();
            }
            return bResult;
        } // WaitForForm

        private void ChangeWindowToToolWindow(IntPtr arg_appWin)
        {
            int iCurrWindowStyle = GetWindowLong(arg_appWin, (int)Win32.GWL_EXSTYLE);
            SetWindowLong(arg_appWin,
                (int)Win32.GWL_EXSTYLE,
                (IntPtr)(iCurrWindowStyle | (int)Win32L.WS_EX_TOOLWINDOW));
            SetWindowPos(arg_appWin, IntPtr.Zero, 0, 0, 0, 0, // x, y, cx, cy
                (uint)(Win32UI.SWP_FRAMECHANGED |
                        Win32UI.SWP_NOMOVE |
                        Win32UI.SWP_NOZORDER |
                        Win32UI.SWP_NOSIZE |
                        Win32UI.SWP_NOOWNERZORDER |
                        0));
        }
        #endregion

        public void loadSettings()
        {
            try
            {
                TextReader tr = new StreamReader(@current_working_directory + "\\settings\\General_Settings.txt");

                try
                {
                    if (tr.ReadLine().Equals("True"))
                        AppendSearch.Checked = true;
                    else AppendSearch.Checked = false;

                    if (tr.ReadLine().Equals("True"))
                        AutoResizeSearch.Checked = true;
                    else AutoResizeSearch.Checked = false;

                    if (tr.ReadLine().Equals("True"))
                        experTabView_prev.Checked = true;
                    else experTabView_prev.Checked = false;

                    if (tr.ReadLine().Equals("True"))
                        prompt_for_vid_conv.Checked = true;
                    else prompt_for_vid_conv.Checked = false;

                    if (tr.ReadLine().Equals("True"))
                        cbClearTempDirOnExit.Checked = true;
                    else cbClearTempDirOnExit.Checked = false;

                    string temp1 = tr.ReadLine();

                    if (temp1.Equals("<CWD>"))
                    {
                        temp_path = current_working_directory + "\\temp\\";
                        temp_dir_textbox.Text = "<Current Working Directory>";
                        temp_cwd.Checked = true;
                    }

                    else
                    {
                        temp_path = temp1;
                        temp_dir_textbox.Text = temp1;

                    }

                    string temp2 = tr.ReadLine();

                    if (temp2.Equals("<CWD>"))
                    {
                        conv_video_path = current_working_directory + "\\converted_videos\\";
                        conv_video_textbox.Text = "<Current Working Directory>";
                        conv_cwd.Checked = true;
                    }

                    else
                    {
                        conv_video_path = temp2;
                        conv_video_textbox.Text = temp2;
                    }

                    if (tr.ReadLine().Equals("True"))
                    {
                        make_yt_default.Checked = true;
                        tabControl1.Focus();
                        tabControl1.SelectedTab = YouTubeWebsiteSearchTab;
                        grab_url_of_video.Show();
                    }

                    if (experTabView_prev.Checked)
                    {
                        PreviewMode.Text = "Tab preview active (Right Arrow Key)";
                    }

                    else PreviewMode.Text = "In-line preview active (Right Arrow Key)";
                }

                catch (Exception settingsException)
                {
                    MessageBox.Show("The settings file does not appear to be in the expected format.\n\n" + settingsException.ToString());
                }


                tr.Close();

            }

            catch (Exception no_settings_file)
            {
                MessageBox.Show("There was a problem reading the settings file. Make sure the file \"General Settings\" exists in the folder \"settings\" in thhe same directory as TubeQueue.\n\nSetting all settings to default");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            runIt = false;

            search(0, 25);
        }

        public void search(int start_index, int end_index)
        {
            BringWindowToTop(appWin);
            SetWindowPos(appWin, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
            ShowWindow(appWin, (int)Win32.SW_SHOW);
            ShowWindow(appWin, (int)Win32.SW_NORMAL);

            searchList.Items.Clear();
            iconList_search.Images.Clear();


      
            string search_term = SearchTermTextbox.Text;

            YouTubeQuery query = new YouTubeQuery(YouTubeQuery.DefaultVideoUri);

            //order results by the number of views (most viewed first)

            if (sortByRelevance.Checked)
            {
                query.OrderBy = "relevance";
            }

            else if (sortByViewCount.Checked)
            {
                query.OrderBy = "viewCount";
            }

            else if (sortByDateAdded.Checked)
            {
                query.OrderBy = "published";
            }

            else if (sortByRating.Checked)
            {
                query.OrderBy = "rating";
            }


      
            query.VQ = search_term;

          
            query.StartIndex = start_index;
            query.NumberToRetrieve = end_index - start_index;

            YouTubeFeed videoFeed = service.Query(query);

            ListViewItem item;
            ListViewItem.ListViewSubItem item_sub;

            int iter = 0;

            foreach (YouTubeEntry entry in videoFeed.Entries)
            {

                try
                {
                    MediaThumbnail thumbnail = entry.Media.Thumbnails[0];
                    String uri = thumbnail.Attributes["url"].ToString();
                    WebRequest requestPic = WebRequest.Create(uri);
                    WebResponse responsePic = requestPic.GetResponse();
                    Image webImage = Image.FromStream(responsePic.GetResponseStream());
                    iconList_search.Images.Add(webImage);
                }
                catch
                {
                    // cant find thumbnail. who cares?

                    Image blank = Image.FromFile(current_working_directory + "\\Resources\\Blank.bmp");

                    iconList_search.Images.Add(blank);
                }

              

               
                item = new ListViewItem();
                item.ImageIndex = iter;
                item_sub = new ListViewItem.ListViewSubItem();
                item_sub.Text = entry.Title.Text;
                item.SubItems.Add(item_sub);

                item_sub = new ListViewItem.ListViewSubItem();
                item_sub.Text = entry.Media.Description.Value;
                item.SubItems.Add(item_sub);

                String duration = "00:00";

                foreach (MediaContent mediaContent in entry.Media.Contents)
                {

                    if (mediaContent.Attributes["duration"].ToString() != null)
                    {
                        TimeSpan t = TimeSpan.FromSeconds(Double.Parse(mediaContent.Attributes["duration"].ToString()));

                        if (t.Hours == 0) duration = t.Minutes.ToString().PadLeft(2, '0') + ":" + t.Seconds.ToString().PadLeft(2, '0');
                        else duration = t.ToString();

                    }




                }

                item_sub = new ListViewItem.ListViewSubItem();
                item_sub.Text = duration;
                item.SubItems.Add(item_sub);


                SimpleElement statistics = entry.getYouTubeExtension("statistics");

                String viewCount = "???";

                if (statistics != null)
                {
                    viewCount = statistics.Attributes["viewCount"].ToString();
                }

                item_sub = new ListViewItem.ListViewSubItem();
                item_sub.Text = viewCount;
                item.SubItems.Add(item_sub);


                string rating = "???";

                if (entry.Rating != null)
                {
                    rating = entry.Rating.Average.ToString();
                }

                item_sub = new ListViewItem.ListViewSubItem();
                item_sub.Text = rating;
                item.SubItems.Add(item_sub);

                item_sub = new ListViewItem.ListViewSubItem();
                item_sub.Text = entry.AlternateUri.Content.Replace("www.youtube.com", "youtube.com");
                item.SubItems.Add(item_sub);

                searchList.Items.Add(item);
                UpdateAutoScroll(ref searchList);

                if (AutoResizeSearch.Checked)
                {
                    searchList.Focus();
                    SendKeys.Send("^{+}");
                }
                iter++;
            }

            searchList.Focus();
            numResults.Text = "Videos " + start_index + " - " + end_index;
            ShowWindow(appWin, (int)Win32.SW_HIDE);
        }

        public void initListView()
        {
            ColumnHeader header1 = searchList.Columns.Add("prev", "Prev", 40, HorizontalAlignment.Left, 0);
            ColumnHeader header2 = searchList.Columns.Add("title", "Title", Convert.ToInt32(18 * searchList.Font.SizeInPoints), HorizontalAlignment.Left, 1);
            ColumnHeader header6 = searchList.Columns.Add("description", "Description", 20 * Convert.ToInt32(searchList.Font.SizeInPoints), HorizontalAlignment.Left, 5);
            ColumnHeader header3 = searchList.Columns.Add("time", "Time", Convert.ToInt32(5 * searchList.Font.SizeInPoints), HorizontalAlignment.Left, 2);
            ColumnHeader header4 = searchList.Columns.Add("view_count", "Views", Convert.ToInt32(7 * searchList.Font.SizeInPoints), HorizontalAlignment.Left, 3);
            ColumnHeader header5 = searchList.Columns.Add("rating", "Rating", Convert.ToInt32(5 * searchList.Font.SizeInPoints), HorizontalAlignment.Left, 4);
            ColumnHeader header7 = searchList.Columns.Add("url", "URL", 20 * Convert.ToInt32(searchList.Font.SizeInPoints), HorizontalAlignment.Left, 6);
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {

            ListView.ListViewItemCollection lView = queue.Items;

            foreach (ListViewItem item in lView)
            {
                item.Text = makeTitleFileCompliant(item.Text);
            }



            if (queue.Items.Count == 0)
            {
                MessageBox.Show("The Video Collection Queue is currently empty. Try adding items to it from the search list or directly from a URL.");

            }

            else
            {

                String conversion = "";

                if (AVI_RadioButton.Checked)
                {
                    conversion = "Convert to " + AVI_RadioButton.Text + " (" + conversionSettings.Text + ")";
                }

                else if (MP4_RadioButton.Checked)
                {
                    conversion = "Convert to " + MP4_RadioButton.Text + " (" + conversionSettings.Text + ")";
                }

                else if (FLV_RadioButton.Checked)
                {
                    conversion = "Download as " + FLV_RadioButton.Text + " (" + conversionSettings.Text + ")";
                }

                else if (generalMP4_RadioButton.Checked)
                {
                    conversion = "Convert to " + generalMP4_RadioButton.Text + " (" + conversionSettings.Text + ")";
                }

                else if (threegp_radiobutton.Checked)
                {
                    conversion = "Convert to " + threegp_radiobutton.Text + " (" + conversionSettings.Text + ")";
                }

                else if (getPrevSavedConversions_RadioButton.Checked)
                {
                    MyComboBoxItem item = (MyComboBoxItem)getPrevSavedSelectBox.SelectedItem;

                    conversion = "Convert to Custom (" + conversionSettings.Text + ")";
                }

                else if (iPodTouchPhone_RadioButton.Checked)
                {
                    conversion = "Convert to " + iPodTouchPhone_RadioButton.Text + " (" + conversionSettings.Text + ")";
                }

                TreeNode queue_identifier = new TreeNode("Queue " + queue_iteration);
                TreeNode action = new TreeNode(conversion);
                TreeNode video_name;

                foreach (ListViewItem item in queue.Items)
                {


                    if (!item.SubItems[1].Text.Contains("http://youtube.com"))
                    {
                        video_name = new TreeNode(item.SubItems[0].Text + " [" + item.SubItems[1].Text + "]");
                    }

                    else
                    {
                        try
                        {
                            char[] splitter1 = { '/' };
                            string[] split_url = item.SubItems[1].Text.Split(splitter1);

                            char[] splitter2 = { '=' };
                            string[] split_second_part = split_url[3].Split(splitter2);

                            video_name = new TreeNode(item.SubItems[0].Text + " [" + split_second_part[1] + "]");

                        }

                        catch (Exception malformat)
                        {
                            MessageBox.Show("The YouTube URL seems to be malformatted.");
                            video_name = null;
                        }

                    }


                    if (!video_name.Equals(null))
                        action.Nodes.Add(video_name);
                }

                queue_identifier.Nodes.Add(action);
                processingQueue.Nodes.Add(queue_identifier);

                queue_iteration++;

            }

        }

        private void searchList_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void sync_Click(object sender, EventArgs e)
        {
            if (searchList.Items.Count == 0)
            {
                MessageBox.Show("Search list is empty! Try searching for a term and selecting the thumbnails of the respective videos you wish to download in the resulting search list.");
            }

            else if (searchList.SelectedItems.Count == 0)
            {
                MessageBox.Show("No items selected for queueing!");
            }


            else
            {
                ToolsView.TabPages[0].Focus();

                ListView.SelectedListViewItemCollection selectedVideosList = searchList.SelectedItems;

                foreach (ListViewItem item in selectedVideosList)
                {
                    queue.Items.Add(item.SubItems[1].Text);
                    queue.Items[queue_sync_iteration].SubItems.Add(item.SubItems[6].Text);
                    queue_sync_iteration++;
                    // UpdateAutoScroll(ref queue);
                }
                UpdateAutoScroll(ref queue);
            }



        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            queue_sync_iteration = 0;
            queue.Items.Clear();
        }

        private void TubeMasterForm_Move(object sender, EventArgs e)
        {

            if (preview.Visible)
            {
                preview.Location = new Point(tabControl1.Location.X + 500, tabControl1.Location.Y);

            }
        }

        private void TubeMasterForm_Load(object sender, EventArgs e)
        {
            this.Text = "TubeQueue v " + version_number + " by Andrew Stein " + release_date;

            MainTabs.TabPages[0].Text = "Download and Convert";
            MainTabs.TabPages[1].Text = "Settings";

            originalTitleColumnWidth = searchList.Columns[1].Width;
            originalDescriptionColumnWidth = searchList.Columns[2].Width;

            maximizeOrMinimizeSearchListButton.Tag = "minimized";

            CheckForUpdates();


        }

        private void CheckForUpdates()
        {

            bool contactedUpdatedServer = false;

            try
            {
                WebClient Client = new WebClient();
                Client.DownloadFile("http://www.steinsolutions.com/home/TubeQueue/latestversion.txt", Application.StartupPath + "\\latestversion.txt");
                contactedUpdatedServer = true;

            }

            catch
            {

                if (MessageBox.Show(
                    "Cannot contact update server. This version may not be able to download videos from YouTube.\n\nVisit program homepage to check for updates?", "Cannot contact update server", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk
                ) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("http://fileforum.betanews.com/detail/TubeQueue/1219424161/1");
                }
            }

            if (contactedUpdatedServer)
            {
                String latestVersionText = File.ReadAllText(Application.StartupPath + "\\latestversion.txt");
                String[] latestVersion_split = latestVersionText.Split(',');
                Double latestVersion = Double.Parse(latestVersion_split[0]);
                String criticality = latestVersion_split[1];
                String releaseDate = latestVersion_split[2];

                String thisVersionText = File.ReadAllText(Application.StartupPath + "\\thisversion.txt");
                String[] thisVersionText_split = thisVersionText.Split(',');
                Double thisVersion = Double.Parse(thisVersionText_split[0]);

                if (latestVersion > thisVersion)
                {
                    String message;

                    if (criticality == "critical")
                    {
                        message = "A new version of TubeQueue (v. " + latestVersion + ") was released on " + releaseDate + ".\n\nIt is considered a critical update. If you do not update, you may not be able to download YouTube videos.\n\nVisit website to update?";
                    }
                    else
                    {
                        message = "A new version of TubeQueue (v. " + latestVersion + ") was released on " + releaseDate + ".\n\nIt is not considered a critical update but it may contain bug fixes and new features.\n\nVisit website to update?";
                    }

                    if (MessageBox.Show(
                        message, "New version avaiable", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk
                    ) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start("http://fileforum.betanews.com/detail/TubeQueue/1219424161/1");
                    }

                }
            }

        }

        private void searchList_KeyDown(object sender, KeyEventArgs e)
        {

            int numPreviewTabs = 0;
            String video_url = "";

            try
            {
                tabs.Dispose();
                preview.Dispose();
            }

            catch (Exception whatev)
            {
                MessageBox.Show(whatev.ToString());

            }

            preview = new Form();

            preview.Size = new Size(730, 600);


            tabs = new TabControl();
            tabs.Size = new Size(730, 600);

            switch (e.KeyCode)
            {


                case System.Windows.Forms.Keys.Right:

                    ListView.SelectedListViewItemCollection selectedVideosList = this.searchList.SelectedItems;


                    if (PreviewMode.Checked)
                    {
                        foreach (ListViewItem item in selectedVideosList)
                        {
                            video_url = item.SubItems[6].Text;

                            if (!experTabView_prev.Checked)
                            {
                                webBrowser1.Url = new Uri(item.SubItems[6].Text);

                                NoVideoSelectedYet.Hide();
                                NoVideoSelectedYet2.Hide();
                                NoVideoSelectedYet3.Hide();
                                webBrowser1.Show();

                                ToolsView.SelectedTab = tabPage5;
                            }


                            else
                            {
                                try
                                {
                                    tabs.TabPages.Add(numPreviewTabs.ToString(), item.SubItems[1].Text.Substring(0, 8) + "...", numPreviewTabs);
                                }

                                catch (Exception tooShort)
                                {
                                    tabs.TabPages.Add(numPreviewTabs.ToString(), item.SubItems[1].Text + "...", numPreviewTabs);
                                }

                                tabs.TabPages[tabs.TabCount - 1].Width = tabs.TabPages[tabs.TabCount - 1].Width + 15;

                                WebBrowser preview_browse = new WebBrowser();
                                preview_browse.Size = new Size(730, 600);

                                preview_browse.Url = new Uri(video_url);


                                tabs.TabPages[numPreviewTabs].Controls.Add(preview_browse);

                                numPreviewTabs++;

                            }

                        }

                        if (experTabView_prev.Checked)
                        {
                            preview.TopMost = true;
                            preview.Size = new Size(preview.Size.Width + 15, preview.Size.Height);
                            preview.Show();
                            preview.Location = new Point(ToolsView.Location.X + 15, ToolsView.Location.Y);
                            preview.Controls.Add(tabs);

                        }

                    }

                    preview.Location = new Point(tabControl1.Location.X + 500, tabControl1.Location.Y);

                    break;

                default:
                    break;
            }

        }

        private void clear_searchlist_Click(object sender, EventArgs e)
        {
            searchList.Items.Clear();
        }

        private void SearchTermTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                runIt = false;
                search(0, 25);
            }

            if (keyHandled)
            {
                e.Handled = true;
                keyHandled = false;
            }
        }

        private void processingQueue_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                processingQueue.SelectedNode = processingQueue.GetNodeAt(e.X, e.Y);

                if (processingQueue.SelectedNode != null)
                {
                    processingQueueStrip.Show(processingQueue, e.Location);
                }
            }
        }

        private void removeProcessingQueueItem_Click(object sender, EventArgs e)
        {

            if (processingQueue.SelectedNode.Text.Contains("Queue"))
            {
                processingQueue.SelectedNode.Remove();
            }

            else
            {
                if (processingQueue.SelectedNode != null)
                {

                    if (processingQueue.SelectedNode.Text.Contains("Convert to") || processingQueue.SelectedNode.Text.Contains("Download as"))
                    {

                        processingQueue.Nodes.Remove(processingQueue.SelectedNode.Parent);
                    }

                    else
                    {

                        if (processingQueue.SelectedNode.Parent.Nodes.Count == 1)
                        {
                            processingQueue.SelectedNode.Parent.Parent.Remove();

                        }

                        else
                        {
                            if (processingQueue.SelectedNode.Parent != null)
                            {
                                processingQueue.SelectedNode.Parent.Nodes.Remove(processingQueue.SelectedNode);
                            }

                            else
                            {
                                processingQueue.Nodes.Remove(processingQueue.SelectedNode);
                            }
                        }


                    }

                }

            }

        }

        private void ClearProcessingQueue_Click(object sender, EventArgs e)
        {
            queue_iteration = 1;
            processingQueue.Nodes.Clear();

        }

        private void ffmpeg_settings_textbox_save_Leave(object sender, EventArgs e)
        {
            saveTweakedConversions();

        }

        private void ffmpeg_settings_textbox_save_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {
                saveTweakedConversions();
            }
        }

        public void saveTweakedConversions()
        {
            try
            {

                StreamWriter SW;
                SW = File.AppendText(@current_working_directory + "\\settings\\Saved_Conversions.txt");
                SW.WriteLine(ffmpeg_settings_textbox_save.Text + "," + conversionSettings.Text);
                SW.Close();

                MessageBox.Show("Tweaked Conversion Saved");
                ffmpeg_settings_textbox_save.Text = "Type a name describing the settings here, then press Enter.";

            }

            catch (Exception error_file)
            {
                MessageBox.Show("Error writing to file!\n" + error_file.ToString());
            }

        }

        private void ffmpeg_settings_textbox_save_Click(object sender, EventArgs e)
        {
            ffmpeg_settings_textbox_save.Text = "";

        }

        private void getPrevSavedSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            getPrevSavedConversions_RadioButton.Checked = true;

            MyComboBoxItem item = (MyComboBoxItem)getPrevSavedSelectBox.SelectedItem;

            conversionSettings.Text = item.getValue();
        }

        private void DownloadAndProcessButton_Click(object sender, EventArgs e)
        {

            if (processingQueue.Nodes.Count == 0)
            {
                MessageBox.Show("There are no items to process in the queue");

            }
            try
            {

                foreach (TreeNode queue_indetification in processingQueue.Nodes)
                {
                    Application.DoEvents();
                    TreeNodeCollection queue_nodes = queue_indetification.Nodes;

                    foreach (TreeNode action in queue_nodes)
                    {
                        string conversion = action.Text.Substring(action.Text.LastIndexOf('(') + 1).Replace(")", "");

                        TreeNodeCollection videos = action.Nodes;

                        foreach (TreeNode video in videos)
                        {
                

                            string url;
                            string download_url;
                            Uri download_url_to_uri;

                            string title = video.Text.Substring(0, video.Text.LastIndexOf('[') - 1);
                            string code = video.Text.Substring(video.Text.LastIndexOf('[') + 1).Replace("]", "");

                            FileInfo fInfo = new FileInfo(code);

                            // If the file is local, go straight to conversion.

                            if (fInfo.Exists)
                            {
                                download_url_to_uri = null;
                                dwnTasks.Add(new DownloaderTask(download_url_to_uri, lvDownloads, code, conversion, temp_path, conv_video_path, prompt_for_vid_conv.Checked, true));
                            }

                            // Otherwise, download it and then convert.

                            else
                            {

                                title = makeTitleFileCompliant(video.Text.Substring(0, video.Text.LastIndexOf('[') - 1));

                                url = "http://youtube.com/watch?v=" + code;
                                download_url = get_download_url(url);
                                download_url_to_uri = new Uri(download_url);

                                dwnTasks.Add(new DownloaderTask(download_url_to_uri, lvDownloads, title, conversion, temp_path, conv_video_path, prompt_for_vid_conv.Checked, false));

                            }


                        }

                    }

                }

             
            }

            catch (Exception issue)
            {
                MessageBox.Show("There has been a problem with initiating the download/processing process. The exception text is --\n\n" + issue.ToString());
            }
        }

        public string makeTitleFileCompliant(string title_uncomp)
        {
            String ret_val = "";

            if (title_uncomp.Length == 0)
            {
                Random random = new Random();
                ret_val = "generic video" + random.Next(1000).ToString();
            }
            else
            {
                ret_val = title_uncomp.Replace("\\", "").Replace("/", "").Replace("*", "").Replace(":", "").Replace("?", "").Replace("\"", "").Replace("<", "").Replace(">", "").Replace("|", "");
            }


            return ret_val;
        }

        private string getYouTubePageContent(string url)
        {
            string buffer;
            try
            {
                string outputBuffer = "where=46038";
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                req.Method = "POST";
                req.ContentLength = outputBuffer.Length;
                req.ContentType = "application/x-www-form-urlencoded";
                StreamWriter swOut = new StreamWriter(req.GetRequestStream());
                swOut.Write(outputBuffer);
                swOut.Close();
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                StreamReader sr = new StreamReader(resp.GetResponseStream());
                buffer = sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception exp)
            {
                buffer = "Download Error: " + exp.ToString();
            }

            return (buffer);
        }

        private string convertYouTubeURL(string url)
        {
            try
            {

                url = url.Replace("www.youtube.com", "youtube.com");

                Match myMatch = Regex.Match(url, "...youtube");

                if (!myMatch.Value.Equals("://youtube"))
                {
                    url = url.Replace(myMatch.Value, "youtube");
                }

                if (url.IndexOf("http://youtube.com/v/") >= 0)
                {
                    url.Replace("http://youtube.com/v/", "http://youtube.com/watch?v=");
                }

                if (url.Contains("&v="))
                {
                    int start = url.IndexOf("&v=") + 3;

                    try
                    {
                        url = "http://youtube.com/watch?v=" + url.Substring(start, 11);
                    }

                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.ToString());
                    }

                }

                if (url.IndexOf("http://youtube.com/watch?v=") < 0)
                {
                    url = "";
                }

            }

            catch (Exception malformated)
            {
                url = "";
            }

            return (url);
        }

        public string get_video_title_from_url(String url)
        {

            // should really be using VideoQualitySelection library here but 
            // too lazy to change it 

            String retTitle = "";

            YTDownload.YTDownload yt = new YTDownload.YTDownload(url);

            retTitle = yt.getTitle;

            return retTitle;

        }

        public string get_download_url(string Url)
        {
           

            String retUrl = "";

            VideoQualitySelection frmVqs = new VideoQualitySelection(Url);

            frmVqs.btnOk.DialogResult = DialogResult.OK;
            var result = frmVqs.ShowDialog();

            if (result.ToString() == "OK")
            {
                retUrl = frmVqs.QualityAsURL;
            }

            frmVqs.Dispose();

            return retUrl;


        }

        private void addURLToQueue_Click(object sender, MouseEventArgs e)
        {
            single_URL_add.Text = "Type in a single YouTube URL and press Enter.";

            number_of_urls.Show(addURLToQueue, e.Location);

        }

        private void URL_to_queue_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                string url = convertYouTubeURL(manually_added_URLs);

                if (url == "")
                {
                    MessageBox.Show("That is not a valid YouTube URL!");
                    manually_added_URLs = "";
                }

                else
                {
                    queue.Items.Add(get_video_title_from_url(url));
                    queue.Items[queue_sync_iteration].SubItems.Add(url);
                    queue_sync_iteration++;
                    manually_added_URLs = "";
                    UpdateAutoScroll(ref queue);
                }

            }

        }

        private void sortByRelevance_CheckedChanged(object sender, EventArgs e)
        {
            if (searchList.Items.Count > 0)
            {
                if (!viewCountRunOnce)
                {
                    viewCountRunOnce = true;

                }

                else
                {
                    search(0, 25);
                }
            }


        }

        private void sortByViewCount_CheckedChanged(object sender, EventArgs e)
        {

            if (searchList.Items.Count > 0)
            {
                search(0, 25);
            }

        }

        private void sortByRating_CheckedChanged(object sender, EventArgs e)
        {

            if (searchList.Items.Count > 0)
            {
                search(0, 25);
            }
        }

        private void sortByDateAdded_CheckedChanged(object sender, EventArgs e)
        {
            if (searchList.Items.Count > 0)
            {
                search(0, 25);
            }

        }

        private void page25More(object sender, EventArgs e)
        {
            if (searchList.Items.Count == 0)
            {
                MessageBox.Show("No results to page through! Try searching for something first.");

            }

            else
            {
                global_start = global_stop + 1;
                global_stop = global_start + 25;

                search(global_start, global_stop);

            }


        }

        public void minimizeTabControlYT()
        {
          
            tabControl1.Width = 583;
            tabControl1.Height = 399;
            tabControl1.SendToBack();
            youtube_browser.Width = 569;
            youtube_browser.Height = 350;

            grab_url_of_video.Visible = true;
            maximizeYTbutton.Visible = true;

        }


        private void button1_Click_1(object sender, EventArgs e)
        {

            if (searchList.Items.Count == 0)
            {
                MessageBox.Show("No results to page through! Try searching for something first.");

            }

            else
            {
                if (global_start <= 0)
                {
                    global_start = 0;
                    global_stop = 25;
                }

                else
                {
                    global_stop = global_start - 1;
                    global_start = global_stop - 25;
                    search(global_start, global_stop);

                }

            }

        }

        private void qUickHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have two options to search for YouTube videos using this program.\n\n(1) You can use the \"Built-in YouTube Search\" search feature that is initially presented to you when the program first loads.\nIn this instance, you simply search using the Search bar. When the results load, right click on the thumbnails of the video(s) that you wish to download/convert, and press \"Add to Queue\"\n\n(2) You can search/browse the YouTube website itself by clicking on the \"YouTube Website Search\" tab on the right of the screen. When you get to the page of the video you wish to download, press the \"Add to Queue\" button.\n\nBy default, videos are temporarily stored in the same directory as the TubeQueue.exe executable, in a folder called \"temp\".\n \"Processed\" videos (those that have been converted, etc) are stored in the same directory, under a folder called \"processed_videos\". The locations of these folders can be changed in the settings.\n\nFor hands-on help, see the tutorial video.");

        }


        private void SaveTweakedConversion_Click_1(object sender, EventArgs e)
        {
            Point loc = new Point(conversionSettings.Location.X + 50, conversionSettings.Location.Y - 300);

            savedFFMPEGTweakedSettings.Show(conversionSettings, loc);

        }

        private void getPrevSavedSelectBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            getPrevSavedConversions_RadioButton.Checked = true;

            MyComboBoxItem item = (MyComboBoxItem)getPrevSavedSelectBox.SelectedItem;

            conversionSettings.Text = item.getValue();
        }

        private void getPrevSavedSelectBox_DropDown_1(object sender, EventArgs e)
        {
            getPrevSavedSelectBox.Items.Clear();

            TextReader tr = new StreamReader(@current_working_directory + "\\settings\\Saved_Conversions.txt");

            // read a line of text

            string line;
            char[] splitter = { ',' };

            while ((line = tr.ReadLine()) != null)
            {
                string[] split = line.Split(splitter);

                getPrevSavedSelectBox.Items.Add(new MyComboBoxItem(split[0], split[1]));
            }

            tr.Close();
        }

        private void AVI_RadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            conversionSettings.Text = "ffmpeg -i %v -vcodec msmpeg4 -vtag MP43 %o.avi";

        }

        private void MP4_RadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            conversionSettings.Text = "ffmpeg -y -i %v -f mp4 -vcodec libx264 -level 13 -b 512k -bt 512k -bufsize 2000k -maxrate 768k -g 250 -coder 0 -threads auto -acodec libfaac -ac 2 -ab 128k %o.mp4";
        }

        private void generalMP4_RadioButton_CheckedChanged_1(object sender, EventArgs e)
        {

            conversionSettings.Text = "ffmpeg -i %v -ar 22050 %o.mp4";
        }

        private void FLV_RadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            conversionSettings.Text = "<Do Nothing, Just Download>";
        }

        private void threegp_radiobutton_CheckedChanged_1(object sender, EventArgs e)
        {
            conversionSettings.Text = "ffmpeg -i %v -s 176x144 -i %o.3gp";

        }

        private void iPodTouchPhone_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            conversionSettings.Text = "ffmpeg -y -i %v -f mp4 -vcodec libx264 -level 13 -s 320x240 -b 512k -bt 512k -bufsize 2000k -maxrate 768k -g 250 -coder 0 -threads auto -acodec libfaac -ac 2 -ab 128k %o.mp4";
        }

        private void tutorialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "http://www.youtube.com/watch?v=j9xymYfv_Ho");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TubeQueue by Andrew Stein (andrew1stein@gmail.com)\n\nhttp://www.andrewsteinhome.com\n\nDownload listview logic thanks to Macari Veaceslav of CodeProject. http://www.codeproject.com/KB/dotnet/WebClientAsyncDownloader.aspx\n\nThanks to spunky for the VLC tips -- http://spunkyvt.wordpress.com/2008/04/21/vlc-and-c/\n\nThis project also extensively relies on the YouTube APT .NET abstraction classes, the open-source and incredible FFMPEG project, and various code snippets from across the Web. That's why TubeQueue will always be freeware - I'm just paying my dues to the Internet community.");
        }

        private void bugsIssuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(1) The DOS window that results when FFMPEG is spawned is not supressed and contained in some fashion within the program window itself. Support for this will hopefully come in a future update.\n\n(2) The downloading progress indication box isn't scrollable as a result of it constantly reverting to the top. This will hopefully be fixed in a future update.\n\n(3) You can't delete individual items from the Video Collection Queue or the Downloaded Items listview. This will come in a future update.\n\n(4) No feedback of any kind is piped from FFMPEG back to the program. This will be fixed in a future update.");
        }

        private void deleteSelectedNode_Click(object sender, EventArgs e)
        {
            if (processingQueue.SelectedNode != null)
            {
                // Root node's Parent property is null, so do check

                if (processingQueue.SelectedNode.Text.Contains("Convert to"))
                {
                    processingQueue.Nodes.Remove(processingQueue.SelectedNode.Parent);
                }

                else
                {
                    if (processingQueue.SelectedNode.Parent != null)
                    {
                        processingQueue.SelectedNode.Parent.Nodes.Remove(processingQueue.SelectedNode);
                    }

                    else
                    {
                        processingQueue.Nodes.Remove(processingQueue.SelectedNode);
                    }

                }

            }
        }

        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            TextWriter save = new StreamWriter(@current_working_directory + "\\settings\\General_Settings.txt");
            save.WriteLine(AppendSearch.Checked.ToString());
            save.WriteLine(AutoResizeSearch.Checked.ToString());
            save.WriteLine(experTabView_prev.Checked.ToString());
            save.WriteLine(prompt_for_vid_conv.Checked.ToString());
            save.WriteLine(cbClearTempDirOnExit.Checked.ToString());

            if (temp_cwd.Checked)
            {
                save.WriteLine("<CWD>");
            }

            else save.WriteLine(temp_path);

            if (conv_cwd.Checked)
            {
                save.WriteLine("<CWD>");
            }

            else save.WriteLine(conv_video_path);

            save.WriteLine(make_yt_default.Checked.ToString());

            save.Close();

            MessageBox.Show("Settings saved.");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchList_MouseMove(object sender, MouseEventArgs e)
        {
            if (searchList_focus)
                searchList.Focus();
        }

        private void queue_MouseMove(object sender, MouseEventArgs e)
        {
            if (queue_focus)
                queue.Focus();
        }

        private void SearchTermTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                SearchTermTextbox.SelectAll();
            }

        }

        private void searchList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column.ToString().Equals("1"))
            {
                //searchList.Sorting = SortOrder.Ascending;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lvDownloads.Items.Clear();
        }

        private void addToQueueStripItem_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedVideosList = searchList.SelectedItems;

            foreach (ListViewItem item in selectedVideosList)
            {
                queue.Items.Add(item.SubItems[1].Text);
                queue.Items[queue_sync_iteration].SubItems.Add(item.SubItems[6].Text);
                queue_sync_iteration++;
                //UpdateAutoScroll(ref queue);
            }
            UpdateAutoScroll(ref queue);
        }

        private void searchList_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (searchList.SelectedItems.Count > 1)
                {
                    addToQueueStripItem.Text = "Add videos to queue";
                }

                else if (searchList.SelectedItems.Count == 1)
                {
                    addToQueueStripItem.Text = "Add video to queue";
                }

                addToQueueStrip.Show(searchList, e.Location);

            }
        }

        private void addToQueueStrip_Opening(object sender, CancelEventArgs e)
        {
            addToQueueStripItem.ShowDropDown();
        }

        private void ToolsView_Selected(object sender, TabControlEventArgs e)
        {

            if (e.TabPage.Text.Equals("Preview") && searchList.SelectedItems.Count == 0)
            {
                webBrowser1.Hide();

                NoVideoSelectedYet.Show();
                NoVideoSelectedYet2.Show();
                NoVideoSelectedYet3.Show();

            }

            else
            {
                NoVideoSelectedYet.Hide();
                NoVideoSelectedYet2.Hide();
                NoVideoSelectedYet3.Hide();
                webBrowser1.Show();

            }

        }

        private void single_url_choice_Click(object sender, EventArgs e)
        {


        }

        private void mul_urls_choice_Click(object sender, EventArgs e)
        {
            mul_urls = new Form();

            mul_urls.Height = mul_urls.Height +10;
            mul_urls.Width = mul_urls.Height + 10;

            // prevent user from resizing this form
            mul_urls.MaximumSize = new Size(mul_urls.Height + 10, mul_urls.Height + 10);

            mul_urls.MinimumSize = new Size(mul_urls.Height + 10, mul_urls.Height + 10);

            
            mul_urls.StartPosition = FormStartPosition.CenterParent;
            TextBox myTextbox = new TextBox();
            Label instructions = new Label();
            instructions.Text = "Add multiple URL's here, seperated by a space.";
            instructions.Width = 300;
            instructions.Location = new Point(12, 6);
            myTextbox.Location = new Point(12, 30);
            myTextbox.Multiline = true;
            myTextbox.Width = 280;
            myTextbox.Height = 200;
            myTextbox.Name = "myTextbox";

            Button add = new Button();
            add.Text = "Add URL(s) to queue";
            add.Width = 120;

            mul_urls.Controls.Add(myTextbox);
            add.Location = new Point(12, 240);
            mul_urls.Controls.Add(add);
            mul_urls.Controls.Add(instructions);

            searchList_focus = false;
            queue_focus = false;
            processingQueue_focus = false;

            add.Click += new System.EventHandler(this.add_Click);
            mul_urls.TopMost = true; // not sure if you need this – it may end up hidden behind your main form
            mul_urls.Show();

        }

        public delegate void ladd_Click(object sender, EventArgs e);

        public void add_Click(object sender, EventArgs e)
        {
            //manually_added_URLs = mul_urls.Controls["myTextbox"].Text;
            // 2:
            manually_added_URLs = mul_urls.Controls["myTextbox"].Text;//dad: breakpoint

            string[] split = manually_added_URLs.Split(Environment.NewLine.ToCharArray());


            BringWindowToTop(appWin);
            SetWindowPos(appWin, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
            ShowWindow(appWin, (int)Win32.SW_SHOW);
            ShowWindow(appWin, (int)Win32.SW_NORMAL);


            foreach (string s in split)
            {
                if (!s.Equals(""))
                {



                    string url = convertYouTubeURL(s);


                    if (url.Equals(""))
                    {
                        MessageBox.Show("That is not a valid YouTube URL! Offending URL - \n" + s);
                    }

                    else
                    {
                        queue.Items.Add(get_video_title_from_url(url));
                        queue.Items[queue_sync_iteration].SubItems.Add(url);
                        queue_sync_iteration++;
                        UpdateAutoScroll(ref queue);
                    }
                }

            }
            UpdateAutoScroll(ref queue);


            ShowWindow(appWin, (int)Win32.SW_HIDE);

            manually_added_URLs = "";
            mul_urls.Close();
        }

        private void UpdateAutoScroll(ref ListView arg_lv)
        {

            if (arg_lv != null)
            {

                int iCount = arg_lv.Items.Count;

                if (iCount >= 1)
                {

                    arg_lv.Items[iCount - 1].EnsureVisible();

                    arg_lv.Refresh();

                }

            }

        }

        private void youtube_browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {



            if (tabControl1.SelectedTab.Name.Equals("YouTubeWebsiteSearchTab"))
            {


                minimizeTabControlYT();
                grab_url_of_video.Visible = true;

                if (first_run)
                {
                    Uri url = new Uri("http://www.youtube.com");
                    youtube_browser.Url = url;
                }

                first_run = false;

            }

            else
            {
                grab_url_of_video.Visible = false;

                minimizeTabControlYT();

                try
                {

                    if (System.Windows.Forms.Application.OpenForms["YoutubeWebsiteControls"] != null)
                    {
                        System.Windows.Forms.Application.OpenForms["YoutubeWebsiteControls"].Close();
                    }



                }

                catch{
                }

                searchList_Minimize();

            } 

            if (tabControl1.SelectedTab.Name.Equals("mediaLibTab"))
            {
                DisplayItems(conv_video_path);
            }

            
        }

        private void DisplayItems(string path)
        {
            mediaLibImageList.Images.Clear();
            lvMediaLibrary.Items.Clear();

            System.IO.DirectoryInfo di = new DirectoryInfo(path);

            foreach (System.IO.FileInfo file in di.GetFiles())
            {
                string key = file.Extension;


                if (key != ".txt")
                {
                    if (!this.mediaLibImageList.Images.Keys.Contains(file.FullName))
                    {
                        this.mediaLibImageList.Images.Add(file.FullName, System.Drawing.Icon.ExtractAssociatedIcon(file.FullName).ToBitmap());
                    }

                    int index = this.mediaLibImageList.Images.Keys.IndexOf(file.FullName);


                    ListViewItem item = new ListViewItem();

                    item.Text = file.Name;

                    item.ImageIndex = index;

                    item.Tag = file.FullName;


                    this.lvMediaLibrary.Items.Add(item);
                }

              
            }

            lvMediaLibrary.SmallImageList = mediaLibImageList;
            lvMediaLibrary.View = View.SmallIcon;
        }

        private void experTabView_prev_CheckedChanged(object sender, EventArgs e)
        {
            if (experTabView_prev.Checked)
            {
                PreviewMode.Text = "Tab preview active (Right Arrow Key)";
            }

            else PreviewMode.Text = "In-line preview active (Right Arrow Key)";
        }

        private void single_URL_add_MouseDown(object sender, MouseEventArgs e)
        {
            if (single_URL_add.Text.Equals("Type in a single YouTube URL and press Enter."))
            single_URL_add.Clear();
        }

        private void single_URL_add_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                manually_added_URLs = single_URL_add.Text;

                BringWindowToTop(appWin);
                SetWindowPos(appWin, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
                ShowWindow(appWin, (int)Win32.SW_SHOW);
                ShowWindow(appWin, (int)Win32.SW_NORMAL);

                string url = convertYouTubeURL(manually_added_URLs);

                ShowWindow(appWin, (int)Win32.SW_HIDE);

                if (url == "")
                {
                    MessageBox.Show("That is not a valid YouTube URL!");
                    manually_added_URLs = "";
                }

                else
                {
                    queue.Items.Add(get_video_title_from_url(url));
                    queue.Items[queue_sync_iteration].SubItems.Add(url);
                    queue_sync_iteration++;
                    manually_added_URLs = "";
                    UpdateAutoScroll(ref queue);

                }
            }

            if (keyHandled)
            {
                e.Handled = true;
                keyHandled = false;


            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            openLocalFLVFile.Multiselect = true;

            if (openLocalFLVFile.ShowDialog() == DialogResult.OK)
            {
                foreach (string filename in openLocalFLVFile.FileNames)
                {
                    FileInfo fInfo = new FileInfo(filename);
                    queue.Items.Add(fInfo.Name.Replace(fInfo.Extension, ""));
                    queue.Items[queue_sync_iteration].SubItems.Add(filename);
                    queue_sync_iteration++;
                    //UpdateAutoScroll(ref queue);
                }
                UpdateAutoScroll(ref queue);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (temp_dir_select.ShowDialog() == DialogResult.OK)
            {
                temp_path = temp_dir_select.SelectedPath;
            }

            temp_dir_textbox.Text = temp_path;

        }

        private void temp_cwd_CheckedChanged(object sender, EventArgs e)
        {
            if (temp_cwd.Checked)
            {
                button4.Hide();
                temp_dir_textbox.Text = "<Current Working Directory>";
                temp_path = current_working_directory + "\\temp\\";
            }

            else button4.Show();
        }

        private void conv_cwd_CheckedChanged(object sender, EventArgs e)
        {
            if (conv_cwd.Checked)
            {
                button5.Hide();
                conv_video_textbox.Text = "<Current Working Directory>";
                conv_video_path = current_working_directory + "\\processed_videos\\";
            }

            else button5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (conv_video_dir.ShowDialog() == DialogResult.OK)
            {
                conv_video_path = conv_video_dir.SelectedPath;
                conv_video_textbox.Text = conv_video_path;
            }

        }

        private void getPrevSavedConversions_RadioButton_CheckedChanged(object sender, EventArgs e)
        {

            if (getPrevSavedConversions_RadioButton.Checked)
            {
                try
                {
                    MyComboBoxItem item = (MyComboBoxItem)getPrevSavedSelectBox.SelectedItem;

                    if (!item.getValue().Equals("Previously saved conversion..."))
                    {
                        conversionSettings.Text = item.getValue();
                    }

                }

                catch (Exception noItemSelected)
                {
                    getPrevSavedConversions_RadioButton.Checked = false;
                }


            }

        }

        private void grab_url_of_video_Click(object sender, EventArgs e)
        {

            getURLFromWebview();
        }

        public void getURLFromWebview()
        {

            BringWindowToTop(appWin);
            SetWindowPos(appWin, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
            ShowWindow(appWin, (int)Win32.SW_SHOW);
            ShowWindow(appWin, (int)Win32.SW_NORMAL);

            string url = convertYouTubeURL(youtube_browser.Url.ToString());
            ShowWindow(appWin, (int)Win32.SW_HIDE);

            queue.Items.Add(get_video_title_from_url(url));
            queue.Items[queue_sync_iteration].SubItems.Add(url);
            queue_sync_iteration++;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "http://www.andrewsteinhome.com");
        }

        private void TubeQueue_FormClosing(object sender, FormClosingEventArgs e)
        {

            // clean out the temporary directory if the setting is set

            try
            {
                if (cbClearTempDirOnExit.Checked)
                {

                    string[] tempFiles = Directory.GetFiles(temp_path);

                    foreach (string files in tempFiles)
                    {
                        // we don't want to delete "do not delete.txt"

                        if (new FileInfo(files).Extension != ".txt")
                        {
                            File.Delete(files);
                        }
                      
                    }
                }
            
            }

            catch
            {
                MessageBox.Show("Could not empty temporary directory - possibly a permissions issue");
            }
          
            progressWin.Kill();
        }

        private void queue_MouseUp_1(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                queue_menu_options.Show(queue, e.Location);

            }
        }

        private void queue_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = queue.SelectedItems;

            foreach (ListViewItem item in selected)
            {
                item.BeginEdit();
            }
        }

        private void rename_queue_menu_options_Click(object sender, EventArgs e)
        {

            ListView.SelectedListViewItemCollection selected = queue.SelectedItems;

            foreach (ListViewItem item in selected)
            {
                item.BeginEdit();
            }
        }

        private void delete_queue_menu_options_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = queue.SelectedItems;

            foreach (ListViewItem item in selected)
            {
                item.Remove();
                queue_sync_iteration--;
            }
        }

        private void closeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (progressWin != null)
                progressWin.Kill();

            Environment.Exit(0);

        }

        private void addURLToQueue_MouseClick(object sender, MouseEventArgs e)
        {
            number_of_urls.Show(addURLToQueue, e.Location);
        }

        private void addURLToQueue_Click(object sender, EventArgs e)
        {
            //
        }

        private void single_url_choice_MouseDown(object sender, MouseEventArgs e)
        {
            //Point temp = new Point (addURLToQueue.Location.X, addURLToQueue.Location.Y);

            addsingleURL.Show(addURLToQueue, e.Location); ;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(temp_path);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(conv_video_path);
        }

        private void maximizeYTbutton_Click(object sender, EventArgs e)
        {
            grab_url_of_video.Visible = false;
            maximizeYTbutton.Visible = false;

        
            tabControl1.Width = 1200;
            tabControl1.Height = 590;
            youtube_browser.Width = 1070;
            youtube_browser.Height = 590;
            tabControl1.BringToFront();

            YoutubeWebsiteControls frm = new YoutubeWebsiteControls();
            frm.Show();
            frm.TopMost = true;
        }

        private void maximizeOrMinimizeSearchListButton_Click(object sender, EventArgs e)
        {
            // currently minimized but we want to maximize it 

            if (maximizeOrMinimizeSearchListButton.Tag.ToString() == "minimized")
            {
                searchList_Maximize();
                maximizeOrMinimizeSearchListButton.Tag = "";
            }

            // we are resetting to defaults
            else
            {
                searchList_Minimize();
                maximizeOrMinimizeSearchListButton.Tag = "minimized";
             

            }

        }

        private void searchList_Minimize()
        {
            searchList.Width = 564;
            searchList.Height = 282;
            tabControl1.Width = 583;
            tabControl1.Height = 399;
            maximizeOrMinimizeSearchListButton.Tag = "minimized";


            searchList.Columns[2].Width = originalDescriptionColumnWidth;
            searchList.Columns[1].Width = originalTitleColumnWidth;

            maximizeOrMinimizeSearchListButton.Image = global::TubeQueue.Properties.Resources.max;
        }

        private void searchList_Maximize()
        {
            searchList.Width = 1070;
            searchList.Height = 590;
            tabControl1.Width = 1070;
            tabControl1.Height = 590;
            tabControl1.BringToFront();

            searchList.Columns[2].Width = 400;
            searchList.Columns[1].Width = 300;

            maximizeOrMinimizeSearchListButton.Tag = "maximized";

            maximizeOrMinimizeSearchListButton.Image = global::TubeQueue.Properties.Resources.min;
        }

        private void maximizeYTbutton_MouseLeave(object sender, EventArgs e)
        {
            if (ttHelp != null)
            {
                ttHelp.Dispose();
            }
        }

        private void maximizeYTbutton_MouseEnter(object sender, EventArgs e)
        {
            ttHelp = new ToolTip();
            ttHelp.IsBalloon = true;
            ttHelp.SetToolTip(maximizeYTbutton, "Maximize the YouTube window");

        }

        private void maximizeOrMinimizeSearchListButton_MouseEnter(object sender, EventArgs e)
        {
            ttHelp = new ToolTip();
            ttHelp.IsBalloon = true;
            ttHelp.SetToolTip(maximizeOrMinimizeSearchListButton, "Maximize or minimize the search grid");
        }

        private void maximizeOrMinimizeSearchListButton_MouseLeave(object sender, EventArgs e)
        {
            if (ttHelp != null)
            {
                ttHelp.Dispose();
            }
        }

        private void pagePrevious25_MouseEnter(object sender, EventArgs e)
        {
            ttHelp = new ToolTip();
            ttHelp.IsBalloon = true;
            ttHelp.SetToolTip(pagePrevious25 , "Previous 25 results");
        }

        private void pagePrevious25_MouseLeave(object sender, EventArgs e)
        {
            if (ttHelp != null)
            {
                ttHelp.Dispose();
            }
        }

        private void pageNext25_MouseEnter(object sender, EventArgs e)
        {
            ttHelp = new ToolTip();
            ttHelp.IsBalloon = true;
            ttHelp.SetToolTip(pageNext25 , "Next 25 results");
        }

        private void pageNext25_MouseLeave(object sender, EventArgs e)
        {
            if (ttHelp != null)
            {
                ttHelp.Dispose();
            }
        }

        private void lvMediaLibrary_DoubleClick(object sender, EventArgs e)
        {
            String fName = lvMediaLibrary.SelectedItems[0].Tag.ToString();
            System.Diagnostics.Process.Start(fName);
        }

      
    }
}

// supporting classes

#region ListViewNF Class

class ListViewNF : System.Windows.Forms.ListView
{
    public ListViewNF()
    {
        //Activate double buffering
        this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);

        //Enable the OnNotifyMessage event so we get a chance to filter out 
        // Windows messages before they get to the form's WndProc
        this.SetStyle(ControlStyles.EnableNotifyMessage, true);
    }

    protected override void OnNotifyMessage(Message m)
    {
        //Filter out the WM_ERASEBKGND message
        if (m.Msg != 0x14)
        {
            base.OnNotifyMessage(m);
        }
    }
}

#endregion  

#region DownloaderTask class

class DownloaderTask
{
    string current_working_directory = Application.StartupPath;

    #region Private fields
    private WebClient webClient;
    private string fileName;

    bool local_file_global;
    string final_temp = "";
    string final_conv = "";

    private string conversion_description;
    bool prompt_for_vid_conv_final;
    private Uri uriData;
    private long fileSize;

    private System.Windows.Forms.ListView lvDetails;
    private System.Windows.Forms.ListViewGroup associatedGroup;
    private List<System.Windows.Forms.ListViewItem> descriptionItems;

    private const int DETAIL_URI = 0;
    private const int DETAIL_BYTES = 1;
    private const int DETAIL_CANCEL = 2;
    #endregion

    #region Constructors
    /// <summary>
    ///     Default constructor  
    /// </summary>
    /// <param name="uriData">the URI to the downloadable resource</param>
    public DownloaderTask(Uri uriData)
        : this(uriData, null, null, null, null, null, false, false)
    {

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="uriString"></param>
    public DownloaderTask(string uriString)
        : this(new Uri(uriString), null, null, null, null, null, false, false)
    {

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="uriString"></param>
    /// <param name="lvDetails"></param>
    public DownloaderTask(string uriString, System.Windows.Forms.ListView lvDetails)
        : this(new Uri(uriString), lvDetails, null, null, null, null, false, false)
    {
    }

    /// <summary>
    ///     The intialization constructor
    /// </summary>
    /// <param name="uriData">The URI to downloadable resource</param>
    /// <param name="lvDetails">The list view wich holds status info</param>
    public DownloaderTask(Uri uriData, System.Windows.Forms.ListView lvDetails, string title, string conversion_descrip, string temp_path, string video_conv_path, bool prompt_for_vid_conv, bool local_file)
    {
        local_file_global = local_file;

        prompt_for_vid_conv_final = prompt_for_vid_conv;

        final_temp = temp_path;
        final_conv = video_conv_path;

        conversion_description = conversion_descrip;

        // Case: File is local

        if (local_file_global)
        {
            fileName = title;

            if (conversion_description.Equals("<Do Nothing, Just Download>"))
            {
                File.Move(@final_temp + "\\" + fileName + ".flv", @final_conv + "\\" + fileName + ".flv");
            }

            else
            {
                DirectoryInfo dir_Info = new DirectoryInfo(current_working_directory);
                String root = dir_Info.Root.ToString().Replace("\\", "");

                FileInfo fInfo = new FileInfo(fileName);
                String file_name = fInfo.Name.Replace(fInfo.Extension, "");
                String conversion = conversion_description.Replace("%v", "\"" + fileName + "\"").Replace("%o", "\"" + final_conv + "\\" + file_name + "\"").Replace("ffmpeg", "ffmpeg.exe");
                TextWriter convert = new StreamWriter(current_working_directory + "\\tubequeue_latest_conversion.bat");
                convert.WriteLine("@echo off");
                convert.WriteLine(root);
                convert.WriteLine("CD \"" + current_working_directory + "\"");
                convert.WriteLine("START " + conversion);
                convert.Close();

                System.Diagnostics.Process convert_proc = new System.Diagnostics.Process();
                convert_proc.StartInfo.CreateNoWindow = true;

                if (prompt_for_vid_conv_final == true)

                    MessageBox.Show("Click OK to start conversion of " + fileName + ".\n(You can turn this notice off in the Settings.)");
                convert_proc = System.Diagnostics.Process.Start(current_working_directory + "\\tubequeue_latest_conversion.bat");

                convert_proc.WaitForExit();

            }

        }
        else
        {
            #region Prepare for download
            this.uriData = uriData;
            fileName = title;
            webClient = new WebClient();
            this.lvDetails = lvDetails;
            #endregion

            #region Assign call backs

            lvDetails.Width = lvDetails.Width + 50;
            if (lvDetails != null)
            {
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(webClient_DownloadProgressChanged);
                webClient.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(webClient_DownloadFileCompleted);


                associatedGroup = lvDetails.Groups.Add((new Guid()).ToString(), String.Format("{0} - starting ... ", fileName));

                descriptionItems = new List<System.Windows.Forms.ListViewItem>();
                descriptionItems.Add(new System.Windows.Forms.ListViewItem(uriData.OriginalString, associatedGroup)); // DETAIL_URI
                descriptionItems.Add(new System.Windows.Forms.ListViewItem("Downloaded 0/? bytes", associatedGroup)); // DETAIL_BYTES

                //descriptionItems.Add(new System.Windows.Forms.ListViewItem("Cancel", associatedGroup)); // DETAIL_CANCEL
                descriptionItems.Add(new System.Windows.Forms.ListViewItem("", associatedGroup)); // DETAIL_CANCEL

                descriptionItems[DETAIL_CANCEL].BackColor = System.Drawing.Color.Silver;
                descriptionItems[DETAIL_CANCEL].ForeColor = System.Drawing.Color.Blue;
                descriptionItems[DETAIL_URI].ImageIndex = 0;

                lvDetails.Items.AddRange(descriptionItems.ToArray());
                // gives error: UpdateAutoScroll(ref lvDetails);
                lvDetails.Update();
            }
            #endregion

            #region Start file download


            if (File.Exists(@temp_path + "\\" + fileName + ".flv"))
            {
                Random random = new Random();

                fileName = fileName + "_" + random.Next(0, 5000).ToString();
                webClient.DownloadFileAsync(uriData, @temp_path + "\\" + fileName + ".flv", associatedGroup);
            }

            else
            {
                webClient.DownloadFileAsync(uriData, @temp_path + "\\" + fileName + ".flv", associatedGroup);
            }

            #endregion

        }

    }
    #endregion

    #region Downloader callback
    /// <summary>
    ///     Call back for download complete.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e">Download complete status</param>
    private void webClient_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
    {

        #region Check if additional info. is required
        if (associatedGroup == null)
        {
            return;
        }
        #endregion

        #region Process error state

        if (e.Error == null)
        {

            associatedGroup.Header = String.Format("{0} - completed", fileName);
            descriptionItems[DETAIL_BYTES].ForeColor = System.Drawing.Color.Green;
            descriptionItems[DETAIL_BYTES].Text = String.Format("File size - {0}", GetHumanReadableFileSize(fileSize));

            //MessageBox.Show(conversion_description);

            if (conversion_description.Equals("<Do Nothing, Just Download>"))
            {
                File.Move(@final_temp + "\\" + fileName + ".flv", @final_conv + "\\" + fileName + ".flv");
            }

            else
            {
                DirectoryInfo dir_Info = new DirectoryInfo(current_working_directory);
                String root = dir_Info.Root.ToString().Replace("\\", "");
                String conversion = conversion_description.Replace("%v", "\"" + final_temp + "\\" + fileName + ".flv\"").Replace("%o", "\"" + final_conv + "\\" + fileName + "\"").Replace("ffmpeg", "ffmpeg.exe");
                TextWriter convert = new StreamWriter(current_working_directory + "\\tubequeue_latest_conversion.bat");
                convert.WriteLine("@echo off");
                convert.WriteLine(root);
                convert.WriteLine("CD \"" + current_working_directory + "\"");
                convert.WriteLine("START " + conversion);
                convert.Close();

                System.Diagnostics.Process convert_proc = new System.Diagnostics.Process();
                convert_proc.StartInfo.CreateNoWindow = true;

                if (prompt_for_vid_conv_final == true)

                    MessageBox.Show("Click OK to start conversion of " + fileName + ".\n(You can turn this notice off in the settings)");
                convert_proc = System.Diagnostics.Process.Start(current_working_directory + "\\tubequeue_latest_conversion.bat");

                convert_proc.WaitForExit();

            }




            //descriptionItems[DETAIL_CANCEL].Text = "Remove";
            descriptionItems[DETAIL_CANCEL].Text = "";
        }
        else if (e.Cancelled == false && e.Error != null)
        {
            associatedGroup.Header = String.Format("{0} - Failed", fileName);
            descriptionItems[DETAIL_BYTES].Text = e.Error.Message;
            descriptionItems[DETAIL_BYTES].ForeColor = System.Drawing.Color.Red;
        }
        #endregion

        #region Process canceled download
        if (e.Cancelled == true)
        {
            associatedGroup.Header = String.Format("{0} - Canceled", fileName);
            descriptionItems[DETAIL_BYTES].ForeColor = System.Drawing.Color.DarkGray;
        }
        #endregion



    }

    /// <summary>
    ///     A download progress is reported
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e">the download progress information</param>
    private void webClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
    {


        //Application.DoEvents();


        #region Check if additional info. is required
        if (associatedGroup == null)
        {
            return;
        }
        #endregion

        #region Show progress info
        fileSize = e.TotalBytesToReceive;
        associatedGroup.Header = String.Format("{0} - {1}%", fileName, e.ProgressPercentage);
        descriptionItems[DETAIL_BYTES].Text = String.Format("Downloaded {0}/{1}", GetHumanReadableFileSize(e.BytesReceived), GetHumanReadableFileSize(fileSize));
        #endregion
    }
    #endregion


    #region Helper classes
    /// <summary>
    ///     Convert bytes to a human readable format
    /// </summary>
    /// <param name="fileSize">the number bytes</param>
    /// <returns>apropriate amount of bytes (Gb, Mb, Kb, bytes)</returns>
    private string GetHumanReadableFileSize(long fileSize)
    {
        #region Gb
        if ((fileSize / (1024 * 1024 * 1024)) > 0)
        {

            return String.Format("{0} Gb", (double)Math.Round((double)(fileSize / (1024 * 1024 * 1024)), 2));
        }
        #endregion

        #region Mb
        if ((fileSize / (1024 * 1024)) > 0)
        {
            return String.Format("{0} Mb", (double)Math.Round((double)(fileSize / (1024 * 1024)), 2));
        }
        #endregion

        #region Kb
        if ((fileSize / 1024) > 0)
        {
            return String.Format("{0} Kb", (double)Math.Round((double)(fileSize / 1024), 2));
        }
        #endregion

        #region Bytes
        return String.Format("{0} b", fileSize);
        #endregion
    }
    #endregion

    #region Component event handler
    /// <summary>
    ///     Process the item click event. Cancel or remove a download. 
    /// </summary>
    /// <param name="item">The item which was clicked</param>
    /// <returns>True if the clicked item is managed by this component</returns>
    public bool ItemClicked(System.Windows.Forms.ListViewItem item)
    {

        if (associatedGroup != null && descriptionItems != null && descriptionItems.Count > 0 && item == descriptionItems[DETAIL_CANCEL])
        {
            if (webClient.IsBusy == true)
            {
                webClient.CancelAsync();
            }
            else
            {
                webClient.CancelAsync();
                foreach (System.Windows.Forms.ListViewItem itemList in descriptionItems)
                {
                    lvDetails.Items.Remove(itemList);
                    itemList.Remove();
                }

                descriptionItems.Clear();
                lvDetails.Groups.Remove(associatedGroup);
            }

            return true;
        }

        return false;
    }
    #endregion
}

#endregion

#region MyComboBoxItem class

public class MyComboBoxItem
{
    private string _name;
    private string _value;

    public MyComboBoxItem(string name, string value)
    {
        _name = name;
        _value = value;
    }

    public override string ToString()
    {
        return _name;
    }

    public String getValue()
    {
        return _value;
    }

}

#endregion

#region StyleHelper class

public class StyleHelper
{
    public static void DisableFlicker(System.Windows.Forms.Control ctrl)
    {
        MethodInfo method = ctrl.GetType().GetMethod("SetStyle", BindingFlags.Instance | BindingFlags.NonPublic);
        if (method != null)
        {
            method.Invoke(ctrl, new object[] { ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true });
        }
    }
}

#endregion

