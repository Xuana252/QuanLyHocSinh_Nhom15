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
            IDMonTextBox.Clear();
            TenMonTextBox.Clear();
            Hide();
        }





        private void MonHocForm_Shown(object sender, EventArgs e)
        {
            SQLConnect db = SQLConnect.GetInstance();
            db.Open();
            db.sqlCmd.CommandType = CommandType.Text;
            db.sqlCmd.CommandText = "SELECT * FROM MONHOC WHERE idMonHoc <> 'NO'";

            db.sqlCmd.Connection = db.sqlCon;

            db.reader = db.sqlCmd.ExecuteReader();

            MonListView1.Items.Clear();

            while (db.reader.Read())
            {
                string idMonHoc = db.reader.GetString(0);
                string tenMonHoc = db.reader.GetString(1);


                ListViewItem item = new ListViewItem();
                item.Text = (MonListView1.Items.Count + 1).ToString();
                item.SubItems.Add(idMonHoc);
                item.SubItems.Add(tenMonHoc);

                MonListView1.Items.Add(item);

            }
            db.reader.Close();
        }
        private void MonListView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = this.MonListView1.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void MonListView1_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void ThemSuaMonButton_Click(object sender, EventArgs e)
        {
            if (IDMonTextBox.Text == "" || TenMonTextBox.Text == "")
            {
                Error.GetInstance().Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }    
            if(MonListView1.SelectedItems.Count > 0)
            {
                MonHoc.GetInstance().SuaMonHoc(IDMonTextBox.Text,TenMonTextBox.Text);
                MonHocForm_Shown(sender,e);
            }
            else
            {
                MonHoc.GetInstance().ThemMonHoc(IDMonTextBox.Text, TenMonTextBox.Text);
                MonHocForm_Shown(sender, e);
            }
        }

        private void XoaMonButton_Click(object sender, EventArgs e)
        {
            MonHoc.GetInstance().XoaMonHoc(MonListView1.SelectedItems);
            MonHocForm_Shown(sender, e);
        }

        private void MonListView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (MonListView1.SelectedItems.Count > 0)
            {
                IDMonTextBox.Text = MonListView1.SelectedItems[0].SubItems[1].Text;
                TenMonTextBox.Text = MonListView1.SelectedItems[0].SubItems[2].Text;
            }
            else
            {
                
                IDMonTextBox.Text = string.Empty;
                TenMonTextBox.Text = string.Empty;
            }
        }
    }

}
