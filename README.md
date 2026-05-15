<h1 align="center">👻 Maze Of The Ghost</h1>

<p align="center">
First-person survival horror maze game developed with Unity and C#.<br>
Collect resources, evade the ghost, and escape the haunted maze.
</p>

<p align="center">
  <img src="https://img.shields.io/badge/Engine-Unity%202022%20LTS-black"/>
  <img src="https://img.shields.io/badge/Language-C%23-purple"/>
  <img src="https://img.shields.io/badge/UI-TextMeshPro-blue"/>
  <img src="https://img.shields.io/badge/Physics-Unity%20Physics-orange"/>
  <img src="https://img.shields.io/badge/Platform-PC-green"/>
  <img src="https://img.shields.io/badge/Genre-Survival%20Horror-red"/>
  <img src="https://img.shields.io/badge/Status-Completed-brightgreen"/>
</p>

---

## Project Overview

Maze Of The Ghost is a first-person survival horror game where the player must navigate through a haunted maze while avoiding a pursuing ghost.

The objective is simple:
- explore the maze,
- collect critical resources,
- unlock the exit,
- and survive long enough to escape.

The game combines exploration, limited-resource management, and enemy evasion mechanics to create a tense gameplay experience.

<img width="1920" height="1080" alt="Maze_Of_The_Ghost_3" src="https://github.com/user-attachments/assets/1ee83c20-aca3-48d0-9a4e-6fcd79c3c4f4" />

---

## Project Structure

```text
Maze_Of_The_Ghost/
│── Assets/
│   ├── Scenes/
│   │   ├── MenuScene.unity
│   │   ├── ControlsScene.unity
│   │   ├── GameScene.unity
│   │   ├── OptionsScene.unity
│   │   ├── WinScene.unity
│   │   └── LoseScene.unity
│   │
│   └── Scripts/
│       ├── Move_Player_Script.cs
│       ├── Camera_Script.cs
│       ├── Ghost_Script.cs
│       ├── Collision_Script.cs
│       ├── Battery_Control_Script.cs
│       ├── Stamina_Control_Script.cs
│       ├── Item_Script.cs
│       ├── Pause_Menu_Script.cs
│       ├── Button_Script.cs
│       ├── Game_Music_Script.cs
│       └── Music_Script.cs
│
├── Packages/
└── ProjectSettings/
```

---

## Core Systems

### Player Controller
- First-person movement
- Sprint system
- Stamina consumption & regeneration
- Camera bobbing

### Enemy AI
- Ghost tracking and pursuit
- Temporary stun mechanic via snowballs

### Resource System
- Battery collection
- Snowball inventory
- Key collection
- Door unlocking

### UI System
- Pause menu
- Win/Lose screens
- Stamina & battery indicators

---

## Features

### Core Gameplay
- **Exploration and Survival**: Navigate a maze filled with interactive objects and an enemy.
- **Ghost Enemy**: Avoid the ghost that chases the player. Use snowballs to temporarily stop it for 5 seconds.
- **Resource Management**: Manage stamina, flashlight batteries, and snowball supplies to escape the maze.

### Player Abilities
- **Walking and Sprinting**: Move around the environment, with sprinting consuming stamina.
- **Flashlight**: Essential for visibility; deactivates when batteries run out.
- **Snowball Throwing**: Aim and throw snowballs to defend against ghosts.

### Collectible Items
- **Key**: Unlock the hidden door to progress toward victory.
- **Batteries**: Recharge flashlight power.
- **Snowballs**: Increase your throwable snowball count.

### Immersive Environment
- **Camera Effects**: Bobbing and mouse-controlled rotation for added realism.
- **Audio Feedback**: Sounds for key pickup, stamina depletion, and ghost interactions create a better experience for the game.

### Victory and Failure
- **Win Condition**: Collect a key, unlock the exit door, and escape the maze.
- **Lose Condition**: Get caught by a ghost and trigger the game over screen.

---

## Game Mechanics

### Stamina System
- Sprinting consumes stamina, displayed via a stamina bar on the UI.
- Stamina regenerates when walking or idle.
- Running out of stamina triggers breathing sounds and forces the player to slow down.

