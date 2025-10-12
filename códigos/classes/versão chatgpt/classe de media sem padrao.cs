var valor = new Media(4, 8, 7, 9, 4);
Console.WriteLine($"A média é: {valor.CalcularMedia()}");


public class Media
{
    private List<double> listaValores;
    
    public Media(params double[] valores)
    {
        listaValores = new List<double>(valores);
    }

    public double CalcularMedia()
    {
        if (listaValores.Count == 0) return 0;

        double soma = 0;
        foreach (double valor in listaValores)
        {
            soma += valor;
        }

        return soma / listaValores.Count;
    }
}
