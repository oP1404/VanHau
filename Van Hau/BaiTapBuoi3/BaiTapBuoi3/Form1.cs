using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapBuoi3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = string.Format("Hom nay la ngay {0} - Bay gio la {1}", DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("hh:mm:ss tt"));
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = " AVI file| *.avi | MPEG File | *.mpeg | Wav File | *.Wav | Midi File| *.midi | Mp4 File | *.mp4 | MP3 |*.mp3";
            if (dlg.ShowDialog() == DialogResult.OK)
                axWindowsMeidaPlayer1.URL = dlg.FileName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
