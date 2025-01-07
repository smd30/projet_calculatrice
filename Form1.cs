﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace projet_calculatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double memo;
        char op;
        double memoire = 0;

        private void ecrire (string valeur){
            if (txtEcran.Text == "0")
            {
                txtEcran.Text = valeur;
            }
            else
            {
                txtEcran.Text = txtEcran.Text + valeur;
            }
        }
        public void operation(char p)
        {
            memo = double.Parse(txtEcran.Text);
            op = p;
            txtEcran.Text = "0";
        }
        
        

        private void btn_effacer_Click(object sender, EventArgs e)
        {
            if (txtEcran.Text.Length > 1)
            {
                txtEcran.Text = txtEcran.Text.Substring(0, txtEcran.Text.Length - 1);
            }
            else
            {
                txtEcran.Text = "0"; 
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_fois_Click(object sender, EventArgs e)
        {
            operation('*');
        }


        private void txtEcran_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_mr_Click(object sender, EventArgs e)
        {
            txtEcran.Text = memoire.ToString();
        }

        private void btn_pourcent_Click(object sender, EventArgs e)
        {
            memo = (double.Parse(txtEcran.Text)) * (0.01);
            txtEcran.Text = memo.ToString();
        }

        private void btn_racine_Click(object sender, EventArgs e)
        {
            memo = Math.Sqrt(double.Parse(txtEcran.Text));
            txtEcran.Text = memo.ToString();
        }

        private void btnx2_Click(object sender, EventArgs e)
        {
            memo = Math.Pow((double.Parse(txtEcran.Text)), 2);
            txtEcran.Text = memo.ToString();
        }

        private void btn1surX_Click(object sender, EventArgs e)
        {
            memo = 1 / (double.Parse(txtEcran.Text));
            txtEcran.Text = memo.ToString();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtEcran.Text = "0";
        }

        private void byn_C_Click(object sender, EventArgs e)
        {
            txtEcran.Text = "0";
            memo = 0;
            op = '\0';
        }

        private void btn_effacer_Click_1(object sender, EventArgs e)
        {
            if (txtEcran.Text.Length > 1)
            {
                txtEcran.Text = txtEcran.Text.Substring(0, txtEcran.Text.Length - 1);
            }
            else
            {
                txtEcran.Text = "0";
            }
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            operation('÷');
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            ecrire("7");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ecrire("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ecrire("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ecrire("3");
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            ecrire("6");
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            ecrire("9");
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            ecrire("4");
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            ecrire("5");
        }

        private void btn_egal_Click_1(object sender, EventArgs e)
        {
            if (op == '+')
            {
                memo = memo + double.Parse(txtEcran.Text);
                txtEcran.Text = memo.ToString();

            }
            else if (op == '-')
            {
                memo = memo - double.Parse(txtEcran.Text);
                txtEcran.Text = memo.ToString();
            }
            else if (op == '*')
            {
                memo = memo * double.Parse(txtEcran.Text);
                txtEcran.Text = memo.ToString();
            }
            else if (op == '÷')
            {
                if (txtEcran.Text == "0")
                {
                    txtEcran.Text = "ERREUR";
                }
                else
                {
                    memo = memo / double.Parse(txtEcran.Text);
                    txtEcran.Text = memo.ToString();
                }

            }
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            operation('+');
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            ecrire("8");
        }

        

        private void btn_moins_Click(object sender, EventArgs e)
        {
            operation('-');
        }

        private void btnPlusMoins_Click_1(object sender, EventArgs e)
        {
            memo = (double.Parse(txtEcran.Text)) * (-1);
            txtEcran.Text = memo.ToString();
        }

        private void btn_virgule_Click_1(object sender, EventArgs e)
        {
           if (txtEcran.Text.Contains(",") == false)
            {
                txtEcran.Text = txtEcran.Text + ",";
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            ecrire("0");
        }

        private void mplus_Click(object sender, EventArgs e)
        {
            memoire += double.Parse(txtEcran.Text);
        }

        private void mMoins_Click(object sender, EventArgs e)
        {
            memoire -= double.Parse(txtEcran.Text);
        }

        private void btnMs_Click(object sender, EventArgs e)
        {
             memoire = double.Parse(txtEcran.Text);
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            memoire += double.Parse(txtEcran.Text);
        }
    }
}