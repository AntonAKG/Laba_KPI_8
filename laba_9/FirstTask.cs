namespace laba_9;

public class FirstTask
{
    public void First()
        // Ввести прізвище, ім'я та по батькові в одну строку.
         // Вивести інформацію чи починається хоча б одне слово з літери М. Всі букви і в імені продублювати.
        // Вивести прізвище та кількість букв в імені.
        // Вивести ім'я в зворотному порядку.
        // Вивести прізвище по одній букві в стовпчик.

    {
        Console.Write("Input Name: ");
        var name = Console.ReadLine();


        Console.Write("Input surname: ");
        var surname = Console.ReadLine();


        Console.Write("Input patronymic: ");
        var patronymic = Console.ReadLine();

        Dictionary<string, string> User = new Dictionary<string, string>();

        User.Add("name", name);
        User.Add("surname", surname);
        User.Add("patronymic", patronymic);

        Console.WriteLine(User);


        // Ввести прізвище, ім'я та по батькові в одну строку.
        Console.WriteLine($"{surname} {name} {patronymic}");

        // Вивести інформацію чи починається хоча б одне слово з літери М
        if (name.ToUpper().StartsWith("M") || surname.ToUpper().StartsWith("M") || patronymic.ToUpper().StartsWith("M"))
        {
            Console.WriteLine("some word starts with M");
        }

        // Всі букви і в імені продублювати
        DoubleLetterI(User);

        // Вивести прізвище та кількість букв в імені.
        PrintSurnameCountLetter(surname, name);

        // Вивести ім'я в зворотному порядку.
        Console.WriteLine($"reverse name: {ReverseName((name))}");

        // Вивести прізвище по одній букві в стовпчик.
        PrintSurnameByColumn($"{surname}");
    }


    static void DoubleLetterI(Dictionary<string, string> User)
    {
        foreach (var (key, value) in User)
        {
            string result = "";

            foreach (var letter in value)
            {
                if (letter == 'I' || letter == 'i')
                {
                    result += letter.ToString() + letter.ToString();
                }

                else
                {
                    result += letter.ToString();
                }
            }

            Console.WriteLine(result);
        }
    }

    static void PrintSurnameCountLetter(string surname, string name)
    {
        Console.WriteLine($"{surname}");

        int count = 0;

        foreach (var letter in name)
        {
            if (char.IsLetter(letter))
            {
                count++;
            }
        }

        Console.WriteLine($"count letter in name: {count}");
    }

    static string ReverseName(string name)
    {
        string reversedName = "";

        for (int i = name.Length - 1; i >= 0; i--)
        {
            reversedName += name[i];
        }

        return reversedName;
    }

    static void PrintSurnameByColumn(string surname)
    {
        foreach (var letter in surname)
        {
            Console.WriteLine(letter);
        }
    }
    
}