List<string> allowedSigns = ["rock", "paper", "scissors"];

// Console.WriteLine("What's your name?");
// string firstName = Console.ReadLine()!;
// // Console.ReadLine();

// //Console.WriteLine("Hello, " + firstName + "!");
// Console.WriteLine($"Hello, {firstName}!"); // To wyświetla taki sam tekst jak linijka powyżej

// if (firstName == "Snake")
//     Console.WriteLine("Kept waiting, huh?");
// else
//     Console.WriteLine("What's in that box?");

Console.WriteLine("Let's play Rock Paper Scissors, ok?");

Console.WriteLine("Player 1, provide sign (rock/paper/scissors)");
string firstSign = GetCorrectSign();

Console.WriteLine("Let's play Rock Paper Scissors, ok?");
while (true)
{
    string firstSign = GetCorrectSign("Player 1");
    string secondSign = GetRandomSign("Player 2");

    // 1. Znajdź indeks znaku podanego przez drugą osobę -> x
    int secondSignIndex = allowedSigns.IndexOf(secondSign);
    // 2. Wylicz indeks znaku, który wygrywa ze znakiem drugiej osoby -> (x + 1) % length
    int indexOfSignWinningWithSecondSign = (secondSignIndex + 1) % allowedSigns.Count;
    // 3. Znajdź indeks znaku podanego przez pierwszą osobę -> y
    int firstSignIndex = allowedSigns.IndexOf(firstSign);


    if (firstSign.Equals(secondSign, StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("It's a tie!");
    }
    // 4. Sprawdź czy indeks znaku pierwszej osoby jest równy indeksowi znaku wygrywającego
    //    ze znakiem drugiej osoby -> y == (x + 1) % l
    else if (firstSignIndex == indexOfSignWinningWithSecondSign)
    {
        Console.WriteLine("First player won!");
    }
    else
    {
        Console.WriteLine("Second player won!");
    }
}

string GetCorrectSign(string playerName)
{
    Console.WriteLine($"{playerName}, provide sign ({string.Join("/", allowedSigns)})");
    string sign = Console.ReadLine()!;
    // czy podany znak NIE jest jednym z oczekiwanych?
    while (!allowedSigns.Contains(sign))
    {
        // wyświetl ze znak jest niepoprawny
        Console.WriteLine($"Provide correct sign! ({string.Join("/", allowedSigns)})");
        // pozwól poprawić swoje zachowanie (poda ponownie znak)
        sign = Console.ReadLine()!;
    }

    return sign;
}
else
{
    Console.WriteLine("Second player won!");
}

string GetCorrectSign()
{
   Console.WriteLine("Player 1, provide sign (rock/paper/scissors)");
string firstSign = Console.ReadLine()!;
// czy podany znak NIE jest jednym z oczekiwanych?
// if (firstSign != "rock" && firstSign != "paper" && firstSign != "scissors")
while (!(firstSign == "rock" || firstSign == "paper" || firstSign == "scissors"))
{
    // wyświetl ze znak jest niepoprawny
    Console.WriteLine("Provide correct sign! (rock/paper/scissors)");
    // pozwól poprawić swoje zachowanie (poda ponownie znak)
    firstSign = Console.ReadLine()!;
}

return firstSign;
}

// if (firstSign == secondSign)
// {
//     Console.WriteLine("It's a tie!");
// }
// else if ((firstSign == "rock" && secondSign == "scissors")
//     || (firstSign == "paper" && secondSign == "rock")
//     || (firstSign == "scissors" && secondSign == "paper"))
// {
//     Console.WriteLine("First player won!");
// }
// else
// {
//     Console.WriteLine("Second player won!");
// }



string GetRandomSign(string playerName)
{
    int index = Random.Shared.Next(allowedSigns.Count);
    string sign = allowedSigns[index];
    Console.WriteLine($"{playerName} chosen {sign}");
    return sign;
}