using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Calculadora_TP1
{
    public partial class FormCalculadora : Form
    {
        Operando operando1 = new Operando();
        Operando operando2 = new Operando();

        double resultado;
        char operador = '+';
        string decimalABinario = "Valor invalido.";
        string BinarioADecimal = "Valor invalido.";
        public FormCalculadora()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Carga de FormCalculadora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Limpiar_Click(sender, e);
        }

        /// <summary>
        /// TextBox que carga el objeto operando1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            operando1.Numero = this.textNumero1.Text;
        }

        /// <summary>
        /// TextBox que carga el objeto operando 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            operando2.Numero = this.textNumero2.Text;

        }

        /// <summary>
        /// Seleccion de los operadores +, -, * o /
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Operador_SelectedIndexChanged(object sender, EventArgs e)
        {
            operador = Convert.ToChar(this.Operador.Text);
        }

        /// <summary>
        /// Opera los numeros cargados previamente(opera + predeterminadamente)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Operar_Click(object sender, EventArgs e)
        {
            resultado = Calculadora.Operar(operando1, operando2, operador);
            Muestreo.Items.Add($"{operando1.Numero}{operador}{operando2.Numero}={resultado}");
            labelResultado.Text = Convert.ToString(resultado);


        }

        /// <summary>
        /// Limpia los casilleros del forms.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Limpiar_Click(object sender, EventArgs e)
        {
            textNumero1.Text = "";
            textNumero2.Text = "";
            Muestreo.Items.Clear();
            labelResultado.Text = "0";
            resultado = 0;
            decimalABinario = "Valor invalido.";
            BinarioADecimal = "Valor invalido.";
        }

        /// <summary>
        /// Consulta antes de cerrar el forms, luego lo cierra si el usuario selecciona la opcion si
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cerrar_Click(object sender, EventArgs e)
        {
            const string mensaje1 = "Desea cerrar la calculadora?";

            var result = MessageBox.Show(mensaje1, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Convierte un numero a binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConvertirABinario_Click(object sender, EventArgs e)
        {

            decimalABinario = Operando.DecimalBinario(Convert.ToString(resultado));
            Muestreo.Items.Add(decimalABinario);

        }

        /// <summary>
        /// convierte un numero a decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConvertirADecimal_Click(object sender, EventArgs e)
        {

                BinarioADecimal = Operando.BinarioDecimal(Convert.ToString(decimalABinario));
                Muestreo.Items.Add(BinarioADecimal);

        }

        /// <summary>
        /// Caja que muestra los datos de las cuentas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Muestreo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Muestra solo el resultado en el label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
