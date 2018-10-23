using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace TextEditor
{
    public partial class textEditor : Form
    {
        public textEditor()
        {
            InitializeComponent();
        }

        private void open_file(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Text Files|*.txt"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string line;

                // Read the file and display it.  
                string file = System.IO.File.ReadAllText(ofd.FileName);
                textBox1.Text = file;
            }
        }

        private void new_file(object sender, EventArgs e)
        {
            textBox1.Text = "";

        }

        private void save_file(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Text Files|*.txt"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var line = textBox1.Text.Split('\n');
                System.IO.File.WriteAllLines(sfd.FileName, line);

            }
        }

        private void show_help(object sender, EventArgs e)
        {
            MessageBox.Show("This is a simple text editor made by saurabh sharma <itsjzt> ", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void open_notepad(object sender, EventArgs e)
        {
            Process.Start("notepad");
        }

        private void textEditor_Load(object sender, EventArgs e)
        {

        }
    }
}
