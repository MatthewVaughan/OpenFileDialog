using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab26
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// About Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display a message box showing developers name and class
            MessageBox.Show($"Matthew Vaughan\nCS1400 Sec 003");
        }

        /// <summary>
        /// Exit Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Close out of the program
            this.Close();
        }

        /// <summary>
        /// Open Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
                  OpenFileDialog openFileDialog1 = new OpenFileDialog();
            
            openFileDialog1.InitialDirectory = "c:\\";
                  openFileDialog1.Filter = "text files (*.txt)|*txt";
                  if (openFileDialog1.ShowDialog() == DialogResult.OK)
                      {
                        if ((myStream = openFileDialog1.OpenFile()) != null)
                        {
                               StreamReader data = new StreamReader(myStream);
                               txtReadFile.Text = data.ReadLine();
                        }
                 }
        }
    }
}