### Ghost AI
- Ghosts actively pursue the player.
- Hitting a ghost with a snowball temporarily stops it for 5 seconds.

### Interactive Environment
- Collision-based interactions for items, enemies, and objectives.
- Rotating key, batteries, and snowballs for a dynamic visual effect.

---

## How to Play

1. **Explore** the environment and collect key items (keys, batteries, snowballs).
2. **Avoid Ghosts**
   - If they catch you, the game is over.
   - Throw snowballs to temporarily stop them.
3. **Manage Resources**
   - **Batteries**: Keep your flashlight powered.
   - **Snowballs**: Save them for ghost encounters.
   - **Stamina**: Use sprint wisely to escape.
4. **Unlock the Door**: Collect a key to open the door and escape.

---

## Controls

- **Mouse**: Look around
- **W, A, S, D**: Move
- **Shift**: Sprint (consumes stamina)
- **Space**: Throw snowball (if available)

---

## Technologies Used

- **Unity Engine** — game development platform
- **C#** — gameplay programming
- **TextMeshPro** — UI text rendering
- **Unity Physics** — collision and rigidbody systems
- **Unity UI (UGUI)** — menus and HUD

---

## Credits

### Game Development
**A. Furkan Öcel** and **Yusuf Balmumcu**

### Team Member #1 - A. Furkan Öcel
- Picking up items (`OnTriggerEnter`) — `Collision_Script.cs`
- Rotating items (`transform.Rotate`) — `Item_Script.cs`
- Snowball-Ghost interaction (`OnTriggerEnter`) — `Ghost_Script.cs`
- Ghost movement (`transform.rotation`, `transform.position`) — `Ghost_Script.cs`
- Door key check (`OnTriggerEnter`) — `Collision_Script.cs`
- Player throwing snowball (`AddForce`) — `Collision_Script.cs`

GitHub: https://github.com/AFurkanOcel

### Team Member #2 - Yusuf Balmumcu
- Character movement and orientation (`Vector3.MoveTowards`) — `Move_Player_Script.cs`
- Ground detection (`Physics.Raycast`) — `Move_Player_Script.cs`
- First-person camera control (`transform.rotation`) — `Camera_Script.cs`
- Camera bobbing (`transform.localPosition`) — `Camera_Script.cs`
- Stamina and battery reduction (`IEnumerator`) — `Battery_Control_Script.cs`, `Stamina_Control_Script.cs`

GitHub: https://github.com/YusufBalmumcu

---

## Assets

- 3D Hand Model: https://assetstore.unity.com/packages/3d/characters/stylized-simple-hands-221297
- 3D Battery Model: https://assetstore.unity.com/packages/3d/props/mobile-power-ups-free-vol-1-36106
- 3D Ghost Model: https://assetstore.unity.com/packages/3d/characters/little-ghost-lowpoly-free-271926
- 3D Key Model: https://assetstore.unity.com/packages/3d/props/rust-key-167590
- 3D Snowball Texture: https://assetstore.unity.com/packages/2d/textures-materials/water/stylize-snow-texture-153579
- Sky Texture: https://assetstore.unity.com/packages/2d/textures-materials/sky/allsky-free-10-sky-skybox-set-146014

---

## Audio

- Walking Sound Effect: https://www.youtube.com/watch?v=y3MVUQnIsoM
- Breathing Sound Effect: https://www.youtube.com/watch?v=MIxY154tBcg
- Game Music: https://assetstore.unity.com/packages/audio/music/rock/halloween-game-music-pack-235870

---

## Voice Actors

- **Off-screen**: A. Furkan Öcel

---

## Maze Generation

https://www.mazegenerator.net/

---

## Installation and Play

1. Clone the repository:

```bash
git clone https://github.com/AFurkanOcel/Maze_Of_The_Ghost
```

2. Open the project in Unity 2022.3 LTS.

3. Load `GameScene` and press **Play**.

### Play Online

https://waxer16.itch.io/maze-of-the-ghost
