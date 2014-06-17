using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using YTDownload;
using SS.YoutubeDownloader.AdvLib;


namespace TubeQueue
{
    public partial class VideoQualitySelection : Form
    {
        string url = "";

        public VideoQualitySelection(string sentUrl)
        {
            InitializeComponent();
            url = sentUrl;

            init();

        }

        private void init()
        {
          
            //DataTable dT = new DataTable();
            //dT.Columns.Add("URL");
            //dT.Columns.Add("Link");


            IList<SS.YoutubeDownloader.AdvLib.YouTubeVideoQuality> dls = YouTubeDownloader.GetYouTubeVideoUrls(new String[1] { url });

            YTDownload.YTDownload yt = new YTDownload.YTDownload(url);



            label1.Text = yt.getTitle;
                    
            //Dictionary<String, String> urls = yt.GetAllUrls;

          //  foreach (KeyValuePair<string, string> entry in urls)
            //{
            //    dataGridView1.Rows.Add(new String[2]{entry.Key,entry.Value});
 
            //}

            foreach (var item in dls)
            {
                 string videoExtention = item.Extention;
                 string videoDimension = BeautifyVideoSize(item.Dimension);
                 string videoSize = BeautifySize(item.VideoSize);
                 
                 dataGridView1.Rows.Add(new String[2]{videoExtention + " " + videoDimension + " " + videoSize ,item.DownloadUrl});
              

            }


            //dataGridView1.DataSource = dT;
        }

        private string BeautifySize(Int64 size, Int32 decimals = 2)
        {
            string[] sizes = { "Bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
            double formattedSize = size;
            Int32 sizeIndex = 0;
            while (formattedSize >= 1024 & sizeIndex < sizes.Length)
            {
                formattedSize /= 1024;
                sizeIndex += 1;
            }
            return string.Format("{0} {1}", Math.Round(formattedSize, decimals), sizes[sizeIndex]);
        }

        private string BeautifyVideoSize(object value)
        {
            string s = ((Size)value).Height >= 720 ? " HD" : "";
            return ((Size)value).Width + " x " + ((Size)value).Height + s;
        }

        public string QualityAsURL { get; set; } 

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a quality.");

            }
            else
            {
                this.QualityAsURL = dataGridView1.SelectedRows[0].Cells["DLUrl"].Value.ToString();
                this.Close();

            }

          
        }

    }
}
