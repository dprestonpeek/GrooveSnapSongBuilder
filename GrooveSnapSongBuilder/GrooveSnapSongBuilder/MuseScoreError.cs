using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GrooveSnapSongBuilder
{
    public partial class MuseScoreError : Form
    {
        public string Title;
        public string Message;
        public MuseScoreError()
        {
            InitializeComponent();
            Text = Title;
            MessageBox.Text = Message;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
