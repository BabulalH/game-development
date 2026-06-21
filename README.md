# 2D Unity Game Development

A starter project for 2D game development in Unity with C#.

## Features

- **PlayerController**: Handles player movement (A/D) and jumping (Space)
- **Enemy**: AI enemy that chases the player when in range
- **GameManager**: Manages game state and scoring
- **Collectible**: Collectible items that award points

## Setup

1. Clone this repository
2. Open the project in Unity (2021 LTS or newer)
3. Create a new scene or use the provided scenes
4. Assign scripts to GameObjects
5. Add required components (Rigidbody2D, Colliders, etc.)

## Controls

- **A/D** - Move left/right
- **Space** - Jump

## Project Structure

```
Assets/
├── Scripts/
│   ├── PlayerController.cs
│   ├── Enemy.cs
│   ├── GameManager.cs
│   └── Collectible.cs
└── Scenes/
```

## Next Steps

- Add animations
- Implement UI elements
- Add sound effects and music
- Create level design
- Add more enemy types
