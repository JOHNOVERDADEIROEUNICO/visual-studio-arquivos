//OBS: caracteres especiais (enter, backspace, esc, delete, etc) são melhores de serem pegos no keyDown
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