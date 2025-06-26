// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// this is just to test cyclomatic complexity scanning during build.
for (int i = 0; i < 100; i++)
{
    if (i % 6 == 0)
    {
        while (i % 6 == 0)
        {
            i++;
        }
    }
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    else
    {
        var y = i switch
        {
            1 => "one",
            2 => "two",
            3 => "three",
            4 => "four",
            _ => "" switch
            {
                "" => "empty",
                _ => "default"
            }
        };
    }
}