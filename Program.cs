
#region Part A — Project & Structure
/*
 .csproj:-
 ---------
 ده ملف إعدادات المشروع، وبيحتوي على إعدادات المشروع الأساسية
 زي نوع الـ Output وإصدار الـ .NET المستخدم.

<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>  // Executable application
    <TargetFramework>net10.0</TargetFramework> //  المشروع ده يشتغل ويتبنى باستخدام .NET 10.
    <ImplicitUsings>enable</ImplicitUsings> // زي using system; .NET بيضيف مجموعة من  common namespaces تلقائيًا.
    <Nullable>enable</Nullable> //معناها  Nullable Reference Types متفعلة.
  </PropertyGroup>

</Project>


 Program.cs:-
 -------------
 ده الملف الأساسي اللي بنكتب فيه كود ال C# الخاص بالبرنامج.

 obj/:-
 ------
 ده فولدر بيحتوي على الملفات المؤقتة وال Intermediate Files
 اللي بيستخدمها .NET أثناء عملية ال Build.

 bin/:-
 ------
 ده فولدر بيحتوي على الملفات الناتجة بعد عملية ال Build
 زي ال DLL والملفات المطلوبة لتشغيل البرنامج.

 File-scoped namespace:-
 -----------------------
 ال File-scoped namespace بيخلينا نكتب الـ namespace من غير { }
 وده بيشيل مستوى من ال indentation ويخلي الكود أبسط في الشكل.

 Solution format:-
 ------------------
 المشروع ده بيستخدم ال .slnx وهو الـ Solution Format الأحدث.
 من مميزات ال .sln القديم إنه متوافق بشكل أفضل مع الأدوات والبيئات القديمة.
*/
#endregion


namespace CSharpBasicsAssignment;

class Program
{
    static void Main()
    {
        RunTypesDemo();

        #region Part C — Value vs. Reference Types 
        // Experiment 1 — struct copy semantics
        Point p1 = new Point { X = 1, Y = 2 };
        Point p2 = p1;
        p2.X = 99;
        Console.WriteLine($"p1: X = {p1.X}, Y = {p1.Y}");
        Console.WriteLine($"p2: X = {p2.X}, Y = {p2.Y}");

        // Experiment 2 — Experiment 2 — class reference semantics (Order class)
        Order o1 = new Order
        {
            OrderId = 1001,
            CustomerName = "Mohamed",
            Quantity = 5,
            UnitPrice = 100m,
            TotalPrice = 0m,
            IsPaid = false,
            DiscountPercent = 10,
            ShippingCity = "Alexandria",
            Priority = 'H',
            ItemCode = 123456789
        };

        Order o2 = o1;
        Console.WriteLine(o1.OrderId);
        Console.WriteLine(o2.OrderId);

        #endregion
    }

    #region Part B — Variables, Types & Casting
    /// <summary>
    /// Demonstrates various C# types, conversions, and operations.
    /// </summary>
    /// 
    static void RunTypesDemo()
    {
        // 1. Different types

        int age = 25;
        long population = 1000000;
        double height = 175.5;
        decimal price = 99.99m;
        bool isActive = true;
        char grade = 'A';
        string name = "Mohamed";
        var country = "Egypt";

        Console.WriteLine($"int: {age}, Type: {age.GetType()}");
        Console.WriteLine($"long: {population}, Type: {population.GetType()}");
        Console.WriteLine($"double: {height}, Type: {height.GetType()}");
        Console.WriteLine($"decimal: {price}, Type: {price.GetType()}");
        Console.WriteLine($"bool: {isActive}, Type: {isActive.GetType()}");
        Console.WriteLine($"char: {grade}, Type: {grade.GetType()}");
        Console.WriteLine($"string: {name}, Type: {name.GetType()}");
        Console.WriteLine($"var: {country}, Type: {country.GetType()}");


        // 2. Implicit conversion

        int number = 100;
        long bigNumber = number;

        char letter = 'A';
        int letterNumber = letter;

        Console.WriteLine($"int to long: {bigNumber}");
        Console.WriteLine($"char to int: {letterNumber}");


        // 3. Explicit conversion

        double value = 9.8;

        int result1 = (int)value;
        int result2 = Convert.ToInt32(value);

        Console.WriteLine($"(int) conversion: {result1}");
        Console.WriteLine($"Convert.ToInt32: {result2}");


        // 4. Integer division

        int division1 = 5 / 2;
        double division2 = 5.0 / 2;

        Console.WriteLine($"5 / 2 = {division1}");
        Console.WriteLine($"5.0 / 2 = {division2}");


        // 5. Boxing / Unboxing

        int originalNumber = 50;

        object boxedNumber = originalNumber; // Boxing
        Console.WriteLine($"After boxing: {boxedNumber}");

        int unboxedNumber = (int)boxedNumber; // Unboxing
        Console.WriteLine($"After unboxing: {unboxedNumber}");


        // 6. Parsing

        string validText = "42";
        int parsedNumber = int.Parse(validText);

        Console.WriteLine($"Parsed number: {parsedNumber}");

        string text = "abc";

        if (int.TryParse(text, out int tryResult))
        {
            Console.WriteLine($"TryParse result: {tryResult}");
        }
        else
        {
            Console.WriteLine("TryParse failed: 'abc' is not a valid integer.");
        }


        // 7. float to decimal

        float floatNumber = 10.5f;

        decimal decimalNumber = (decimal)floatNumber;

        Console.WriteLine($"float to decimal: {decimalNumber}");
    }
    #endregion
}

