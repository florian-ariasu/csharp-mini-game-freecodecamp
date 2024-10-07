# Challenge-project-Create-methods-in-CSharp

Starter and Final code for the Challenge project: "Create methods C# console applications" from the Microsoft Learn
collection "Getting started with C#"

<!-- Implementation details -->

# Predefined functions
This mini project comes with a starter code, containing the following functions: 

InitializeGame()
TerminalResized()
ShowFood()
ChangePlayer()
FreezePlayer() 
Move()

# Implemented by me
## First task: check terminal window resizing and optional move() function parameter for quitting if any non-directional key was pressed

"The first task I had was to terminate the game whenever the temrinal window was resized and to add an optional 
parameter to the move function so that when this parameter is enabled, the game will terminate if pressing any 
non-directional key.To achieve this I have created the function AnnounceTerminating() to accomplish the result for 
the terminal window resizing part and for the optional parameter I have created an instance of the Random class so 
to decide whether the optional parameter is 0 or 1. For 1 the game should stop when a non-directional key is 
pressed and for 0 should continue."

### Function implemented: void AnnounceTerminating()


## Second task: check whether there is food left, if not display new food string

"The second task was to create a function that checks if there is food left and 
if not to display a new food string. Along with this aspect, I had to change the player s aspect as well, by calling 
the function ChangePlayer(). I have created JustAteFood() so to meet the requirements."

### Function implemented: bool JustAteFood()


## Third task: change movement speed or freeze the player based on the player s appearance

"The third task s purpose was to check whether the player string is equal to "(X_X)" so to know to freeze the player 
temporarily, therefore I ve created the function CheckFreezeCondition(). Moreover, the task also consisted of the 
case when the player string is equal to "(^-^)" so that I know the player s left and right movement speed should 
increase or decrease by 3. Hence, the function I have created CheckMovementSpeed() that exactly checks that."

### Functions implemented: bool CheckMovementSpeed() and bool CheckFreezeCondition()


#### These were all the tasks, thanks for reading !

