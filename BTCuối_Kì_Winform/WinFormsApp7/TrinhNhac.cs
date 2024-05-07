using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class TrinhNhac : Form
    {
        public TrinhNhac()
        {
            InitializeComponent();
        }
        OpenFileDialog openFileDialog;
        string[] filepaths;
        string[] filenames;
        private void TrinhNhac_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int choose = listBox1.SelectedIndex;
                axWindowsMediaPlayer1.URL = filepaths[choose];
                this.textBox1.Text = filenames[choose];
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("bạn muốn thoát ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Mp 3 files, mp4 files (*.mp3 ,*.mp4)|*.mp*";
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Open";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filepaths = openFileDialog.FileNames; // lay duong dan
                filenames = openFileDialog.SafeFileNames; //lay ten file
                foreach (var item in filenames)
                {
                    this.listBox1.Items.Add(item);
                }
            }
        }
    }
}
