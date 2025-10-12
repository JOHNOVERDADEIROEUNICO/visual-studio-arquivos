Random nAleatorio = new();

int number = nAleatorio.Next(1, 100);
int myNumber = 0;
int tentativas = 0;

while(true)
{
        Console.WriteLine("Tente adivinhar o número entre 1 e 100:");
        string nFake = Console.ReadLine();
        myNumber = int.Parse(nFake);
        tentativas ++;

        if(myNumber > number)
        {
                Console.WriteLine($"MUITO ALTO!\nSeu palpite: {myNumber}");    
        } 
        else if(myNumber < number)
        {
                Console.WriteLine($"MUITO BAIXO!\nSeu palpite: {myNumber}");    
        }
        else
        {  
                break;
        }
}

Console.WriteLine($"seu palpite: {myNumber}\nPARÁBENS VOCÊ CONSEGUIU! foram necessárias {tentativas} tentativas para acertar.");