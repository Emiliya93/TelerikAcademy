using System;

/*
    Problem 11. Bank Account Data

    A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN,
    3 credit card numbers associated with the account.
    Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
*/

class BankAccountData
{
    static void Main()
    {
        string name = "Smiley Vince Mikey";
        decimal balance = 1032.56M;
        string bankName = "Sofia Just Bank";
        string iban = "454s5w54deff6";
        string creditCard1 = "05235649421654";
        string creditCard2 = "26468431248";
        string creditCard3 = "64542172148";

        Console.WriteLine("Bank account data:");
        Console.WriteLine();
        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Available amount of money (balance): {0}", balance);
        Console.WriteLine("Bank name: {0}", bankName);
        Console.WriteLine("IBAN: {0}", iban);
        Console.WriteLine("Credit card numbers:");
        Console.WriteLine("Credit card 1: {0}; card 2: {1}; card3: {2}", creditCard1, creditCard2, creditCard3);
    }
}