﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFisica
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo4.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
