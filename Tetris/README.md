# Tetris

A fully playable Tetris clone built in Unity as the **final project** for my Game Development course, presented to the course instructor.

## Unity Version

`2022.1.24f1`

## Features

- All 7 standard tetrominoes (**I, J, L, O, S, T, Z**), defined by their cell layout and color tile.
- **Grid-based board** (10×20 by default) built on a Unity `Tilemap`, with full collision/bounds checking.
- **Piece movement** — move left/right, soft drop, and hard drop.
- **Rotation with wall kicks**, using the SRS-style kick tables for both the `I` piece and the `J/L/O/S/T/Z` pieces, so pieces rotate smoothly near walls and other blocks instead of getting stuck.
- **Ghost piece** — a preview of where the active piece will land, updated live as the piece moves and rotates.
- **Lock delay** — pieces briefly "stick" before locking in place, giving the player a moment to make last adjustments.
- **Line clearing** — completed rows are cleared and everything above collapses down.
- **Game over detection** when a new piece can't spawn in a valid position.

## Controls

| Key | Action |
|---|---|
| `A` | Move left |
| `D` | Move right |
| `S` | Soft drop |
| `Q` | Rotate counter-clockwise |
| `E` | Rotate clockwise |
| `Space` | Hard drop |

## Project Structure

```
Assets/
├── Scenes/
│   └── Tetris.unity        # Main game scene
├── Scripts/
│   ├── Board.cs             # Grid, spawning, collision, line clearing
│   ├── Piece.cs             # Active piece movement, rotation, locking
│   ├── Ghost.cs             # Landing-position preview
│   ├── Tetromino.cs         # Tetromino type & data struct
│   └── Data.cs              # Tetromino cell layouts & wall-kick tables
├── Sprites/                 # Block, border, and grid sprites
├── Tiles/                   # Tile assets used by the Tilemap
└── Art/                     # Source .psd files for blocks & border
```

## Opening the Project

1. Open Unity Hub and add this folder as a project.
2. Use Unity **2022.1.24f1** (or let Unity Hub prompt you to install/switch to it).
3. Open `Assets/Scenes/Tetris.unity` and press **Play**.
