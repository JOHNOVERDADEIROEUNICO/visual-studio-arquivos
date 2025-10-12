using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformsfirst
{
    public partial class Form1 : Form
    {
        int cycles = 1;
        double resultado, valor = 0;
        string operador = string.Empty;

        private void AplicarOperacao(string Operador)
        {
            string valorString = txtDisplay.Text;
            if (valorString.Any(c => ".".Contains(c)))
            {
                valorString = valorString.Replace(".", ",");
                valor = double.TryParse(valorString, out double val) ? val : 0;
            }
            else
            {
                valor = double.TryParse(valorString, out double val) ? val : 0;
            }


            if (cycles == 1)
                resultado = valor;
            else
            {
                switch (operador)
                {
                    case "+":
                        resultado += valor;
                        break;
                    case "-":
                        resultado -= valor;
                        break;
                    case "*":
                        resultado *= valor;
                        break;
                    case "/":
                        if (valor == 0)
                            MessageBox.Show("Divisão por zero não é permitida.", "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            resultado /= valor;
                        break;
                    case "%":
                        resultado = (resultado * valor) / 100;
                        break;
                    case "=":
                        resultado = valor;
                        break;
                }
            }

            operador = Operador;

            cycles++;

            txtDisplay.Clear();

            if (operador == "=")
                txtDisplay.Text = resultado.ToString();

        }

        public Form1()
        {
            InitializeComponent();

            //Habilitar teclas do teclado na calculadora:
            this.KeyPreview = true;
            this.AcceptButton = null;
            this.KeyDown += Calculadora_KeyDown;
            this.KeyPress += Calculadora_KeyPress;
            
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            txtDisplay.Focus();
        }

        private void Calculadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                txtDisplay.Text += e.KeyChar;
                e.Handled = true;
            }
            else if ("%".Contains(e.KeyChar))
            {
                
                porcetagem_Click(null, null);
                e.Handled = true;
            }
            else if ("+".Contains(e.KeyChar))
            {
                
                Mais_Click(null, null);
                e.Handled = true;
            }
            else if ("-".Contains(e.KeyChar))
            {
                
                Menos_Click(null, null);
                e.Handled = true;
            }
            else if ("*".Contains(e.KeyChar))
            {
                
                Multiplicador_Click(null, null);
                e.Handled = true;
            }
            else if ("/".Contains(e.KeyChar))
            {
                
                Divisor_Click(null, null);
                e.Handled = true;
            }
            else if ("=".Contains(e.KeyChar))
            {
                
                Igual_Click(null, null);
                e.Handled = true;
            }

            else if (".".Contains(e.KeyChar) || ",".Contains(e.KeyChar))
            {
                txtDisplay.Text += ",";
                e.Handled = true;
            }
        }

        //Trata Caracateres Especiais:
        
        private void Calculadora_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Igual_Click(null, null);
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Back)
            {
                if (txtDisplay.Text.Length > 0)
                    txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete)
            {
                txtDisplay.Clear();
                e.SuppressKeyPress = true;
            }
        }

        private void InitializeComponent()
        {
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.Mais = new System.Windows.Forms.Button();
            this.Menos = new System.Windows.Forms.Button();
            this.Multiplicador = new System.Windows.Forms.Button();
            this.Divisor = new System.Windows.Forms.Button();
            this.Igual = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.ponto_Flutuante = new System.Windows.Forms.Button();
            this.ponto_flutuante2 = new System.Windows.Forms.Button();
            this.porcetagem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(-3, 1);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(1473, 100);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.TextChanged += new System.EventHandler(this.txtDisplay_TextChanged);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(496, 273);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(170, 180);
            this.button0.TabIndex = 1;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(-2, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 180);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(-3, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 180);
            this.button2.TabIndex = 3;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(-3, 452);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 180);
            this.button3.TabIndex = 4;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(163, 97);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 180);
            this.button4.TabIndex = 5;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(163, 273);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(170, 180);
            this.button5.TabIndex = 6;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(163, 452);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(170, 180);
            this.button6.TabIndex = 7;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(329, 97);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(170, 180);
            this.button7.TabIndex = 8;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(329, 273);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(170, 180);
            this.button8.TabIndex = 9;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(329, 452);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(170, 180);
            this.button9.TabIndex = 10;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Mais
            // 
            this.Mais.BackColor = System.Drawing.SystemColors.Info;
            this.Mais.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mais.Location = new System.Drawing.Point(1039, 97);
            this.Mais.Name = "Mais";
            this.Mais.Size = new System.Drawing.Size(228, 219);
            this.Mais.TabIndex = 11;
            this.Mais.Text = "+";
            this.Mais.UseVisualStyleBackColor = false;
            this.Mais.Click += new System.EventHandler(this.Mais_Click);
            // 
            // Menos
            // 
            this.Menos.BackColor = System.Drawing.SystemColors.Info;
            this.Menos.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menos.Location = new System.Drawing.Point(1039, 313);
            this.Menos.Name = "Menos";
            this.Menos.Size = new System.Drawing.Size(228, 209);
            this.Menos.TabIndex = 12;
            this.Menos.Text = "-";
            this.Menos.UseVisualStyleBackColor = false;
            this.Menos.Click += new System.EventHandler(this.Menos_Click);
            // 
            // Multiplicador
            // 
            this.Multiplicador.BackColor = System.Drawing.SystemColors.Info;
            this.Multiplicador.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplicador.Location = new System.Drawing.Point(1262, 313);
            this.Multiplicador.Name = "Multiplicador";
            this.Multiplicador.Size = new System.Drawing.Size(208, 209);
            this.Multiplicador.TabIndex = 13;
            this.Multiplicador.Text = "*";
            this.Multiplicador.UseVisualStyleBackColor = false;
            this.Multiplicador.Click += new System.EventHandler(this.Multiplicador_Click);
            // 
            // Divisor
            // 
            this.Divisor.BackColor = System.Drawing.SystemColors.Info;
            this.Divisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divisor.Location = new System.Drawing.Point(1262, 97);
            this.Divisor.Name = "Divisor";
            this.Divisor.Size = new System.Drawing.Size(208, 219);
            this.Divisor.TabIndex = 14;
            this.Divisor.Text = "/";
            this.Divisor.UseVisualStyleBackColor = false;
            this.Divisor.Click += new System.EventHandler(this.Divisor_Click);
            // 
            // Igual
            // 
            this.Igual.BackColor = System.Drawing.SystemColors.Info;
            this.Igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Igual.Location = new System.Drawing.Point(1196, 516);
            this.Igual.Name = "Igual";
            this.Igual.Size = new System.Drawing.Size(274, 116);
            this.Igual.TabIndex = 15;
            this.Igual.Text = "=";
            this.Igual.UseVisualStyleBackColor = false;
            this.Igual.Click += new System.EventHandler(this.Igual_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.GrayText;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(1039, 516);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(161, 116);
            this.Clear.TabIndex = 16;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ponto_Flutuante
            // 
            this.ponto_Flutuante.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ponto_Flutuante.Location = new System.Drawing.Point(496, 452);
            this.ponto_Flutuante.Name = "ponto_Flutuante";
            this.ponto_Flutuante.Size = new System.Drawing.Size(170, 180);
            this.ponto_Flutuante.TabIndex = 17;
            this.ponto_Flutuante.Text = ",";
            this.ponto_Flutuante.UseVisualStyleBackColor = true;
            this.ponto_Flutuante.Click += new System.EventHandler(this.ponto_Flutuante_Click);
            // 
            // ponto_flutuante2
            // 
            this.ponto_flutuante2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ponto_flutuante2.Location = new System.Drawing.Point(496, 97);
            this.ponto_flutuante2.Name = "ponto_flutuante2";
            this.ponto_flutuante2.Size = new System.Drawing.Size(170, 180);
            this.ponto_flutuante2.TabIndex = 18;
            this.ponto_flutuante2.Text = ".";
            this.ponto_flutuante2.UseVisualStyleBackColor = true;
            this.ponto_flutuante2.Click += new System.EventHandler(this.ponto_flutuante2_Click);
            // 
            // porcetagem
            // 
            this.porcetagem.BackColor = System.Drawing.SystemColors.Info;
            this.porcetagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porcetagem.Location = new System.Drawing.Point(816, 97);
            this.porcetagem.Name = "porcetagem";
            this.porcetagem.Size = new System.Drawing.Size(228, 219);
            this.porcetagem.TabIndex = 19;
            this.porcetagem.Text = "%";
            this.porcetagem.UseVisualStyleBackColor = false;
            this.porcetagem.Click += new System.EventHandler(this.porcetagem_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1469, 633);
            this.Controls.Add(this.porcetagem);
            this.Controls.Add(this.ponto_flutuante2);
            this.Controls.Add(this.ponto_Flutuante);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Igual);
            this.Controls.Add(this.Divisor);
            this.Controls.Add(this.Multiplicador);
            this.Controls.Add(this.Menos);
            this.Controls.Add(this.Mais);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.txtDisplay);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
            txtDisplay.Focus();
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
            txtDisplay.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
            txtDisplay.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
            txtDisplay.Focus();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
            txtDisplay.Focus();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
            txtDisplay.Focus();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
            txtDisplay.Focus();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
            txtDisplay.Focus();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
            txtDisplay.Focus();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
            txtDisplay.Focus();
        }



        private void Mais_Click(object sender, EventArgs e)
        {
            AplicarOperacao("+");
            txtDisplay.Focus();

        }


        private void Menos_Click(object sender, EventArgs e)
        {
            AplicarOperacao("-");
            txtDisplay.Focus();

        }


        private void Multiplicador_Click(object sender, EventArgs e)
        {
            AplicarOperacao("*");
            txtDisplay.Focus();

        }


        private void Divisor_Click(object sender, EventArgs e)
        {
            AplicarOperacao("/");
            txtDisplay.Focus();

        }


        private void Igual_Click(object sender, EventArgs e)
        {
            AplicarOperacao("=");
            txtDisplay.Focus();

        }

        private void ponto_Flutuante_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ",";
            txtDisplay.Focus();
        }

        private void ponto_flutuante2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ".";
            txtDisplay.Focus();
        }

        private void porcetagem_Click(object sender, EventArgs e)
        {
            AplicarOperacao("%");
            txtDisplay.Focus();

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            resultado = 0;
            operador = string.Empty;
            cycles = 1;

            txtDisplay.Clear();
            txtDisplay.Focus();
        }
    }

    
}
