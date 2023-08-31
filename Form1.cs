using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 열기ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog(this);
            textBox1.Text = File.ReadAllText(OpenFileDialog.FileName);
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog(this);
            File.WriteAllText(saveFileDialog1);
        }
    }
}
