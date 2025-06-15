# 3D Platformer Game

## Overview
This is a 3D platformer game developed in Unity where players navigate through levels, collecting items and racing against time. The game features a unique win condition system that triggers a victory sequence when the player reaches the end of each level.

## Features
- Time-based gameplay with a countdown timer
- Victory sequence with special effects and music
- Pause menu functionality
- Dynamic background music system
- Win condition triggers
- Player movement and controls

## Technical Implementation
The game is built using Unity's component-based architecture, with several key scripts handling different aspects of gameplay:

### WinTrigger.cs
This script manages the win condition of the game. When the player enters a designated trigger zone, it:
- Stops the main gameplay timer
- Activates the victory UI canvas
- Disables the pause menu
- Switches background music to victory theme
- Freezes the game time

### PlayerController.cs
Handles player movement and interaction with the game world.

### Timer.cs
Manages the game's countdown timer and time-based mechanics.

### PauseMenu.cs
Controls the game's pause functionality and menu system.

## Audio System
The game features a dynamic audio system with two main tracks:
- Cheery Monday BGM: Main gameplay background music
- Victory Piano BGM: Special victory theme that plays upon level completion

## Setup Instructions
1. Open the project in Unity (version 2020.3 or later recommended)
2. Open the main scene from the Scenes folder
3. Press Play to test the game
4. Use WASD for movement and Space for jumping

## Development Notes
This project was developed as a learning exercise in Unity game development, focusing on:
- Component-based architecture
- Event-driven programming
- Audio system implementation
- UI/UX design
- Game state management

## Usage
The game begins in the main menu where you can select level **1**, **2**, or **3**, modify your settings in the **Options** menu, or **Exit** the game.

In the Options menu, you can change:
- Volume of the background music
- Volume of the sound effects
- Invert the movement of the camera

### Game Controls:
- Move: Arrow keys or WASD
- Jump: Space Bar
- Camera Control: Hold right-click and move mouse
- Pause: Esc key

To complete each level, collide with the sea horse flag to trigger the victory sequence and see your completion time.

# Platformer Videogame

## Description

Platform video games, or simply platformers, are a genre of video games characterized by having to walk, run, jump, or climb on a series of platforms and cliffs, with enemies, while collecting objects to complete the game. This repository contains the source code for a simple 3-level 3D platformer.

### 3D Platformer Game Overview
This is a 3D platformer game developed in Unity where players navigate through a single level, collecting flowers and avoiding hazards such as sharp metal cones and icebergs. The game features a unique win condition system that triggers a victory sequence when the player collects all flowers and reaches the end of the level.

### Features
- Time-based gameplay with a countdown timer.
- **Flower collection**: Players collect flowers scattered across the level to progress.
- **Hazards**: Sharp metal cones and icebergs that damage the player on contact.
- **Health system**: Players have a health bar that decreases when colliding with hazards.
- **Victory sequence**: Activated when all flowers are collected and the player reaches the end of the level.
- Pause menu functionality.
- Dynamic background music system.
- Win condition triggers when all flowers are collected.

### Technical Implementation
The game is built using Unity's component-based architecture, with several key scripts handling different aspects of gameplay:

- **WinTrigger.cs**: Manages the win condition of the game. When the player collects all flowers and reaches the end of the level, it:
  - Stops the main gameplay timer.
  - Activates the victory UI canvas.
  - Disables the pause menu.
  - Switches background music to the victory theme.
  - Freezes the game time.

- **PlayerController.cs**: Handles player movement and interaction with the game world, including flower collection and hazard detection.

- **PlayerHazard.cs**: Manages the player's health system and applies damage when the player collides with hazards (sharp metal cones and icebergs).

- **Hazard.cs**: Detects when the player collides with hazards and applies damage over time, adjusting the player's health accordingly.

- **Timer.cs**: Manages the game's countdown timer and time-based mechanics.

- **PauseMenu.cs**: Controls the game's pause functionality and menu system.

### Audio System
The game features a dynamic audio system with two main tracks:
- **Cheery Monday BGM**: Main gameplay background music.
- **Victory Piano BGM**: Special victory theme that plays upon collecting all flowers and completing the level.

### Hazard and Health System
- **Hazards**: The game includes sharp metal cones and icebergs scattered throughout the level. These objects act as hazards that will damage the player on contact. Players need to avoid them while navigating through the level to preserve their health.
  
- **Health System**: Players have a health bar that decreases when they come into contact with hazards. The player’s health starts at 100, and if it reaches 0, the player dies. The health bar is updated in real-time as damage is taken.

- **Hazard Detection**: Hazards continuously apply damage to the player when they stay within the hazard’s trigger zone. The rate of damage can be adjusted for each hazard in the Hazard.cs script. If the player leaves the hazard zone, the damage stops.

### Setup Instructions
1. Open the project in Unity (version 2020.3 or later recommended).
2. Open the main scene from the Scenes folder.
3. Press Play to test the game.
4. Use WASD for movement and Space for jumping.
5. Collect all the flowers in the level and reach the end to win!

### Development Notes
This project was developed as a learning exercise in Unity game development, focusing on:
- Component-based architecture.
- Event-driven programming.
- Audio system implementation.
- UI/UX design.
- Game state management.
- Collision detection with hazards.

### Usage
The game begins in the main menu where you can:
- Select the available level.
- Modify your settings in the Options menu.
- Exit the game.

In the Options menu, you can change:
- Volume of the background music.
- Volume of the sound effects.
- Invert the movement of the camera.

Game Controls:
- Move: Arrow keys or WASD.
- Jump: Space Bar.
- Camera Control: Hold right-click and move mouse.
- Pause: Esc key.

To complete the level, collect all the flowers scattered across the terrain and avoid hazards such as sharp metal cones and icebergs. Once you have all the flowers, head to the end of the level to trigger the victory sequence and see your completion time.

