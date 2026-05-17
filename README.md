<h1 align="center">Maze Of The Ghost</h1>

<p align="center">
First-person survival horror maze game built with Unity and C#.
</p>

<p align="center">
  <img src="https://img.shields.io/badge/Engine-Unity%202022.3.21f1-black"/>
  <img src="https://img.shields.io/badge/Language-C%23-purple"/>
  <img src="https://img.shields.io/badge/UI-TextMeshPro-blue"/>
  <img src="https://img.shields.io/badge/AI-Ghost%20Enemy-red"/>
  <img src="https://img.shields.io/badge/Gameplay-Resource%20Management-orange"/>
  <img src="https://img.shields.io/badge/Platform-PC-green"/>
  <img src="https://img.shields.io/badge/Platform-WebGL-brightgreen"/>
  <img src="https://img.shields.io/badge/Genre-Survival%20Horror-red"/>
  <img src="https://img.shields.io/badge/Status-Completed-brightgreen"/>
</p>

---

<img width="1920" height="1080" alt="Maze Of The Ghost gameplay screenshot" src="https://github.com/user-attachments/assets/1ee83c20-aca3-48d0-9a4e-6fcd79c3c4f4" />

## Overview

Maze Of The Ghost is a first-person survival horror game where the player navigates a haunted maze while avoiding a pursuing ghost. The goal is to collect key resources, unlock the exit, and survive long enough to escape.

The game focuses on:

- maze exploration
- limited-resource management
- ghost evasion
- item collection
- simple win and lose conditions

## Platforms

This repository contains the Unity source projects for both PC and WebGL versions:

- `Maze_Of_The_Ghost(PC)` - Unity project configured for the desktop version
- `Maze_Of_The_Ghost(Web)` - Unity project configured for the WebGL version

The WebGL version is playable on itch.io:

https://waxer16.itch.io/maze-of-the-ghost

Build outputs are intentionally excluded from the repository. Desktop builds should be distributed separately through GitHub Releases, itch.io, or another release channel.

## Project Structure

```text
Maze_Of_The_Ghost/
|-- Maze_Of_The_Ghost(PC)/
|   |-- Assets/
|   |   |-- Scenes/
|   |   |   |-- MenuScene.unity
|   |   |   |-- ControlsScene.unity
|   |   |   |-- GameScene.unity
|   |   |   |-- OptionsScene.unity
|   |   |   |-- WinScene.unity
|   |   |   `-- LoseScene.unity
|   |   `-- Scripts/
|   |       |-- Move_Player_Script.cs
|   |       |-- Camera_Script.cs
|   |       |-- Ghost_Script.cs
|   |       |-- Collision_Script.cs
|   |       |-- Battery_Control_Script.cs
|   |       |-- Stamina_Control_Script.cs
|   |       |-- Item_Script.cs
|   |       |-- Pause_Menu_Script.cs
|   |       |-- Button_Script.cs
|   |       |-- Game_Music_Script.cs
|   |       `-- Music_Script.cs
|   |-- Packages/
|   `-- ProjectSettings/
|
|-- Maze_Of_The_Ghost(Web)/
|   |-- Assets/
|   |-- Packages/
|   `-- ProjectSettings/
|
|-- .gitattributes
|-- .gitignore
|-- LICENSE
`-- README.md
```

## Features

- **First-person movement** with mouse look, walking, sprinting, and camera bobbing.
- **Stamina system** that drains while sprinting and regenerates while walking or idle.
- **Flashlight resource management** using collectible batteries.
- **Ghost enemy behavior** that pursues the player through the maze.
- **Snowball defense mechanic** that temporarily stops the ghost.
- **Collectible key and locked exit** for the win condition.
- **Menu, controls, options, win, and lose scenes** built with Unity UI and TextMeshPro.
- **Audio feedback** for movement, stamina, pickups, and game atmosphere.

## Game Mechanics

### Survival Loop

The player explores the maze, collects batteries and snowballs, finds the key, and unlocks the exit while avoiding the ghost.

### Resource Management

- Batteries keep the flashlight usable.
- Stamina limits sprinting and forces the player to choose when to run.
- Snowballs can be saved for dangerous ghost encounters.

### Enemy Interaction

The ghost actively chases the player. If it catches the player, the lose scene is triggered. Hitting the ghost with a snowball temporarily stops it for 5 seconds.

## Controls

| Input | Action |
| --- | --- |
| Mouse | Look around |
| W, A, S, D | Move |
| Shift | Sprint |
| Space | Throw snowball, if available |

## Installation and Play

1. Clone the repository:

```bash
git clone https://github.com/AFurkanOcel/Maze_Of_The_Ghost.git
```

2. Open one of the Unity project folders in Unity `2022.3.21f1`:

```text
Maze_Of_The_Ghost(PC)
Maze_Of_The_Ghost(Web)
```

3. Open `MenuScene` to start from the menu flow, or open `GameScene` to test gameplay directly.

4. Press **Play** in the Unity Editor.

## Technologies Used

- **Unity 2022.3.21f1** - game engine
- **C#** - gameplay scripting
- **TextMeshPro** - UI text rendering
- **Unity UI (UGUI)** - menus and HUD
- **Unity Physics** - collision, triggers, and rigidbody interactions
- **WebGL** - browser build target

## Credits

### Game Development

**A. Furkan ÖCEL** and **Yusuf BALMUMCU**

### A. Furkan ÖCEL

- Item pickup logic - `Collision_Script.cs`
- Rotating collectible items - `Item_Script.cs`
- Snowball and ghost interaction - `Ghost_Script.cs`
- Ghost movement behavior - `Ghost_Script.cs`
- Door key check - `Collision_Script.cs`
- Snowball throwing with force - `Collision_Script.cs`

GitHub: https://github.com/AFurkanOcel

### Yusuf BALMUMCU

- Character movement and orientation - `Move_Player_Script.cs`
- Ground detection - `Move_Player_Script.cs`
- First-person camera control - `Camera_Script.cs`
- Camera bobbing - `Camera_Script.cs`
- Stamina and battery systems - `Battery_Control_Script.cs`, `Stamina_Control_Script.cs`

GitHub: https://github.com/YusufBalmumcu

## Assets and Audio

### Assets

- 3D Hand Model: https://assetstore.unity.com/packages/3d/characters/stylized-simple-hands-221297
- 3D Battery Model: https://assetstore.unity.com/packages/3d/props/mobile-power-ups-free-vol-1-36106
- 3D Ghost Model: https://assetstore.unity.com/packages/3d/characters/little-ghost-lowpoly-free-271926
- 3D Key Model: https://assetstore.unity.com/packages/3d/props/rust-key-167590
- 3D Snowball Texture: https://assetstore.unity.com/packages/2d/textures-materials/water/stylize-snow-texture-153579
- Sky Texture: https://assetstore.unity.com/packages/2d/textures-materials/sky/allsky-free-10-sky-skybox-set-146014

### Audio

- Walking Sound Effect: https://www.youtube.com/watch?v=y3MVUQnIsoM
- Breathing Sound Effect: https://www.youtube.com/watch?v=MIxY154tBcg
- Game Music: https://assetstore.unity.com/packages/audio/music/rock/halloween-game-music-pack-235870

### Other

- Maze Generation: https://www.mazegenerator.net/
- Off-screen Voice: A. Furkan ÖCEL
