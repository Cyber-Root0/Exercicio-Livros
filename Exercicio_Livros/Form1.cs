using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_Livros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct livros
        {
            public int codigo;
            public string titulo;
            public string autor;
            public string estilo;
            public double preco;


        }
        
        int contador = 0;
        int codigo = 1;
        double valores = 0;
        double contador2 = 1;
        livros[] vet= new livros[5];
        
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            //denifição dos vetores....

            vet[contador].codigo = Convert.ToInt32(lb_codigo.Text);
            vet[contador].titulo = tb_titulo.Text;
            vet[contador].autor = tb_autor.Text;
            vet[contador].estilo = tb_estilo.Text;
            vet[contador].preco = Convert.ToDouble(tb_preco.Text);

            //calculo da media de livros
            valores = valores + vet[contador].preco;
            double media = valores / contador2;
            lb_media.Text = "R$ " + media;


            //jogando os dados na Grid....
            Grid1.Rows.Add(vet[contador].codigo, vet[contador].titulo, vet[contador].autor, vet[contador].estilo, vet[contador].preco);
            
            //limpeza de telas no layot
            tb_titulo.Clear();
            tb_autor.Clear();
            tb_estilo.Clear();
            tb_preco.Clear();

            
            //sistema do veotor e struct
            contador = contador + 1;
            contador2 = contador2 + 1;

            codigo = codigo + 1;
            lb_codigo.Text = "" + codigo;
          

            




        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rb_codigo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (rb_codigo.Checked == true)
            {
                Grid2.Rows.Clear();
                int contador = 0;
                bool achou = false;
                int numeroqueparou = 0;
                int pesquisa = Convert.ToInt32(tb_pesquisa.Text);
                while(contador<4 && achou == false)
                {
                    if (vet[contador].codigo==pesquisa)
                    {
                        achou = true;
                        numeroqueparou = contador;
                    }
                    contador = contador + 1;

                }

                Grid2.Rows.Add(vet[numeroqueparou].codigo, vet[numeroqueparou].titulo, vet[numeroqueparou].autor, vet[numeroqueparou].estilo, vet[numeroqueparou].preco);
                tb_pesquisa.Clear();



            }

            if (rb_estilo.Checked == true)
            {

                Grid2.Rows.Clear();
                int contador = 0;

                int numeroqueparou = 0;
                string pesquisa = (tb_pesquisa.Text);
                while (contador < 4)
                {
                    if (vet[contador].estilo == pesquisa)
                    {
                     
                        numeroqueparou = contador;
                        Grid2.Rows.Add(vet[numeroqueparou].codigo, vet[numeroqueparou].titulo, vet[numeroqueparou].autor, vet[numeroqueparou].estilo, vet[numeroqueparou].preco);
                    }
                    contador = contador + 1;
                    

                }

                
                tb_pesquisa.Clear();




            }
            if (rb_titulo.Checked == true)
            {
                Grid2.Rows.Clear();
                int contador = 0;

                int numeroqueparou = 0;
                string pesquisa = (tb_pesquisa.Text);
                while (contador < 4)
                {
                    if (vet[contador].titulo == pesquisa)
                    {

                        numeroqueparou = contador;
                        Grid2.Rows.Add(vet[numeroqueparou].codigo, vet[numeroqueparou].titulo, vet[numeroqueparou].autor, vet[numeroqueparou].estilo, vet[numeroqueparou].preco);
                    }
                    contador = contador + 1;


                }


                tb_pesquisa.Clear();




            }





        }
    }
}
