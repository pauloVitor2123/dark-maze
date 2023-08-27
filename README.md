# Dark Maze

Dark Maze is a maze game, set in first person, where your focus is to escape as quickly as possible from a procedurally generated maze, which is your main objective. As a secondary objective, we have the score, where the faster the maze is completed, the more points you will earn. You will be dropped at a random point, and the exit that is also at a random point will emit a glow on the player's screen, thus becoming visible if the player approaches.
Our game was made for mobile devices, more specifically the Android system, where the controls are simple, intuitive and touch sensitive, as a mobile device suggests.
The game was made in Unity, a popular game engine, compatible with Windows, MacOS and Linux. The programming language used was C#.

![image](https://github.com/pauloVitor2123/dark-maze/assets/120388301/de182a47-7756-41c5-980a-236c75ac02bd)


## Style
The game style is Puzzle with Suspense. The Dark Maze has a Puzzle dynamic since it is a labyrinth, where the main objective of the player is to find the exit. In addition, the scenario combined with a soundtrack brings suspense to increase the adrenaline and cause some discomfort for the player.

## Target Audience
The game was developed for players who seek challenges of reasoning and memory under pressure, lovers of suspense games and labyrinths.

## The Character

The character has the ability to walk around the setting freely, with a first-person view, he has the intention of finding the way out of the maze, in addition, the character has a torch to improve his visibility in the face of the darkness that surrounds him. map displays

## Camera
The game's camera is designed in first person, where you put yourself in the character's shoes, and your camera movement options are:

#### Horizontal:
The player has the possibility to rotate his camera up to 360º.

#### Vertical:
The player has the possibility to rotate his camera vertically up to 180°.

![image](https://github.com/pauloVitor2123/dark-maze/assets/120388301/7774149f-1f77-4cac-9342-2be1ef3e2a26)


## Score
The scoring system takes into account the time the player takes to find the maze exit and the level he is at.In the easy level the player will start with 200 (two hundred) points, in the medium level he will start with 300 (three hundred) and in the difficult level he will start with 500 (five hundred), all points can reach zero if the timer resets. When there are 3 (three) minutes and 30 (thirty) seconds left on the timer, there will be a decrease in the score. That is, the player will have enough time to find the exit. If the score reaches 0 (zero) points, he will be notified with a game over screen and can leave the game or try again.

## Map
The game's scenario will be rendered randomly through a script, where at each execution of the game a maze with different measures will be created, the dimensions of the maze will be defined according to the difficulty level chosen by the player. Below we have a view of the labyrinth.

![image](https://github.com/pauloVitor2123/dark-maze/assets/120388301/d05afd4a-65bd-439b-907d-4fad46928f0a)

## Ranking
Whoever completes it faster, loses less points, since you start with a certain amount, and it goes down according to your speed in completing the maze, rising in the ranking.
There is also a rule, that with extrapolated time, you will automatically lose, because with that time, your points will reach 0.
When does the game end? When a player finds the end of the map and enters the glowing circle, they go to the ranking screen, and compare themselves to other players.
