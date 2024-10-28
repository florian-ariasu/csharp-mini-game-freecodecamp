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

"The second task was to create a function that checks if there is food left and 
if not to display a new food string. Along with this aspect, I had to change the player s aspect as well, by calling 
the function ChangePlayer(). I have created JustAteFood() so to meet the requirements."

#### Function implemented: 
```csharp
bool JustAteFood();
```


### Third task: change movement speed or freeze the player based on the player s appearance

"The third task s purpose was to check whether the player string is equal to "(X_X)" so to know to freeze the player 
temporarily, therefore I ve created the function CheckFreezeCondition(). Moreover, the task also consisted of the 
case when the player string is equal to "(^-^)" so that I know the player s left and right movement speed should 
increase or decrease by 3. Hence, the function I have created CheckMovementSpeed() that exactly checks that."

#### Functions implemented:
```csharp
bool CheckMovementSpeed();
bool CheckFreezeCondition();
```

> [!TIP]
> Thanks for reading! Practice daily and have fun!

