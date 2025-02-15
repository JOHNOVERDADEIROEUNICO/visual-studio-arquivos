bool flag = true;
//adicone // na linha debaixo e remova o // da linha dentro do escopo if para verificar o erro de escopo
int value = 0;

if (flag)
//As chaves são opcionais!!!
//{
    //int value = 10;
    value += 5;
    Console.WriteLine($"Inside the code block: {value}");
//}
//Remova ou adicione comentario da linha abaixo para alterar a variavel value
value = 10;
Console.WriteLine($"Outside the code block: {value}");
//Se seguir os passos do primeiro comentário irá dar erro pois a variável value só existe dentro do bloco if