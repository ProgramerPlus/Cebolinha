string texto;

Console.ForegroundColor = (ConsoleColor)2;
Console.WriteLine("--------------Cebolinha--------------");
Console.ResetColor();
Console.WriteLine("Escreva uma frase:");
texto = Console.ReadLine()!;
texto = texto.Replace("rr", "l");
texto = texto.Replace("r", "l");

Console.WriteLine(texto);
