This is a solution for keeping track of branching game states.
Create Quest Nodes as scriptable objects and then view them and connect/change them in the graph view.

Other objects can then listen to changes in said quest nodes and adjust themselves accordingly both in editor and runtime.
This allows for faster testing and debugging as one can easily skip to a desired state of the game with a single click.
