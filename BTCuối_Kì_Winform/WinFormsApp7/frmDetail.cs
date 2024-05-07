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
    public partial class frmDetail : Form
    {
        private BindingSource formDataSource;
        public frmDetail(BindingSource formDataSource)
        {
            InitializeComponent();
            this.formDataSource = formDataSource;
            txtManhac.DataBindings.Clear();
            txtManhac.DataBindings.Add("Text", formDataSource, Dungchung.dt.Columns[0].ColumnName, true, DataSourceUpdateMode.OnPropertyChanged);
            dtpNPH.DataBindings.Add("Text", formDataSource, Dungchung.dt.Columns[2].ColumnName, true, DataSourceUpdateMode.OnPropertyChanged);
            txtTennhac.DataBindings.Add("Text", formDataSource, Dungchung.dt.Columns[1].ColumnName, true, DataSourceUpdateMode.OnPropertyChanged);
            txtTacgia.DataBindings.Add("Text", formDataSource, Dungchung.dt.Columns[3].ColumnName, true, DataSourceUpdateMode.OnPropertyChanged);
            txtView.DataBindings.Add("Text", formDataSource, Dungchung.dt.Columns[4].ColumnName, true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void frmDetail_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            tbl = Dungchung.dt.GetChanges();
            //Nếu có sự thay đổi sẽ phát sinh các lệnh cập nhật
            if (tbl == null)
                MessageBox.Show("Dữ liệu chưa thay đổi");
            else
            {
                Dungchung.cmb = new SqlCommandBuilder(Dungchung.da);
                //Dungchung.cmb = new SqlCommandBuilder(Dungchung.da);
                Dungchung.da.Update(Dungchung.dt);
                MessageBox.Show("Có " + tbl.Rows.Count +
               " dòng đã được cập nhật");
            }
        }
    }
}
