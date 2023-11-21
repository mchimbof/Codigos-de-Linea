using System;
using System.Windows.Forms;

namespace Code_Linea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            LimpiaGrafico();
        }

        //Funciones
        public void LimpiaGrafico()
        {
            rbtn_aminrz.Checked = false;
            rbtn_aminrzinv.Checked = false;
            rbtn_amirz.Checked = false;
            rbtn_amirzinv.Checked = false;
            rbtn_bipolar.Checked = false;
            rbtn_cmi.Checked = false;
            rbtn_diferencial.Checked = false;
            rbtn_manchester.Checked = false;
            rbtn_manchesterdiferencial.Checked = false;
            rbtn_miller.Checked = false;
            rbtn_unipolarz.Checked = false;
            rbt_polarz.Checked = false;

            txtcodigo.Text = "";
            lblcodigo.Text = "";
            lblcodigo_linea.Text = "";
            grafico.Series[0].Points.Clear();
            grafico_linea.Series[0].Points.Clear();
            lblcodigo.Text = "Codigo: N/A";
            lblcodigo_linea.Text = "Codigo de Linea: N/A";
         
        }

        public void codigo_referencia()
        {
            String codigo;
            codigo = txtcodigo.Text;
            string[] vector = new string[codigo.Length];
            int[] puntosArray = new int[codigo.Length];

            //De codigo a vector            
            for (int i = 0; i < codigo.Length; i++)
            {
                vector[i] = Convert.ToChar(codigo[i]).ToString();
                puntosArray[i] = int.Parse(vector[i]);
            }
            //Grafica los codigo
            grafico.Series[0].Points.AddXY(0, 0);
            for (int p = 0; p < puntosArray.Length; p++)
            {
                if (puntosArray[p] == 1) //Grafica los 1
                {
                    grafico.Series[0].Points.AddXY(p, puntosArray[p]);
                    grafico.Series[0].Points.AddXY(p + 1, puntosArray[p]);
                }
                else //Grafica los 0
                {
                    grafico.Series[0].Points.AddXY(p, puntosArray[p]);
                    grafico.Series[0].Points.AddXY(p + 1, puntosArray[p]);
                }
            }
            grafico.Series[0].Points.AddXY(codigo.Length, 0);
            lblcodigo.Text = "Codigo: " + codigo;
        }

        private void rbt_polarz_CheckedChanged(object sender, EventArgs e)
        {
            grafico.Series[0].Points.Clear();
            grafico_linea.Series[0].Points.Clear();
            codigo_referencia();

            //Codigo Polar RZ
            String codigo;
            codigo = txtcodigo.Text;
            string[] vector = new string[codigo.Length];
            int[] puntosArray = new int[codigo.Length];

            //De codigo a vector            
            for (int i = 0; i < codigo.Length; i++)
            {
                vector[i] = Convert.ToChar(codigo[i]).ToString();
                puntosArray[i] = int.Parse(vector[i]);
            }
            //Grafica los codigo
            for (int p = 0; p < puntosArray.Length; p++)
            {
                Console.WriteLine(p + " " + puntosArray[p]);
                if (puntosArray[p] == 1) //Grafica los 1
                {
                    grafico_linea.Series[0].Points.AddXY(p, puntosArray[p]);

                    grafico_linea.Series[0].Points.AddXY(p + 1, puntosArray[p]);
                }
                else //Grafica los 0
                {
                    grafico_linea.Series[0].Points.AddXY(p, -1);
                    grafico_linea.Series[0].Points.AddXY(p + 1, -1);
                }
            }
            lblcodigo_linea.Text = "Codigo Polar RZ: " + codigo;

        }

        private void rbtn_bipolar_CheckedChanged(object sender, EventArgs e)
        {
            grafico.Series[0].Points.Clear();
            grafico_linea.Series[0].Points.Clear();
            codigo_referencia();

            //Codigo Bipolar
            String codigo;
            codigo = txtcodigo.Text;
            string[] vector = new string[codigo.Length];
            int[] puntosArray = new int[codigo.Length];
            int cont = 0;
            //De codigo a vector            
            for (int i = 0; i < codigo.Length; i++)
            {
                vector[i] = Convert.ToChar(codigo[i]).ToString();
                puntosArray[i] = int.Parse(vector[i]);
            }

            //Grafica los codigo
            grafico_linea.Series[0].Points.AddXY(0, 0);
            for (int p = 0; p < puntosArray.Length; p++)
            {
                Console.WriteLine(p + " " + puntosArray[p]);
                if (puntosArray[p] == 1) //Grafica los 1
                {
                    if (cont % 2 == 0)
                    {
                        grafico_linea.Series[0].Points.AddXY(p, 0);
                        grafico_linea.Series[0].Points.AddXY(p, puntosArray[p]);
                        grafico_linea.Series[0].Points.AddXY(p + 0.5, puntosArray[p]);
                        grafico_linea.Series[0].Points.AddXY(p + 0.5, 0);
                    }
                    else
                    {
                        grafico_linea.Series[0].Points.AddXY(p, 0);
                        grafico_linea.Series[0].Points.AddXY(p, -1);
                        grafico_linea.Series[0].Points.AddXY(p + 0.5, -1);
                        grafico_linea.Series[0].Points.AddXY(p + 0.5, 0);
                    }
                    cont = cont + 1;
                }
                else //Grafica los 0
                {
                    grafico_linea.Series[0].Points.AddXY(p, puntosArray[p]);
                    grafico_linea.Series[0].Points.AddXY(p + 1, puntosArray[p]);
                }
            }
            grafico_linea.Series[0].Points.AddXY(codigo.Length, 0);
            lblcodigo_linea.Text = "Codigo Bipolar RZ: " + codigo;

        }

        private void rbtn_aminrz_CheckedChanged(object sender, EventArgs e)
        {
            grafico.Series[0].Points.Clear();
            grafico_linea.Series[0].Points.Clear();
            codigo_referencia();

            //AMI NRZ
            String codigo;
            codigo = txtcodigo.Text;
            string[] vector = new string[codigo.Length];
            int[] puntosArray = new int[codigo.Length];
            int cont = 0;
            //De codigo a vector            
            for (int i = 0; i < codigo.Length; i++)
            {
                vector[i] = Convert.ToChar(codigo[i]).ToString();
                puntosArray[i] = int.Parse(vector[i]);
            }
            //Grafica los codigo
            for (int p = 0; p < puntosArray.Length; p++)
            {
                if (puntosArray[p] == 1) //Grafica los 1
                {
                    if (cont % 2 == 1)
                    {
                        grafico_linea.Series[0].Points.AddXY(p, -1);
                        grafico_linea.Series[0].Points.AddXY(p + 1, -1);
                    }
                    else
                    {
                        grafico_linea.Series[0].Points.AddXY(p, puntosArray[p]);
                        grafico_linea.Series[0].Points.AddXY(p + 1, puntosArray[p]);
                    }
                    cont = cont + 1;
                }
                else //Grafica los 0
                {
                    grafico_linea.Series[0].Points.AddXY(p, 0);
                    grafico_linea.Series[0].Points.AddXY(p + 1, 0);
                }
            }
            lblcodigo_linea.Text = "Codigo Ami NRZ: " + codigo;

        }

        private void rbtn_aminrzinv_CheckedChanged(object sender, EventArgs e)
        {
            grafico.Series[0].Points.Clear();
            grafico_linea.Series[0].Points.Clear();
            codigo_referencia();

            //AMI NRZ INVERTIDO
            String codigo;
            codigo = txtcodigo.Text;
            string[] vector = new string[codigo.Length];
            int[] puntosArray = new int[codigo.Length];
            int cont = 0;
            //De codigo a vector            
            for (int i = 0; i < codigo.Length; i++)
            {
                vector[i] = Convert.ToChar(codigo[i]).ToString();
                puntosArray[i] = int.Parse(vector[i]);
            }

            //Grafica los codigo            
            for (int p = 0; p < puntosArray.Length; p++)
            {
                Console.WriteLine(p + " " + puntosArray[p]);
                if (puntosArray[p] == 1) //Grafica los 1
                {
                    grafico_linea.Series[0].Points.AddXY(p, 0);
                    grafico_linea.Series[0].Points.AddXY(p + 1, 0);
                }
                else //Grafica los 0
                {
                    if (cont % 2 == 1)
                    {
                        grafico_linea.Series[0].Points.AddXY(p, 1);
                        grafico_linea.Series[0].Points.AddXY(p + 1, 1);
                    }
                    else
                    {
                        grafico_linea.Series[0].Points.AddXY(p, -1);
                        grafico_linea.Series[0].Points.AddXY(p + 1, -1);
                    }
                    cont = cont + 1;
                }
            }
            grafico_linea.Series[0].Points.AddXY(codigo.Length, 0);
            /*
            if (puntosArray[codigo.Length - 1] == 0)
            { MessageBox.Show("Es O"); }
            else
            { MessageBox.Show("Es 1"); }*/
            lblcodigo_linea.Text = "Codigo Ami NRZ Invertido: " + codigo;

        }

        private void rbtn_amirz_CheckedChanged(object sender, EventArgs e)
        {
            grafico.Series[0].Points.Clear();
            grafico_linea.Series[0].Points.Clear();
            codigo_referencia();

            //AMI RZ
            String codigo;
            codigo = txtcodigo.Text;
            string[] vector = new string[codigo.Length];
            int[] puntosArray = new int[codigo.Length];
            int cont = 0;
            //De codigo a vector            
            for (int i = 0; i < codigo.Length; i++)
            {
                vector[i] = Convert.ToChar(codigo[i]).ToString();
                puntosArray[i] = int.Parse(vector[i]);
            }
            //Grafica los codigo
            for (int p = 0; p < puntosArray.Length; p++)
            {
                if (puntosArray[p] == 1) //Grafica los 1
                {
                    if (cont % 2 == 0)
                    {
                        grafico_linea.Series[0].Points.AddXY(p, 1);
                        grafico_linea.Series[0].Points.AddXY(p + 0.5, 1);
                        grafico_linea.Series[0].Points.AddXY(p + 0.5, 0);
                        grafico_linea.Series[0].Points.AddXY(p + 1, 0);
                    }
                    else
                    {
                        grafico_linea.Series[0].Points.AddXY(p, -1);
                        grafico_linea.Series[0].Points.AddXY(p + 0.5, -1);
                        grafico_linea.Series[0].Points.AddXY(p + 0.5, 0);
                        grafico_linea.Series[0].Points.AddXY(p + 1, 0);
                    }
                    cont = cont + 1;
                }
                else //Grafica los 0
                {
                    grafico_linea.Series[0].Points.AddXY(p, 0);
                    grafico_linea.Series[0].Points.AddXY(p + 1, 0);
                }
            }
            //grafico_linea.Series[0].Points.AddXY(codigo.Length, -1);
            lblcodigo_linea.Text = "Codigo Ami RZ: " + codigo;

        }

        private void rbtn_amirzinv_CheckedChanged(object sender, EventArgs e)
        {
            grafico.Series[0].Points.Clear();
            grafico_linea.Series[0].Points.Clear();
            codigo_referencia();

            //AMI NRZ INVERTIDO
            String codigo;
            codigo = txtcodigo.Text;
            string[] vector = new string[codigo.Length];
            int[] puntosArray = new int[codigo.Length];
            int cont = 0;
            //De codigo a vector            
            for (int i = 0; i < codigo.Length; i++)
            {
                vector[i] = Convert.ToChar(codigo[i]).ToString();
                puntosArray[i] = int.Parse(vector[i]);
            }
            //Grafica los codigo            
            for (int p = 0; p < puntosArray.Length; p++)
            {
                if (puntosArray[p] == 1) //Grafica los 1
                {
                    grafico_linea.Series[0].Points.AddXY(p, 0);
                    grafico_linea.Series[0].Points.AddXY(p + 1, 0);
                }
                else //Grafica los 0
                {
                    if (cont % 2 == 1)
                    {
                        grafico_linea.Series[0].Points.AddXY(p, 1);
                        grafico_linea.Series[0].Points.AddXY(p + 0.5, 1);
                        grafico_linea.Series[0].Points.AddXY(p + 0.5, 0);
                        grafico_linea.Series[0].Points.AddXY(p + 1, 0);
                    }
                    else
                    {
                        grafico_linea.Series[0].Points.AddXY(p, -1);
                        grafico_linea.Series[0].Points.AddXY(p + 0.5, -1);
                        grafico_linea.Series[0].Points.AddXY(p + 0.5, 0);
                        grafico_linea.Series[0].Points.AddXY(p + 1, 0);
                    }
                    cont = cont + 1;
                }
            }
            lblcodigo_linea.Text = "Codigo Ami RZ Invertido: " + codigo;

        }

        private void rbtn_manchester_CheckedChanged(object sender, EventArgs e)
        {
            grafico.Series[0].Points.Clear();
            grafico_linea.Series[0].Points.Clear();
            codigo_referencia();

            //Codigo Polar RZ
            String codigo;
            codigo = txtcodigo.Text;
            string[] vector = new string[codigo.Length];
            int[] puntosArray = new int[codigo.Length];

            //De codigo a vector            
            for (int i = 0; i < codigo.Length; i++)
            {
                vector[i] = Convert.ToChar(codigo[i]).ToString();
                puntosArray[i] = int.Parse(vector[i]);

            }
            //Grafica los codigo
            for (int p = 0; p < puntosArray.Length; p++)
            {
                if (puntosArray[p] == 0) //Grafica los 1
                {
                    grafico_linea.Series[0].Points.AddXY(p, -1);
                    grafico_linea.Series[0].Points.AddXY(p + 0.5, -1);
                    grafico_linea.Series[0].Points.AddXY(p + 0.5, 1);
                    grafico_linea.Series[0].Points.AddXY(p + 1, 1);
                }
                else //Grafica los 0
                {
                    grafico_linea.Series[0].Points.AddXY(p, 1);
                    grafico_linea.Series[0].Points.AddXY(p + 0.5, 1);
                    grafico_linea.Series[0].Points.AddXY(p + 0.5, -1);
                    grafico_linea.Series[0].Points.AddXY(p + 0.5, -1);
                    grafico_linea.Series[0].Points.AddXY(p + 1, -1);
                }
            }
            lblcodigo_linea.Text = "Codigo Manchester: " + codigo;

        }

        private void rbtn_unipolarz_CheckedChanged(object sender, EventArgs e)
        {
            grafico.Series[0].Points.Clear();
            grafico_linea.Series[0].Points.Clear();
            codigo_referencia();

            //Codigo UniPolar RZ
            String codigo;
            codigo = txtcodigo.Text;
            string[] vector = new string[codigo.Length];
            int[] puntosArray = new int[codigo.Length];

            //De codigo a vector            
            for (int i = 0; i < codigo.Length; i++)
            {
                vector[i] = Convert.ToChar(codigo[i]).ToString();
                puntosArray[i] = int.Parse(vector[i]);
            }
            //Grafica los codigo
            grafico_linea.Series[0].Points.AddXY(0, 0);
            for (int p = 0; p < puntosArray.Length; p++)
            {
                Console.WriteLine(p + " " + puntosArray[p]);
                if (puntosArray[p] == 1) //Grafica los 1
                {
                    grafico_linea.Series[0].Points.AddXY(p, 0);
                    grafico_linea.Series[0].Points.AddXY(p, puntosArray[p]);
                    grafico_linea.Series[0].Points.AddXY(p + 0.5, puntosArray[p]);
                    grafico_linea.Series[0].Points.AddXY(p + 0.5, 0);
                }
                else //Grafica los 0
                {
                    grafico_linea.Series[0].Points.AddXY(p, puntosArray[p]);
                    grafico_linea.Series[0].Points.AddXY(p + 1, puntosArray[p]);
                }
            }
            grafico_linea.Series[0].Points.AddXY(codigo.Length, 0);
            lblcodigo_linea.Text = "Codigo UniPolar RZ: " + codigo;

        }

        private void rbtn_manchesterdiferencial_CheckedChanged(object sender, EventArgs e)
        {
            grafico.Series[0].Points.Clear();
            grafico_linea.Series[0].Points.Clear();
            codigo_referencia();

            //Codigo Polar RZ
            String codigo;
            codigo = txtcodigo.Text;
            string[] vector = new string[codigo.Length];
            int[] puntosArray = new int[codigo.Length];
            int cont1 = 0;

            //De codigo a vector - puntosArray            
            for (int i = 0; i < codigo.Length; i++)
            {
                vector[i] = Convert.ToChar(codigo[i]).ToString();
                puntosArray[i] = int.Parse(vector[i]);
            }
            //Grafica los codigo
            Console.WriteLine(codigo);
            for (int p = 0; p < puntosArray.Length; p++)
            {
                if (puntosArray[p] == 1) //Grafica los 1
                {
                    if (cont1 % 2 == 0)//1 Impar
                    {
                        // MessageBox.Show("Transiccion a 0");
                        grafico_linea.Series[0].Points.AddXY(p, 1);
                        grafico_linea.Series[0].Points.AddXY(p + 0.5, 1);
                        grafico_linea.Series[0].Points.AddXY(p + 0.5, -1);
                        grafico_linea.Series[0].Points.AddXY(p + 1, -1);
                    }
                    else  /////////////1 Par
                    {
                        //   MessageBox.Show("Transiccion a 1");
                        grafico_linea.Series[0].Points.AddXY(p, -1);
                        grafico_linea.Series[0].Points.AddXY(p + 0.5, -1);
                        grafico_linea.Series[0].Points.AddXY(p + 0.5, 1);
                        grafico_linea.Series[0].Points.AddXY(p + 1, 1);
                    }

                    cont1 = cont1 + 1;
                }
                else //Los 0
                {
                    if (cont1 % 2 == 1) //0 de Bajada
                    {
                        grafico_linea.Series[0].Points.AddXY(p, 1);
                        grafico_linea.Series[0].Points.AddXY(p + 0.5, 1);
                        grafico_linea.Series[0].Points.AddXY(p + 0.5, -1);
                        grafico_linea.Series[0].Points.AddXY(p + 1, -1);
                    }
                    else //0 de subida
                    {
                        grafico_linea.Series[0].Points.AddXY(p, -1);
                        grafico_linea.Series[0].Points.AddXY(p + 0.5, -1);
                        grafico_linea.Series[0].Points.AddXY(p + 0.5, 1);
                        grafico_linea.Series[0].Points.AddXY(p + 1, 1);
                    }
                }

            }
            lblcodigo_linea.Text = "Codigo Manchester Diferencial: " + codigo;

        }

        private void rbtn_cmi_CheckedChanged(object sender, EventArgs e)
        {
            if (txtcodigo.Text != "")
            {
                grafico_linea.Series[0].Points.Clear();
                grafico.Series[0].Points.Clear();

                codigo_referencia();

                //CMI
                String codigo;
                codigo = txtcodigo.Text;
                string[] vector = new string[codigo.Length];
                int[] vector_grafico = new int[codigo.Length];

                //De codigo a vector y vector_grafico            
                for (int i = 0; i < codigo.Length; i++)
                {
                    vector[i] = Convert.ToChar(codigo[i]).ToString();
                    vector_grafico[i] = int.Parse(vector[i]);
                }
                //Grafica los codigo
                int cont1 = 0;
                for (int p = 0; p < vector_grafico.Length; p++)
                {
                    if (vector_grafico[p] == 1) //Grafica los 1
                    {
                        if (cont1 % 2 == 1) //Impar
                        {
                            grafico_linea.Series[0].Points.AddXY(p, -1);
                            grafico_linea.Series[0].Points.AddXY(p + 1, -1);
                        }
                        else
                        {
                            grafico_linea.Series[0].Points.AddXY(p, 1);
                            grafico_linea.Series[0].Points.AddXY(p + 1, 1);

                        }
                        cont1 = cont1 + 1;
                    }
                    else //Grafica los 0
                    {
                        grafico_linea.Series[0].Points.AddXY(p, -1);
                        grafico_linea.Series[0].Points.AddXY(p + 0.5, -1);
                        grafico_linea.Series[0].Points.AddXY(p + 0.5, 1);
                        grafico_linea.Series[0].Points.AddXY(p + 1, 1);
                    }
                }
                grafico.Series[0].Points.AddXY(codigo.Length, 0);
                lblcodigo_linea.Text = "Codigo CMI : " + codigo;
            }
            else
            {
                MessageBox.Show("No se acepta campo vacio");
                txtcodigo.Focus();
            }
        }

        private void rbtn_diferencial_CheckedChanged(object sender, EventArgs e)
        {
            grafico_linea.Series[0].Points.Clear();
            grafico.Series[0].Points.Clear();

            codigo_referencia();

            //Diferencial
            String codigo;
            codigo = txtcodigo.Text;
            string suma = "";
            string[] vector = new string[codigo.Length];
            int[] vector_grafico = new int[codigo.Length];

            // codigo a Vector
            for (int i = 0; i < codigo.Length; i++)
            {
                vector[i] = Convert.ToChar(codigo[i]).ToString();
                vector_grafico[i] = int.Parse(vector[i]);
            }

            //Suma Binaria  
            if (vector_grafico[0] == 1)
            {  suma = "0";     }
            else { suma = "1"; }

            for (int j = 1; j < codigo.Length; j++)
            {
                if (codigo[j] == suma[j - 1])
                {
                    suma = suma + "0";
                }
                else { suma = suma + "1"; }
            }
            lblcodigo_linea.Text = "Codigo Diferencial: "+suma;
            //Suma a Vector
            for (int k = 0; k < codigo.Length; k++)
            {
                vector[k] = Convert.ToChar(suma[k]).ToString();
                vector_grafico[k] = int.Parse(vector[k]);
            }
            //Grafica
            for (int l = 0; l < vector_grafico.Length; l++)
            {
                if (vector_grafico[l] == 1)
                {
                    grafico_linea.Series[0].Points.AddXY(l, 1);
                    grafico_linea.Series[0].Points.AddXY(l + 1, 1);
                }
                else
                {
                    grafico_linea.Series[0].Points.AddXY(l, 0);
                    grafico_linea.Series[0].Points.AddXY(l + 1, 0);
                }
            }

        }

        private void rbtn_miller_CheckedChanged(object sender, EventArgs e)
        {
            if (txtcodigo.Text != "")
            {
                grafico_linea.Series[0].Points.Clear();
                grafico.Series[0].Points.Clear();

                codigo_referencia();

                //MILLER
                String codigo;
                codigo = txtcodigo.Text;
                string[] vector = new string[codigo.Length];
                int[] vector_grafico = new int[codigo.Length];

                //De codigo a vector y vector_grafico            
                for (int i = 0; i < codigo.Length; i++)
                {
                    vector[i] = Convert.ToChar(codigo[i]).ToString();
                    vector_grafico[i] = int.Parse(vector[i]);
                }
                //Grafica los codigo
                int cont1 = 0;
                int cont0 = 0;

                for (int p = 0; p < vector_grafico.Length; p++)
                {
                    if (vector_grafico[p] == 1) //Grafica los 1
                    {
                        if (cont1 % 2 == 0)
                        {
                            grafico_linea.Series[0].Points.AddXY(p, -1);
                            grafico_linea.Series[0].Points.AddXY(p + 0.5, -1);
                            grafico_linea.Series[0].Points.AddXY(p + 0.5, 1);
                            grafico_linea.Series[0].Points.AddXY(p + 1, 1);
                        }
                        else
                        {
                            grafico_linea.Series[0].Points.AddXY(p, 1);
                            grafico_linea.Series[0].Points.AddXY(p + 0.5, 1);
                            grafico_linea.Series[0].Points.AddXY(p + 0.5, -1);
                            grafico_linea.Series[0].Points.AddXY(p + 1, -1);
                        }
                        cont1 = cont1 + 1;
                    }
                    else //Grafica los 0
                    {
                        if (cont0 % 2 == 0)
                        {
                            grafico_linea.Series[0].Points.AddXY(p, -1);
                            grafico_linea.Series[0].Points.AddXY(p + 1, -1);
                        }
                        else
                        {
                            grafico_linea.Series[0].Points.AddXY(p, 1);
                            grafico_linea.Series[0].Points.AddXY(p + 1, 1);
                        }
                        cont0 = cont0 + 1;
                    }
                }
                lblcodigo_linea.Text = "Codigo Miller: " + codigo;
            }
            else
            {
                MessageBox.Show("No se acepta campo vacio");
                txtcodigo.Focus();
            }
        }
    }
}


    
 

