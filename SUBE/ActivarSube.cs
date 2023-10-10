using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Interface {
    public partial class ActivarSube : Form
    {

        public ActivarSube()
        {
            InitializeComponent();

        }

        private void txtNumeroTarjeta_TextChanged(object sender, EventArgs e)
        {   
            bool isNumber;
            string finalString;
            string input;
            
            input = txtNumeroTarjeta.Text;

            isNumber = input.All(char.IsDigit);
            finalString = "";

            Console.WriteLine(isNumber);



            if (isNumber && input.Length <= 16)
            {
                finalString = separarNumerosTarjetas(input);
            } else
            {
                finalString = "Numero invalido.";
            }

            lblNumeroTarjetaSUBE.Text = finalString;
        }

        private string separarNumerosTarjetas(string numero)
        {
            List<char> list; 
            string final;
            int contador;

            list = new List<char>();
            final = "";
            contador = 0;


            foreach (char c in numero)
            {
                list.Add(c);
                contador++; 

                if (contador == 4 || contador == 8 || contador == 12)
                {
                    list.Add((char)32);
                    list.Add((char)32);    
                }
            }

            foreach (char c in list)
            {
                final += c;
            }

            return final;
        }
    }
}
