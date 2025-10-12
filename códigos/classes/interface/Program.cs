class Program
{
        static void Main()
        {
                ferrariF80 f = new ferrariF80();

                f.ligar();

                f.velocimetro();

                f.acelerar(100);

                f.velocimetro();

                f.frear(20);

                f.velocimetro();

                f.desligar();
        }
}