public class ferrariF80 : ICarro
{
    public int velocidade { get; set; }
    public bool ligado { get; set; }
    

    public void velocimetro()
    {
        Console.WriteLine($"O velocimetro se encontra em {velocidade}KM/H");
    }
    public bool ligar()
    {
        Console.WriteLine("VRUMMMMMMMMM");
        return ligado = true;

    }
    public bool desligar()
    {
        Console.WriteLine("Carro desligado");
        return ligado = false;

    }
    public int acelerar(int vAcrescentado)
    {
        if (ligado == true)
        {
            Console.WriteLine($"vrrrrrruuuummmm, o carro estava em {velocidade} e aumentou mais {vAcrescentado}KM/H");
            return velocidade += vAcrescentado;
        }
        else
        {
            Console.WriteLine("O carro está desligado impossível acelerar");
            return velocidade = 0;
            
        }
    }
    public int frear(int vDecrementado)
    {
        if (ligado == true)
        {
            Console.WriteLine($"O carro está ficando mais lento, O carro estva em {velocidade} e diminuiu para {vDecrementado}KM/H");
            return velocidade -= vDecrementado;
        }
        else
        {
            Console.WriteLine("O carro está desligado, impossível desacelerar");
            return velocidade = 0;
        }
        
    }

}