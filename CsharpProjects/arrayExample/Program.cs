// string[] fraudulentOrderIDs = new string [3]; // O número dentro dos colchetes indica o tamanho da lista, nesse caso ele é uma instância nova

// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";

string[] fraudulentOrderIDs = { "A123", "B456", "C789" }; // Inserindo sem declarar o tamanho do array

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process");
