using Estilo.Styles;

class NotNull
{
    public static string Tratador()
    {
        string entrada;

        while(true)
        {
            
            entrada = (Console.ReadLine() ?? "").Trim();

            if(string.IsNullOrWhiteSpace(entrada))
            {
                Linha.Linha10();
                Console.WriteLine("Nenhum nome encontrado, por favor digite um nome.");
                Console.Write("Digite aqui: ");
            }
            else
            {
                return entrada;
            }
        }
    }
}