Mini-Project
Project Name: Witch Ducktor

Overview of the Game:
This Project was inspired by two games: ‘Animal Crossing’ and ‘Strange Horticulture’. The visual aesthetic was inspired by the cuteness observed in ‘Animal Crossing’ featuring a central character, a cute duck, navigating a cute environment. Gameplay mechanics draw inspiration from 'Strange Horticulture' emphasizing the identification and collection of plants. The plants were important to further the plot, which I had envisioned. The player wakes up on an Island and controls the character to explore their surroundings. A central objective slowly emerges: They need to find the ingredients to make an anti-duck potion, to restore the character to its original form—a witch. The genre of the game is a puzzle game. 
The main parts of the game are:
•	Player – Duck, moved with the keyboard WASD or arrow keys
•	Camera – Is attached to the player and controlled with Cinemachine to follow the player. 
•	Potion items – Cactus, Roses and Mushrooms. When “picked up” a counter goes up, maxing and the game object is immediately destroyed.
•	Map – The map is in the house on the first island, and from there the player can travel by clicking on the UI. 
•	3 Islands – Each Island contains a required ingredient. They are on different scenes and can be traveled to via the map.
•	Cauldron – The Cauldron is where the potion is made, but it is only possible to make the potion if all the ingredients are found. 
Game features:
•	The game contains different audio sources. In the background plays a chill lo-fi soundtrack and sounds of waves, to create ambience. It also contains sounds of footsteps when the player is walking and a sound of a door when entering the house, contributing to the immersion of the game.
•	The Things the player can interact with in the 3d world are highlighted with a white outline, which was done with a tool found in the assets store called: Quick Outline. After downloading the tool, a script was provided, which could then be attached to the object that needed to be highlighted. 
•	Most scenes were rendered in Perspective projection, but the scene inside the house was rendered in orthographic perspective.
•	The particle system was utilized to make the cauldron seem like it bubbles.
Project Parts:
•	Scripts:
o	Movement – Used to move the player around, rotate the player to face the direction it is walking and for playing walking audio when walking.
o	MapScript – Used to load scenes when clicking on islands on the map.
o	HouseDoor – Used to load the InsideHouse scene, when the player collides with the door.
o	LeaveHouse – Used to multiple things. It was first made for leaving the house(hence the name) when clicking on it with the mouse using raycast, but has since been the script where most things that needed raycasting was written.
o	BackgroundSound – Used to make the background audio play only once and not be destroyed when loading a new scene.
o	CollectedItems – Used to keep count of how many ingredients are found. It also makes sure that the game object it is attached to is not destroyed when loading a new scene and only instantiated once. When all items have been found and the count has reached 3, the script sets a game object in the CauldronCanvas to true, revealing a button to make the potion.
o	AddedItems is the script that increments the count in the CollectedItems script, using raycast and identifying and destroying the ingredient’s game object after collecting them.
•	Models & Prefabs:
o	Duck model from https://kaylousberg.itch.io/kay-kit-mini-game-variety-pack
o	Candles and road tiles from https://kaylousberg.itch.io/kaykit-spooktober 
o	2D assets (exit button) from https://craftpix.net/download/34/
o	Other 2d assets from https://crusenho.itch.io/complete-gui-essential-pack 
o	Book from https://poly.pizza/m/FsCIGEfTEs
o	Map from https://poly.pizza/m/4hvGyOso598 
o	Crops from https://quaternius.com/packs/ultimatecrops.html 
o	Other models from https://kenney.nl/assets/category:3D?sort=update
•	Audio
o	Background audio from https://www.youtube.com/watch?v=h5JiF3YPs54&t=649s 
o	Bubble audio from https://freesound.org/people/newlocknew/sounds/581417/ 
o	Wave Audio from https://freesound.org/people/mmiron/sounds/243953/
o	Door audio from https://freesound.org/people/angelkunev/sounds/519065/ 
o	Walking audio from https://freesound.org/people/dragonmin/sounds/554592/ 
•	Scenes:
o	SampleScene – The main scene on the island with the house.
o	InsideHouse
o	MountainIsland
o	Roses
•	Testing:
o	Game was tested on Windows and Linux, game cannot be currently played on a mobile platform

Used Resources
•	3D Tilemapping in Unity - https://www.youtube.com/watch?v=ulFc6p3hQzQ 
•	Making the camera follow the player using cinemachine - https://www.youtube.com/watch?v=Z2KmfduirfU 
•	General stuff - https://discussions.unity.com/ 
•	Questions - https://chat.openai.com/ 
