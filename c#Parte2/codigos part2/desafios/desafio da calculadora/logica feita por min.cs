//esta é uma parte do código que fiz usando winforms no visual studio, lógica principal da calculadora.
    
private void Mais_Click(object sender, EventArgs e)
{
    if (cycles == 1)
    {
        resultado = double.TryParse(txtDisplay.Text, out double number) ? number : 0;
    }
    else
    {
        switch (operador)
        {
            case "+":
                resultado += double.TryParse(txtDisplay.Text, out double valor) ? valor : 0;
                break;
            case "-":
                resultado -= double.TryParse(txtDisplay.Text, out valor) ? valor : 0;
                break;
            case "*":
                resultado *= double.TryParse(txtDisplay.Text, out valor) ? valor : 0;
                break;
            case "/":
                resultado /= double.TryParse(txtDisplay.Text, out valor) ? valor : 0;
                break;
            case "=":
                resultado = double.TryParse(txtDisplay.Text, out valor) ? valor : 0;
                break;
        }
    }

    operador = "+";

    cycles++;
    
    txtDisplay.Clear();
}

private void Menos_Click(object sender, EventArgs e)
{
    if (cycles == 1)
    {
        resultado = double.TryParse(txtDisplay.Text, out double number) ? number : 0;
    }
    else
    {
        switch (operador)
        {
            case "+":
                resultado += double.TryParse(txtDisplay.Text, out double valor) ? valor : 0;
                break;
            case "-":
                resultado -= double.TryParse(txtDisplay.Text, out valor) ? valor : 0;
                break;
            case "*":
                resultado *= double.TryParse(txtDisplay.Text, out valor) ? valor : 0;
                break;
            case "/":
                resultado /= double.TryParse(txtDisplay.Text, out valor) ? valor : 0;
                break;
            case "=":
                resultado = double.TryParse(txtDisplay.Text, out valor) ? valor : 0;
                break;
        }
    }

    operador = "-";

    cycles++;

    txtDisplay.Clear();
}

private void Multiplicador_Click(object sender, EventArgs e)
{
    if (cycles == 1)
    {
        resultado = double.TryParse(txtDisplay.Text, out double number) ? number : 0;
    }
    else
    {
        switch (operador)
        {
            case "+":
                resultado += double.TryParse(txtDisplay.Text, out double valor) ? valor : 0;
                break;
            case "-":
                resultado -= double.TryParse(txtDisplay.Text, out valor) ? valor : 0;
                break;
            case "*":
                resultado *= double.TryParse(txtDisplay.Text, out valor) ? valor : 0;
                break;
            case "/":
                resultado /= double.TryParse(txtDisplay.Text, out valor) ? valor : 0;
                break;
            case "=":
                resultado = double.TryParse(txtDisplay.Text, out valor) ? valor : 0;
                break;
        }
    }

    operador = "*";

    cycles++;

    txtDisplay.Clear();
}

private void Divisor_Click(object sender, EventArgs e)
{
    if (cycles == 1)
    {
        resultado = double.TryParse(txtDisplay.Text, out double number) ? number : 0;
    }
    else
    {
        switch (operador)
        {
            case "+":
                resultado += double.TryParse(txtDisplay.Text, out double valor) ? valor : 0;
                break;
            case "-":
                resultado -= double.TryParse(txtDisplay.Text, out valor) ? valor : 0;
                break;
            case "*":
                resultado *= double.TryParse(txtDisplay.Text, out valor) ? valor : 0;
                break;
            case "/":
                resultado /= double.TryParse(txtDisplay.Text, out valor) ? valor : 0;
                break;
            case "=":
                resultado = double.TryParse(txtDisplay.Text, out valor) ? valor : 0;
                break;
        }
    }

    operador = "/";

    cycles++;

    txtDisplay.Clear();
}

private void Igual_Click(object sender, EventArgs e)
{
    if (cycles == 1)
    {
        resultado = double.TryParse(txtDisplay.Text, out double number) ? number : 0;
    }
    else
    {
        switch (operador)
        {
            case "+":
                resultado += double.TryParse(txtDisplay.Text, out double valor) ? valor : 0;
                break;
            case "-":
                resultado -= double.TryParse(txtDisplay.Text, out valor) ? valor : 0;
                break;
            case "*":
                resultado *= double.TryParse(txtDisplay.Text, out valor) ? valor : 0;
                break;
            case "/":
                resultado /= double.TryParse(txtDisplay.Text, out valor) ? valor : 0;
                break;
            case "=":
                resultado = double.TryParse(txtDisplay.Text, out valor) ? valor : 0;
                break;
        }
    }

    operador = "=";

    txtDisplay.Text = resultado.ToString();
}

private void Clear_Click(object sender, EventArgs e)
{
    resultado = 0;
    operador = string.Empty;
    cycles = 1;

    txtDisplay.Clear();
}
}