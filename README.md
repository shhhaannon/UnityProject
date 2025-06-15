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
The game begins in the main menu where you can select level **1**, **2** or **3**, modify your settings in the **Options** menu or **Exit** the game.

In the Options menu you can change:
- Volume of the background music
- Volume of the sound effects
- Invert the movement of the camera

Game Controls:
- Move: Arrow keys or WASD
- Jump: Space Bar
- Camera Control: Hold right click and move mouse
- Pause: Esc key

To complete each level, collide with the sea horse flag to trigger the victory sequence and see your completion time.

# Platformer Videogame
## Description

Platform video games, or simply platformers, are a genre of video games characterized by having to walk, run, jump or climb on a series of platforms and cliffs, with enemies, while collecting objects to complete the game. This repository contains the source code for a simple 3-level 3D platformer.  


