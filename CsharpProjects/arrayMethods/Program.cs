string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Ordenando...");
Array.Sort(pallets); // Organiza os items do vetor em ordem alfabética.
foreach (var pallet in pallets)
{
  Console.WriteLine($"-- {pallet}");
}

Console.WriteLine(" ");
Console.WriteLine("Revertendo a ordem...");
Array.Reverse(pallets); // Reverte a ordenação dos itens do vetor
foreach (var pallet in pallets)
{
  Console.WriteLine($"-- {pallet}");
}

Console.WriteLine(" ");
Array.Clear(pallets, 0, 2); // Remove a quantidade de itens a partir de uma determinada posição do vetor, deixando o item null (Semelhante ao array.splice no JS)
Console.WriteLine($"Limpando 2... Contagem: {pallets.Length}");
foreach (var pallet in pallets)
{
  Console.WriteLine($"-- {pallet}");
}

Console.WriteLine(" ");
Array.Resize(ref pallets, 6); // Redimenciona o tamanho do vetor podendo adicionar ou remover dependendo do tamanho original, caso os novos valores não sejam atribuidos receberâo valor null
Console.WriteLine($"Redimensionando 6... Contagem: {pallets.Length}");

pallets[4] = "CO1";
pallets[5] = "CO2";

foreach (var pallet in pallets)
{
  Console.WriteLine($"-- {pallet}");
}

/*
  Se o método Array.Resize() não remover elementos vazios de uma matriz, há algum outro método auxiliar que faz isso automaticamente?
  Não. A melhor maneira de esvaziar os elementos de uma matriz é contar o número de elementos não nulos percorrendo cada item e incrementando uma variável (contador). Em seguida, você criará uma segunda matriz que tem o tamanho da variável do contador. Por fim, você executará um loop em cada elemento na matriz original e copiará valores não nulos na nova matriz.
*/

string value = "abc123";
char[] valueArray = value.ToCharArray(); // Cada caracter de uma palavra vira uma posição no vetor
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = String.Join("," , valueArray); // conecta cada elemento do vetor com o que foi passado no parâmetro
Console.WriteLine(result);

string[] items = result.Split(','); // Semelhante ao JS, divide o array com base no que foi passado como parâmetro
foreach (string item in items)
{
  Console.WriteLine(item);
}

