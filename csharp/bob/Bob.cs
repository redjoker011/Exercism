using System;
using System.Text.RegularExpressions;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        string normalizedStatement = statement.Trim();

        if (string.IsNullOrEmpty(normalizedStatement))
        {
            return "Fine. Be that way!";
        }
        else if (normalizedStatement.IsYell() && normalizedStatement.IsQuestion())
        {
            return "Calm down, I know what I'm doing!";
        }
        else if (normalizedStatement.IsQuestion())
        {
            return "Sure.";
        }
        else if (normalizedStatement.IsYell())
        {
            return "Whoa, chill out!";
        }
        else
        {
            return "Whatever.";
        }
    }

    public static bool IsQuestion(this string message)
    {
        return message.EndsWith("?");
    }

    public static bool IsYell(this string message)
    {
        return message == message.ToUpper() && message.Any(char.IsLetter);
    }
}
