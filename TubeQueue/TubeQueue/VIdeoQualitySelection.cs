using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using YTDownload;

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



            YTDownload.YTDownload yt = new YTDownload.YTDownload(url);

            label1.Text = yt.getTitle;
                    
            Dictionary<String, String> urls = yt.GetAllUrls;

            foreach (KeyValuePair<string, string> entry in urls)
            {
                dataGridView1.Rows.Add(new String[2]{entry.Key,entry.Value});
 
            }


            //dataGridView1.DataSource = dT;
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
