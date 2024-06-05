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
    public partial class Error : MetroFramework.Forms.MetroForm
    {
        public static Error _instsance;
        public Error()
        {
            _instsance = this;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }
        public void Show(String text)
        {
            Visible = true;
            label1.Text = text;
        }

        public static Error GetInstance()
        {
            if( _instsance == null )
                _instsance = new Error();   
            return _instsance;
        }
    }
}
