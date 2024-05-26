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
    public partial class LopForm : MetroFramework.Forms.MetroForm
    {
        public LopForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void LopForm_Shown(object sender, EventArgs e)
        {
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;
            db.sqlCmd.CommandText = "SELECT * FROM LOPHOC";

            db.sqlCmd.Connection = db.sqlCon;

            db.reader = db.sqlCmd.ExecuteReader();

            DanhSachLopHocListView.Items.Clear();

            while (db.reader.Read())
            {
                string idLop =db.reader.GetString(0);
                string tenLop  =db.reader.GetString(1);
                string siSo =db.reader.GetInt32(2).ToString();
                string idGVCN=db.reader.GetString(3);    

                ListViewItem item = new ListViewItem();
                item.Text = (DanhSachLopHocListView.Items.Count + 1).ToString();
                item.SubItems.Add(idLop);
                item.SubItems.Add(tenLop);
                item.SubItems.Add(siSo);
                item.SubItems.Add(idGVCN);
               

                DanhSachLopHocListView.Items.Add(item);

            }
            db.reader.Close();
        }

        private void metroListView1_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void metroListView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = this.DanhSachLopHocListView.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }
    }
}
