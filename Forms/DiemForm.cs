﻿using System;
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
    public partial class DiemForm : MetroFramework.Forms.MetroForm
    {
        App mainApp;
        ChiTietBangDiem chiTietBangDiem= ChiTietBangDiem.GetInstance();
        public string idbangdiem;
        public string idhocsinh;
        public bool flagSua=false;

        public DiemForm(App MainApp)
        {
            InitializeComponent();
            mainApp = MainApp;
           
           
        }



        private void ExitButton_Click(object sender, EventArgs e)
        {
            Hide();
            flagSua = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(flagSua)
            {
                chiTietBangDiem.SuaDiem(idbangdiem, idhocsinh, numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value);
                mainApp.LoadTabBaoCaoMon();
                this.Hide();
            }
            else
            {
                chiTietBangDiem.ThemDiem(idbangdiem, idhocsinh, numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value);
                mainApp.LoadTabBaoCaoMon();
                this.Hide();
            }
            flagSua = false;
        }

        private void DiemForm_VisibleChanged(object sender, EventArgs e)
        {
            if (flagSua)
            {
                numericUpDown1.Value = chiTietBangDiem.Diem15p;
                numericUpDown2.Value = chiTietBangDiem.Diem1Tiet;
                numericUpDown3.Value = chiTietBangDiem.DiemTB;
            }
            else
            {
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;
                numericUpDown3.Value = 0;
            }


        }
    }
}
