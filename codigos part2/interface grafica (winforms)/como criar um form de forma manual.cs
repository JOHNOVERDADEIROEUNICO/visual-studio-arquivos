using System;
using System.Windows.Forms;

class Program
{
    static void Main()
    {
        Application.EnableVisualStyles(); 
        Application.Run(new MeuForm()); // abre a janela
    }
}

class MeuForm : Form
{
    public MeuForm()
    {
        this.Text = "Minha Primeira Janela"; // título
        this.Width = 400;
        this.Height = 300;

        Button botao = new Button();
        botao.Text = "Clique aqui";
        botao.Top = 50;
        botao.Left = 100;

        botao.Click += (s, e) => MessageBox.Show("Botão clicado!");

        this.Controls.Add(botao); // adiciona o botão na janela
    }
}
