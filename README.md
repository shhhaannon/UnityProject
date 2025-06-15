3D Platformer Game
Overview
This is a 3D platformer game developed in Unity where players navigate through a single level, collecting flowers and avoiding hazards such as sharp metal cones and icebergs. The game features a unique win condition system that triggers a victory sequence when the player collects all flowers and reaches the end of the level.

Features
Time-based gameplay with a countdown timer

Flower collection: Players collect flowers scattered across the level to progress

Hazards: Sharp metal cones and icebergs that damage the player on contact

Victory sequence: Activated when all flowers are collected and the player reaches the end of the level

Pause menu functionality

Dynamic background music system

Win condition triggers when all flowers are collected

Technical Implementation
The game is built using Unity's component-based architecture, with several key scripts handling different aspects of gameplay:

WinTrigger.cs
This script manages the win condition of the game. When the player collects all flowers and reaches the end of the level, it:

Stops the main gameplay timer

Activates the victory UI canvas

Disables the pause menu

Switches background music to the victory theme

Freezes the game time

PlayerController.cs
Handles player movement and interaction with the game world, including flower collection and hazard detection.

Timer.cs
Manages the game's countdown timer and time-based mechanics.

PauseMenu.cs
Controls the game's pause functionality and menu system.

Hazard.cs
Manages collision with hazards like sharp metal cones and icebergs. When the player collides with these hazards, the player takes damage or is reset to a checkpoint.

Audio System
The game features a dynamic audio system with two main tracks:

Cheery Monday BGM: Main gameplay background music

Victory Piano BGM: Special victory theme that plays upon collecting all flowers and completing the level

Setup Instructions
Open the project in Unity (version 2020.3 or later recommended)

Open the main scene from the Scenes folder

Press Play to test the game

Use WASD for movement and Space for jumping

Collect all the flowers in the level and reach the end to win!

Development Notes
This project was developed as a learning exercise in Unity game development, focusing on:

Component-based architecture

Event-driven programming

Audio system implementation

UI/UX design

Game state management

Collision detection with hazards

Usage
The game begins in the main menu where you can:

Select the available level

Modify your settings in the Options menu

Exit the game

In the Options menu, you can change:
Volume of the background music

Volume of the sound effects

Invert the movement of the camera

Game Controls:
Move: Arrow keys or WASD

Jump: Space Bar

Camera Control: Hold right-click and move mouse

Pause: Esc key

To complete the level, collect all the flowers scattered across the terrain, and avoid the sharp metal cones and icebergs. Once you have all the flowers, head to the end of the level to trigger the victory sequence and see your completion time.



