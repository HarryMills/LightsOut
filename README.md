# Lights Out Game

Lights Out is a puzzle game consisting of an n x n grid of lights, in this implementation it is 5 x 5. At the beginning of the game, a random number of lights between 1 and 10 are switched on. When a light is pressed, this light and the four adjacent lights are toggled, i.e., they are switched on if they were off and switched off otherwise. The purpose of the game is to switch all the lights off. 

![Image from Wikipedia.](https://upload.wikimedia.org/wikipedia/commons/thumb/a/a9/LightsOutIllustration.svg/400px-LightsOutIllustration.svg.png)

This has been implemented in the .Net environment in C#. The game starts with a random number of lights on (between 1 and 10). The game stops when the user has turned off all of the lights or gives up. 

Code has been fully commented to explain every part of the source code. 

Unit testing has been completed and can be found within the Lights Out Test project. Testing covers the main functionality of the program. 
