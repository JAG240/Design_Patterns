# Design Patterns

This work is based off information found by reading a book called [_Game Design Patterns_](https://gameprogrammingpatterns.com/contents.html)

## Goal
The goal behind this project is to apply some of the knowledge gained while reading the book _Game Design Patterns_ (link above). By creating a project where I can apply this knowledge, I can support my learning style of learning by doing. 
Each design pattern should be used in a reasonable implementation and integrated into a single interaction environment (aka a single playable screen with one game scene). 

## States

### Command
The command pattern widely is used to "buffer" input actions. This can be done for many reasons but, ultimately this buffer to input actions allows the user to log each action and in turn this action can be done, undone, and redone. 
Think of the widely used undo (ctrl + z) command on windows where virtually everything can be undone. In my implementation, the user will click on a pawn then a location for the pawn to be moved to. Then the user can use left arrow key to 
undo the most recent action. Once undone, the user may also use the right arrow key to redo that action.

### Flyweight 
The flyweight pattern is used to reduce repeated information. You can think of this like how a database might use a foreign key to describe a column that hold more information that is repeated (if normalized correctly). 
In my implementation of this pattern, we see the AIClass scriptable object which contains all shared attributes for all pawns. Since unity has the scriptable object technology, we can utilze this to determine factors about each pawn type. 
We created a goblin and human asset file which contains a team, maxHealth, and material (for the purpose of changing pawn's color). Now, if we want any blank pawn to become human or goblin, we simply apply this asset file to their prefab and the state manager logic
will apply the properties to the pawn. 

### Observer 
The observer pattern is used by many technologies today. If you've ever used JavaScript, odds are at some point you've subscribed some logic to an input key or event. This pattern uses this same idea of creating and subscribing events as it becomes more efficient 
than the standard update loop. In my implementation, the user will need to click on the pawn that they would like to move. Once this pawn is clicked, the pawn is now subscribed to an event that will pass the destination. If the pawn is then deselected, or another pawn is
selected in it's place, the pawn will then unsubscribe to the event to receive the destination. 

### State Machine
The state machine pattern is a significant pattern for games and more professional settings alike. In my implementation I used a state machine for each pawn. At any given moment each pawn is either in the Idle, Wait, or Walk state. 
At the idle state, the pawn is simply waiting for the user to click on them with no instructions. Once clicked on, they enter the Wait state which is indicated by the pawn turning red. In this state the pawn is waiting for only 2 instructions, they will either 
receive a destination, or to be deselected. If deselected, the pawn will return to the idle state. If a destination is received, the pawn will update its color to orange to indicate it is in action and move to the destination. Once at the destination,
or very close to it, the pawn will re-enter the idle state. 

## Conclusion 
By using these patterns I was able to easily setup a system that decoupled function between each system. This means that each state pattern does not _require_ another system to work. However, the inputs and actions of each system is exposed to a reasonable degree 
that another system could easily be integrated. The best show of this is the state machine pattern where not only can the user input a destination of each pawn but, the command pattern could input previous destinations to control the pawn's movement. 
