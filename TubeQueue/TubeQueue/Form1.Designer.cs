namespace Form1
{
    partial class TubeQueue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.iconList_search = new System.Windows.Forms.ImageList(this.components);
            this.MainTabs = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.processingQueue = new System.Windows.Forms.TreeView();
            this.deleteSelectedNode = new System.Windows.Forms.Button();
            this.ClearProcessingQueue = new System.Windows.Forms.Button();
            this.DownloadAndProcessButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.lvDownloads = new EXControls.EXListView();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.builtInYTSearchTab = new System.Windows.Forms.TabPage();
            this.maximizeOrMinimizeSearchListButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.numResults = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SearchTermTextbox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.sortByViewCount = new System.Windows.Forms.RadioButton();
            this.SortByLabel = new System.Windows.Forms.Label();
            this.sortByRelevance = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.sortByRating = new System.Windows.Forms.RadioButton();
            this.sortByDateAdded = new System.Windows.Forms.RadioButton();
            this.PreviewMode = new System.Windows.Forms.CheckBox();
            this.searchList = new System.Windows.Forms.ListView();
            this.getMoreSearchResults = new System.Windows.Forms.Button();
            this.YouTubeWebsiteSearchTab = new System.Windows.Forms.TabPage();
            this.maximizeYTbutton = new System.Windows.Forms.Button();
            this.youtube_browser = new System.Windows.Forms.WebBrowser();
            this.grab_url_of_video = new System.Windows.Forms.Button();
            this.mediaLibTab = new System.Windows.Forms.TabPage();
            this.lvMediaLibrary = new System.Windows.Forms.ListView();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ProcessLabel = new System.Windows.Forms.Label();
            this.addURLToQueue = new System.Windows.Forms.Button();
            this.AddURLLabel = new System.Windows.Forms.Label();
            this.Process = new System.Windows.Forms.Label();
            this.ToolsView = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.getPrevSavedConversions_RadioButton = new System.Windows.Forms.RadioButton();
            this.clearButton = new System.Windows.Forms.Button();
            this.SaveTweakedConversion = new System.Windows.Forms.Button();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.iPodTouchPhone_RadioButton = new System.Windows.Forms.RadioButton();
            this.threegp_radiobutton = new System.Windows.Forms.RadioButton();
            this.getPrevSavedSelectBox = new System.Windows.Forms.ComboBox();
            this.generalMP4_RadioButton = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.conversionSettings = new System.Windows.Forms.TextBox();
            this.FLV_RadioButton = new System.Windows.Forms.RadioButton();
            this.AVI_RadioButton = new System.Windows.Forms.RadioButton();
            this.MP4_RadioButton = new System.Windows.Forms.RadioButton();
            this.queue = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.URL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.NoVideoSelectedYet = new System.Windows.Forms.Label();
            this.NoVideoSelectedYet2 = new System.Windows.Forms.Label();
            this.NoVideoSelectedYet3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.conv_video_textbox = new System.Windows.Forms.TextBox();
            this.temp_dir_textbox = new System.Windows.Forms.TextBox();
            this.conv_cwd = new System.Windows.Forms.CheckBox();
            this.temp_cwd = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SaveSettingsButton = new System.Windows.Forms.Button();
            this.InterfaceSettings = new System.Windows.Forms.GroupBox();
            this.make_yt_default = new System.Windows.Forms.CheckBox();
            this.prompt_for_vid_conv = new System.Windows.Forms.CheckBox();
            this.experTabView_prev = new System.Windows.Forms.CheckBox();
            this.AutoResizeSearch = new System.Windows.Forms.CheckBox();
            this.AppendSearch = new System.Windows.Forms.CheckBox();
            this.processingQueueStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeProcessingQueueItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savedFFMPEGTweakedSettings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ffmpeg_settings_textbox_save = new System.Windows.Forms.ToolStripTextBox();
            this.addToQueueStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToQueueStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.number_of_urls = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.single_url_choice = new System.Windows.Forms.ToolStripMenuItem();
            this.mul_urls_choice = new System.Windows.Forms.ToolStripMenuItem();
            this.addsingleURL = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.single_URL_add = new System.Windows.Forms.ToolStripTextBox();
            this.openLocalFLVFile = new System.Windows.Forms.OpenFileDialog();
            this.temp_dir_select = new System.Windows.Forms.FolderBrowserDialog();
            this.conv_video_dir = new System.Windows.Forms.FolderBrowserDialog();
            this.queue_menu_options = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rename_queue_menu_options = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_queue_menu_options = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaLibImageList = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.MainTabs.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.builtInYTSearchTab.SuspendLayout();
            this.YouTubeWebsiteSearchTab.SuspendLayout();
            this.mediaLibTab.SuspendLayout();
            this.ToolsView.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.InterfaceSettings.SuspendLayout();
            this.processingQueueStrip.SuspendLayout();
            this.savedFFMPEGTweakedSettings.SuspendLayout();
            this.addToQueueStrip.SuspendLayout();
            this.number_of_urls.SuspendLayout();
            this.addsingleURL.SuspendLayout();
            this.queue_menu_options.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconList_search
            // 
            this.iconList_search.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.iconList_search.ImageSize = new System.Drawing.Size(40, 40);
            this.iconList_search.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MainTabs
            // 
            this.MainTabs.Controls.Add(this.tabPage3);
            this.MainTabs.Controls.Add(this.tabPage4);
            this.MainTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTabs.Location = new System.Drawing.Point(2, 2);
            this.MainTabs.Name = "MainTabs";
            this.MainTabs.SelectedIndex = 0;
            this.MainTabs.Size = new System.Drawing.Size(1091, 620);
            this.MainTabs.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.processingQueue);
            this.tabPage3.Controls.Add(this.deleteSelectedNode);
            this.tabPage3.Controls.Add(this.ClearProcessingQueue);
            this.tabPage3.Controls.Add(this.DownloadAndProcessButton);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.lvDownloads);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.tabControl1);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.ProcessLabel);
            this.tabPage3.Controls.Add(this.addURLToQueue);
            this.tabPage3.Controls.Add(this.AddURLLabel);
            this.tabPage3.Controls.Add(this.Process);
            this.tabPage3.Controls.Add(this.ToolsView);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1083, 594);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Download/Convert";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(900, 408);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(174, 24);
            this.button7.TabIndex = 34;
            this.button7.Text = "Open Converted Videos Folder";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(784, 408);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 24);
            this.button6.TabIndex = 33;
            this.button6.Text = "Open Downloads";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // processingQueue
            // 
            this.processingQueue.Location = new System.Drawing.Point(13, 468);
            this.processingQueue.Name = "processingQueue";
            this.processingQueue.Size = new System.Drawing.Size(491, 119);
            this.processingQueue.TabIndex = 0;
            this.processingQueue.MouseUp += new System.Windows.Forms.MouseEventHandler(this.processingQueue_MouseUp);
            // 
            // deleteSelectedNode
            // 
            this.deleteSelectedNode.Location = new System.Drawing.Point(216, 439);
            this.deleteSelectedNode.Name = "deleteSelectedNode";
            this.deleteSelectedNode.Size = new System.Drawing.Size(94, 24);
            this.deleteSelectedNode.TabIndex = 13;
            this.deleteSelectedNode.Text = "Delete selected";
            this.deleteSelectedNode.UseVisualStyleBackColor = true;
            this.deleteSelectedNode.Click += new System.EventHandler(this.deleteSelectedNode_Click);
            // 
            // ClearProcessingQueue
            // 
            this.ClearProcessingQueue.Location = new System.Drawing.Point(316, 440);
            this.ClearProcessingQueue.Name = "ClearProcessingQueue";
            this.ClearProcessingQueue.Size = new System.Drawing.Size(53, 23);
            this.ClearProcessingQueue.TabIndex = 12;
            this.ClearProcessingQueue.Text = "Clear All";
            this.ClearProcessingQueue.UseVisualStyleBackColor = true;
            this.ClearProcessingQueue.Click += new System.EventHandler(this.ClearProcessingQueue_Click);
            // 
            // DownloadAndProcessButton
            // 
            this.DownloadAndProcessButton.BackColor = System.Drawing.Color.Red;
            this.DownloadAndProcessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadAndProcessButton.ForeColor = System.Drawing.Color.White;
            this.DownloadAndProcessButton.Location = new System.Drawing.Point(375, 435);
            this.DownloadAndProcessButton.Name = "DownloadAndProcessButton";
            this.DownloadAndProcessButton.Size = new System.Drawing.Size(129, 29);
            this.DownloadAndProcessButton.TabIndex = 11;
            this.DownloadAndProcessButton.Text = "Download/Convert";
            this.DownloadAndProcessButton.UseVisualStyleBackColor = false;
            this.DownloadAndProcessButton.Click += new System.EventHandler(this.DownloadAndProcessButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(506, 410);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(188, 22);
            this.label13.TabIndex = 32;
            this.label13.Text = "Download Progress";
            // 
            // lvDownloads
            // 
            this.lvDownloads.ControlPadding = 4;
            this.lvDownloads.FullRowSelect = true;
            this.lvDownloads.Location = new System.Drawing.Point(510, 441);
            this.lvDownloads.MaximumSize = new System.Drawing.Size(564, 149);
            this.lvDownloads.MinimumSize = new System.Drawing.Size(564, 149);
            this.lvDownloads.Name = "lvDownloads";
            this.lvDownloads.OwnerDraw = true;
            this.lvDownloads.Size = new System.Drawing.Size(564, 149);
            this.lvDownloads.TabIndex = 2;
            this.lvDownloads.UseCompatibleStateImageBehavior = false;
            this.lvDownloads.View = System.Windows.Forms.View.Tile;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(708, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 24);
            this.button2.TabIndex = 14;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.builtInYTSearchTab);
            this.tabControl1.Controls.Add(this.YouTubeWebsiteSearchTab);
            this.tabControl1.Controls.Add(this.mediaLibTab);
            this.tabControl1.Location = new System.Drawing.Point(6, 3);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(583, 399);
            this.tabControl1.TabIndex = 30;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // builtInYTSearchTab
            // 
            this.builtInYTSearchTab.Controls.Add(this.maximizeOrMinimizeSearchListButton);
            this.builtInYTSearchTab.Controls.Add(this.label16);
            this.builtInYTSearchTab.Controls.Add(this.numResults);
            this.builtInYTSearchTab.Controls.Add(this.label12);
            this.builtInYTSearchTab.Controls.Add(this.SearchTermTextbox);
            this.builtInYTSearchTab.Controls.Add(this.SearchButton);
            this.builtInYTSearchTab.Controls.Add(this.sortByViewCount);
            this.builtInYTSearchTab.Controls.Add(this.SortByLabel);
            this.builtInYTSearchTab.Controls.Add(this.sortByRelevance);
            this.builtInYTSearchTab.Controls.Add(this.button1);
            this.builtInYTSearchTab.Controls.Add(this.sortByRating);
            this.builtInYTSearchTab.Controls.Add(this.sortByDateAdded);
            this.builtInYTSearchTab.Controls.Add(this.PreviewMode);
            this.builtInYTSearchTab.Controls.Add(this.searchList);
            this.builtInYTSearchTab.Controls.Add(this.getMoreSearchResults);
            this.builtInYTSearchTab.Location = new System.Drawing.Point(4, 22);
            this.builtInYTSearchTab.Name = "builtInYTSearchTab";
            this.builtInYTSearchTab.Padding = new System.Windows.Forms.Padding(3);
            this.builtInYTSearchTab.Size = new System.Drawing.Size(575, 373);
            this.builtInYTSearchTab.TabIndex = 0;
            this.builtInYTSearchTab.Text = "Built-in YouTube Search";
            this.builtInYTSearchTab.ToolTipText = "Built-in YouTube Search (best for batches video opeations)";
            this.builtInYTSearchTab.UseVisualStyleBackColor = true;
            // 
            // maximizeOrMinimizeSearchListButton
            // 
            this.maximizeOrMinimizeSearchListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximizeOrMinimizeSearchListButton.ForeColor = System.Drawing.Color.Blue;
            this.maximizeOrMinimizeSearchListButton.Image = global::TubeQueue.Properties.Resources.max;
            this.maximizeOrMinimizeSearchListButton.Location = new System.Drawing.Point(457, 61);
            this.maximizeOrMinimizeSearchListButton.Name = "maximizeOrMinimizeSearchListButton";
            this.maximizeOrMinimizeSearchListButton.Size = new System.Drawing.Size(37, 21);
            this.maximizeOrMinimizeSearchListButton.TabIndex = 32;
            this.maximizeOrMinimizeSearchListButton.UseVisualStyleBackColor = true;
            this.maximizeOrMinimizeSearchListButton.Click += new System.EventHandler(this.maximizeOrMinimizeSearchListButton_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(164, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(159, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "(best for batch video operations)";
            // 
            // numResults
            // 
            this.numResults.AutoSize = true;
            this.numResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numResults.ForeColor = System.Drawing.Color.Red;
            this.numResults.Location = new System.Drawing.Point(485, 33);
            this.numResults.Name = "numResults";
            this.numResults.Size = new System.Drawing.Size(0, 13);
            this.numResults.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(3, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 22);
            this.label12.TabIndex = 27;
            this.label12.Text = "YouTube Search";
            // 
            // SearchTermTextbox
            // 
            this.SearchTermTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTermTextbox.Location = new System.Drawing.Point(6, 30);
            this.SearchTermTextbox.Name = "SearchTermTextbox";
            this.SearchTermTextbox.Size = new System.Drawing.Size(317, 26);
            this.SearchTermTextbox.TabIndex = 0;
            this.SearchTermTextbox.TextChanged += new System.EventHandler(this.SearchTermTextbox_TextChanged);
            this.SearchTermTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTermTextbox_KeyDown);
            this.SearchTermTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchTermTextbox_KeyPress);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Red;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(329, 29);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(69, 28);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // sortByViewCount
            // 
            this.sortByViewCount.AutoSize = true;
            this.sortByViewCount.Location = new System.Drawing.Point(182, 63);
            this.sortByViewCount.Name = "sortByViewCount";
            this.sortByViewCount.Size = new System.Drawing.Size(79, 17);
            this.sortByViewCount.TabIndex = 22;
            this.sortByViewCount.TabStop = true;
            this.sortByViewCount.Text = "View Count";
            this.sortByViewCount.UseVisualStyleBackColor = true;
            this.sortByViewCount.CheckedChanged += new System.EventHandler(this.sortByViewCount_CheckedChanged);
            // 
            // SortByLabel
            // 
            this.SortByLabel.AutoSize = true;
            this.SortByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortByLabel.Location = new System.Drawing.Point(6, 65);
            this.SortByLabel.Name = "SortByLabel";
            this.SortByLabel.Size = new System.Drawing.Size(92, 13);
            this.SortByLabel.TabIndex = 20;
            this.SortByLabel.Text = "Sort results by:";
            // 
            // sortByRelevance
            // 
            this.sortByRelevance.AutoSize = true;
            this.sortByRelevance.Location = new System.Drawing.Point(99, 63);
            this.sortByRelevance.Name = "sortByRelevance";
            this.sortByRelevance.Size = new System.Drawing.Size(77, 17);
            this.sortByRelevance.TabIndex = 21;
            this.sortByRelevance.TabStop = true;
            this.sortByRelevance.Text = "Relevance";
            this.sortByRelevance.UseVisualStyleBackColor = true;
            this.sortByRelevance.CheckedChanged += new System.EventHandler(this.sortByRelevance_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(500, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 26);
            this.button1.TabIndex = 26;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // sortByRating
            // 
            this.sortByRating.AutoSize = true;
            this.sortByRating.Location = new System.Drawing.Point(267, 63);
            this.sortByRating.Name = "sortByRating";
            this.sortByRating.Size = new System.Drawing.Size(56, 17);
            this.sortByRating.TabIndex = 23;
            this.sortByRating.TabStop = true;
            this.sortByRating.Text = "Rating";
            this.sortByRating.UseVisualStyleBackColor = true;
            this.sortByRating.CheckedChanged += new System.EventHandler(this.sortByRating_CheckedChanged);
            // 
            // sortByDateAdded
            // 
            this.sortByDateAdded.AutoSize = true;
            this.sortByDateAdded.Location = new System.Drawing.Point(329, 63);
            this.sortByDateAdded.Name = "sortByDateAdded";
            this.sortByDateAdded.Size = new System.Drawing.Size(82, 17);
            this.sortByDateAdded.TabIndex = 24;
            this.sortByDateAdded.TabStop = true;
            this.sortByDateAdded.Text = "Date Added";
            this.sortByDateAdded.UseVisualStyleBackColor = true;
            this.sortByDateAdded.CheckedChanged += new System.EventHandler(this.sortByDateAdded_CheckedChanged);
            // 
            // PreviewMode
            // 
            this.PreviewMode.AutoSize = true;
            this.PreviewMode.Location = new System.Drawing.Point(329, 7);
            this.PreviewMode.Name = "PreviewMode";
            this.PreviewMode.Size = new System.Drawing.Size(213, 17);
            this.PreviewMode.TabIndex = 7;
            this.PreviewMode.Text = "In-line Preview Active (Right Arrow Key)";
            this.PreviewMode.UseVisualStyleBackColor = true;
            // 
            // searchList
            // 
            this.searchList.FullRowSelect = true;
            this.searchList.LargeImageList = this.iconList_search;
            this.searchList.Location = new System.Drawing.Point(3, 86);
            this.searchList.Name = "searchList";
            this.searchList.Size = new System.Drawing.Size(564, 282);
            this.searchList.SmallImageList = this.iconList_search;
            this.searchList.TabIndex = 2;
            this.searchList.UseCompatibleStateImageBehavior = false;
            this.searchList.View = System.Windows.Forms.View.Tile;
            this.searchList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.searchList_ColumnClick);
            this.searchList.SelectedIndexChanged += new System.EventHandler(this.searchList_SelectedIndexChanged_1);
            this.searchList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchList_KeyDown);
            this.searchList.MouseHover += new System.EventHandler(this.searchList_MouseHover);
            this.searchList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.searchList_MouseMove);
            this.searchList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.searchList_MouseUp);
            // 
            // getMoreSearchResults
            // 
            this.getMoreSearchResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getMoreSearchResults.ForeColor = System.Drawing.Color.Blue;
            this.getMoreSearchResults.Location = new System.Drawing.Point(537, 58);
            this.getMoreSearchResults.Name = "getMoreSearchResults";
            this.getMoreSearchResults.Size = new System.Drawing.Size(30, 26);
            this.getMoreSearchResults.TabIndex = 13;
            this.getMoreSearchResults.Text = ">";
            this.getMoreSearchResults.UseVisualStyleBackColor = true;
            this.getMoreSearchResults.Click += new System.EventHandler(this.page25More);
            // 
            // YouTubeWebsiteSearchTab
            // 
            this.YouTubeWebsiteSearchTab.Controls.Add(this.maximizeYTbutton);
            this.YouTubeWebsiteSearchTab.Controls.Add(this.youtube_browser);
            this.YouTubeWebsiteSearchTab.Controls.Add(this.grab_url_of_video);
            this.YouTubeWebsiteSearchTab.Location = new System.Drawing.Point(4, 22);
            this.YouTubeWebsiteSearchTab.Name = "YouTubeWebsiteSearchTab";
            this.YouTubeWebsiteSearchTab.Padding = new System.Windows.Forms.Padding(3);
            this.YouTubeWebsiteSearchTab.Size = new System.Drawing.Size(575, 373);
            this.YouTubeWebsiteSearchTab.TabIndex = 1;
            this.YouTubeWebsiteSearchTab.Text = "YouTube Website Search";
            this.YouTubeWebsiteSearchTab.ToolTipText = "YouTube Website Search (for single videos)";
            this.YouTubeWebsiteSearchTab.UseVisualStyleBackColor = true;
            // 
            // maximizeYTbutton
            // 
            this.maximizeYTbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximizeYTbutton.ForeColor = System.Drawing.Color.Blue;
            this.maximizeYTbutton.Image = global::TubeQueue.Properties.Resources.max;
            this.maximizeYTbutton.Location = new System.Drawing.Point(538, 0);
            this.maximizeYTbutton.Name = "maximizeYTbutton";
            this.maximizeYTbutton.Size = new System.Drawing.Size(37, 21);
            this.maximizeYTbutton.TabIndex = 31;
            this.maximizeYTbutton.UseVisualStyleBackColor = true;
            this.maximizeYTbutton.Click += new System.EventHandler(this.maximizeYTbutton_Click);
            // 
            // youtube_browser
            // 
            this.youtube_browser.Location = new System.Drawing.Point(3, 22);
            this.youtube_browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.youtube_browser.Name = "youtube_browser";
            this.youtube_browser.ScriptErrorsSuppressed = true;
            this.youtube_browser.Size = new System.Drawing.Size(569, 350);
            this.youtube_browser.TabIndex = 0;
            this.youtube_browser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // grab_url_of_video
            // 
            this.grab_url_of_video.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grab_url_of_video.ForeColor = System.Drawing.Color.Red;
            this.grab_url_of_video.Location = new System.Drawing.Point(397, 0);
            this.grab_url_of_video.Name = "grab_url_of_video";
            this.grab_url_of_video.Size = new System.Drawing.Size(139, 21);
            this.grab_url_of_video.TabIndex = 31;
            this.grab_url_of_video.Text = "Add Video to Queue";
            this.grab_url_of_video.UseVisualStyleBackColor = true;
            this.grab_url_of_video.Visible = false;
            this.grab_url_of_video.Click += new System.EventHandler(this.grab_url_of_video_Click);
            // 
            // mediaLibTab
            // 
            this.mediaLibTab.Controls.Add(this.lvMediaLibrary);
            this.mediaLibTab.Location = new System.Drawing.Point(4, 22);
            this.mediaLibTab.Name = "mediaLibTab";
            this.mediaLibTab.Padding = new System.Windows.Forms.Padding(3);
            this.mediaLibTab.Size = new System.Drawing.Size(575, 373);
            this.mediaLibTab.TabIndex = 2;
            this.mediaLibTab.Text = "Media Library";
            this.mediaLibTab.UseVisualStyleBackColor = true;
            // 
            // lvMediaLibrary
            // 
            this.lvMediaLibrary.Location = new System.Drawing.Point(6, 3);
            this.lvMediaLibrary.Name = "lvMediaLibrary";
            this.lvMediaLibrary.Size = new System.Drawing.Size(566, 367);
            this.lvMediaLibrary.TabIndex = 0;
            this.lvMediaLibrary.UseCompatibleStateImageBehavior = false;
            this.lvMediaLibrary.View = System.Windows.Forms.View.Tile;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Blue;
            this.button3.Location = new System.Drawing.Point(429, 403);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 22);
            this.button3.TabIndex = 29;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Add local media file(s) to Queue";
            // 
            // ProcessLabel
            // 
            this.ProcessLabel.AutoSize = true;
            this.ProcessLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessLabel.ForeColor = System.Drawing.Color.Blue;
            this.ProcessLabel.Location = new System.Drawing.Point(7, 438);
            this.ProcessLabel.Name = "ProcessLabel";
            this.ProcessLabel.Size = new System.Drawing.Size(176, 22);
            this.ProcessLabel.TabIndex = 27;
            this.ProcessLabel.Text = "Processing Queue";
            // 
            // addURLToQueue
            // 
            this.addURLToQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addURLToQueue.ForeColor = System.Drawing.Color.Blue;
            this.addURLToQueue.Location = new System.Drawing.Point(199, 404);
            this.addURLToQueue.Name = "addURLToQueue";
            this.addURLToQueue.Size = new System.Drawing.Size(30, 21);
            this.addURLToQueue.TabIndex = 18;
            this.addURLToQueue.Text = "...";
            this.addURLToQueue.UseVisualStyleBackColor = true;
            this.addURLToQueue.Click += new System.EventHandler(this.addURLToQueue_Click);
            this.addURLToQueue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addURLToQueue_MouseClick);
            // 
            // AddURLLabel
            // 
            this.AddURLLabel.AutoSize = true;
            this.AddURLLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddURLLabel.Location = new System.Drawing.Point(10, 408);
            this.AddURLLabel.Name = "AddURLLabel";
            this.AddURLLabel.Size = new System.Drawing.Size(183, 13);
            this.AddURLLabel.TabIndex = 17;
            this.AddURLLabel.Text = "Add YouTube URL(s) to Queue";
            // 
            // Process
            // 
            this.Process.AutoSize = true;
            this.Process.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Process.ForeColor = System.Drawing.Color.Blue;
            this.Process.Location = new System.Drawing.Point(595, 3);
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(193, 22);
            this.Process.TabIndex = 10;
            this.Process.Text = "Conversion Settings";
            // 
            // ToolsView
            // 
            this.ToolsView.Controls.Add(this.tabPage1);
            this.ToolsView.Controls.Add(this.tabPage5);
            this.ToolsView.Location = new System.Drawing.Point(595, 25);
            this.ToolsView.Name = "ToolsView";
            this.ToolsView.SelectedIndex = 0;
            this.ToolsView.Size = new System.Drawing.Size(482, 374);
            this.ToolsView.TabIndex = 4;
            this.ToolsView.Selected += new System.Windows.Forms.TabControlEventHandler(this.ToolsView_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.getPrevSavedConversions_RadioButton);
            this.tabPage1.Controls.Add(this.clearButton);
            this.tabPage1.Controls.Add(this.SaveTweakedConversion);
            this.tabPage1.Controls.Add(this.DownloadButton);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.iPodTouchPhone_RadioButton);
            this.tabPage1.Controls.Add(this.threegp_radiobutton);
            this.tabPage1.Controls.Add(this.getPrevSavedSelectBox);
            this.tabPage1.Controls.Add(this.generalMP4_RadioButton);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.conversionSettings);
            this.tabPage1.Controls.Add(this.FLV_RadioButton);
            this.tabPage1.Controls.Add(this.AVI_RadioButton);
            this.tabPage1.Controls.Add(this.MP4_RadioButton);
            this.tabPage1.Controls.Add(this.queue);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(474, 348);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Video Collection Queue";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(227, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(213, 13);
            this.label11.TabIndex = 56;
            this.label11.Text = "\"Add to processing queue\" when complete.";
            // 
            // getPrevSavedConversions_RadioButton
            // 
            this.getPrevSavedConversions_RadioButton.AutoSize = true;
            this.getPrevSavedConversions_RadioButton.Location = new System.Drawing.Point(236, 223);
            this.getPrevSavedConversions_RadioButton.Name = "getPrevSavedConversions_RadioButton";
            this.getPrevSavedConversions_RadioButton.Size = new System.Drawing.Size(14, 13);
            this.getPrevSavedConversions_RadioButton.TabIndex = 55;
            this.getPrevSavedConversions_RadioButton.UseVisualStyleBackColor = true;
            this.getPrevSavedConversions_RadioButton.CheckedChanged += new System.EventHandler(this.getPrevSavedConversions_RadioButton_CheckedChanged);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(154, 10);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(53, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear All";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // SaveTweakedConversion
            // 
            this.SaveTweakedConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveTweakedConversion.Location = new System.Drawing.Point(435, 263);
            this.SaveTweakedConversion.Name = "SaveTweakedConversion";
            this.SaveTweakedConversion.Size = new System.Drawing.Size(36, 23);
            this.SaveTweakedConversion.TabIndex = 54;
            this.SaveTweakedConversion.Text = "Save";
            this.SaveTweakedConversion.UseVisualStyleBackColor = true;
            this.SaveTweakedConversion.Click += new System.EventHandler(this.SaveTweakedConversion_Click_1);
            // 
            // DownloadButton
            // 
            this.DownloadButton.BackColor = System.Drawing.Color.Red;
            this.DownloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadButton.ForeColor = System.Drawing.Color.White;
            this.DownloadButton.Location = new System.Drawing.Point(19, 307);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(173, 35);
            this.DownloadButton.TabIndex = 3;
            this.DownloadButton.Text = "Add to Processing Queue";
            this.DownloadButton.UseVisualStyleBackColor = false;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(226, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "file downloaded from YouTube.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(227, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "items in the video collection queue. Press";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(192, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(226, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "downloads will be associated with the current";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "The following video conversions or direct ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(227, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 16);
            this.label7.TabIndex = 48;
            this.label7.Text = "Conversion/Download Presets";
            // 
            // iPodTouchPhone_RadioButton
            // 
            this.iPodTouchPhone_RadioButton.AutoSize = true;
            this.iPodTouchPhone_RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iPodTouchPhone_RadioButton.Location = new System.Drawing.Point(236, 128);
            this.iPodTouchPhone_RadioButton.Name = "iPodTouchPhone_RadioButton";
            this.iPodTouchPhone_RadioButton.Size = new System.Drawing.Size(172, 17);
            this.iPodTouchPhone_RadioButton.TabIndex = 47;
            this.iPodTouchPhone_RadioButton.Text = "MP4 [iPhone/iPod Touch]";
            this.iPodTouchPhone_RadioButton.UseVisualStyleBackColor = true;
            this.iPodTouchPhone_RadioButton.CheckedChanged += new System.EventHandler(this.iPodTouchPhone_RadioButton_CheckedChanged);
            // 
            // threegp_radiobutton
            // 
            this.threegp_radiobutton.AutoSize = true;
            this.threegp_radiobutton.Enabled = false;
            this.threegp_radiobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threegp_radiobutton.Location = new System.Drawing.Point(236, 197);
            this.threegp_radiobutton.Name = "threegp_radiobutton";
            this.threegp_radiobutton.Size = new System.Drawing.Size(120, 17);
            this.threegp_radiobutton.TabIndex = 46;
            this.threegp_radiobutton.Text = "3gp [Cellphones]";
            this.threegp_radiobutton.UseVisualStyleBackColor = true;
            this.threegp_radiobutton.CheckedChanged += new System.EventHandler(this.threegp_radiobutton_CheckedChanged_1);
            // 
            // getPrevSavedSelectBox
            // 
            this.getPrevSavedSelectBox.FormattingEnabled = true;
            this.getPrevSavedSelectBox.Location = new System.Drawing.Point(256, 220);
            this.getPrevSavedSelectBox.Name = "getPrevSavedSelectBox";
            this.getPrevSavedSelectBox.Size = new System.Drawing.Size(198, 21);
            this.getPrevSavedSelectBox.TabIndex = 45;
            this.getPrevSavedSelectBox.Text = "Additional and Saved Conversions...";
            this.getPrevSavedSelectBox.DropDown += new System.EventHandler(this.getPrevSavedSelectBox_DropDown_1);
            this.getPrevSavedSelectBox.SelectedIndexChanged += new System.EventHandler(this.getPrevSavedSelectBox_SelectedIndexChanged_1);
            // 
            // generalMP4_RadioButton
            // 
            this.generalMP4_RadioButton.AutoSize = true;
            this.generalMP4_RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalMP4_RadioButton.Location = new System.Drawing.Point(236, 151);
            this.generalMP4_RadioButton.Name = "generalMP4_RadioButton";
            this.generalMP4_RadioButton.Size = new System.Drawing.Size(150, 17);
            this.generalMP4_RadioButton.TabIndex = 44;
            this.generalMP4_RadioButton.Text = "MP4 [iTunes, general]";
            this.generalMP4_RadioButton.UseVisualStyleBackColor = true;
            this.generalMP4_RadioButton.CheckedChanged += new System.EventHandler(this.generalMP4_RadioButton_CheckedChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(215, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 16);
            this.label6.TabIndex = 43;
            this.label6.Text = "Conversion Switches to be Used";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = " %o will be replaced by the title of the video.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "%v will be replaced by the name of the FLV";
            // 
            // conversionSettings
            // 
            this.conversionSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversionSettings.Location = new System.Drawing.Point(218, 263);
            this.conversionSettings.Name = "conversionSettings";
            this.conversionSettings.Size = new System.Drawing.Size(214, 20);
            this.conversionSettings.TabIndex = 40;
            this.conversionSettings.Tag = "";
            this.conversionSettings.Text = "ffmpeg -i %v -vcodec msmpeg4 -vtag MP43 %o.avi";
            // 
            // FLV_RadioButton
            // 
            this.FLV_RadioButton.AutoSize = true;
            this.FLV_RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FLV_RadioButton.Location = new System.Drawing.Point(236, 174);
            this.FLV_RadioButton.Name = "FLV_RadioButton";
            this.FLV_RadioButton.Size = new System.Drawing.Size(124, 17);
            this.FLV_RadioButton.TabIndex = 39;
            this.FLV_RadioButton.Text = "FLV [Web format]";
            this.FLV_RadioButton.UseVisualStyleBackColor = true;
            this.FLV_RadioButton.CheckedChanged += new System.EventHandler(this.FLV_RadioButton_CheckedChanged_1);
            // 
            // AVI_RadioButton
            // 
            this.AVI_RadioButton.AutoSize = true;
            this.AVI_RadioButton.Checked = true;
            this.AVI_RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AVI_RadioButton.Location = new System.Drawing.Point(236, 82);
            this.AVI_RadioButton.Name = "AVI_RadioButton";
            this.AVI_RadioButton.Size = new System.Drawing.Size(108, 17);
            this.AVI_RadioButton.TabIndex = 38;
            this.AVI_RadioButton.TabStop = true;
            this.AVI_RadioButton.Text = "AVI [Windows]";
            this.AVI_RadioButton.UseVisualStyleBackColor = true;
            this.AVI_RadioButton.CheckedChanged += new System.EventHandler(this.AVI_RadioButton_CheckedChanged_1);
            // 
            // MP4_RadioButton
            // 
            this.MP4_RadioButton.AutoSize = true;
            this.MP4_RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MP4_RadioButton.Location = new System.Drawing.Point(236, 105);
            this.MP4_RadioButton.Name = "MP4_RadioButton";
            this.MP4_RadioButton.Size = new System.Drawing.Size(123, 17);
            this.MP4_RadioButton.TabIndex = 37;
            this.MP4_RadioButton.Text = "MP4 [iPod Video]";
            this.MP4_RadioButton.UseVisualStyleBackColor = true;
            this.MP4_RadioButton.CheckedChanged += new System.EventHandler(this.MP4_RadioButton_CheckedChanged_1);
            // 
            // queue
            // 
            this.queue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.URL});
            this.queue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queue.LabelEdit = true;
            this.queue.Location = new System.Drawing.Point(6, 8);
            this.queue.Name = "queue";
            this.queue.ShowItemToolTips = true;
            this.queue.Size = new System.Drawing.Size(203, 297);
            this.queue.TabIndex = 0;
            this.queue.UseCompatibleStateImageBehavior = false;
            this.queue.View = System.Windows.Forms.View.Details;
            this.queue.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.queue_AfterLabelEdit);
            this.queue.DoubleClick += new System.EventHandler(this.queue_DoubleClick);
            this.queue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.queue_MouseDown);
            this.queue.MouseMove += new System.Windows.Forms.MouseEventHandler(this.queue_MouseMove);
            this.queue.MouseUp += new System.Windows.Forms.MouseEventHandler(this.queue_MouseUp_1);
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 355;
            // 
            // URL
            // 
            this.URL.Text = "URL";
            this.URL.Width = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.webBrowser1);
            this.tabPage5.Controls.Add(this.NoVideoSelectedYet);
            this.tabPage5.Controls.Add(this.NoVideoSelectedYet2);
            this.tabPage5.Controls.Add(this.NoVideoSelectedYet3);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(474, 348);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Preview";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(468, 342);
            this.webBrowser1.TabIndex = 0;
            // 
            // NoVideoSelectedYet
            // 
            this.NoVideoSelectedYet.AutoSize = true;
            this.NoVideoSelectedYet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoVideoSelectedYet.Location = new System.Drawing.Point(3, 174);
            this.NoVideoSelectedYet.Name = "NoVideoSelectedYet";
            this.NoVideoSelectedYet.Size = new System.Drawing.Size(500, 15);
            this.NoVideoSelectedYet.TabIndex = 1;
            this.NoVideoSelectedYet.Text = "You have not selected a video to preview. Right click the video of your choice ";
            // 
            // NoVideoSelectedYet2
            // 
            this.NoVideoSelectedYet2.AutoSize = true;
            this.NoVideoSelectedYet2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoVideoSelectedYet2.Location = new System.Drawing.Point(3, 189);
            this.NoVideoSelectedYet2.Name = "NoVideoSelectedYet2";
            this.NoVideoSelectedYet2.Size = new System.Drawing.Size(531, 15);
            this.NoVideoSelectedYet2.TabIndex = 2;
            this.NoVideoSelectedYet2.Text = "in the search list and press \"Preview\" or ress the right arrow key on your keyboa" +
    "rd ";
            // 
            // NoVideoSelectedYet3
            // 
            this.NoVideoSelectedYet3.AutoSize = true;
            this.NoVideoSelectedYet3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoVideoSelectedYet3.Location = new System.Drawing.Point(3, 204);
            this.NoVideoSelectedYet3.Name = "NoVideoSelectedYet3";
            this.NoVideoSelectedYet3.Size = new System.Drawing.Size(126, 15);
            this.NoVideoSelectedYet3.TabIndex = 3;
            this.NoVideoSelectedYet3.Text = "to preview a video.";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Controls.Add(this.SaveSettingsButton);
            this.tabPage4.Controls.Add(this.InterfaceSettings);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1083, 594);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Settings";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.conv_video_textbox);
            this.groupBox1.Controls.Add(this.temp_dir_textbox);
            this.groupBox1.Controls.Add(this.conv_cwd);
            this.groupBox1.Controls.Add(this.temp_cwd);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(13, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 138);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Directories";
            // 
            // conv_video_textbox
            // 
            this.conv_video_textbox.Enabled = false;
            this.conv_video_textbox.Location = new System.Drawing.Point(20, 107);
            this.conv_video_textbox.Name = "conv_video_textbox";
            this.conv_video_textbox.Size = new System.Drawing.Size(428, 20);
            this.conv_video_textbox.TabIndex = 7;
            // 
            // temp_dir_textbox
            // 
            this.temp_dir_textbox.Enabled = false;
            this.temp_dir_textbox.Location = new System.Drawing.Point(20, 44);
            this.temp_dir_textbox.Name = "temp_dir_textbox";
            this.temp_dir_textbox.Size = new System.Drawing.Size(428, 20);
            this.temp_dir_textbox.TabIndex = 6;
            // 
            // conv_cwd
            // 
            this.conv_cwd.AutoSize = true;
            this.conv_cwd.Location = new System.Drawing.Point(182, 85);
            this.conv_cwd.Name = "conv_cwd";
            this.conv_cwd.Size = new System.Drawing.Size(196, 17);
            this.conv_cwd.TabIndex = 5;
            this.conv_cwd.Text = "Current Directory/processed_videos";
            this.conv_cwd.UseVisualStyleBackColor = true;
            this.conv_cwd.CheckedChanged += new System.EventHandler(this.conv_cwd_CheckedChanged);
            // 
            // temp_cwd
            // 
            this.temp_cwd.AutoSize = true;
            this.temp_cwd.Location = new System.Drawing.Point(118, 20);
            this.temp_cwd.Name = "temp_cwd";
            this.temp_cwd.Size = new System.Drawing.Size(133, 17);
            this.temp_cwd.TabIndex = 4;
            this.temp_cwd.Text = "Current Directory/temp";
            this.temp_cwd.UseVisualStyleBackColor = true;
            this.temp_cwd.CheckedChanged += new System.EventHandler(this.temp_cwd_CheckedChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(384, 81);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Select a directory ...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(257, 14);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Select a directory ...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(15, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(161, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Processed Video Directory:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Temp Directory:";
            // 
            // SaveSettingsButton
            // 
            this.SaveSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveSettingsButton.Location = new System.Drawing.Point(13, 309);
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.Size = new System.Drawing.Size(97, 34);
            this.SaveSettingsButton.TabIndex = 1;
            this.SaveSettingsButton.Text = "Save Settings";
            this.SaveSettingsButton.UseVisualStyleBackColor = true;
            this.SaveSettingsButton.Click += new System.EventHandler(this.SaveSettingsButton_Click);
            // 
            // InterfaceSettings
            // 
            this.InterfaceSettings.Controls.Add(this.make_yt_default);
            this.InterfaceSettings.Controls.Add(this.prompt_for_vid_conv);
            this.InterfaceSettings.Controls.Add(this.experTabView_prev);
            this.InterfaceSettings.Controls.Add(this.AutoResizeSearch);
            this.InterfaceSettings.Controls.Add(this.AppendSearch);
            this.InterfaceSettings.Location = new System.Drawing.Point(13, 15);
            this.InterfaceSettings.Name = "InterfaceSettings";
            this.InterfaceSettings.Size = new System.Drawing.Size(525, 144);
            this.InterfaceSettings.TabIndex = 0;
            this.InterfaceSettings.TabStop = false;
            this.InterfaceSettings.Text = "Interface";
            // 
            // make_yt_default
            // 
            this.make_yt_default.AutoSize = true;
            this.make_yt_default.Location = new System.Drawing.Point(15, 112);
            this.make_yt_default.Name = "make_yt_default";
            this.make_yt_default.Size = new System.Drawing.Size(463, 17);
            this.make_yt_default.TabIndex = 4;
            this.make_yt_default.Text = "Make \"YouTube Website Search\" tab default page on program load (default: Built-in" +
    " Search)";
            this.make_yt_default.UseVisualStyleBackColor = true;
            // 
            // prompt_for_vid_conv
            // 
            this.prompt_for_vid_conv.AutoSize = true;
            this.prompt_for_vid_conv.Checked = true;
            this.prompt_for_vid_conv.CheckState = System.Windows.Forms.CheckState.Checked;
            this.prompt_for_vid_conv.Location = new System.Drawing.Point(15, 89);
            this.prompt_for_vid_conv.Name = "prompt_for_vid_conv";
            this.prompt_for_vid_conv.Size = new System.Drawing.Size(178, 17);
            this.prompt_for_vid_conv.TabIndex = 3;
            this.prompt_for_vid_conv.Text = "Prompt to start video conversion";
            this.prompt_for_vid_conv.UseVisualStyleBackColor = true;
            // 
            // experTabView_prev
            // 
            this.experTabView_prev.AutoSize = true;
            this.experTabView_prev.Checked = true;
            this.experTabView_prev.CheckState = System.Windows.Forms.CheckState.Checked;
            this.experTabView_prev.Location = new System.Drawing.Point(15, 66);
            this.experTabView_prev.Name = "experTabView_prev";
            this.experTabView_prev.Size = new System.Drawing.Size(510, 17);
            this.experTabView_prev.TabIndex = 2;
            this.experTabView_prev.Text = "Enable popup window based multi tab-view preview of videos (default: single previ" +
    "ew in \"Preview\" tab)";
            this.experTabView_prev.UseVisualStyleBackColor = true;
            this.experTabView_prev.CheckedChanged += new System.EventHandler(this.experTabView_prev_CheckedChanged);
            // 
            // AutoResizeSearch
            // 
            this.AutoResizeSearch.AutoSize = true;
            this.AutoResizeSearch.Location = new System.Drawing.Point(15, 43);
            this.AutoResizeSearch.Name = "AutoResizeSearch";
            this.AutoResizeSearch.Size = new System.Drawing.Size(296, 17);
            this.AutoResizeSearch.TabIndex = 1;
            this.AutoResizeSearch.Text = "Auto-Resize search results columns (default: Fixed Width)";
            this.AutoResizeSearch.UseVisualStyleBackColor = true;
            // 
            // AppendSearch
            // 
            this.AppendSearch.AutoSize = true;
            this.AppendSearch.Location = new System.Drawing.Point(15, 23);
            this.AppendSearch.Name = "AppendSearch";
            this.AppendSearch.Size = new System.Drawing.Size(405, 17);
            this.AppendSearch.TabIndex = 0;
            this.AppendSearch.Text = "Append search results to search list after new search (default behavior: Clear li" +
    "st)";
            this.AppendSearch.UseVisualStyleBackColor = true;
            // 
            // processingQueueStrip
            // 
            this.processingQueueStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeProcessingQueueItem});
            this.processingQueueStrip.Name = "processingQueueStrip";
            this.processingQueueStrip.Size = new System.Drawing.Size(118, 26);
            // 
            // removeProcessingQueueItem
            // 
            this.removeProcessingQueueItem.Name = "removeProcessingQueueItem";
            this.removeProcessingQueueItem.Size = new System.Drawing.Size(117, 22);
            this.removeProcessingQueueItem.Text = "Remove";
            this.removeProcessingQueueItem.ToolTipText = "Remove the selected queue item";
            this.removeProcessingQueueItem.Click += new System.EventHandler(this.removeProcessingQueueItem_Click);
            // 
            // savedFFMPEGTweakedSettings
            // 
            this.savedFFMPEGTweakedSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ffmpeg_settings_textbox_save});
            this.savedFFMPEGTweakedSettings.Name = "savedFFMPEGTweakedSettings";
            this.savedFFMPEGTweakedSettings.Size = new System.Drawing.Size(351, 29);
            this.savedFFMPEGTweakedSettings.Text = "Save FFMPEG Tweaked Settings";
            // 
            // ffmpeg_settings_textbox_save
            // 
            this.ffmpeg_settings_textbox_save.Name = "ffmpeg_settings_textbox_save";
            this.ffmpeg_settings_textbox_save.Size = new System.Drawing.Size(290, 23);
            this.ffmpeg_settings_textbox_save.Text = "Type a name describing the settings here, then press Enter.";
            this.ffmpeg_settings_textbox_save.Leave += new System.EventHandler(this.ffmpeg_settings_textbox_save_Leave);
            this.ffmpeg_settings_textbox_save.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ffmpeg_settings_textbox_save_KeyPress);
            this.ffmpeg_settings_textbox_save.Click += new System.EventHandler(this.ffmpeg_settings_textbox_save_Click);
            // 
            // addToQueueStrip
            // 
            this.addToQueueStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToQueueStripItem});
            this.addToQueueStrip.Name = "processingQueueStrip";
            this.addToQueueStrip.Size = new System.Drawing.Size(149, 26);
            this.addToQueueStrip.Opening += new System.ComponentModel.CancelEventHandler(this.addToQueueStrip_Opening);
            // 
            // addToQueueStripItem
            // 
            this.addToQueueStripItem.Name = "addToQueueStripItem";
            this.addToQueueStripItem.Size = new System.Drawing.Size(148, 22);
            this.addToQueueStripItem.Text = "Add to Queue";
            this.addToQueueStripItem.ToolTipText = "Add video to queue";
            this.addToQueueStripItem.Click += new System.EventHandler(this.addToQueueStripItem_Click);
            // 
            // number_of_urls
            // 
            this.number_of_urls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.single_url_choice,
            this.mul_urls_choice});
            this.number_of_urls.Name = "number_of_urls";
            this.number_of_urls.Size = new System.Drawing.Size(157, 48);
            // 
            // single_url_choice
            // 
            this.single_url_choice.Name = "single_url_choice";
            this.single_url_choice.Size = new System.Drawing.Size(156, 22);
            this.single_url_choice.Text = "Single URL...";
            this.single_url_choice.Click += new System.EventHandler(this.single_url_choice_Click);
            this.single_url_choice.MouseDown += new System.Windows.Forms.MouseEventHandler(this.single_url_choice_MouseDown);
            // 
            // mul_urls_choice
            // 
            this.mul_urls_choice.Name = "mul_urls_choice";
            this.mul_urls_choice.Size = new System.Drawing.Size(156, 22);
            this.mul_urls_choice.Text = "Multiple URLs...";
            this.mul_urls_choice.Click += new System.EventHandler(this.mul_urls_choice_Click);
            // 
            // addsingleURL
            // 
            this.addsingleURL.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.single_URL_add});
            this.addsingleURL.Name = "addsingleURL";
            this.addsingleURL.Size = new System.Drawing.Size(311, 29);
            this.addsingleURL.Opening += new System.ComponentModel.CancelEventHandler(this.addsingleURL_Opening);
            // 
            // single_URL_add
            // 
            this.single_URL_add.Name = "single_URL_add";
            this.single_URL_add.Size = new System.Drawing.Size(250, 23);
            this.single_URL_add.Text = "Type in a single YouTube URL and press Enter.";
            this.single_URL_add.ToolTipText = "Type in a single YouTube URL and press Enter.";
            this.single_URL_add.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.single_URL_add_KeyPress);
            this.single_URL_add.MouseDown += new System.Windows.Forms.MouseEventHandler(this.single_URL_add_MouseDown);
            // 
            // openLocalFLVFile
            // 
            this.openLocalFLVFile.Filter = "FLV Flash Video Files (*.flv)|*.flv|All Files|*.*";
            this.openLocalFLVFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openLocalFLVFile_FileOk);
            // 
            // queue_menu_options
            // 
            this.queue_menu_options.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rename_queue_menu_options,
            this.delete_queue_menu_options});
            this.queue_menu_options.Name = "renameFile";
            this.queue_menu_options.Size = new System.Drawing.Size(118, 48);
            // 
            // rename_queue_menu_options
            // 
            this.rename_queue_menu_options.Name = "rename_queue_menu_options";
            this.rename_queue_menu_options.Size = new System.Drawing.Size(117, 22);
            this.rename_queue_menu_options.Text = "Rename";
            this.rename_queue_menu_options.ToolTipText = "Rename the selected video";
            this.rename_queue_menu_options.Click += new System.EventHandler(this.rename_queue_menu_options_Click);
            // 
            // delete_queue_menu_options
            // 
            this.delete_queue_menu_options.Name = "delete_queue_menu_options";
            this.delete_queue_menu_options.Size = new System.Drawing.Size(117, 22);
            this.delete_queue_menu_options.Text = "Delete";
            this.delete_queue_menu_options.ToolTipText = "Delete the selected video(s)";
            this.delete_queue_menu_options.Click += new System.EventHandler(this.delete_queue_menu_options_Click);
            // 
            // mediaLibImageList
            // 
            this.mediaLibImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.mediaLibImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.mediaLibImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // TubeQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 622);
            this.Controls.Add(this.MainTabs);
            this.MaximumSize = new System.Drawing.Size(1109, 661);
            this.MinimumSize = new System.Drawing.Size(1109, 661);
            this.Name = "TubeQueue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TubeQueue by Andrew Stein, build <buildno> - <INSERT DATE HERE>";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TubeQueue_FormClosing);
            this.Load += new System.EventHandler(this.TubeMasterForm_Load);
            this.Move += new System.EventHandler(this.TubeMasterForm_Move);
            this.MainTabs.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.builtInYTSearchTab.ResumeLayout(false);
            this.builtInYTSearchTab.PerformLayout();
            this.YouTubeWebsiteSearchTab.ResumeLayout(false);
            this.mediaLibTab.ResumeLayout(false);
            this.ToolsView.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.InterfaceSettings.ResumeLayout(false);
            this.InterfaceSettings.PerformLayout();
            this.processingQueueStrip.ResumeLayout(false);
            this.savedFFMPEGTweakedSettings.ResumeLayout(false);
            this.savedFFMPEGTweakedSettings.PerformLayout();
            this.addToQueueStrip.ResumeLayout(false);
            this.number_of_urls.ResumeLayout(false);
            this.addsingleURL.ResumeLayout(false);
            this.addsingleURL.PerformLayout();
            this.queue_menu_options.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabs;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox InterfaceSettings;
        private System.Windows.Forms.CheckBox AppendSearch;
        private System.Windows.Forms.CheckBox AutoResizeSearch;
        private System.Windows.Forms.ImageList iconList_search;
        private System.Windows.Forms.ContextMenuStrip processingQueueStrip;
        private System.Windows.Forms.ToolStripMenuItem removeProcessingQueueItem;
        private System.Windows.Forms.ContextMenuStrip savedFFMPEGTweakedSettings;
        private System.Windows.Forms.ToolStripTextBox ffmpeg_settings_textbox_save;
        private System.Windows.Forms.Button SaveSettingsButton;
        private System.Windows.Forms.CheckBox experTabView_prev;
        private System.Windows.Forms.ContextMenuStrip addToQueueStrip;
        private System.Windows.Forms.ToolStripMenuItem addToQueueStripItem;
        private System.Windows.Forms.ContextMenuStrip number_of_urls;
        private System.Windows.Forms.ToolStripMenuItem single_url_choice;
        private System.Windows.Forms.ToolStripMenuItem mul_urls_choice;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage builtInYTSearchTab;
        private System.Windows.Forms.TextBox SearchTermTextbox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.RadioButton sortByViewCount;
        private System.Windows.Forms.Label SortByLabel;
        private System.Windows.Forms.RadioButton sortByRelevance;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton sortByRating;
        private System.Windows.Forms.RadioButton sortByDateAdded;
        private System.Windows.Forms.CheckBox PreviewMode;
        private System.Windows.Forms.ListView searchList;
        private System.Windows.Forms.Button getMoreSearchResults;
        private System.Windows.Forms.TabPage YouTubeWebsiteSearchTab;
        private System.Windows.Forms.WebBrowser youtube_browser;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProcessLabel;
        private System.Windows.Forms.Button addURLToQueue;
        private System.Windows.Forms.Label AddURLLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label numResults;
        private System.Windows.Forms.Label Process;
        private System.Windows.Forms.Button deleteSelectedNode;
        private System.Windows.Forms.TreeView processingQueue;
        private System.Windows.Forms.Button DownloadAndProcessButton;
        private System.Windows.Forms.Button ClearProcessingQueue;
        private System.Windows.Forms.TabControl ToolsView;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton getPrevSavedConversions_RadioButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button SaveTweakedConversion;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton iPodTouchPhone_RadioButton;
        private System.Windows.Forms.RadioButton threegp_radiobutton;
        private System.Windows.Forms.ComboBox getPrevSavedSelectBox;
        private System.Windows.Forms.RadioButton generalMP4_RadioButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox conversionSettings;
        private System.Windows.Forms.RadioButton FLV_RadioButton;
        private System.Windows.Forms.RadioButton AVI_RadioButton;
        private System.Windows.Forms.RadioButton MP4_RadioButton;
        private System.Windows.Forms.ListView queue;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader URL;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label NoVideoSelectedYet;
        private System.Windows.Forms.Label NoVideoSelectedYet2;
        private System.Windows.Forms.Label NoVideoSelectedYet3;
        private System.Windows.Forms.Button grab_url_of_video;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ContextMenuStrip addsingleURL;
        private System.Windows.Forms.ToolStripTextBox single_URL_add;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.OpenFileDialog openLocalFLVFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.FolderBrowserDialog temp_dir_select;
        private System.Windows.Forms.FolderBrowserDialog conv_video_dir;
        private System.Windows.Forms.CheckBox conv_cwd;
        private System.Windows.Forms.CheckBox temp_cwd;
        private System.Windows.Forms.TextBox conv_video_textbox;
        private System.Windows.Forms.TextBox temp_dir_textbox;
        private System.Windows.Forms.CheckBox prompt_for_vid_conv;
        private System.Windows.Forms.CheckBox make_yt_default;
        private System.Windows.Forms.ContextMenuStrip queue_menu_options;
        private System.Windows.Forms.ToolStripMenuItem rename_queue_menu_options;
        private System.Windows.Forms.ToolStripMenuItem delete_queue_menu_options;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage mediaLibTab;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        internal EXControls.EXListView lvDownloads;
        private System.Windows.Forms.ListView lvMediaLibrary;
        private System.Windows.Forms.ImageList mediaLibImageList;
        private System.Windows.Forms.Button maximizeYTbutton;
        private System.Windows.Forms.Button maximizeOrMinimizeSearchListButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

