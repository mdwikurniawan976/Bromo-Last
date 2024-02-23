using Bromo.Masters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bromo
{
    public partial class AdminMainFrm : Form
    {
        string nama;
        bool SideBarExpand;
        public AdminMainFrm(string nama)
        {
            InitializeComponent();
            this.nama = nama;   

        }

        private void AdminMainFrm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ActiveMdiChild != null)
            { ActiveMdiChild.Close(); }

            panel3.Visible = false;
            MasterBandaraFrm B = new MasterBandaraFrm();
            B.MdiParent = this;
            B.Dock = DockStyle.Fill;
            B.Show();
            button1.ForeColor = Color.Black;
            button1.Image = Bromo.Properties.Resources.map_selected_72;

            button2.ForeColor = Color.LightGray;
            button2.Image = Bromo.Properties.Resources.plane_take_off_unselected_72;

            button3.ForeColor = Color.LightGray;
            button3.Image = Bromo.Properties.Resources.calendar_unselected_72;

            button4.ForeColor = Color.LightGray;
            button4.Image = Bromo.Properties.Resources.purchase_tag_alt_unselected_72;

            button5.ForeColor = Color.LightGray;
            button5.Image = Bromo.Properties.Resources.notepad_unselected_72;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Apakah Anda Yakin Ingin Logout Dari Form Ini {nama} ? ", "Konfirmasi",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                Login m = new Login();
                m.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            { ActiveMdiChild.Close(); }

            panel3.Visible = false;
            MasterMaskapaiFrm B = new MasterMaskapaiFrm();
            B.MdiParent = this;
            B.Dock = DockStyle.Fill;
            B.Show();

            button2.ForeColor = Color.Black;
            button2.Image = Bromo.Properties.Resources.plane_take_off_selected_72;

            button1.ForeColor = Color.LightGray;
            button1.Image = Bromo.Properties.Resources.map_unselected_72;


             button3.ForeColor = Color.LightGray;
            button3.Image = Bromo.Properties.Resources.calendar_unselected_72;

            button4.ForeColor = Color.LightGray;
            button4.Image = Bromo.Properties.Resources.purchase_tag_alt_unselected_72;

            button5.ForeColor = Color.LightGray;
            button5.Image = Bromo.Properties.Resources.notepad_unselected_72;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            { ActiveMdiChild.Close(); }

            panel3.Visible = false;
            MasterJadwalPenerbangan B = new MasterJadwalPenerbangan();
            B.MdiParent = this;
            B.Dock = DockStyle.Fill;
            B.Show();

            button3.ForeColor = Color.Black;
            button3.Image = Bromo.Properties.Resources.calendar_selected_72;


            button1.ForeColor = Color.LightGray;
            button1.Image = Bromo.Properties.Resources.map_unselected_72;

            button2.ForeColor = Color.LightGray;
            button2.Image = Bromo.Properties.Resources.plane_take_off_unselected_72;

        

            button4.ForeColor = Color.LightGray;
            button4.Image = Bromo.Properties.Resources.purchase_tag_alt_unselected_72;

            button5.ForeColor = Color.LightGray;
            button5.Image = Bromo.Properties.Resources.notepad_unselected_72;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            { ActiveMdiChild.Close(); }

            panel3.Visible = false;
            MasterKodePromo B = new MasterKodePromo();
            B.MdiParent = this;
            B.Dock = DockStyle.Fill;
            B.Show();

            button4.ForeColor= Color.Black;
            button4.Image = Bromo.Properties.Resources.purchase_tag_alt_selected_72;


            button1.ForeColor = Color.LightGray;
            button1.Image = Bromo.Properties.Resources.map_unselected_72;

            button2.ForeColor = Color.LightGray;
            button2.Image = Bromo.Properties.Resources.plane_take_off_unselected_72;

            button3.ForeColor = Color.LightGray;
            button3.Image = Bromo.Properties.Resources.calendar_unselected_72;

            button5.ForeColor = Color.LightGray;
            button5.Image = Bromo.Properties.Resources.notepad_unselected_72;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            { ActiveMdiChild.Close(); }

            panel3.Visible = false;
            UbahStatusPenerbangan B = new UbahStatusPenerbangan();
            B.MdiParent = this;
            B.Dock = DockStyle.Fill;
            B.Show();

            button5.ForeColor = Color.Black;
            button5.Image = Bromo.Properties.Resources.notepad_selected_72;


            button1.ForeColor = Color.LightGray;
            button1.Image = Bromo.Properties.Resources.map_unselected_72;

            button2.ForeColor = Color.LightGray;
            button2.Image = Bromo.Properties.Resources.plane_take_off_unselected_72;

            button3.ForeColor = Color.LightGray;
            button3.Image = Bromo.Properties.Resources.calendar_unselected_72;

            button4.ForeColor = Color.LightGray;
            button4.Image = Bromo.Properties.Resources.purchase_tag_alt_unselected_72;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           timer1.Start();  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (SideBarExpand)
            {
                panel2.Width -= 10;
                if(panel2.Width == panel2.MinimumSize.Width)
                {
                    SideBarExpand = false;
                    timer1.Stop();  
                }
                else
                {
                    panel2.Width += 10;
                    if(panel2.Width == panel2.MaximumSize.Width)
                    {
                            SideBarExpand = true;   
                        timer1.Stop();
                    }
                }
            }
        }
    }
}
