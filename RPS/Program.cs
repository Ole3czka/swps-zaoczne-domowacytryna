// typ nazwa;
// typ nazwa = wartosc;
List<string> allowedSigns = ["rock", "paper", "scissors"];

Console.WriteLine("Let's play Rock Paper Scissors, ok?");

string firstSign = GetCorrectSign("Player 1");
string secondSign = GetCorrectSign("Player 2");

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
// else if ((firstSign == allowedSigns[0] && secondSign == allowedSigns[2])
//     || (firstSign == allowedSigns[1] && secondSign == allowedSigns[0])
//     || (firstSign == allowedSigns[2] && secondSign == allowedSigns[1]))
else if (firstSignIndex == indexOfSignWinningWithSecondSign)
{
    Console.WriteLine("First player won!");
}
else
{
    Console.WriteLine("Second player won!");
}

string GetCorrectSign(string playerName)
{
    // Console.WriteLine($"{playerName}, provide sign ({allowedSigns[0]}/{allowedSigns[1]}/{allowedSigns[2]})");
    Console.WriteLine($"{playerName}, provide sign ({string.Join("/", allowedSigns)})");
    string sign = Console.ReadLine()!;
    // czy podany znak NIE jest jednym z oczekiwanych?
    // while (!(sign == allowedSigns[0] || sign == allowedSigns[1] || sign == allowedSigns[2]))
    while (!allowedSigns.Contains(sign))
    {
        // wyświetl ze znak jest niepoprawny
        Console.WriteLine($"Provide correct sign! ({string.Join("/", allowedSigns)})");
        // pozwól poprawić swoje zachowanie (poda ponownie znak)
        sign = Console.ReadLine()!;
    }

    return sign;
}