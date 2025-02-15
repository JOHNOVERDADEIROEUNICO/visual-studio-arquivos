//Usando fora do escreva:(tire os comentarios de um e coloque no outro para testar)
//int saleAmount = 1000;
//int discount = saleAmount > 1000 ? 100 : 50;
//Console.WriteLine($"Discount: {discount}");


//Usando dentro do escreva:
int saleAmount = 1001;

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");