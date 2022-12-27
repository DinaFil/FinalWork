Console.WriteLine("Введите массив строк через пробел:");
string text = (Console.ReadLine());
string[] collection = text.Split(" ");


void LessThenThreeArray(string[] phrase)
{
string[] newphrase = new string[phrase.Length];
for (int i = 0; i < phrase.Length; i++)
{
if (phrase[i].Length < 4) 
{
newphrase[i] = phrase[i];
Console.Write(phrase[i] + " ");
}
}
}
