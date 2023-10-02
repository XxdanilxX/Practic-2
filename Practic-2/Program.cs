using System.Diagnostics.Metrics;

Console.OutputEncoding = System.Text.Encoding.UTF8;
while (true)
{
    Console.WriteLine("Введіть рядок в якому будуть пропуски та символ '*'.");
    string input1 = Console.ReadLine();
    int indexOfSpace = input1.IndexOf(' ');
    if (indexOfSpace != -1)
    {
        string Space = input1.Substring(indexOfSpace + 1);
        int starCount = Space.Count(c => c == '*');
        Console.WriteLine($"Кількість '*' після першого пропуску: {starCount}");
        break;
    }
    else
    {
        Console.WriteLine("Помилка вводу.");
    }
}
while (true)
{
    Console.WriteLine("Введіть рядок.");
    string input = Console.ReadLine();
    Console.WriteLine("Введіть літеру для заміни.");
    char letter = Convert.ToChar(Console.ReadLine());
    if (letter != ' ' || input != " ")
    {
        string result = input.Replace(letter.ToString(), "???");
        Console.WriteLine($"Результат: {result}");
        break;
    }
    else
    {
        Console.WriteLine("Помилка вводу.");
    }

}
while (true)
{
    Console.WriteLine("Введіть речення.");
    string input = Console.ReadLine();
    try
    {
        if (input != " ")
        {
            string[] words = input.Split(' ');
            foreach (string word in words)
            {

                string newinput = word.Substring(1) + word[0];
                Console.Write($"{newinput} ");
            }
            Console.WriteLine();
            break;
        }
        else
        {
            Console.WriteLine("Помилка вводу.");
        }
    }
    catch { }
}
while (true)
{
    Console.WriteLine("Введіть речення.");
    string input = Console.ReadLine();
    Console.WriteLine("Кількість позицій для зсуву.");
    int k = Convert.ToInt32(Console.ReadLine()); 
    if (k != 0 || input != " ")
    {
        string[] words = input.Split(' ');
        string[] newword = new string[words.Length];
        for (int i = 0; i < words.Length; i++)
        {
            int newIndex = (i + k) % words.Length; 
            newword[newIndex] = words[i]; 
        }
        string newinput = string.Join(" ", newword); 
        Console.WriteLine($"Результат циклічного зсуву: {newinput}");
        break;
    }
    else
    {
        Console.WriteLine("Помилка вводу.");
    }
}