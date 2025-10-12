//PERCEBA QUE O KEYPRESS TRABALHA OS CARACTERES ENQUANTO O KEYDOWN TRABALHA AS TECLAS, POR ESSE MOTIVO FICA MELHOR USAR O KEYPRESS PARA CAPTURAR TECLAS COMUNS E O KEYDOWN PARA CAPTURAR TECLAS ESPECIAIS.
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