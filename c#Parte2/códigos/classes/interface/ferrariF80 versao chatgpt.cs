public class FerrariF80 : ICarro
{
    public int Velocidade { get; private set; }
    public bool Ligado { get; private set; }

    public void Velocimetro()
    {
        Console.WriteLine($"Velocímetro: {Velocidade}KM/H");
    }

    public bool Ligar()
    {
        Console.WriteLine("VRUMMMMMMMMM");
        Ligado = true;
        return Ligado;
    }

    public bool Desligar()
    {
        Console.WriteLine("Carro desligado");
        Ligado = false;
        Velocidade = 0;
        return Ligado;
    }

    public int Acelerar(int vAcrescentado)
    {
        if (!Ligado)
        {
            Console.WriteLine("O carro está desligado. Impossível acelerar.");
            return Velocidade;
        }

        Velocidade += vAcrescentado;
        Console.WriteLine($"Acelerando... nova velocidade: {Velocidade}KM/H");
        return Velocidade;
    }

    public int Frear(int vDecrementado)
    {
        if (!Ligado)
        {
            Console.WriteLine("O carro está desligado. Impossível frear.");
            return Velocidade;
        }

        Velocidade = Math.Max(0, Velocidade - vDecrementado);
        Console.WriteLine($"Freando... nova velocidade: {Velocidade}KM/H");
        return Velocidade;
    }
}
