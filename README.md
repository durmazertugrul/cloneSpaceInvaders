# CloneSpaceInvaders

A Unity implementation of the classic Space Invaders arcade game, built as part of a series of clone projects for learning core Unity game development mechanics.

## About the Project

CloneSpaceInvaders recreates the classic Space Invaders gameplay: a player-controlled ship moving along the bottom of the screen, fending off a descending grid of enemies.

This project is part of a broader personal learning path focused on building small, self-contained clone games (Flappy Bird, Space Invaders, 2048, Match-3) to practice Unity fundamentals before moving on to original game projects.

## Current Status

Work in progress. The following pieces are implemented:

- Player horizontal movement control
- Enemy grid movement (horizontal shift + step down)

## Tech Stack

- **Engine:** Unity 6000.4.5f1 (Unity 6)
- **Language:** C#
- **Render Pipeline:** Universal Render Pipeline (URP)
- **Input:** Legacy Input Manager (`Input.GetKeyDown`), Active Input Handling set to Both

## Project Structure

```
Assets/
├── Scenes/               # SampleScene (main game scene)
├── Scripts/
│   ├── PlayerController.cs  # Player movement (implemented)
│   ├── EnemyMovement.cs     # Enemy behaviour
│   └── ...
├── Sprites/
└── Settings/             # URP and project rendering settings
```

## Getting Started

### Prerequisites

- Unity Hub
- Unity Editor version 6000.4.5f1 (or a compatible Unity 6 version)

### Installation

1. Clone the repository:
   ```
   git clone https://github.com/durmazertugrul/cloneSpaceInvaders.git
   ```
2. Open Unity Hub and select **Add project from disk**, then choose the cloned folder.
3. Open the project with the matching Unity Editor version.
4. Open `Assets/Scenes/SampleScene.unity` and press **Play** in the Unity Editor.
5. Use the arrow keys or A/D to move the player.

## Roadmap

- [x] Implement player horizontal movement
- [x] Implement enemy grid movement
- [ ] Implement player shooting
- [ ] Implement enemy shooting
- [ ] Implement collision detection (bullets vs. player/enemies)
- [ ] Add score tracking and UI
- [ ] Add win (all enemies destroyed) and game-over (player hit / enemies reach bottom) states
- [ ] Add restart functionality

## License

No license has been specified for this project yet.
