string[] ipv4Input = { "107.31.1.15", "255.0.0.255", "555..0.555", "255...255" };
string[] address;
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

foreach (string ip in ipv4Input)
{
  address = ip.Split(".",StringSplitOptions.RemoveEmptyEntries); // Impede tentativas de analisar cadeias de caracteres vazias
  ValidateLength();
  ValidateZeroes();
  ValidateRange();

  if (validLength && validZeroes && validRange)
  {
    Console.WriteLine($"{ip} is a valid IPv4 address");
  }
  else
  {
    Console.WriteLine($"{ip} is a invalid IPv4 address");
  }
}

void ValidateLength()
{
  validLength = address.Length == 4;
};

void ValidateZeroes()
{
  foreach (string number in address)
  {
    if (number.Length > 1 && number.StartsWith("0"))
    {
      validZeroes = false;
      return;
    }
  }
  validZeroes = true;
}

void ValidateRange()
{
  foreach (string number in address)
  {
    if (int.Parse(number) > 255)
    {
      validRange = false;
      return;
    }
  }
  validRange = true;
}
