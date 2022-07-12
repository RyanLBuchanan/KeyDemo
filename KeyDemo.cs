using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyDemo
{
    public partial class KeyDemo : Form
    {
        public KeyDemo()
        {
            InitializeComponent();
        }

        //private void charLabel_Click(object sender, EventArgs e)
        //{

        //}

        private void KeyDemo_KeyPressed(object sender, KeyPressEventArgs e)
        {
            charLabel.Text = $"Key pressed: {e.KeyChar}";
        }

        private void KeyDemo_KeyDown(object sender, KeyPressEventArgs e)
        {
            keyInfoLabel.Text =
                $"Alt: {(e.Alt ? "Yes" : "No")}\n" +
                $"Shift: {(e.Shift ? "Yes" : "No")}\n" +
                $"Control: {(e.Control ? "Yes" : "No")}\n" +
                $"KeyCode: {e.KeyCode}\n" +
                $"KeyData: {e.KeyData}\n" +
                $"KeyValue: {e.KeyValue}\n";
        }

        private void KeyDemo_KeyUp(object sender, KeyPressEventArgs e)
        {
            charLabel.Text = "";
            keyInfoLabel.Text = "";
        }
    }
}
