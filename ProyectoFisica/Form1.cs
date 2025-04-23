using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesing(); 
        }
        private void customizeDesing()
        {
            panelMediaSubmenu.Visible = false;
            panelHerramientas.Visible = false; 
        }
        private void hideSubMenu()
        {
            if (panelMediaSubmenu.Visible == true)
                panelMediaSubmenu.Visible = false;

            if (panelHerramientas.Visible == true)
                panelHerramientas.Visible = false;

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu(); 
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }

        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubmenu);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelHerramientas);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form12()); 
            //
            hideSubMenu(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3()); 
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new Form4());
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new Form5());
            hideSubMenu();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Form6());
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            hideSubMenu();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            openChildForm(new Form7());
            hideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Form8());
            hideSubMenu();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Form9());
            hideSubMenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            openChildForm(new Form10());
            hideSubMenu();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Form11());
            hideSubMenu(); 
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Form2());
            hideSubMenu();
        }
    }
}
