# 👻 Maze Of the Ghost

**Platform**: Web / PC

Welcome to **Maze Of the Ghost**, a survival game where the player must navigate a haunted maze, evade a pursuing ghost, and strategically use limited resources to escape the maze and win the game.

---

## 🎮 Gameplay Overview

In Maze Of the Ghost, players take control of a character exploring a maze while managing stamina, using snowballs to stop enemy, and collecting key item to unlock the exit.

<img width="1920" height="1080" alt="Maze_Of_The_Ghost_3" src="https://github.com/user-attachments/assets/1ee83c20-aca3-48d0-9a4e-6fcd79c3c4f4" />

---

## 📋 Features

### Core Gameplay
- **Exploration and Survival**: Navigate a maze filled with interactive objects and a enemy.
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

## 🛠️ Game Mechanics

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

## 🎮 How to Play

1. **Explore** the environment and collect key items (keys, batteries, snowballs).
2. **Avoid Ghosts**:
   - If they catch you, the game is over.
   - Throw snowballs to temporarily stop them.
3. **Manage Resources**:
   - **Batteries**: Keep your flashlight powered.
   - **Snowballs**: Save them for ghost encounters.
   - **Stamina**: Use sprint wisely to escape.
4. **Unlock the Door**: Collect a key to open the door and escape.

---

## 🧩 Controls

- **Mouse**: Look around.
- **W, A, S, D**: Move.
- **Shift**: Sprint (consumes stamina).
- **Space**: Throw snowball (if available).

---

## 🔧 Technologies Used

- **Unity Engine**: Game development platform.
- **C#**: Game logic and mechanics.
- **TextMeshPro**: UI text rendering.
- **Unity Physics**: Rigidbodies and collisions.

---

## 📜 Credits

### **Game Development**: [A. Furkan Öcel, Yusuf Balmumcu]

### Team Member #1 - A. Furkan Öcel
- Picking up items (OnTriggerEnter) Collision_Script.cs:60
- Rotating items in the game (transform.Rotate) Item_Script.cs:16
- Snowball-Ghost interaction (OnTriggerEnter) Ghost_Script.cs:29
- Ghost movement towards the player (transform.rotation, transform.position) Ghost_Script.cs:17
- Door key check (OnTriggerEnter) Collision_Script.cs:70, 76
- Player throwing snowball (AddForce) Collision_Script.cs:42
- Account: https://github.com/AFurkanOcel

### Team Member #2 - Yusuf Balmumcu
- Character movement with vertical & horizontal input and orientation (Vector3.MoveTowards) Move_Player_Script.cs:75
- Detecting contact with ground for friction (Physics.Raycast) Move_Player_Script.cs:65
- First-person camera control (transform.rotation, orientation.rotation) Camera_Script.cs:38
- Walking animation with camera up/down movement (transform.localPosition) Camera_Script.cs:52
- Reducing player’s stamina and battery (inside IEnumerator with .fillAmount) Battery_Control_Script.cs:42, Stamina_Control_Script.cs:88
- Account: https://github.com/YusufBalmumcu

---

### **Assets**:
- 3D Hand Model From: [https://assetstore.unity.com/packages/3d/characters/stylized-simple-hands-221297](https://assetstore.unity.com/packages/3d/characters/stylized-simple-hands-221297)
- 3D Battery Model From: [https://assetstore.unity.com/packages/3d/props/mobile-power-ups-free-vol-1-36106](https://assetstore.unity.com/packages/3d/props/mobile-power-ups-free-vol-1-36106)
- 3D Ghost Model From: [https://assetstore.unity.com/packages/3d/characters/little-ghost-lowpoly-free-271926](https://assetstore.unity.com/packages/3d/characters/little-ghost-lowpoly-free-271926)
- 3D Key Model From: [https://assetstore.unity.com/packages/3d/props/rust-key-167590](https://assetstore.unity.com/packages/3d/props/rust-key-167590)
- 3D Snowball Model From: [https://assetstore.unity.com/packages/2d/textures-materials/water/stylize-snow-texture-153579](https://assetstore.unity.com/packages/2d/textures-materials/water/stylize-snow-texture-153579)
- Sky Texture From: [https://assetstore.unity.com/packages/2d/textures-materials/sky/allsky-free-10-sky-skybox-set-146014](https://assetstore.unity.com/packages/2d/textures-materials/sky/allsky-free-10-sky-skybox-set-146014)
  
### **Audio**: 
- Walking Sound Effect: [https://www.youtube.com/watch?v=y3MVUQnIsoM&ab_channel=HankTank](https://www.youtube.com/watch?v=y3MVUQnIsoM&ab_channel=HankTank)
- Bretahing Sound Effect: [https://www.youtube.com/watch?v=MIxY154tBcg&ab_channel=SoundKind](https://www.youtube.com/watch?v=MIxY154tBcg&ab_channel=SoundKind)
- Game Music From: [https://assetstore.unity.com/packages/audio/music/rock/halloween-game-music-pack-235870#content](https://assetstore.unity.com/packages/audio/music/rock/halloween-game-music-pack-235870#content)

### **Voice Actors**
- **Off-screen**: A. Furkan Öcel  

### **Maze Generation**: [https://www.mazegenerator.net/](https://www.mazegenerator.net/)


---

## 📥 Installation and Play

1. Clone or download this repository:
   ```bash
   git clone https://github.com/AFurkanOcel/Maze_Of_The_Ghost

  - Or use the link down below to try it at itch.io
  - Link: https://waxer16.itch.io/maze-of-the-ghost
