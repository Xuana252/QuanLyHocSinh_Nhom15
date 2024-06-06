using MetroFramework.Controls;
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
        //Khối sự kiện dành cho việc vẽ các item dành cho listview
        //---------------------------------------------------------------------------------------------------------------------------------

        private void ListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            if (sender is MetroListView listView)
            {
                e.NewWidth = listView.Columns[e.ColumnIndex].Width;
                e.Cancel = true;
            }
        }

        private void ListView_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void ListView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = false;
            if (sender is MetroListView listView)
            {
                using (Font headerFont = new Font("Arial", 12, FontStyle.Regular))
                {
                    Rectangle headerBounds = e.Bounds;

                    e.Graphics.FillRectangle(Brushes.Teal, e.Bounds);

                    TextRenderer.DrawText(e.Graphics, listView.Columns[e.ColumnIndex].Text, headerFont, headerBounds, Color.White, Color.Empty, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);

                    e.Graphics.DrawLine(Pens.DarkGray, headerBounds.Left, headerBounds.Bottom - 1, headerBounds.Right, headerBounds.Bottom - 1);
                }
            }

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------
    }

}
