//PRIMEIRO DECLARE O TIPO, O NOME E QUANTOS PARAMETROS O DELEGADO TERÁ:
public delegate int OperacaoMatematica(int x, int y);

//SEGUNDO CIRE MÉTODOS COMPATIVEIS COM O DELEGADO (PARA SER COMPATIVO O MÉTODO DEVE TER O MESMO TIPO):
public class Calculadora
{
    public int Somar(int a, int b)
    {
        return a + b;
    }

    public int Subtrair(int a, int b)
    {
        return a - b;
    }
}

//AGORA PODEMOS USAR O NOSSO PROPRÍO DELEGADO:
class Program
{
    static void Main()
    {
        Calculadora calc = new Calculadora();

        // Criar instâncias do delegado apontando para os métodos
        OperacaoMatematica operacao1 = calc.Somar;
        OperacaoMatematica operacao2 = calc.Subtrair;

        // Chamar os métodos por meio do delegado
        Console.WriteLine("Soma: " + operacao1(10, 5));        // Saída: 15
        Console.WriteLine("Subtração: " + operacao2(10, 5));   // Saída: 5
    }
}
