// See https://aka.ms/new-console-template for more information

using StringExtension;

Console.WriteLine("Informe o texto que deseja dividir e prescione ENTER:");
var textToSplit = Console.ReadLine();

Console.WriteLine("Qual o tamanho máximo de cada parte?");
var splitSize = Console.ReadLine();

var splittedText = textToSplit.SplitBy(Convert.ToInt32(splitSize));

Console.WriteLine("Texto depois de dividido:");
Console.WriteLine(string.Join(Environment.NewLine, splittedText));

Console.ReadKey();
