using System.Text.RegularExpressions;

namespace laba_9;

public class SecondTask
{
    // Знайти в тексті будь-які послідовності букв та цифр,
    // в середині яких є великі букви та вставити між ними нижнє підкреслення та маленьку букву.
    // Напр, “MyVar17 = OtherVar + YetAnother2Var” на
    // “my_var17 = other_var + yet_another2_var”.
    // Вивести виправлений текст на екран
    public void Second()
    {
        string inputText = "MyVar17 = OtherVar + YetAnother2Var";

        string correctedText = CorrectText(inputText);

        Console.WriteLine(correctedText);
        
    }
    static string CorrectText(string input)
    {
        string pattern = @"([a-z])([A-Z0-9])";
        string replacement = "$1_$2";
        string correctedText = Regex.Replace(input, pattern, replacement);

        correctedText = correctedText.ToLower();

        return correctedText;
    }
}