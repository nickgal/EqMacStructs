using System.Text;
using System.Text.RegularExpressions;

public static class StringExtensions
{
    // student_name => StudentName
    public static string SnakeCaseToPascalCase(this string str)
    {
        if (str.Equals(str.ToUpper()))
        {
            str = str.ToLower();
        }

        str = str.Replace('_', ' ');
        str = Regex.Replace(str, "([A-Z]+)", " $1");
        str = Regex.Replace(str, @"(\s+)", " ");
        string titleCase = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(str);
        return titleCase.Replace(" ", string.Empty);
    }

    public static string CleanupString(this string str)
    {
        if (str.StartsWith("m_"))
        {
            str = str[2..];
        }

        if (str.EndsWith("_timer"))
        {
            str = str.ToLower();
        }

        var pascalString = str.SnakeCaseToPascalCase();
        if (str.Contains('_') || str.Equals(str.ToLower()))
        {
            return pascalString;
        }

        if (str.Length > 0 && char.IsLower(str[0]))
        {
            var sb = new StringBuilder(str);
            sb[0] = pascalString[0];
            return sb.ToString();
        }

        return str;
    }

    public static string StructString(this string str)
    {
        str = str.CleanupString();
        return I18n.T(str);
    }
}
