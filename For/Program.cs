// Вид 4. Что-то принимают, что-то возвращают

string Method4(int count, string text)
{
    string result = String.Empty;

    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "a");
Console.WriteLine(res);

// Цикл в цикле

for (int i = 0; i < 10; i++)
{
    for (int j = 0; i < 10; j++)
    {
         Console.WriteLine(i * j);
    }
   // Console.WriteLine();
}