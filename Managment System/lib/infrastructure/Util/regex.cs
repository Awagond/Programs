using System.Text.RegularExpressions;

class RegexHelper{
private static string patternPassword = @"(?=.*[0-9])(?=.*[!@#$%^&*])(?=.*[a-z])(?=.*[A-Z])[0-9a-zA-Z!@#$%^&*]{6,}";

private static string patternOther = @"[0-9a-zA-Z!@#$%^&*]{6,}";

public static bool rgxCheckOtherData(string data){
    return Regex.IsMatch(data, patternOther);
}

public static bool rgxCheckRPassword(string data){
    return Regex.IsMatch(data, patternPassword);
}

}