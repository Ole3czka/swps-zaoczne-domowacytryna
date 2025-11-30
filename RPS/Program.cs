// // See https://aka.ms/new-console-template for more information

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

    Console.WriteLine("Player 2, provide sign (rock/paper/scissors)");
string secondSign = Console.ReadLine()!;

if (firstSign.Equals(secondSign, StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("It's a tie!");
}
else if ((firstSign == "rock" && secondSign == "scissors")
    || (firstSign == "paper" && secondSign == "rock")
    || (firstSign == "scissors" && secondSign == "paper"))
{
    Console.WriteLine("First player won!");
}
else
{
    Console.WriteLine("Second player won!");
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



// else if (firstSign == "rock" && secondSign == "scissors")
// {
//     Console.WriteLine("First player won!");
// }
// else if (firstSign == "paper" && secondSign == "rock")
// {
//     Console.WriteLine("First player won!");
// }
// else if (firstSign == "scissors" && secondSign == "paper")
// {
//     Console.WriteLine("First player won!");
// }


// else
// {
//     if (firstSign == "rock")
//     {
//         if (secondSign == "scissors")
//         {
//             Console.WriteLine("First player won!");
//         }
//         else
//         {
//             Console.WriteLine("Second player won!");
//         }
//     }
// }
