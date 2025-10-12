using System;
using System.Collections.Generic;


escreva escrito = new escreva();
media valor = new media(4, 8, 7, 9, 4);

escrito.linha();
Console.WriteLine($"A media é: {valor.calculoMedia()}");
escrito.linha();




public class escreva
{
        public void linha()
        {
                Console.WriteLine("-----------------------------------------------------");
        }
}

public class media
{
        public double valorDivisorOriginal;
        LinkedList<double> listaM = new LinkedList<double>();
        public double m = 0.0;
        public double sumValores = 0;

        public media(double valorDivisor, params double[] listaR)
        {
                valorDivisorOriginal = valorDivisor;
                for(int n = 0; n < listaR.Length; n++)
                {
                        listaM.AddLast(listaR[n]);
                }
                
        }

        public double calculoMedia()
        {
                //foreach(double valor in listaM )
                //{
                        //Console.WriteLine(valor);
                //}
                for(int n = 0; n < listaM.Count; n++)
                {
                        sumValores = sumValores + listaM.ElementAt(n);
                }

                m = sumValores / valorDivisorOriginal;
                return m;
        }
}