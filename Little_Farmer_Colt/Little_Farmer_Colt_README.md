# Little Farmer Colt

A 3D farm-life game prototype built in Unity during the Game Development course. This is a course exercise project — it's a work-in-progress prototype rather than a finished game, used to practice core Unity concepts like terrain design, animation, and simple game state.

## Unity Version

`2022.1.24f1`

## What's in the project

- **Terrain & environment** — a custom terrain with a terrain layer, plus a skybox asset for the outdoor scene.
- **Farm characters** — a farmer character alongside piglet, pig, chick, and chicken models, ready to be placed and animated on the farm.
- **Crops & structures** — corn stalk models and barn assets for building out the farm.
- **Farming mechanics (early)**:
  - `GameData.cs` — tracks shared game state, currently the player's `water` and `corn` resource counts, exposed as static properties so any script can read/update them.
  - `Take.cs` — plays a "Take" animation and increments the water count when the `T` key is pressed, an early stub for a resource-gathering action.
  - `Array.cs` — sets up 2D arrays to track state (e.g. growth stage/flags) for groups of piglets, pigs, chicks, and chickens.
  - `testScript.cs` — a scratch script used for testing Unity's script lifecycle (logs a greeting on `Start()`).

## Controls (current prototype)

| Key | Action |
|---|---|
| `T` | Play the "Take" animation and add 1 to the water count |

## Status

This project is a **prototype from a course module**, not a finished game. It demonstrates terrain setup, importing/animating 3D characters, and basic data tracking for a farming simulation, and was left at an experimental stage rather than fully built out.

## Opening the Project

1. Open Unity Hub and add this folder as a project.
2. Use Unity **2022.1.24f1** (or let Unity Hub prompt you to install/switch to it).
3. Open the `preview` scene in `Assets/` and press **Play**.
