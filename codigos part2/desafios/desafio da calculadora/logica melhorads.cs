//mesma coisa do logica feita por min, com a diferença que este foi melhorado.

double resultado = 0;
string operador = "";
int cycles = 1;

private void AplicarOperacao(string novoOperador)
{
    double valor = double.TryParse(txtDisplay.Text, out double num) ? num : 0;

    if (cycles == 1)
    {
        resultado = valor;
    }
    else
    {
        switch (operador)
        {
            case "+": resultado += valor; break;
            case "-": resultado -= valor; break;
            case "*": resultado *= valor; break;
            case "/":
                if (valor == 0)
                {
                    MessageBox.Show("Divisão por zero não é permitida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDisplay.Clear();
                    return;
                }
                resultado /= valor;
                break;
            case "=": resultado = valor; break;
        }
    }

    operador = novoOperador;
    cycles++;

    txtDisplay.Clear();

    if (novoOperador == "=")
    {
        txtDisplay.Text = resultado.ToString();
    }
}

private void Mais_Click(object sender, EventArgs e) => AplicarOperacao("+");
private void Menos_Click(object sender, EventArgs e) => AplicarOperacao("-");
private void Multiplicador_Click(object sender, EventArgs e) => AplicarOperacao("*");
private void Divisor_Click(object sender, EventArgs e) => AplicarOperacao("/");
private void Igual_Click(object sender, EventArgs e) => AplicarOperacao("=");
private void Clear_Click(object sender, EventArgs e)
{
    resultado = 0;
    operador = string.Empty;
    cycles = 1;
    txtDisplay.Clear();
}
