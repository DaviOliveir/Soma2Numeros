int primeironumero, segundonumero, soma;

Console.WriteLine("soma dos numeros.\n");

Console.Write("digite seu priemiro numero: ");
primeironumero = Convert.ToInt32(Console.ReadLine());

Console.Write("digite seu segundo numero: ");
segundonumero = Convert.ToInt32(Console.ReadLine());

soma = primeironumero + segundonumero;

Console.WriteLine($"\nsoma: {soma}");