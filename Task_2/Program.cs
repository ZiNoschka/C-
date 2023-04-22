Console.WriteLine("Введите первое число:");
        string? astr = Console.ReadLine();
        if (astr =="" | astr == null ) astr = "0";   
        int a = int.Parse(astr!);

        Console.WriteLine("Введите второе число:");       
        string? bstr = Console.ReadLine();
        if (bstr == "" | bstr == null ) bstr = "0"; 
        int b = int.Parse(bstr!);

        if (a > b) {
            Console.WriteLine($"Максимальное число: {a}");
            Console.WriteLine($"Минимальное число: {b}");
        }
        else {
            Console.WriteLine($"Максимальное число: {b}");
            Console.WriteLine($"Минимальное число: {a}");
        }