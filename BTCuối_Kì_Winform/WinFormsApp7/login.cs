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
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Xml;
namespace WinFormsApp7
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring;
            SqlConnection cnn = new SqlConnection();
            try
            {
                connectionstring = "Server=DESKTOP-DEEH7VJ\\SQLEXPRESS";
                connectionstring += ";database=music";
                connectionstring += ";uid=" + txtUser.Text;
                connectionstring += ";pwd=" + txtpass.Text;
                cnn.ConnectionString = connectionstring;
                cnn.Open();
                MessageBox.Show("ket noi thanh cong"); cnn.Close();
                dgv gv = new dgv();
                gv.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi ke noi" + ex.Message);
            }

        }
    }
}
