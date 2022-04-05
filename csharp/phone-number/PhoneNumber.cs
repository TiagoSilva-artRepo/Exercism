using System;
using System.Linq;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        string NANPPattern = @"^(1|\+1)?[-.]?\s*[\(]?[2-9]\d{2}\)?[-.]?\s*[2-9]\d{2}[-.]?\s*\d{4}\b";
        Regex regex = new Regex(NANPPattern);

        if(!regex.Match(phoneNumber).Success) throw new ArgumentException("Invalid phone number.");
        
        phoneNumber= Regex.Replace(phoneNumber, @"\D", "");
        if (phoneNumber.StartsWith("1")) phoneNumber = phoneNumber.Remove(0, 1);
        return phoneNumber;
    }
}