using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTV
{
    public partial class Form_play : Form
    {
        public string url;
        public Form_play(string url)
        {
            this.url = url;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            string html = "<html><head>" +
                            "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                            "</head><body>";
            html += "<iframe width='560' height='315' src='https://www.youtube.com/embed/{0}' title='YouTube video player' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>";
            html += "</body></html>";
            textBox1.Text = string.Format("https://www.youtube.com/embed/{0}", url.Split('=')[1]);
            this.webBrowser1.DocumentText = string.Format(html, url.Split('=')[1]);
        }

    }
}
