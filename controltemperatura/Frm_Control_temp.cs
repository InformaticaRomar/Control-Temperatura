using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace controltemperatura
{
    public partial class Form_ct : Form
    {
        //SqlConnection conexion;
        //SqlCommand comando;

        public Form_ct()
        {
            InitializeComponent();

            /*conexion = new SqlConnection();
            comando = new SqlCommand();
            conexion.ConnectionString = @"data source = 192.168.1.195\SQLSERVER2008; initial catalog = Ds_Rinya; user id = Ctemperatura; password = temperatura";*/
        }
        private void guardar() 
        {
            string _SSCC = textBox_sscc.Text;
            _SSCC = _SSCC.Trim();
            _SSCC = _SSCC.TrimStart('0').Replace("91x", "").Replace("91X", "");
           // textBox_sscc.Text = _SSCC;
            bool muestra = false;

            bool flag = true;
            bool result = false;
            if (_SSCC.Length == 18)
            {
                double temp = -999;
                double.TryParse(textBox_temp.Text.Replace('.', ','), out temp);
            

                if (temp >= 20)
                {
                    message men = new message(textBox_temp.Text);
                    men.ShowDialog();
                    if (men.DialogResult == DialogResult.Yes)
                    {
                        flag = true;
                    }else { flag = false; }
                }
                Palet palet = new Palet(_SSCC, textBox_temp.Text, checkBox1.Checked);
                if (flag == true) { 
                if (palet.existe() )
                {
                    result = palet.insertar_Quality();
                    textBox_sscc.Focus();
                    textBox_sscc.Text = "";
                    textBox_temp.Text = "";
                }
                    
                    //MessageBox.Show(palet.msg_sql);
                }
                if (result == true)
                {
                    string msg_tunel=" Palet del tunel: "+ palet.get_tunel().ToString();
                    mensaje comprueba = new mensaje(Color.Green, 2, msg_tunel);
                    comprueba.ShowDialog(this);
                    comprueba.Dispose();
                }
                else
                {
                    mensaje comprueba = new mensaje(Color.Red, 2,"");
                    comprueba.ShowDialog(this);
                    comprueba.Dispose();
                }
                label1.Text = "Matricula "+palet.get_SCCC()+ " Tunel "+ palet.get_tunel().ToString();
                textBox_sscc.Focus();
                textBox_sscc.SelectAll();
            }

        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
          if(  MessageBox.Show("Seguro que desea guardar temperatura?", "Guardar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            guardar();
          

        }


        private void textBox_temp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (MessageBox.Show("Seguro que desea guardar temperatura?", "Guardar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                guardar();
            }
        }

        private void textBox_sscc_Enter(object sender, EventArgs e)
        {
            textBox_sscc.SelectAll();

        }

        private void textBox_temp_Enter(object sender, EventArgs e)
        {
            textBox_temp.SelectAll();
        }

        private void textBox_sscc_TextChanged(object sender, EventArgs e)
        {
            msg_insert.Text = "";
        }

        private void textBox_sscc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                string _SSCC = textBox_sscc.Text;
                _SSCC = _SSCC.Trim();
                _SSCC = _SSCC.TrimStart('0').Replace("91x", "").Replace("91X", "");
                textBox_sscc.Text = _SSCC;
                textBox_temp.Focus();
                textBox_temp.SelectAll();
            }
               
        }

        private void Form_ct_Load(object sender, EventArgs e)
        {

        }
    }
}
