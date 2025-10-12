using System;

Console.WriteLine("Informe o Raio de uma esfera para saber seu volume:");
string nFake = Console.ReadLine();

int n = int.Parse(nFake);

double piu = Math.PI;
double v = (4.0/3) * piu * Math.Pow(n,3);

Console.WriteLine($"VOLUME = {Math.Round(v,3)}");