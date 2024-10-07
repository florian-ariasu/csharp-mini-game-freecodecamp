# Challenge-project-Create-methods-in-CSharp

    Starter and Final code for the Challenge project: "Create methods C# console applications" from the Microsoft Learn
collection "Getting started with C#"

<!-- Implementation details -->

    This mini project comes with a starter code, containing the following functions: InitializeGame(),
TerminalResized(), ShowFood(), ChangePlayer(), FreezePlayer() and Move().

    The first task I had was to terminate the game whenever the temrinal window was resized and to add an optional 
parameter to the move function so that when this parameter is enabled, the game will terminate if pressing any 
non-directional key.To achieve this I have created the function AnnounceTerminating() to accomplish the result for 
the terminal window resizing part and for the optional parameter I have created an instance of the Random class so 
to decide whether the optional parameter is 0 or 1. For 1 the game should stop when a non-directional key is 
pressed and for 0 should continue. The second task was to create a function that checks if there is food left and 
if not to display a new food string. Along with this aspect, I had to change the player aspect as well, by calling 
the function ChangePlayer() in the function I have created named JustAteFood() so to meet the requirements. The 
third task s purpose was to check whether the player string is equal to "(X_X)" so to now to freeze the player 
temporarily, therefore I ve created the function CheckFreezeCondition(). Moreover, the task also consisted of the 
case when the player string is equal to "(^-^)" so that I know the player s left and right movement should 
increase or decrease the player s movement speed by 3. Hence, the function I have created CheckMovementSpeed() 
that exactly checks that. These were all the tasks, thanks for reading !

