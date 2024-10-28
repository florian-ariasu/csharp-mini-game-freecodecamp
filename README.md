# Challenge-project-Create-methods-in-CSharp

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

## Implemented by me

### First task: check terminal window resizing and optional move() function parameter for quitting if any non-directional key was pressed

- **Game Termination**: The game should end if the terminal window is resized.
- **Optional Parameter in Move Function**: I added an optional parameter to `Move()` that stops the game when any non-directional key is pressed.
  
To achieve these, I:
- Created a function called `AnnounceTerminating()` for the resizing condition.
- Used an instance of the `Random` class to decide the optional parameter's value (1 to stop the game, 0 to continue).

#### Function implemented: 
```csharp
void AnnounceTerminating();
```

### Second task: check whether there is food left, if not display new food string

- **Food String Update**: Update the food if there's nothing left.
- **Change Player's Appearance**: Update the player's appearance by calling the `ChangePlayer()`

#### Function implemented: 
```csharp
bool JustAteFood();
```

### Third task: change movement speed or freeze the player based on the player's appearance

- **Freeze the player temporarily if his appearance is `(X_X)`, therefore I have created the function `CheckFreezeCondition()`**
- **Increase player's speed to left/right by 3 based on this exact appearance `(^-^)`, therefore I have created 
`CheckMovementSpeed()`**
#### Functions implemented:
```csharp
bool CheckMovementSpeed();
bool CheckFreezeCondition();
```

> [!TIP]
> Thanks for reading! Practice daily and have fun!

