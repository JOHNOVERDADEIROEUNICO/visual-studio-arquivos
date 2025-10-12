//Juntando a partial class da part1 com a part2 temos nossa janela que funciona como uma calculadora!
namespace winformsfirst
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        //Componenetes do nosso form:
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button Mais;
        private System.Windows.Forms.Button Menos;
        private System.Windows.Forms.Button Multiplicador;
        private System.Windows.Forms.Button Divisor;
        private System.Windows.Forms.Button Igual;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button ponto_Flutuante;
        private System.Windows.Forms.Button ponto_flutuante2;
        private System.Windows.Forms.Button porcetagem;
    }
}