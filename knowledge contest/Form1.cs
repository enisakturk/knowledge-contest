using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace knowledge_contest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int questionNo = 0, t_rue = 0, f_alse = 0;

       

        private void btnnext_Click(object sender, EventArgs e)
        {
            btna.Enabled = true;
            btnb.Enabled = true;
            btnc.Enabled = true;
            btnd.Enabled = true;
            btnnext.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            questionNo++;
            lblquestion.Text = questionNo.ToString();
            if (questionNo==1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir";
                btna.Text = "1920";
                btnb.Text = "1923";
                btnc.Text = "1930";
                btnd.Text = "1881";
                label4.Text = "1923";
            }
            if (questionNo==2)
            {
                richTextBox1.Text = "Hangi şehrimiz Ege Bölgesi'nde bulunmaz";
                btna.Text = "İzmir";
                btnb.Text = "Balıkesir";
                btnc.Text = "Aydın";
                btnd.Text = "Trabzon";
                label4.Text = "Balıkesir";
            }
            if (questionNo==3)
            {
                richTextBox1.Text = "Son Kuşlar hangi yazarımıza aittir";
                btna.Text = "Sait Faik";
                btnb.Text = "Cemal Süreya";
                btnc.Text = "Atilla İlhan";
                btnd.Text = "Reşat Nuri";
                label4.Text = "Sait Faik";
                btnnext.Text = "Sonuçlar";
            }
            if (questionNo==4)
            {
                btna.Enabled = false;
                btnb.Enabled = false;
                btnc.Enabled = false;
                btnd.Enabled = false;
                btnnext.Enabled = false;
                MessageBox.Show("True:" + t_rue + "\n" + "False:" + f_alse);
            }

            
        }

       

        private void btna_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnnext.Enabled = true;

            label5.Text = btna.Text;

            if (label4.Text==label5.Text)
            {
                t_rue++;
                lbltrue.Text = t_rue.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                f_alse++;
                lblfalse.Text = f_alse.ToString();
                pictureBox2.Visible = true;
            }
        }

        

        private void btnb_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnnext.Enabled = true;

            label5.Text = btnb.Text;

            if (label4.Text == label5.Text)
            {
                t_rue++;
                lbltrue.Text = t_rue.ToString();
                pictureBox1.Visible = true;
        
            }
            else
            {
                f_alse++;
                lblfalse.Text = f_alse.ToString();
                pictureBox2.Visible = true;
            }

        }
        private void btnc_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnnext.Enabled = true;

            label5.Text = btnc.Text;

            if (label4.Text == label5.Text)
            {
                t_rue++;
                lbltrue.Text = t_rue.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                f_alse++;
                lblfalse.Text = f_alse.ToString();
                pictureBox2.Visible = true;
            }
        }
        private void btnd_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnnext.Enabled = true;

            label5.Text = btnd.Text;

            if (label4.Text == label5.Text)
            {
                t_rue++;
                lbltrue.Text = t_rue.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                f_alse++;
                lblfalse.Text = f_alse.ToString();
                pictureBox2.Visible = true;
            }
        }
    }
}
