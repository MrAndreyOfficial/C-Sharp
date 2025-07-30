const int minNumber = 0;
const int maxNumber = 100;

int number = GenerateNumber(minNumber, maxNumber);

int attempts = 3;

bool isInGame = true;

while (isInGame)
{
    WriteTip($"Attempts: {attempts}\n");

    WriteTip($"Enter your number between {minNumber} and {maxNumber}: ");
    var userNumber = Console.ReadLine();

    if (int.TryParse(userNumber, out int genNumber))
    {
        if (genNumber == number)
        {
            WriteTip("You won!\nContinue? Y/N: ");
            char choice = char.Parse(Console.ReadLine()!);

            if (choice != 'Y' && choice != 'y')
                StopGame();

            ResetGame();
            number = GenerateNumber(minNumber, maxNumber);
        }
        else
        {
            WriteTip("Wrong!\n");
            attempts--;
        }

        if (attempts == 0)
        {
            WriteTip("You lose! Continue? Y/N: ");

            var choice = Console.ReadLine();

            if (choice != "Y" && choice != "y")
                StopGame();

            ResetGame();

            number = GenerateNumber(minNumber, maxNumber);
        }

        continue;
    }

    WriteTip("Enter an integer\n");
}

void ResetGame() => attempts = 3;
void StopGame() => isInGame = false;

void WriteTip(string message) => Console.Write(message);
int GenerateNumber(int min, int max) => new Random().Next(min, max + 1);
