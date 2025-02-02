string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000"; 
// A parte comentada se ativada irá dar erro devido ao index estar fora do range establecido de 3 elementos.

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

/* string[] fraudulentOrderIDs = [ "A123", "B456", "C789" ]; ou
   string[] fraudulentOrderIDs = { "A123", "B456", "C789" };
Outro jeito de se aciionar uma matriz já declarando seus valores em sua declaração.*/

//Método length:
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");