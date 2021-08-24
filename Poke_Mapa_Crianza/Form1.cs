using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poke_Mapa_Crianza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //variables globales
        object[] poke_stats_eng = new object[] { "---","HP", "ATK","DEF","ATK E","DEF E", "VEL", "NAT"};
        object[] poke_stats_esp = new object[] { "---", "PS", "ATQ", "DEF", "ATQ E", "DEF E", "VEL", "NATU" };
        object[] poke_stats = new object[8];

        string[] poke_estadisticas = new string[8];

        int hp = 0, atk = 0, def = 0, atk_e = 0, def_e = 0, vel = 0, natu = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            poke_stats = poke_stats_eng;

            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
            comboBox6.Items.Clear();
            comboBox7.Items.Clear();
            comboBox8.Items.Clear();
            comboBox9.Items.Clear();
            comboBox10.Items.Clear();
            comboBox11.Items.Clear();
            comboBox12.Items.Clear();
            comboBox13.Items.Clear();
            comboBox14.Items.Clear();
            comboBox15.Items.Clear();
            comboBox16.Items.Clear();
            comboBox17.Items.Clear();
            comboBox18.Items.Clear();
            comboBox19.Items.Clear();
            comboBox20.Items.Clear();
            comboBox21.Items.Clear();
            comboBox22.Items.Clear();
            comboBox23.Items.Clear();
            comboBox24.Items.Clear();
            comboBox25.Items.Clear();
            comboBox26.Items.Clear();
            comboBox27.Items.Clear();
            comboBox28.Items.Clear();
            comboBox29.Items.Clear();
            comboBox30.Items.Clear();
            comboBox31.Items.Clear();
            comboBox32.Items.Clear();

            comboBox1.Items.AddRange(poke_stats);
            comboBox2.Items.AddRange(poke_stats);
            comboBox3.Items.AddRange(poke_stats);
            comboBox4.Items.AddRange(poke_stats);
            comboBox5.Items.AddRange(poke_stats);
            comboBox6.Items.AddRange(poke_stats);
            comboBox7.Items.AddRange(poke_stats);
            comboBox8.Items.AddRange(poke_stats);
            comboBox9.Items.AddRange(poke_stats);
            comboBox10.Items.AddRange(poke_stats);
            comboBox11.Items.AddRange(poke_stats);
            comboBox12.Items.AddRange(poke_stats);
            comboBox13.Items.AddRange(poke_stats);
            comboBox14.Items.AddRange(poke_stats);
            comboBox15.Items.AddRange(poke_stats);
            comboBox16.Items.AddRange(poke_stats);
            comboBox17.Items.AddRange(poke_stats);
            comboBox18.Items.AddRange(poke_stats);
            comboBox19.Items.AddRange(poke_stats);
            comboBox20.Items.AddRange(poke_stats);
            comboBox21.Items.AddRange(poke_stats);
            comboBox22.Items.AddRange(poke_stats);
            comboBox23.Items.AddRange(poke_stats);
            comboBox24.Items.AddRange(poke_stats);
            comboBox25.Items.AddRange(poke_stats);
            comboBox26.Items.AddRange(poke_stats);
            comboBox27.Items.AddRange(poke_stats);
            comboBox28.Items.AddRange(poke_stats);
            comboBox29.Items.AddRange(poke_stats);
            comboBox30.Items.AddRange(poke_stats);
            comboBox31.Items.AddRange(poke_stats);
            comboBox32.Items.AddRange(poke_stats);
            /* 
             comboBox1.SelectedIndex = -1;
             comboBox2.SelectedIndex = -1;
             comboBox3.SelectedIndex = -1;
             comboBox4.SelectedIndex = -1;
             comboBox5.SelectedIndex = -1;
             comboBox6.SelectedIndex = -1;
             comboBox7.SelectedIndex = -1;
             comboBox8.SelectedIndex = -1;
             comboBox9.SelectedIndex = -1;
             comboBox10.SelectedIndex = -1;
             comboBox11.SelectedIndex = -1;
             comboBox12.SelectedIndex = -1;
             comboBox13.SelectedIndex = -1;
             comboBox14.SelectedIndex = -1;
             comboBox15.SelectedIndex = -1;
             comboBox16.SelectedIndex = -1;
             comboBox17.SelectedIndex = -1;
             comboBox18.SelectedIndex = -1;
             comboBox19.SelectedIndex = -1;
             comboBox20.SelectedIndex = -1;
             comboBox21.SelectedIndex = -1;
             comboBox22.SelectedIndex = -1;
             comboBox23.SelectedIndex = -1;
             comboBox24.SelectedIndex = -1;
             comboBox25.SelectedIndex = -1;
             comboBox26.SelectedIndex = -1;
             comboBox27.SelectedIndex = -1;
             comboBox28.SelectedIndex = -1;
             comboBox29.SelectedIndex = -1;
             comboBox30.SelectedIndex = -1;
             comboBox31.SelectedIndex = -1;
             comboBox32.SelectedIndex = -1;
             */

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            comboBox7.SelectedIndex = 0;
            comboBox8.SelectedIndex = 0;
            comboBox9.SelectedIndex = 0;
            comboBox10.SelectedIndex = 0;
            comboBox11.SelectedIndex = 0;
            comboBox12.SelectedIndex = 0;
            comboBox13.SelectedIndex = 0;
            comboBox14.SelectedIndex = 0;
            comboBox15.SelectedIndex = 0;
            comboBox16.SelectedIndex = 0;
            comboBox17.SelectedIndex = 0;
            comboBox18.SelectedIndex = 0;
            comboBox19.SelectedIndex = 0;
            comboBox20.SelectedIndex = 0;
            comboBox21.SelectedIndex = 0;
            comboBox22.SelectedIndex = 0;
            comboBox23.SelectedIndex = 0;
            comboBox24.SelectedIndex = 0;
            comboBox25.SelectedIndex = 0;
            comboBox26.SelectedIndex = 0;
            comboBox27.SelectedIndex = 0;
            comboBox28.SelectedIndex = 0;
            comboBox29.SelectedIndex = 0;
            comboBox30.SelectedIndex = 0;
            comboBox31.SelectedIndex = 0;
            comboBox32.SelectedIndex = 0;

            for (int i = 0; i < poke_stats.Length; i++)
            {
                poke_estadisticas[i] = poke_stats[i].ToString();
            }

            label3.Text = poke_estadisticas[1];
            label4.Text = poke_estadisticas[2];
            label5.Text = poke_estadisticas[3];
            label6.Text = poke_estadisticas[4];
            label7.Text = poke_estadisticas[5];
            label8.Text = poke_estadisticas[6];
            label9.Text = poke_estadisticas[7];

            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hp = 0;
            atk = 0;
            def = 0;
            atk_e = 0;
            def_e = 0;
            vel = 0;
            natu = 0;

            suma_pokes(comboBox1.SelectedIndex);
            suma_pokes(comboBox2.SelectedIndex);
            suma_pokes(comboBox3.SelectedIndex);
            suma_pokes(comboBox4.SelectedIndex);
            suma_pokes(comboBox5.SelectedIndex);
            suma_pokes(comboBox6.SelectedIndex);
            suma_pokes(comboBox7.SelectedIndex);
            suma_pokes(comboBox8.SelectedIndex);
            suma_pokes(comboBox9.SelectedIndex);
            suma_pokes(comboBox10.SelectedIndex);
            suma_pokes(comboBox11.SelectedIndex);
            suma_pokes(comboBox12.SelectedIndex);
            suma_pokes(comboBox13.SelectedIndex);
            suma_pokes(comboBox14.SelectedIndex);
            suma_pokes(comboBox15.SelectedIndex);
            suma_pokes(comboBox16.SelectedIndex);
            suma_pokes(comboBox17.SelectedIndex);
            suma_pokes(comboBox18.SelectedIndex);
            suma_pokes(comboBox19.SelectedIndex);
            suma_pokes(comboBox20.SelectedIndex);
            suma_pokes(comboBox21.SelectedIndex);
            suma_pokes(comboBox22.SelectedIndex);
            suma_pokes(comboBox23.SelectedIndex);
            suma_pokes(comboBox24.SelectedIndex);
            suma_pokes(comboBox25.SelectedIndex);
            suma_pokes(comboBox26.SelectedIndex);
            suma_pokes(comboBox27.SelectedIndex);
            suma_pokes(comboBox28.SelectedIndex);
            suma_pokes(comboBox29.SelectedIndex);
            suma_pokes(comboBox30.SelectedIndex);
            suma_pokes(comboBox31.SelectedIndex);
            suma_pokes(comboBox32.SelectedIndex);

            textBox32.Text = hp.ToString();
            textBox33.Text = atk.ToString();
            textBox34.Text = def.ToString();
            textBox35.Text = atk_e.ToString();
            textBox36.Text = def_e.ToString();
            textBox37.Text = vel.ToString();
            textBox38.Text = natu.ToString();

            if (natu>1)
            {
                textBox38.BackColor = Color.Red;
            }
            else
            {
                textBox38.BackColor = Color.White;
            }
        }

        public String calcula_combinacion(String cadena_combi)
        {
            String resultado = "";

            //MessageBox.Show(cadena_combi);

            if (cadena_combi.Contains(",0,"))
            {
                resultado = "";
            }

            if (cadena_combi.Contains(",1,"))
            {
                resultado += poke_estadisticas[1].ToString()+" /";
            }

            if (cadena_combi.Contains(",2,"))
            {
                resultado += poke_estadisticas[2].ToString() + " /";
            }

            if (cadena_combi.Contains(",3,"))
            {
                resultado += poke_estadisticas[3].ToString() + " /";
            }

            if (cadena_combi.Contains(",4,"))
            {
                resultado += poke_estadisticas[4].ToString() + " /";
            }

            if (cadena_combi.Contains(",5,"))
            {
                resultado += poke_estadisticas[5].ToString() + " /";
            }

            if (cadena_combi.Contains(",6,"))
            {
                resultado += poke_estadisticas[6].ToString() + " /";
            }

            if (cadena_combi.Contains(",7,"))
            {
                resultado += poke_estadisticas[7].ToString() + " /";
            }

            try
            {
                resultado = resultado.Substring(0, resultado.Length - 2);
            }
            catch { };

            return resultado;
        }

        public void suma_pokes(int stat)
        {
            switch (stat)
            {
                case 1:
                    hp++;
                break;

                case 2:
                    atk++;
                 break;

                case 3:
                    def++;
                break;

                case 4:
                    atk_e++;
                break;

                case 5:
                    def_e++;
                break;

                case 6:
                    vel++;
                break;

                case 7:
                    natu++;
                break;
            }
        }

        public bool verifica_combinacion_nivel1(String cadena_verif)
        {
            string[] items=null;

            items = cadena_verif.Split('/');

            if (items.Length==2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool verifica_combinacion_nivel2(String cadena_verif)
        {
            string[] items=null;

            items = cadena_verif.Split('/');

            if (items.Length == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool verifica_combinacion_nivel3(String cadena_verif)
        {
            string[] items = null;

            items = cadena_verif.Split('/');

            if (items.Length == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool verifica_combinacion_nivel4(String cadena_verif)
        {
            string[] items = null;

            items = cadena_verif.Split('/');

            if (items.Length == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool verifica_combinacion_nivel5(String cadena_verif)
        {
            string[] items = null;

            items = cadena_verif.Split('/');

            if (items.Length == 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = calcula_combinacion("," + comboBox1.SelectedIndex.ToString() + "," + comboBox2.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel1(textBox1.Text))
            {
                textBox1.BackColor = Color.Lime;
            }
            else
            {
                if (textBox1.Text.Length > 0) {
                    textBox1.BackColor = Color.Red;
                }
                else
                {
                    textBox1.BackColor = Color.White;
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = calcula_combinacion("," + comboBox1.SelectedIndex.ToString() + "," + comboBox2.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel1(textBox1.Text))
            {
                textBox1.BackColor = Color.Lime;
            }
            else
            {
                if (textBox1.Text.Length > 0)
                {
                    textBox1.BackColor = Color.Red;
                }
                else
                {
                    textBox1.BackColor = Color.White;
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = calcula_combinacion("," + comboBox3.SelectedIndex.ToString() + "," + comboBox4.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel1(textBox2.Text))
            {
                textBox2.BackColor = Color.Lime;
            }
            else
            {
                if (textBox2.Text.Length > 0)
                {
                    textBox2.BackColor = Color.Red;
                }
                else
                {
                    textBox2.BackColor = Color.White;
                }
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = calcula_combinacion("," + comboBox3.SelectedIndex.ToString() + "," + comboBox4.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel1(textBox2.Text))
            {
                textBox2.BackColor = Color.Lime;
            }
            else
            {
                if (textBox2.Text.Length > 0)
                {
                    textBox2.BackColor = Color.Red;
                }
                else
                {
                    textBox2.BackColor = Color.White;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox17.Text = calcula_combinacion("," + comboBox1.SelectedIndex.ToString() + "," + comboBox2.SelectedIndex.ToString() + "," + comboBox3.SelectedIndex.ToString() + "," + comboBox4.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel2(textBox17.Text))
            {
                textBox17.BackColor = Color.Lime;
            }
            else
            {
                if (textBox17.Text.Length>0) {
                    textBox17.BackColor = Color.Red;
                }
                else
                {
                    textBox17.BackColor = Color.White;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox17.Text = calcula_combinacion("," + comboBox1.SelectedIndex.ToString() + "," + comboBox2.SelectedIndex.ToString() + "," + comboBox3.SelectedIndex.ToString() + "," + comboBox4.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel2(textBox17.Text))
            {
                textBox17.BackColor = Color.Lime;
            }
            else
            {
                if (textBox17.Text.Length > 0)
                {
                    textBox17.BackColor = Color.Red;
                }
                else
                {
                    textBox17.BackColor = Color.White;
                }
            }
        }
        
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = calcula_combinacion("," + comboBox5.SelectedIndex.ToString() + "," + comboBox6.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel1(textBox3.Text))
            {
                textBox3.BackColor = Color.Lime;
            }
            else
            {
                if (textBox3.Text.Length > 0)
                {
                    textBox3.BackColor = Color.Red;
                }
                else
                {
                    textBox3.BackColor = Color.White;
                }
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = calcula_combinacion("," + comboBox5.SelectedIndex.ToString() + "," + comboBox6.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel1(textBox3.Text))
            {
                textBox3.BackColor = Color.Lime;
            }
            else
            {
                if (textBox3.Text.Length > 0)
                {
                    textBox3.BackColor = Color.Red;
                }
                else
                {
                    textBox3.BackColor = Color.White;
                }
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox4.Text = calcula_combinacion("," + comboBox7.SelectedIndex.ToString() + "," + comboBox8.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel1(textBox4.Text))
            {
                textBox4.BackColor = Color.Lime;
            }
            else
            {
                if (textBox4.Text.Length > 0)
                {
                    textBox4.BackColor = Color.Red;
                }
                else
                {
                    textBox4.BackColor = Color.White;
                }
            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox4.Text = calcula_combinacion("," + comboBox7.SelectedIndex.ToString() + "," + comboBox8.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel1(textBox4.Text))
            {
                textBox4.BackColor = Color.Lime;
            }
            else
            {
                if (textBox4.Text.Length > 0)
                {
                    textBox4.BackColor = Color.Red;
                }
                else
                {
                    textBox4.BackColor = Color.White;
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox18.Text = calcula_combinacion("," + comboBox5.SelectedIndex.ToString() + "," + comboBox6.SelectedIndex.ToString() + "," + comboBox7.SelectedIndex.ToString() + "," + comboBox8.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel2(textBox18.Text))
            {
                textBox18.BackColor = Color.Lime;
            }
            else
            {
                if (textBox18.Text.Length > 0)
                {
                    textBox18.BackColor = Color.Red;
                }
                else
                {
                    textBox18.BackColor = Color.White;
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox18.Text = calcula_combinacion("," + comboBox5.SelectedIndex.ToString() + "," + comboBox6.SelectedIndex.ToString() + "," + comboBox7.SelectedIndex.ToString() + "," + comboBox8.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel2(textBox18.Text))
            {
                textBox18.BackColor = Color.Lime;
            }
            else
            {
                if (textBox18.Text.Length > 0)
                {
                    textBox18.BackColor = Color.Red;
                }
                else
                {
                    textBox18.BackColor = Color.White;
                }
            }
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            textBox25.Text = calcula_combinacion("," + comboBox1.SelectedIndex.ToString() + "," + comboBox2.SelectedIndex.ToString() + "," + comboBox3.SelectedIndex.ToString() + "," + comboBox4.SelectedIndex.ToString() + 
                                                 "," + comboBox5.SelectedIndex.ToString() + "," + comboBox6.SelectedIndex.ToString() + "," + comboBox7.SelectedIndex.ToString() + "," + comboBox8.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel3(textBox25.Text))
            {
                textBox25.BackColor = Color.Lime;
            }
            else
            {
                if(textBox25.Text.Length>0){
                    textBox25.BackColor = Color.Red;
                }
                else
                {
                    textBox25.BackColor = Color.White;
                }
                
            }
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            textBox25.Text = calcula_combinacion("," + comboBox1.SelectedIndex.ToString() + "," + comboBox2.SelectedIndex.ToString() + "," + comboBox3.SelectedIndex.ToString() + "," + comboBox4.SelectedIndex.ToString() +
                                                  "," + comboBox5.SelectedIndex.ToString() + "," + comboBox6.SelectedIndex.ToString() + "," + comboBox7.SelectedIndex.ToString() + "," + comboBox8.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel3(textBox25.Text))
            {
                textBox25.BackColor = Color.Lime;
            }
            else
            {
                if (textBox25.Text.Length > 0)
                {
                    textBox25.BackColor = Color.Red;
                }
                else
                {
                    textBox25.BackColor = Color.White;
                }

            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox5.Text = calcula_combinacion("," + comboBox9.SelectedIndex.ToString() + "," + comboBox10.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel1(textBox5.Text))
            {
                textBox5.BackColor = Color.Lime;
            }
            else
            {
                if (textBox5.Text.Length > 0)
                {
                    textBox5.BackColor = Color.Red;
                }
                else
                {
                    textBox5.BackColor = Color.White;
                }
            }
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox5.Text = calcula_combinacion("," + comboBox9.SelectedIndex.ToString() + "," + comboBox10.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel1(textBox5.Text))
            {
                textBox5.BackColor = Color.Lime;
            }
            else
            {
                if (textBox5.Text.Length > 0)
                {
                    textBox5.BackColor = Color.Red;
                }
                else
                {
                    textBox5.BackColor = Color.White;
                }
            }
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox6.Text = calcula_combinacion("," + comboBox11.SelectedIndex.ToString() + "," + comboBox12.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel1(textBox6.Text))
            {
                textBox6.BackColor = Color.Lime;
            }
            else
            {
                if (textBox6.Text.Length > 0)
                {
                    textBox6.BackColor = Color.Red;
                }
                else
                {
                    textBox6.BackColor = Color.White;
                }
            }
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox6.Text = calcula_combinacion("," + comboBox11.SelectedIndex.ToString() + "," + comboBox12.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel1(textBox6.Text))
            {
                textBox6.BackColor = Color.Lime;
            }
            else
            {
                if (textBox6.Text.Length > 0)
                {
                    textBox6.BackColor = Color.Red;
                }
                else
                {
                    textBox6.BackColor = Color.White;
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox19.Text = calcula_combinacion("," + comboBox9.SelectedIndex.ToString() + "," + comboBox10.SelectedIndex.ToString() + "," + comboBox11.SelectedIndex.ToString() + "," + comboBox12.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel2(textBox19.Text))
            {
                textBox19.BackColor = Color.Lime;
            }
            else
            {
                if (textBox19.Text.Length > 0)
                {
                    textBox19.BackColor = Color.Red;
                }
                else
                {
                    textBox19.BackColor = Color.White;
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox19.Text = calcula_combinacion("," + comboBox9.SelectedIndex.ToString() + "," + comboBox10.SelectedIndex.ToString() + "," + comboBox11.SelectedIndex.ToString() + "," + comboBox12.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel2(textBox19.Text))
            {
                textBox19.BackColor = Color.Lime;
            }
            else
            {
                if (textBox19.Text.Length > 0)
                {
                    textBox19.BackColor = Color.Red;
                }
                else
                {
                    textBox19.BackColor = Color.White;
                }
            }
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox7.Text = calcula_combinacion("," + comboBox13.SelectedIndex.ToString() + "," + comboBox14.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel1(textBox7.Text))
            {
                textBox7.BackColor = Color.Lime;
            }
            else
            {
                if (textBox7.Text.Length > 0)
                {
                    textBox7.BackColor = Color.Red;
                }
                else
                {
                    textBox7.BackColor = Color.White;
                }
            }
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox7.Text = calcula_combinacion("," + comboBox13.SelectedIndex.ToString() + "," + comboBox14.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel1(textBox7.Text))
            {
                textBox7.BackColor = Color.Lime;
            }
            else
            {
                if (textBox7.Text.Length > 0)
                {
                    textBox7.BackColor = Color.Red;
                }
                else
                {
                    textBox7.BackColor = Color.White;
                }
            }
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox8.Text = calcula_combinacion("," + comboBox15.SelectedIndex.ToString() + "," + comboBox16.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel1(textBox8.Text))
            {
                textBox8.BackColor = Color.Lime;
            }
            else
            {
                if (textBox8.Text.Length > 0)
                {
                    textBox8.BackColor = Color.Red;
                }
                else
                {
                    textBox8.BackColor = Color.White;
                }
            }
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox8.Text = calcula_combinacion("," + comboBox15.SelectedIndex.ToString() + "," + comboBox16.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel1(textBox8.Text))
            {
                textBox8.BackColor = Color.Lime;
            }
            else
            {
                if (textBox8.Text.Length > 0)
                {
                    textBox8.BackColor = Color.Red;
                }
                else
                {
                    textBox8.BackColor = Color.White;
                }
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox20.Text = calcula_combinacion("," + comboBox13.SelectedIndex.ToString() + "," + comboBox14.SelectedIndex.ToString() + "," + comboBox15.SelectedIndex.ToString() + "," + comboBox16.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel2(textBox20.Text))
            {
                textBox20.BackColor = Color.Lime;
            }
            else
            {
                if (textBox20.Text.Length > 0)
                {
                    textBox20.BackColor = Color.Red;
                }
                else
                {
                    textBox20.BackColor = Color.White;
                }
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBox20.Text = calcula_combinacion("," + comboBox13.SelectedIndex.ToString() + "," + comboBox14.SelectedIndex.ToString() + "," + comboBox15.SelectedIndex.ToString() + "," + comboBox16.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel2(textBox20.Text))
            {
                textBox20.BackColor = Color.Lime;
            }
            else
            {
                if (textBox20.Text.Length > 0)
                {
                    textBox20.BackColor = Color.Red;
                }
                else
                {
                    textBox20.BackColor = Color.White;
                }
            }
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            textBox26.Text = calcula_combinacion("," + comboBox9.SelectedIndex.ToString() + "," + comboBox10.SelectedIndex.ToString() + "," + comboBox11.SelectedIndex.ToString() + "," + comboBox12.SelectedIndex.ToString() +
                                                "," + comboBox13.SelectedIndex.ToString() + "," + comboBox14.SelectedIndex.ToString() + "," + comboBox15.SelectedIndex.ToString() + "," + comboBox16.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel3(textBox26.Text))
            {
                textBox26.BackColor = Color.Lime;
            }
            else
            {
                if (textBox26.Text.Length>0)
                {
                    textBox26.BackColor = Color.Red;
                }
                else
                {
                    textBox26.BackColor = Color.White;
                }
                
            }
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            textBox26.Text = calcula_combinacion("," + comboBox9.SelectedIndex.ToString() + "," + comboBox10.SelectedIndex.ToString() + "," + comboBox11.SelectedIndex.ToString() + "," + comboBox12.SelectedIndex.ToString() +
                                                "," + comboBox13.SelectedIndex.ToString() + "," + comboBox14.SelectedIndex.ToString() + "," + comboBox15.SelectedIndex.ToString() + "," + comboBox16.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel3(textBox26.Text))
            {
                textBox26.BackColor = Color.Lime;
            }
            else
            {
                if (textBox26.Text.Length > 0)
                {
                    textBox26.BackColor = Color.Red;
                }
                else
                {
                    textBox26.BackColor = Color.White;
                }

            }
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            textBox29.Text = calcula_combinacion("," + comboBox1.SelectedIndex.ToString() + "," + comboBox2.SelectedIndex.ToString() + "," + comboBox3.SelectedIndex.ToString() + "," + comboBox4.SelectedIndex.ToString() +
                                                 "," + comboBox5.SelectedIndex.ToString() + "," + comboBox6.SelectedIndex.ToString() + "," + comboBox7.SelectedIndex.ToString() + "," + comboBox8.SelectedIndex.ToString() + 
                                                "," + comboBox9.SelectedIndex.ToString() + "," + comboBox10.SelectedIndex.ToString() + "," + comboBox11.SelectedIndex.ToString() + "," + comboBox12.SelectedIndex.ToString() +
                                                "," + comboBox13.SelectedIndex.ToString() + "," + comboBox14.SelectedIndex.ToString() + "," + comboBox15.SelectedIndex.ToString() + "," + comboBox16.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel4(textBox29.Text))
            {
                textBox29.BackColor = Color.Lime;
            }
            else
            {
                if (textBox29.Text.Length>0)
                {
                    textBox29.BackColor = Color.Red;
                }
                else
                {
                    textBox29.BackColor = Color.White;
                }
                
            }
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            textBox29.Text = calcula_combinacion("," + comboBox1.SelectedIndex.ToString() + "," + comboBox2.SelectedIndex.ToString() + "," + comboBox3.SelectedIndex.ToString() + "," + comboBox4.SelectedIndex.ToString() +
                                                 "," + comboBox5.SelectedIndex.ToString() + "," + comboBox6.SelectedIndex.ToString() + "," + comboBox7.SelectedIndex.ToString() + "," + comboBox8.SelectedIndex.ToString() +
                                                "," + comboBox9.SelectedIndex.ToString() + "," + comboBox10.SelectedIndex.ToString() + "," + comboBox11.SelectedIndex.ToString() + "," + comboBox12.SelectedIndex.ToString() +
                                                "," + comboBox13.SelectedIndex.ToString() + "," + comboBox14.SelectedIndex.ToString() + "," + comboBox15.SelectedIndex.ToString() + "," + comboBox16.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel4(textBox29.Text))
            {
                textBox29.BackColor = Color.Lime;
            }
            else
            {
                if (textBox29.Text.Length > 0)
                {
                    textBox29.BackColor = Color.Red;
                }
                else
                {
                    textBox29.BackColor = Color.White;
                }

            }
        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox9.Text = calcula_combinacion("," + comboBox17.SelectedIndex.ToString() + "," + comboBox18.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel1(textBox9.Text))
            {
                textBox9.BackColor = Color.Lime;
            }
            else
            {
                if (textBox9.Text.Length > 0)
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.White;
                }
            }
        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox9.Text = calcula_combinacion("," + comboBox17.SelectedIndex.ToString() + "," + comboBox18.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel1(textBox9.Text))
            {
                textBox9.BackColor = Color.Lime;
            }
            else
            {
                if (textBox9.Text.Length > 0)
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.White;
                }
            }
        }

        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox10.Text = calcula_combinacion("," + comboBox19.SelectedIndex.ToString() + "," + comboBox20.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel1(textBox10.Text))
            {
                textBox10.BackColor = Color.Lime;
            }
            else
            {
                if (textBox10.Text.Length > 0)
                {
                    textBox10.BackColor = Color.Red;
                }
                else
                {
                    textBox10.BackColor = Color.White;
                }
            }
        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox10.Text = calcula_combinacion("," + comboBox19.SelectedIndex.ToString() + "," + comboBox20.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel1(textBox10.Text))
            {
                textBox10.BackColor = Color.Lime;
            }
            else
            {
                if (textBox10.Text.Length > 0)
                {
                    textBox10.BackColor = Color.Red;
                }
                else
                {
                    textBox10.BackColor = Color.White;
                }
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            textBox21.Text = calcula_combinacion("," + comboBox17.SelectedIndex.ToString() + "," + comboBox18.SelectedIndex.ToString() + "," + comboBox19.SelectedIndex.ToString() + "," + comboBox20.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel2(textBox21.Text))
            {
                textBox21.BackColor = Color.Lime;
            }
            else
            {
                if (textBox21.Text.Length>0)
                {
                    textBox21.BackColor = Color.Red;
                }
                else
                {
                    textBox21.BackColor = Color.White;
                }                
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            textBox21.Text = calcula_combinacion("," + comboBox17.SelectedIndex.ToString() + "," + comboBox18.SelectedIndex.ToString() + "," + comboBox19.SelectedIndex.ToString() + "," + comboBox20.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel2(textBox21.Text))
            {
                textBox21.BackColor = Color.Lime;
            }
            else
            {
                if (textBox21.Text.Length > 0)
                {
                    textBox21.BackColor = Color.Red;
                }
                else
                {
                    textBox21.BackColor = Color.White;
                }
            }
        }

        private void comboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox11.Text = calcula_combinacion("," + comboBox21.SelectedIndex.ToString() + "," + comboBox22.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel1(textBox11.Text))
            {
                textBox11.BackColor = Color.Lime;
            }
            else
            {
                if (textBox11.Text.Length > 0)
                {
                    textBox11.BackColor = Color.Red;
                }
                else
                {
                    textBox11.BackColor = Color.White;
                }
            }
        }

        private void comboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox11.Text = calcula_combinacion("," + comboBox21.SelectedIndex.ToString() + "," + comboBox22.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel1(textBox11.Text))
            {
                textBox11.BackColor = Color.Lime;
            }
            else
            {
                if (textBox11.Text.Length > 0)
                {
                    textBox11.BackColor = Color.Red;
                }
                else
                {
                    textBox11.BackColor = Color.White;
                }
            }
        }

        private void comboBox23_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox12.Text = calcula_combinacion("," + comboBox23.SelectedIndex.ToString() + "," + comboBox24.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel1(textBox12.Text))
            {
                textBox12.BackColor = Color.Lime;
            }
            else
            {
                if (textBox12.Text.Length > 0)
                {
                    textBox12.BackColor = Color.Red;
                }
                else
                {
                    textBox12.BackColor = Color.White;
                }
            }
        }

        private void comboBox24_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox12.Text = calcula_combinacion("," + comboBox23.SelectedIndex.ToString() + "," + comboBox24.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel1(textBox12.Text))
            {
                textBox12.BackColor = Color.Lime;
            }
            else
            {
                if (textBox12.Text.Length > 0)
                {
                    textBox12.BackColor = Color.Red;
                }
                else
                {
                    textBox12.BackColor = Color.White;
                }
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            textBox22.Text = calcula_combinacion("," + comboBox21.SelectedIndex.ToString() + "," + comboBox22.SelectedIndex.ToString() + "," + comboBox23.SelectedIndex.ToString() + "," + comboBox24.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel2(textBox22.Text))
            {
                textBox22.BackColor = Color.Lime;
            }
            else
            {
                if(textBox22.Text.Length>0){
                    textBox22.BackColor = Color.Red;
                }
                else
                {
                    textBox22.BackColor = Color.White;
                }
                
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            textBox22.Text = calcula_combinacion("," + comboBox21.SelectedIndex.ToString() + "," + comboBox22.SelectedIndex.ToString() + "," + comboBox23.SelectedIndex.ToString() + "," + comboBox24.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel2(textBox22.Text))
            {
                textBox22.BackColor = Color.Lime;
            }
            else
            {
                if (textBox22.Text.Length > 0)
                {
                    textBox22.BackColor = Color.Red;
                }
                else
                {
                    textBox22.BackColor = Color.White;
                }

            }
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            textBox27.Text = calcula_combinacion("," + comboBox17.SelectedIndex.ToString() + "," + comboBox18.SelectedIndex.ToString() + "," + comboBox19.SelectedIndex.ToString() + "," + comboBox20.SelectedIndex.ToString() +
                                                "," + comboBox21.SelectedIndex.ToString() + "," + comboBox22.SelectedIndex.ToString() + "," + comboBox23.SelectedIndex.ToString() + "," + comboBox24.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel3(textBox27.Text))
            {
                textBox27.BackColor = Color.Lime;
            }
            else
            {
                if (textBox27.Text.Length>0)
                {
                    textBox27.BackColor = Color.Red;
                }
                else
                {
                    textBox27.BackColor = Color.White;
                }
                
            }
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            textBox27.Text = calcula_combinacion("," + comboBox17.SelectedIndex.ToString() + "," + comboBox18.SelectedIndex.ToString() + "," + comboBox19.SelectedIndex.ToString() + "," + comboBox20.SelectedIndex.ToString() +
                                                "," + comboBox21.SelectedIndex.ToString() + "," + comboBox22.SelectedIndex.ToString() + "," + comboBox23.SelectedIndex.ToString() + "," + comboBox24.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel3(textBox27.Text))
            {
                textBox27.BackColor = Color.Lime;
            }
            else
            {
                if (textBox27.Text.Length > 0)
                {
                    textBox27.BackColor = Color.Red;
                }
                else
                {
                    textBox27.BackColor = Color.White;
                }

            }
        }

        private void comboBox25_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox13.Text = calcula_combinacion("," + comboBox25.SelectedIndex.ToString() + "," + comboBox26.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel1(textBox13.Text))
            {
                textBox13.BackColor = Color.Lime;
            }
            else
            {
                if (textBox13.Text.Length > 0)
                {
                    textBox13.BackColor = Color.Red;
                }
                else
                {
                    textBox13.BackColor = Color.White;
                }
            }
        }

        private void comboBox26_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox13.Text = calcula_combinacion("," + comboBox25.SelectedIndex.ToString() + "," + comboBox26.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel1(textBox13.Text))
            {
                textBox13.BackColor = Color.Lime;
            }
            else
            {
                if (textBox13.Text.Length > 0)
                {
                    textBox13.BackColor = Color.Red;
                }
                else
                {
                    textBox13.BackColor = Color.White;
                }
            }
        }

        private void comboBox27_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox14.Text = calcula_combinacion("," + comboBox27.SelectedIndex.ToString() + "," + comboBox28.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel1(textBox14.Text))
            {
                textBox14.BackColor = Color.Lime;
            }
            else
            {
                if (textBox14.Text.Length > 0)
                {
                    textBox14.BackColor = Color.Red;
                }
                else
                {
                    textBox14.BackColor = Color.White;
                }
            }
        }

        private void comboBox28_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox14.Text = calcula_combinacion("," + comboBox27.SelectedIndex.ToString() + "," + comboBox28.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel1(textBox14.Text))
            {
                textBox14.BackColor = Color.Lime;
            }
            else
            {
                if (textBox14.Text.Length > 0)
                {
                    textBox14.BackColor = Color.Red;
                }
                else
                {
                    textBox14.BackColor = Color.White;
                }
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            textBox23.Text = calcula_combinacion("," + comboBox25.SelectedIndex.ToString() + "," + comboBox26.SelectedIndex.ToString() + "," + comboBox27.SelectedIndex.ToString() + "," + comboBox28.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel2(textBox23.Text))
            {
                textBox23.BackColor = Color.Lime;
            }
            else
            {
                if (textBox23.Text.Length>0)
                {
                    textBox23.BackColor = Color.Red;
                }
                else
                {
                    textBox23.BackColor = Color.White;
                }
                
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            textBox23.Text = calcula_combinacion("," + comboBox25.SelectedIndex.ToString() + "," + comboBox26.SelectedIndex.ToString() + "," + comboBox27.SelectedIndex.ToString() + "," + comboBox28.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel2(textBox23.Text))
            {
                textBox23.BackColor = Color.Lime;
            }
            else
            {
                if (textBox23.Text.Length > 0)
                {
                    textBox23.BackColor = Color.Red;
                }
                else
                {
                    textBox23.BackColor = Color.White;
                }

            }
        }

        private void comboBox29_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox15.Text = calcula_combinacion("," + comboBox29.SelectedIndex.ToString() + "," + comboBox30.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel1(textBox15.Text))
            {
                textBox15.BackColor = Color.Lime;
            }
            else
            {
                if (textBox15.Text.Length > 0)
                {
                    textBox15.BackColor = Color.Red;
                }
                else
                {
                    textBox15.BackColor = Color.White;
                }
            }
        }

        private void comboBox30_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox15.Text = calcula_combinacion("," + comboBox29.SelectedIndex.ToString() + "," + comboBox30.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel1(textBox15.Text))
            {
                textBox15.BackColor = Color.Lime;
            }
            else
            {
                if (textBox15.Text.Length > 0)
                {
                    textBox15.BackColor = Color.Red;
                }
                else
                {
                    textBox15.BackColor = Color.White;
                }
            }
        }

        private void comboBox31_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox16.Text = calcula_combinacion("," + comboBox31.SelectedIndex.ToString() + "," + comboBox32.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel1(textBox16.Text))
            {
                textBox16.BackColor = Color.Lime;
            }
            else
            {
                if (textBox16.Text.Length > 0)
                {
                    textBox16.BackColor = Color.Red;
                }
                else
                {
                    textBox16.BackColor = Color.White;
                }
            }
        }

        private void comboBox32_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox16.Text = calcula_combinacion("," + comboBox31.SelectedIndex.ToString() + "," + comboBox32.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel1(textBox16.Text))
            {
                textBox16.BackColor = Color.Lime;
            }
            else
            {
                if (textBox16.Text.Length > 0)
                {
                    textBox16.BackColor = Color.Red;
                }
                else
                {
                    textBox16.BackColor = Color.White;
                }
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            textBox24.Text = calcula_combinacion("," + comboBox29.SelectedIndex.ToString() + "," + comboBox30.SelectedIndex.ToString() + "," + comboBox31.SelectedIndex.ToString() + "," + comboBox32.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel2(textBox24.Text))
            {
                textBox24.BackColor = Color.Lime;
            }
            else
            {
                if (textBox24.Text.Length>0)
                {
                    textBox24.BackColor = Color.Red;
                }
                else
                {
                    textBox24.BackColor = Color.White;
                }                
            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            textBox24.Text = calcula_combinacion("," + comboBox29.SelectedIndex.ToString() + "," + comboBox30.SelectedIndex.ToString() + "," + comboBox31.SelectedIndex.ToString() + "," + comboBox32.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel2(textBox24.Text))
            {
                textBox24.BackColor = Color.Lime;
            }
            else
            {
                if (textBox24.Text.Length > 0)
                {
                    textBox24.BackColor = Color.Red;
                }
                else
                {
                    textBox24.BackColor = Color.White;
                }
            }
        }       

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            textBox28.Text = calcula_combinacion("," + comboBox25.SelectedIndex.ToString() + "," + comboBox26.SelectedIndex.ToString() + "," + comboBox27.SelectedIndex.ToString() + "," + comboBox28.SelectedIndex.ToString() +
                                                "," + comboBox29.SelectedIndex.ToString() + "," + comboBox30.SelectedIndex.ToString() + "," + comboBox31.SelectedIndex.ToString() + "," + comboBox32.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel3(textBox28.Text))
            {
                textBox28.BackColor = Color.Lime;
            }
            else
            {
                if(textBox28.Text.Length>0){
                    textBox28.BackColor = Color.Red;
                }
                else
                {
                    textBox28.BackColor = Color.White;
                }
                
            }
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            textBox28.Text = calcula_combinacion("," + comboBox25.SelectedIndex.ToString() + "," + comboBox26.SelectedIndex.ToString() + "," + comboBox27.SelectedIndex.ToString() + "," + comboBox28.SelectedIndex.ToString() +
                                                 "," + comboBox29.SelectedIndex.ToString() + "," + comboBox30.SelectedIndex.ToString() + "," + comboBox31.SelectedIndex.ToString() + "," + comboBox32.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel3(textBox28.Text))
            {
                textBox28.BackColor = Color.Lime;
            }
            else
            {
                if (textBox28.Text.Length > 0)
                {
                    textBox28.BackColor = Color.Red;
                }
                else
                {
                    textBox28.BackColor = Color.White;
                }

            }
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            textBox30.Text = calcula_combinacion("," + comboBox17.SelectedIndex.ToString() + "," + comboBox18.SelectedIndex.ToString() + "," + comboBox19.SelectedIndex.ToString() + "," + comboBox20.SelectedIndex.ToString() +
                                                "," + comboBox21.SelectedIndex.ToString() + "," + comboBox22.SelectedIndex.ToString() + "," + comboBox23.SelectedIndex.ToString() + "," + comboBox24.SelectedIndex.ToString() +
                                                "," + comboBox25.SelectedIndex.ToString() + "," + comboBox26.SelectedIndex.ToString() + "," + comboBox27.SelectedIndex.ToString() + "," + comboBox28.SelectedIndex.ToString() +
                                                "," + comboBox29.SelectedIndex.ToString() + "," + comboBox30.SelectedIndex.ToString() + "," + comboBox31.SelectedIndex.ToString() + "," + comboBox32.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel4(textBox30.Text))
            {
                textBox30.BackColor = Color.Lime;
            }
            else
            {
                if (textBox30.Text.Length>0)
                {
                    textBox30.BackColor = Color.Red;
                }
                else
                {
                    textBox30.BackColor = Color.White;
                }
                
            }
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            textBox30.Text = calcula_combinacion("," + comboBox17.SelectedIndex.ToString() + "," + comboBox18.SelectedIndex.ToString() + "," + comboBox19.SelectedIndex.ToString() + "," + comboBox20.SelectedIndex.ToString() +
                                                 "," + comboBox21.SelectedIndex.ToString() + "," + comboBox22.SelectedIndex.ToString() + "," + comboBox23.SelectedIndex.ToString() + "," + comboBox24.SelectedIndex.ToString() +
                                                 "," + comboBox25.SelectedIndex.ToString() + "," + comboBox26.SelectedIndex.ToString() + "," + comboBox27.SelectedIndex.ToString() + "," + comboBox28.SelectedIndex.ToString() +
                                                 "," + comboBox29.SelectedIndex.ToString() + "," + comboBox30.SelectedIndex.ToString() + "," + comboBox31.SelectedIndex.ToString() + "," + comboBox32.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel4(textBox30.Text))
            {
                textBox30.BackColor = Color.Lime;
            }
            else
            {
                if (textBox30.Text.Length > 0)
                {
                    textBox30.BackColor = Color.Red;
                }
                else
                {
                    textBox30.BackColor = Color.White;
                }

            }
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            textBox31.Text = calcula_combinacion("," + comboBox1.SelectedIndex.ToString() + "," + comboBox2.SelectedIndex.ToString() + "," + comboBox3.SelectedIndex.ToString() + "," + comboBox4.SelectedIndex.ToString() +
                                                 "," + comboBox5.SelectedIndex.ToString() + "," + comboBox6.SelectedIndex.ToString() + "," + comboBox7.SelectedIndex.ToString() + "," + comboBox8.SelectedIndex.ToString() +
                                                 "," + comboBox9.SelectedIndex.ToString() + "," + comboBox10.SelectedIndex.ToString() + "," + comboBox11.SelectedIndex.ToString() + "," + comboBox12.SelectedIndex.ToString() +
                                                 "," + comboBox13.SelectedIndex.ToString() + "," + comboBox14.SelectedIndex.ToString() + "," + comboBox15.SelectedIndex.ToString() + "," + comboBox16.SelectedIndex.ToString() +
                                                 "," + comboBox17.SelectedIndex.ToString() + "," + comboBox18.SelectedIndex.ToString() + "," + comboBox19.SelectedIndex.ToString() + "," + comboBox20.SelectedIndex.ToString() +
                                                 "," + comboBox21.SelectedIndex.ToString() + "," + comboBox22.SelectedIndex.ToString() + "," + comboBox23.SelectedIndex.ToString() + "," + comboBox24.SelectedIndex.ToString() +
                                                 "," + comboBox25.SelectedIndex.ToString() + "," + comboBox26.SelectedIndex.ToString() + "," + comboBox27.SelectedIndex.ToString() + "," + comboBox28.SelectedIndex.ToString() +
                                                 "," + comboBox29.SelectedIndex.ToString() + "," + comboBox30.SelectedIndex.ToString() + "," + comboBox31.SelectedIndex.ToString() + "," + comboBox32.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel5(textBox31.Text))
            {
                textBox31.BackColor = Color.Lime;
            }
            else
            {
                if (textBox31.Text.Length > 0)
                {
                    textBox31.BackColor = Color.Red;
                }
                else
                {
                    textBox31.BackColor = Color.White;
                }
            }
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            textBox31.Text = calcula_combinacion("," + comboBox1.SelectedIndex.ToString() + "," + comboBox2.SelectedIndex.ToString() + "," + comboBox3.SelectedIndex.ToString() + "," + comboBox4.SelectedIndex.ToString() +
                                                  "," + comboBox5.SelectedIndex.ToString() + "," + comboBox6.SelectedIndex.ToString() + "," + comboBox7.SelectedIndex.ToString() + "," + comboBox8.SelectedIndex.ToString() +
                                                  "," + comboBox9.SelectedIndex.ToString() + "," + comboBox10.SelectedIndex.ToString() + "," + comboBox11.SelectedIndex.ToString() + "," + comboBox12.SelectedIndex.ToString() +
                                                  "," + comboBox13.SelectedIndex.ToString() + "," + comboBox14.SelectedIndex.ToString() + "," + comboBox15.SelectedIndex.ToString() + "," + comboBox16.SelectedIndex.ToString() +
                                                  "," + comboBox17.SelectedIndex.ToString() + "," + comboBox18.SelectedIndex.ToString() + "," + comboBox19.SelectedIndex.ToString() + "," + comboBox20.SelectedIndex.ToString() +
                                                  "," + comboBox21.SelectedIndex.ToString() + "," + comboBox22.SelectedIndex.ToString() + "," + comboBox23.SelectedIndex.ToString() + "," + comboBox24.SelectedIndex.ToString() +
                                                  "," + comboBox25.SelectedIndex.ToString() + "," + comboBox26.SelectedIndex.ToString() + "," + comboBox27.SelectedIndex.ToString() + "," + comboBox28.SelectedIndex.ToString() +
                                                  "," + comboBox29.SelectedIndex.ToString() + "," + comboBox30.SelectedIndex.ToString() + "," + comboBox31.SelectedIndex.ToString() + "," + comboBox32.SelectedIndex.ToString() + ",");

            if (verifica_combinacion_nivel5(textBox31.Text))
            {
                textBox31.BackColor = Color.Lime;
            }
            else
            {
                if (textBox31.Text.Length > 0)
                {
                    textBox31.BackColor = Color.Red;
                }
                else
                {
                    textBox31.BackColor = Color.White;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            comboBox7.SelectedIndex = 0;
            comboBox8.SelectedIndex = 0;
            comboBox9.SelectedIndex = 0;
            comboBox10.SelectedIndex = 0;
            comboBox11.SelectedIndex = 0;
            comboBox12.SelectedIndex = 0;
            comboBox13.SelectedIndex = 0;
            comboBox14.SelectedIndex = 0;
            comboBox15.SelectedIndex = 0;
            comboBox16.SelectedIndex = 0;
            comboBox17.SelectedIndex = 0;
            comboBox18.SelectedIndex = 0;
            comboBox19.SelectedIndex = 0;
            comboBox20.SelectedIndex = 0;
            comboBox21.SelectedIndex = 0;
            comboBox22.SelectedIndex = 0;
            comboBox23.SelectedIndex = 0;
            comboBox24.SelectedIndex = 0;
            comboBox25.SelectedIndex = 0;
            comboBox26.SelectedIndex = 0;
            comboBox27.SelectedIndex = 0;
            comboBox28.SelectedIndex = 0;
            comboBox29.SelectedIndex = 0;
            comboBox30.SelectedIndex = 0;
            comboBox31.SelectedIndex = 0;
            comboBox32.SelectedIndex = 0;
        }

    }
}
