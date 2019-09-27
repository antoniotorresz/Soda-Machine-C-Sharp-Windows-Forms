using Expendedora.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace Expendedora
{

    public partial class Expendedora : Form
    {
        private List<Producto> productos = new List<Producto>();
        double precio = 4.5;
        double credito = 0;
        int counter = 0;


        public Expendedora()
        {
            InitializeComponent();          
            cargarProductos();
            label9.Location = new Point(147,5);
        }

        private void cargarProductos()
        {
            Producto prod1 = new Producto();
            prod1.Nombre = "Coca-Cola";
            prod1.Cantidad = 5;
            productos.Add(prod1);

            Producto prod2 = new Producto();
            prod2.Nombre = "Fanta";
            prod2.Cantidad = 5;

            productos.Add(prod2);

            Producto prod3 = new Producto();
            prod3.Nombre = "Sprite";
            prod3.Cantidad = 5;
            productos.Add(prod3);

            Producto prod4 = new Producto();
            prod4.Nombre = "Seven-Up";
            prod4.Cantidad = 5;
            productos.Add(prod4);

            Producto prod5 = new Producto();
            prod5.Nombre = "Jarrito";
            prod5.Cantidad = 5;
            productos.Add(prod5);
            label7.Text = "Precio de productos: " + precio.ToString();
            //MessageBox.Show("Numero de productos: " + productos.Count);
            cargarDatos();
        }

        private void cargarDatos()
        {
            label1.Text = productos[0].Cantidad.ToString();
            label2.Text = productos[1].Cantidad.ToString();
            label3.Text = productos[2].Cantidad.ToString();
            label4.Text = productos[3].Cantidad.ToString();
            label5.Text = productos[4].Cantidad.ToString();


            radioButton1.Text = productos[0].Nombre;
            radioButton2.Text = productos[1].Nombre;
            radioButton3.Text = productos[2].Nombre;
            radioButton4.Text = productos[3].Nombre;
            radioButton5.Text = productos[4].Nombre;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.cocacola;
        }

        private void RadioButton2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.fanta;
        }

        private void RadioButton3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.sprite;
        }

        private void RadioButton4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources._7up;
        }

        private void RadioButton5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.jarrito;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            var entrada = textBox1.Text;
            if (!string.IsNullOrEmpty(entrada))
            {
                if (!entrada.Any(char.IsLetter))
                {
                    double numero = Convert.ToDouble(entrada);

                    if (numero == 0.50 || numero == 1 || numero == 2
                || numero == 5 || numero == 10)
                    {
                        credito += numero;
                        label6.Text = "Crédito total: " + credito.ToString();
                        textBox1.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("SOLO SE ADMITEN MONEDAS DE: \n$0.5," +
                            " $1.00, $2.00, $5.00, $10.00 ");
                        textBox1.Text = "";
                    }
                }
                else {
                    MessageBox.Show("No existen monedas de " + entrada.ToString());
                    textBox1.Text = "";
                }
            }
            else {
                MessageBox.Show("Ingresa el valor de tu moneda");
            }

            if (credito >= precio) {
                panel2.Enabled = true;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            
            if (radioButton1.Checked) {
                if (productos[0].Cantidad > 0)
                {
                    if (credito >= precio)
                    {
                        label8.Text = "Cambio: " + Convert.ToString(credito - precio);
                        productos[0].Cantidad -= 1;
                        label1.Text = Convert.ToString(productos[0].Cantidad);
                        credito = 0;
                        label9.Text = "Gracias por su compra";
                        pictureBox1.Image = null;
                        playSound();
                        validarCredito();

                    }
                    else {
                        MessageBox.Show("No cuentas con el credito necesario");
                    }
                    label6.Text = "Crédito total: "+ credito.ToString();
                }
                else {
                    radioButton1.Enabled = false;
                    radioButton1.Checked = false;
                    MessageBox.Show("No hay existencia.");
                }
            }


            if (radioButton2.Checked)
            {
                if (productos[1].Cantidad > 0)
                {
                    if (credito >= precio)
                    {
                        label8.Text = "Cambio: " + Convert.ToString(credito - precio);
                        productos[1].Cantidad -= 1;
                        label2.Text = Convert.ToString(productos[1].Cantidad);
                        credito = 0;
                        label9.Text = "Gracias por su compra";
                        pictureBox1.Image = null;
                        playSound();
                        validarCredito();
                    }
                    else {
                        MessageBox.Show("No cuentas con el credito necesario");
                    }
                    label6.Text = "Crédito total: " + credito.ToString();
                }
                else
                {
                    radioButton2.Enabled = false;
                    MessageBox.Show("No hay existencia");
                }
            }


            if (radioButton3.Checked)
            {
                if (productos[2].Cantidad > 0)
                {
                    if (credito >= precio)
                    {
                        label8.Text = "Cambio: " + Convert.ToString(credito - precio);
                        productos[2].Cantidad -= 1;
                        label3.Text = Convert.ToString(productos[2].Cantidad);
                        credito = 0;
                        label9.Text = "Gracias por su compra";
                        pictureBox1.Image = null;
                        playSound();
                        validarCredito();
                    }
                    else
                    {
                        MessageBox.Show("No cuentas con el credito necesario");
                    }
                    label6.Text = "Crédito total: " + credito.ToString();
                }
                else
                {
                    radioButton3.Enabled = false;
                    MessageBox.Show("No hay existencia");
                }
            }
            if (radioButton4.Checked)
            {
                if (productos[3].Cantidad > 0)
                {
                    if (credito >= precio)
                    {
                        label8.Text = "Cambio: " + Convert.ToString(credito - precio);
                        productos[3].Cantidad -= 1;
                        label4.Text = Convert.ToString(productos[3].Cantidad);
                        credito = 0;
                        label9.Text = "Gracias por su compra";
                        pictureBox1.Image = null;
                        playSound();
                        validarCredito();
                    }
                    else
                    {
                        MessageBox.Show("No cuentas con el credito necesario");
                    }
                    label6.Text = "Crédito total: " + credito.ToString();
                }
                else
                {
                    radioButton4.Enabled = false;
                    MessageBox.Show("No hay existencia");
                }
            }
            if (radioButton5.Checked)
            {
                if (productos[4].Cantidad > 0)
                {
                    if (credito >= precio)
                    {
                        label8.Text = "Cambio: " + Convert.ToString(credito - precio);
                        productos[4].Cantidad -= 1;
                        label5.Text = Convert.ToString(productos[4].Cantidad);
                        credito = 0;
                        label9.Text = "Gracias por su compra";
                        pictureBox1.Image = null;
                        playSound();
                        validarCredito();
                    }
                    else
                    {
                        MessageBox.Show("No cuentas con el credito necesario");
                    }
                    label6.Text = "Crédito total: " + credito.ToString();
                }
                else
                {
                    radioButton5.Enabled = false;
                    MessageBox.Show("No hay existencia");
                }
            }

        }

        private void playSound()
        {
            //SoundPlayer player = new SoundPlayer(@"C:\Users\Antonio\Downloads\machine_sound.wav");
            SoundPlayer player = new SoundPlayer(Resources.machine_sound);
            player.Play();
        }

        private void validarCredito()
        {
            if (credito < precio)
            {
                panel2.Enabled = false;
            }
        }

        private void NuevoPrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string entrada = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la nueva tarifa");

            try {
                if (!string.IsNullOrEmpty(entrada))
                {
                    if (!entrada.Any(char.IsLetter))
                    {
                        if (esValido(entrada))
                        {
                            precio = Convert.ToDouble(entrada);
                            label7.Text = "Precio de productos: " + precio;

                            if (precio > credito)
                            {
                                panel2.Enabled = false;
                            }
                            else if (credito >= precio)
                            {
                                panel2.Enabled = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cantidad no válida, ingrese cantidades múltiplos de $0.50");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cantidad no válida, ingrese cantidades múltiplos de $0.50");
                    }
                }
                else
                {

                }
            }
            catch (Exception) {

            }
        }

        private bool esValido(string entrada)
        {
            if (entrada.Contains(".1") || entrada.Contains(".2") || entrada.Contains(".3") ||
                entrada.Contains(".4") || entrada.Contains(".6") || entrada.Contains(".7") || entrada.Contains(".51")
                || entrada.Contains(".52") || entrada.Contains(".53") || entrada.Contains(".54") || entrada.Contains(".56")
                || entrada.Contains(".57") || entrada.Contains(".58") || entrada.Contains(".59")
               || entrada.Contains(".8") || entrada.Contains(".9") || entrada.Contains(".0"))
            {
                return false;
            }
            else {
                return true;
            }
        }

        private void CocaColaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var entrada = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad a surtir:");
            try {
                if (!string.IsNullOrEmpty(entrada))
                {
                    if (!entrada.Any(char.IsLetter))
                    {
                        int numero = 0;
                        if (esValidoCantidad(entrada))
                        {
                            numero = Convert.ToInt32(entrada);
                        }
                        if (numero > 0)
                        {
                            productos[0].Cantidad += numero;
                            label1.Text = productos[0].Cantidad.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Cantidad no valida");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No existe esta cantidad: " + entrada.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Entrada vacía");
                }
            }
            catch (Exception) {

            }
            //productos[0].Cantidad = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad a surtir:"));
        }

        private void FantaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var entrada = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad a surtir:");
            try
            {
                if (!string.IsNullOrEmpty(entrada))
                {
                    if (!entrada.Any(char.IsLetter))
                    {
                        int numero = 0;
                        if (esValidoCantidad(entrada))
                        {
                            numero = Convert.ToInt32(entrada);
                        }
                        if (numero > 0)
                        {
                            productos[1].Cantidad += numero;
                            label2.Text = productos[1].Cantidad.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Cantidad no valida");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No existe esta cantidad: " + entrada.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Entrada vacía");
                }
            }
            catch (Exception)
            {

            }
        }

        private bool esValidoCantidad(string entrada)
        {
            if (entrada.Contains(".1") || entrada.Contains(".2") || entrada.Contains(".3") ||
                entrada.Contains(".4") || entrada.Contains(".6") || entrada.Contains(".7") || entrada.Contains(".5")
               || entrada.Contains(".8") || entrada.Contains(".9") || entrada.Contains(".0"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void SpriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var entrada = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad a surtir:");
            try
            {
                if (!string.IsNullOrEmpty(entrada))
                {
                    if (!entrada.Any(char.IsLetter))
                    {
                        int numero = 0;
                        if (esValidoCantidad(entrada))
                        {
                            numero = Convert.ToInt32(entrada);
                        }
                        if (numero > 0)
                        {
                            productos[2].Cantidad += numero;
                            label3.Text = productos[2].Cantidad.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Cantidad no valida");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No existe esta cantidad: " + entrada.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Entrada vacía");
                }
            }
            catch (Exception)
            {

            }
        }

        private void SevenUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var entrada = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad a surtir:");
            try
            {
                if (!string.IsNullOrEmpty(entrada))
                {
                    if (!entrada.Any(char.IsLetter))
                    {
                        int numero = 0;
                        if (esValidoCantidad(entrada))
                        {
                            numero = Convert.ToInt32(entrada);
                        }
                        if (numero > 0)
                        {
                            productos[3].Cantidad += numero;
                            label4.Text = productos[3].Cantidad.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Cantidad no valida");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No existe esta cantidad: " + entrada.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Entrada vacía");
                }
            }
            catch (Exception)
            {

            }
        }

        private void JarritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var entrada = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad a surtir:");
            try
            {
                if (!string.IsNullOrEmpty(entrada))
                {
                    if (!entrada.Any(char.IsLetter))
                    {
                        int numero = 0;
                        if (esValidoCantidad(entrada))
                        {
                            numero = Convert.ToInt32(entrada);
                        }
                        if (numero > 0)
                        {
                            productos[4].Cantidad += numero;
                            label5.Text = productos[4].Cantidad.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Cantidad no valida");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No existe esta cantidad: " + entrada.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Entrada vacía");
                }
            }
            catch (Exception)
            {

            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (label9.Location.X == 147)
            {
                counter = -60;
                label9.Location = new Point(counter, 5);
            }
            else
            {
                label9.Location = new Point(counter, 5);
                counter += 1;
            }

            if (counter == 40) {
                label9.Text = "Bebidas frías";
            }
        }
    }
}
