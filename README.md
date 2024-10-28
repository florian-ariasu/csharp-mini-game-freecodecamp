# Challenge-project-Create-methods-in-CSharp
<br>

> [!NOTE]
> Starter and Final code for the Challenge project: "Create methods C# console applications" from the Microsoft Learn
> collection "Getting started with C#"

<!-- Implementation details -->

## Predefined functions

This mini project comes with a starter code, containing the following functions: 
```csharp
void InitializeGame();
bool TerminalResized();
void ShowFood();
void ChangePlayer();
void FreezePlayer();
void Move();
```

> [!IMPORTANT]
> Move() function has 2 optional parameters `check` and `speed` for tasks 1 and 3.
> If I call Move() without any parameters, the default ones will be used.


## Implemented by me

### First task

- **Game Termination**: The game should end if the terminal window is resized.
- **Optional Parameter in Move Function**: I added an optional parameter to `Move()` that stops the game when any non-directional key is pressed.
  
To achieve these, I:
- Created a function called `AnnounceTerminating()` for the resizing condition.
- Used an instance of the `Random` class to decide the optional parameter's value (1 to stop the game, 0 to continue).

#### Function implemented: 
```csharp
void AnnounceTerminating();
```

### Second task

- **Food String Update**: Update the food if there's nothing left.
- **Change Player's Appearance**: Update the player's appearance by calling the `ChangePlayer()` function

#### Function implemented: 
```csharp
bool JustAteFood();
```

### Third task

- **Freeze the player temporarily if his appearance is `(X_X)`, therefore I have created the function `CheckFreezeCondition()`**
- **Increase player's speed to left/right by 3 based on this exact appearance `(^-^)`, therefore I have created 
the `CheckMovementSpeed()` function**

#### Functions implemented:
```csharp
bool CheckMovementSpeed();
bool CheckFreezeCondition();
```

> [!TIP]
> Thanks for reading! Practice daily and have fun!

