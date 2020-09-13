using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace Rss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        


        private void BtnHurriyet_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmloku = new XmlTextReader("http://www.stargazete.com/rss/rss.asp");
            while (xmloku.Read())
            {
                if(xmloku.Name == "title")
                {
                    listBox1.Items.Add(xmloku.ReadString());
                }
            }
        }

        private void BtnCumhuriyet_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmloku = new XmlTextReader("http://www.cumhuriyet.com.tr/rss/son_dakika.xml");
            while (xmloku.Read())
            {
                if (xmloku.Name == "title")
                {
                    listBox1.Items.Add(xmloku.ReadString());
                }
            }

        }

        private void BtnCnn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmloku = new XmlTextReader("http://www.cnnturk.com/feed/rss/news");
            while (xmloku.Read())
            {
                if (xmloku.Name == "title")
                {
                    listBox1.Items.Add(xmloku.ReadString());
                }
            }
        }
    }
}
