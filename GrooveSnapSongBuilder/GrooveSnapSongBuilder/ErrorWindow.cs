using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GrooveSnapSongBuilder
{
    public partial class ErrorWindow : Form
    {
        public ErrorWindow()
        {
            InitializeComponent();
        }

        public void ShowError(string message)
        {
            ShowMessage("Error", message);
        }

        public void ShowMessage(string title, string message)
        {
            Text = title;
            MessageBox.Text = message;
            ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
