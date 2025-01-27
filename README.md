# 🕹️ Maze Of the Ghost

Welcome to **Maze Of the Ghost**, a survival game where the player must navigate a haunted maze, evade a pursuing ghost, and strategically use limited resources to escape the maze and win the game.

---

## 🎮 Gameplay Overview

In Maze Of the Ghost, players take control of a character exploring a maze while managing stamina, using snowballs to stop enemy, and collecting key item to unlock the exit.

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

### **Game Development**: [Yusuf Balmumcu, Ahmet Furkan Öcel]
### Grup Üyesi #1 -22360859001 -Yusuf Balmumcu
- Vertical Horizontal girdisi ve Orientation ile karakter hareketi (Vector3.MoveTowards) Move_Player_Script.cs:75
- Sürtünme için yere teması tespit etme (Physics.Raycast) Move_Player_Script.cs:65
- First Person kamera kontrolü (transform.totation,orientation.rotation) Camera_Script.cs:38
- Kameranın yukarı aşağı hareketi ile yürüme animasyonu (transform.localPosition) Camera_Script.cs:52
- Oyuncunun Stamina ve Bataryasının azaltılması (IEnumerator içinde .fillamount) Battery_Control_Script.cs:42, Stamina_Control_Script.cs:88
### Grup Üyesi #2 -23360859729 -Ahmet Furkan Öcel
- Item alabilme (OnTriggerEnter) Collision_Script.cs:60
- Item ları oyunda döndürme (transform.Rotate) Item_Script.cs:16
- Kartopu Hayalet Etkileşimi (OnTriggerEnter) Ghost_Script.cs:29
- Hayaletin oyuncuya doğru hareketi (transform.rotation,transform.position) Ghost_Script.cs:17
- Kapının anahtar kontrolü (OnTriggerEnter) Collision_Script.cs:70, 76
- Oyuncunun kar topunu atması (AddForce) Collision_Script.cs:42
---
## **Final Kısım Görev Dağılımları** [Yusuf Balmumcu, Ahmet Furkan Öcel]
### Yusuf Balmumcu - 22360859001
- Pause Menü (20x)
- Ses ve Müzik (20x)
- Asenkronizasyon (10x)
- Farklı State Animasyonlar (10x)
### Ahmet Furkan Öcel - 23360859729
- Ana Menü (30x)
- Ses ve Müzik (10x)
- Farklı State Animasyonlar (20x)
---
### **Assets**:
- 3d Battery Model From: [https://assetstore.unity.com/packages/3d/props/mobile-power-ups-free-vol-1-36106](https://assetstore.unity.com/packages/3d/props/mobile-power-ups-free-vol-1-36106)
- 3d Ghost Model From: [https://assetstore.unity.com/packages/3d/characters/little-ghost-lowpoly-free-271926](https://assetstore.unity.com/packages/3d/characters/little-ghost-lowpoly-free-271926)
- 3d Key Model From: [https://assetstore.unity.com/packages/3d/props/rust-key-167590](https://assetstore.unity.com/packages/3d/props/rust-key-167590)
- 3d Snowball Model From: [https://assetstore.unity.com/packages/2d/textures-materials/water/stylize-snow-texture-153579](https://assetstore.unity.com/packages/2d/textures-materials/water/stylize-snow-texture-153579)
- Sky Texture From: [https://assetstore.unity.com/packages/2d/textures-materials/sky/allsky-free-10-sky-skybox-set-146014](https://assetstore.unity.com/packages/2d/textures-materials/sky/allsky-free-10-sky-skybox-set-146014)
  
### **Audio**: 
- Walking Sound Effect: [https://www.youtube.com/watch?v=y3MVUQnIsoM&ab_channel=HankTank](https://www.youtube.com/watch?v=y3MVUQnIsoM&ab_channel=HankTank)
- Bretahing Sound Effect: [https://www.youtube.com/watch?v=MIxY154tBcg&ab_channel=SoundKind](https://www.youtube.com/watch?v=MIxY154tBcg&ab_channel=SoundKind)
- Game Music From: [https://assetstore.unity.com/packages/audio/music/rock/halloween-game-music-pack-235870#content](https://assetstore.unity.com/packages/audio/music/rock/halloween-game-music-pack-235870#content)

### **Maze Generation**: [https://www.mazegenerator.net/](https://www.mazegenerator.net/)


---

## 📥 Installation and Play

1. Clone or download this repository:
   ```bash
   git clone https://github.com/YusufBalmumcu/MazeGame

  - Or use the link down below to try it at itch.io
  - Link: https://waxer16.itch.io/maze-of-the-ghost
