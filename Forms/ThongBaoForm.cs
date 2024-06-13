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
    public partial class ThongBaoForm : MetroFramework.Forms.MetroForm
    {
        public static ThongBaoForm _instsance;
        public ThongBaoForm()
        {
            _instsance = this;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void LogError(String text)
        {
            FormLabel.ForeColor = Color.FromArgb(192, 0, 0);
            FormLabel.Image=Properties.Resources.ErrorIcon;
            label1.Text = text;
            if (!Visible)
                ShowDialog();
        }

        public void Inform(String text)
        {
            FormLabel.ForeColor = Color.FromArgb(0, 192, 0);
            FormLabel.Image = Properties.Resources.SuccessIcon;
            label1.Text=text;
            if (!Visible)
                ShowDialog();
        }

        public static ThongBaoForm GetInstance()
        {
            if( _instsance == null )
                _instsance = new ThongBaoForm();   
            return _instsance;
        }
    }
}
