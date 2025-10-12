public class SaldoInsuficienteException : Exception
{
    public SaldoInsuficienteException(double saldo, double valorSaque)
        : base($"Saldo insuficiente. Saldo atual: {saldo}, Valor do saque: {valorSaque}")
    {
    }
}

public class ContaBancaria
{
    private double saldo;
    
    public void Sacar(double valor)
    {
        if (valor > saldo)
        {
            throw new SaldoInsuficienteException(saldo, valor);
        }
        saldo -= valor;
    }
}