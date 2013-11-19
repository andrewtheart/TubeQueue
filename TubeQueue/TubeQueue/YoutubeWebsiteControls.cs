using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TubeQueue;


namespace TubeQueue
{
    public partial class YoutubeWebsiteControls : Form
    {
       
        public YoutubeWebsiteControls()
        {
          
            InitializeComponent();
        }


        protected override void OnLoad(System.EventArgs e)
        {
            Screen scr = Screen.FromPoint(this.Location);
            this.Location = new Point(scr.WorkingArea.Right - this.Width - 10, scr.WorkingArea.Top +10);
            base.OnLoad(e);
        }

     

        private void grab_url_of_video_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.OpenForms["TubeQueue"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["TubeQueue"] as Form1.TubeQueue).getURLFromWebview();
            }

        }

      
        private void button8_Click(object sender, EventArgs e)
        {
            //// Get the total number of open forms
            //int openFormCount = Application.OpenForms.Count;

            //// Iterate through the open forms and perform your method on them
            //foreach (Form form in Application.OpenForms)
            //{
            //    MessageBox.Show(form.Name);
            //}


            if (System.Windows.Forms.Application.OpenForms["TubeQueue"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["TubeQueue"] as Form1.TubeQueue).minimizeTabControlYT();
            }

            this.Close();
        }

        private void YoutubeWebsiteControls_Load(object sender, EventArgs e)
        {

        }

    }
}
