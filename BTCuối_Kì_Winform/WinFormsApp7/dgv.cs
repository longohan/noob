using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WinFormsApp7
{

    public partial class dgv : Form
    {
        public dgv()
        {
            InitializeComponent();
        }
        private void KhoiTao_DuLieu()
        {

            Dungchung.KetNoi();
            //------------------
            Dungchung.cmd = new SqlCommand("Select * From ThongTinNhac", Dungchung.cnn);
            Dungchung.da = new SqlDataAdapter();
            Dungchung.da.SelectCommand = Dungchung.cmd;
            Dungchung.da.Fill(Dungchung.dt);
            //Dungchung.cmd = new SqlCommand("Select ", Dungchung.cnn);
            //Dungchung.daNhac = new SqlDataAdapter();
            //Dungchung.daNhac.SelectCommand = Dungchung.cmd;
            //Dungchung.daNhac.Fill(Dungchung.dtNhac);
            bs.DataSource = Dungchung.dt;
            dgv1.DataSource = Dungchung.dt;
        }
        private void dgv_Load(object sender, EventArgs e)
        {
            KhoiTao_DuLieu();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            frmDetail dt = new frmDetail(bs);
            dt.Show();
        }

        private void bs_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            if (e.BindingCompleteContext == BindingCompleteContext.DataSourceUpdate && e.Exception == null)
            {
                e.Binding.BindingManagerBase.EndCurrentEdit();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            tbl = Dungchung.dt.GetChanges();
            //Nếu có sự thay đổi sẽ phát sinh các lệnh cập nhật
            if (tbl == null)
                MessageBox.Show("Dữ liệu chưa thay đổi");
            else
            {
                Dungchung.cmb = new SqlCommandBuilder(Dungchung.da);
                Dungchung.da.Update(Dungchung.dt);
                MessageBox.Show("Có " + tbl.Rows.Count +
               " dòng đã được cập nhật");
            }
        }
    }
}
public static class Dungchung
{
    public static SqlConnection cnn = new SqlConnection();
    public static SqlDataAdapter da;
    public static DataTable dt = new DataTable();
    public static SqlDataAdapter daNhac;
    public static DataTable dtNhac = new DataTable();
    public static SqlDataAdapter daTG;
    public static DataTable dtTG = new DataTable();
    public static SqlCommand cmd;
    public static SqlCommandBuilder cmb;
    public static void KetNoi()
    {
        string connectionstring;
        try
        {
            connectionstring = "server=DESKTOP-DEEH7VJ\\SQLEXPRESS";//<<<nhớ đổi lại tên server         
            connectionstring += ";database='music'";
            connectionstring += ";integrated security=true";
            Dungchung.cnn.ConnectionString = connectionstring;
            Dungchung.cnn.Open();
            MessageBox.Show("ket noi thanh cong");
        }
        catch (Exception ex)
        {
            MessageBox.Show("loi ke noi" + ex.Message);
        }
    }
}
