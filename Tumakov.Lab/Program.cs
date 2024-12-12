public class Program
{
    static void Main(string[] args)
    {
        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
       
    }
    public static void Task1()
    {
        Console.WriteLine("\n Упражнение 8.1 В класс банковский счет, созданный в упражнениях 7.1- 7.3 добавить\r\nметод, который переводит деньги с одного счета на другой. У метода два параметра: ссылка\r\nна объект класса банковский счет откуда снимаются деньги, второй параметр – сумма.");
        BankAccount account1 = new BankAccount("Сберегательный");
        BankAccount account2 = new BankAccount("Текущий");

        account1.Deposit(1000);
        account2.Deposit(500);

        BankAccount.Transfer(account1, account2, 300);

        Console.WriteLine($"Баланс счета 1: {account1.GetBalance()}");
        Console.WriteLine($"Баланс счета 2: {account2.GetBalance()}");
    }

    public static void Task2()
    {
        Console.WriteLine("\nУпражнение 8.2 Реализовать метод, который в качестве входного параметра принимает\r\nстроку string, возвращает строку типа string, буквы в которой идут в обратном порядке.\r\nПротестировать метод.");

        string line = "у пожилого";
        Console.WriteLine($"Исходная строка: {line}");
        Console.WriteLine($"Перевернутая строка: {StringReverse(line)}");
    }

    static string StringReverse(string line)
    {
       
        string reversed = string.Empty;

       
        for (int i = line.Length - 1; i >= 0; i--)
        {
            reversed += line[i]; 
        }

        return reversed; 
    }

    public static void Task3()
    {
        Console.WriteLine("\nУпражнение 8.3 Написать программу, которая спрашивает у пользователя имя файла. Если\r\nтакого файла не существует, то программа выдает пользователю сообщение и заканчивает\r\nработу, иначе в выходной файл записывается содержимое исходного файла, но заглавными\r\nбуквами.");
        Console.WriteLine("Введите имя файла для чтения (с расширением):");
        string inputFileName = Console.ReadLine();

       
        if (!File.Exists(inputFileName))
        {
            Console.WriteLine("Файл не найден. Программа завершает работу.");
            return; 
        }

        string outputFileName = "output.txt"; 

        try
        {
           
            string content = File.ReadAllText(inputFileName);

           
            string upperContent = content.ToUpper();

           
            File.WriteAllText(outputFileName, upperContent);

            Console.WriteLine($"Содержимое файла '{inputFileName}' было успешно записано в '{outputFileName}' в заглавных буквах.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }

    }

    public static void Task4()
    {
        Console.WriteLine("\nУпражнение 8.4 Реализовать метод, который проверяет реализует ли входной параметр\r\nметода интерфейс System.IFormattable. Использовать оператор is и as. (Интерфейс\r\nIFormattable обеспечивает функциональные возможности форматирования значения объекта\r\nв строковое представление.)\n\n");

       
        int number = 42;
        double pi = 3.14159;
        string text = "Hello, World!";
        DateTime dateTime = DateTime.Now;

       
        CheckIfIFormattable(number);
        CheckIfIFormattable(pi);
        CheckIfIFormattable(text);
        CheckIfIFormattable(dateTime);
    }

    static void CheckIfIFormattable(object obj)
    {
         // используем оператор is для проверки интерфейса
        if (obj is IFormattable formattable)
        {
            Console.WriteLine($"Объект {obj} реализует интерфейс IFormattable.");
            // пример форматирования
            string formatted = formattable.ToString(null, null); // null использовать стандартный формат
            Console.WriteLine($"Форматированное представление: {formatted}");
        }
        else
        {
            Console.WriteLine($"Объект {obj} не реализует интерфейс IFormattable.");
        }
    }

    public static void Task5()
    {
       Console.WriteLine("\n\nДомашнее задание 8.2 Список песен. В методе Main создать список из четырех песен. В\r\nцикле вывести информацию о каждой песне. Сравнить между собой первую и вторую\r\nпесню в списке. Песня представляет собой класс с методами для заполнения каждого из\r\nполей, методом вывода данных о песне на печать, методом, который сравнивает между\r\nсобой два объекта.");
        List<Song> songs = new List<Song>();

       
        for (int i = 0; i < 4; i++)
        {
            Song song = new Song();
            Console.WriteLine($"Введите название песни {i + 1}:");
            song.SetName(Console.ReadLine());

            Console.WriteLine($"Введите автора песни {i + 1}:");
            song.SetAuthor(Console.ReadLine());

            songs.Add(song);
        }

        
        Console.WriteLine("\nСписок песен:");
        foreach (var song in songs)
        {
            Console.WriteLine(song.Title());
        }

      
        if (songs.Count >= 2)
        {
            bool areEqual = songs[0].Equals(songs[1]);
            if (areEqual)
            {
                Console.WriteLine("\nПервая и вторая песни одинаковые.");
            }
            else
            {
                Console.WriteLine("\nПервая и вторая песни разные.");
            }
        }
        else
        {
            Console.WriteLine("\nНедостаточно песен для сравнения.");
        }

        Console.ReadLine(); 
    }

  
}
