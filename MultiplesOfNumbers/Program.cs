
        Console.Write("Enter dividend");
        double dividend = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter divisor");
        double divisor = Convert.ToDouble(Console.ReadLine());

        
        if (dividend % divisor == 0)
            Console.WriteLine("Multiples");
        else
            Console.WriteLine("Not multiples");
       