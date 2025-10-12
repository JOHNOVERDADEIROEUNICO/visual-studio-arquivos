//ESTE DELGADO REPRESENTA UM MÉTODO QUE COMPARA  DOIS OBJETOS DE UM MESMO TIPO E RETORNA UM INT.
Comparison<int> comparar = (x, y) => x.CompareTo(y);

// MÉTODOS DE ORDENAÇÃO COMO O .SORT COSTUMAM POSSUIR O COMPARISON EMBUTIDO DENTRO DELES:
List<int> numeros = new List<int> { 5, 1, 9, 3 };
numeros.Sort(comparar); // Ordena de forma crescente
