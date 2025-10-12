using System;

double piu = Math.PI;

Console.WriteLine("Informe 3 valores (A, B e C em ordem) seperados por espaço:"); //CURIOSIDADE: o método parse irá respeitar a cultura do país, ou seja se estivermos no Brsail devemos usar vírgula para valores de ponto flutuante, enquanto nos EUA o ponto tradicional das linguagens de progamação, isso se formos usar o parse, senão, usa-se o ponto tradicional mesmo.

string nFakes = Console.ReadLine();

string[] partes = nFakes.Split(' ');

double a = double.Parse(partes[0]);
double b = double.Parse(partes[1]);
double c = double.Parse(partes[2]);

Console.WriteLine($"{a} {b} {c}");

double triRetangulo = (a * c) / 2;
double circulo = piu * (c * c);
double trapezio = (a + b) * c / 2;
double quadrado = b * b;
double retangulo = a * b;

Console.WriteLine($"TRIÂNGULO = {Math.Round(triRetangulo, 3)}\nCÍRCULO = {Math.Round(circulo, 3)}\nTRAPEZIO = {Math.Round(trapezio, 3)}\nQUADRADO = {Math.Round(quadrado, 3)}\nRETÂNGULO = {Math.Round(retangulo, 3)}");