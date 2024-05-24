using System;


string userInput;
int parsedNumber = 0;
bool isValidInput = false;

Console.WriteLine("Skriv ett nummer mellan 1 - 10!");
//Körs sålänge använder inte ger ett godkänt input
while (!isValidInput)
{
    userInput = Console.ReadLine();
    //Konverterar en string som användaren ger till ett nummer, och kollar ifall numret är mellan 1 och 10. 
    //Ifall numret inte är mellan 1 - 10 körs loopen om och användaren varnas.
    if (int.TryParse(userInput, out parsedNumber) && parsedNumber >= 1 && parsedNumber <= 10)
    {
        isValidInput = true;
    }
    else
    {
        Console.WriteLine("Ogiltig input. Försök igen och skriv ett nummer mellan 1 och 10.");
    }
}

Console.WriteLine("Du skrev numret " + parsedNumber);
Console.WriteLine("Grattis!");
Console.ReadLine();
