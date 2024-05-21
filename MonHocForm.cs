using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh_Nhom15
{
    public partial class MonHocForm : MetroFramework.Forms.MetroForm
    {
        public MonHocForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void MonHocForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == true)
            {
                SQLConnect db = SQLConnect.GetInstance();
                db.Open();
                db.sqlCmd.CommandType = CommandType.Text;
                db.sqlCmd.CommandText = "SELECT * FROM MONHOC";

                db.sqlCmd.Connection = db.sqlCon;

                db.reader = db.sqlCmd.ExecuteReader();

                metroListView1.Items.Clear();

                while (db.reader.Read())
                {
                    string idMonHoc = db.reader.GetString(0);
                    string tenMonHoc = db.reader.GetString(1);
                    

                    ListViewItem item = new ListViewItem();
                    item.Text = (metroListView1.Items.Count + 1).ToString();
                    item.SubItems.Add(idMonHoc);
                    item.SubItems.Add(tenMonHoc);

                    metroListView1.Items.Add(item);

                }
                db.reader.Close();
            }
        }

        private void metroListView1_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void metroListView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = this.metroListView1.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }
    }
}
