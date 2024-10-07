using System;

// Initial declarations
Random random = new Random();
Console.CursorVisible = false;
int height = Console.WindowHeight - 1;
int width = Console.WindowWidth - 5;
bool shouldExit = false;

// Console position of the player
int playerX = 0;
int playerY = 0;

// Console position of the food
int foodX = 0;
int foodY = 0;

// Available player and food strings
string[] states = { "('-')", "(^-^)", "(X_X)" };
string[] foods = { "@@@@@", "$$$$$", "#####" };

// Array for checking if there s food left
int[] arr = new int[foods[0].Length];

// Current player string displayed in the Console
string player = states[0];

// Index of the current food
int food = 0;

// New var for the optional parameter check
Random rnd = new Random();
int check = rnd.Next(0, 2);

// Check optional parameter for Move()
void CheckOptionalParameter(int value)
{
    if (value == 1)
    {
        Environment.Exit(0);
    }
    else
    {
        return;
    }
}

InitializeGame();
while (!shouldExit)
{
    int speed = 1;

    if (CheckMovementSpeed())
    {
        speed = 3;
    }
    
    if (speed == 1)
    {
        Move(check);
    }
    else
    {
        Move(check, speed);
    }
}

// Returns true if the Terminal was resized 
bool TerminalResized()
{
    return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
}

// Displays random food at a random location
void ShowFood()
{
    // Update food to a random index
    food = random.Next(0, foods.Length);

    // Update food position to a random location
    foodX = random.Next(0, width - player.Length);
    foodY = random.Next(0, height - 1);

    int count = 0;
    for (int i = 0; i < foods[0].Length; i++)
    {
        arr[i] = foodY + count;
        ++count;
    }

    // Display the food at the location
    Console.SetCursorPosition(foodX, foodY);
    Console.Write(foods[food]);
}

// Changes the player to match the food consumed
void ChangePlayer()
{
    player = states[food];
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

// Temporarily stops the player from moving
void FreezePlayer()
{
    System.Threading.Thread.Sleep(1000);
    player = states[0];
}

void AnnounceTerminating()
{
    Console.Clear();
    Console.WriteLine("Console was resized. Program exiting.");
    Thread.Sleep(700);
    shouldExit = true;
    Environment.Exit(0);
}

// Function to determine whether the food is already eaten or not
bool JustAteFood(int playerX, int playerY)
{
    if (playerX == foodX)
    {
        int len = playerY - foodY;

        if (len == 0)
        {
            return true;
        }
        else if (Math.Abs(len) > foods[0].Length - 1)
        {
            return false;
        }
        else if (len < 0)
        {
            int positiveLen = Math.Abs(len);

            for (int i = 0; i < positiveLen; i++)
            {
                arr[i] = 0;
            }
        }
        else
        {
            for (int i = len - 1; i >= 0; i--)
            {
                arr[i] = 0;
            }
        }
    }

    bool complete = true;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != 0)
        {
            complete = false;
        }
    }

    return complete;
}

// Function to check freeze condition
bool CheckFreezeCondition()
{
    if (player == "(X_X)")
    {
        return true;
    }

    return false;
}

// Function to check for increased movement speed
bool CheckMovementSpeed()
{
    if (player == "(^-^)")
    {
        return true;
    }

    return false;
}

// Reads directional input from the Console and moves the player
void Move(int check = 0, int speed = 1)
{
    if (CheckFreezeCondition())
    {
        FreezePlayer();
    }

    int lastX = playerX;
    int lastY = playerY;

    if (TerminalResized())
    {
        AnnounceTerminating();
    }

    var key = Console.ReadKey(true).Key;

    switch (key)
    {
        case ConsoleKey.UpArrow:
            playerY--;
            break;
        case ConsoleKey.DownArrow:
            playerY++;
            break;
        case ConsoleKey.LeftArrow:
            playerX -= speed;
            break;
        case ConsoleKey.RightArrow:
            playerX += speed;
            break;
        case ConsoleKey.Escape:
            shouldExit = true;
            break;
        default:
            CheckOptionalParameter(check);
            break;
    }

    // Clear the characters at the previous position
    Console.SetCursorPosition(lastX, lastY);
    for (int i = 0; i < player.Length; i++)
    {
        Console.Write(" ");
    }

    // Keep player position within the bounds of the Terminal window
    playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
    playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

    if (JustAteFood(playerX, playerY))
    {
        ChangePlayer();
        ShowFood();
    }

    // Draw the player at the new location
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

// Clears the console, displays the food and player
void InitializeGame()
{
    Console.Clear();
    ShowFood();
    Console.SetCursorPosition(0, 0);
    Console.Write(player);
}
