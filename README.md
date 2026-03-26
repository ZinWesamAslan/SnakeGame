# Snake Game - Windows Forms (C#)

A classic Snake game built with C# and Windows Forms, featuring multiple game modes, customizable settings, power-ups, obstacles, and a 1v1 mode (code included but not fully integrated). The project demonstrates object-oriented programming, event handling, and GDI+ graphics in a desktop environment.

---

## Table of Contents
- [Overview](#overview)
- [Features](#features)
- [Requirements](#requirements)
- [Installation & Running](#installation--running)
- [Game Modes](#game-modes)
- [Controls](#controls)
- [Settings](#settings)
- [Game Mechanics](#game-mechanics)
- [Screens](#screens)
- [1v1 Mode (Separate Implementation)](#1v1-mode-separate-implementation)
- [Project Structure](#project-structure)

---

## Overview
This project is a complete Snake game with a polished Windows Forms interface. It includes:

- A main menu with buttons to start the game, view scores, see prizes, and access settings.
- Sound effects on hover and click.
- A real‑time preview panel in the settings form to visualize changes without starting a game.
- Statistics displayed on the main form (time played, food eaten, money earned, etc.).
- Two game behaviors: **Normal** (die on wall collision) and **Crazy** (wrap around).
- Power‑up items (red, yellow, blue, green) that modify the snake’s length, score, speed, or controls.
- Obstacles (stones) that appear when certain score thresholds are reached.
- A separate **1v1 mode** (code included but not linked to the main project) where two snakes compete on the same grid.

---

## Features

- **Multiple Forms**
  - `MainForm` – navigation, statistics display.
  - `GameForm` – the main gameplay area.
  - `ScoreForm` – high scores and session stats.
  - `PrizesForm` – achievements or collectible info.
  - `SettingsForm` – customize game parameters.

- **Customizable Settings**
  - Number of food items on the field.
  - Initial snake length.
  - Board size (Large / Medium / Small).
  - Game speed.
  - Colors of food and stones.
  - Preview panel shows immediate visual feedback.

- **Game Modes**
  - **Normal**: Snake dies when hitting the wall or its own body.
  - **Crazy**: Snake wraps to the opposite side when touching a wall (still dies if it hits itself).

- **Food Types**
  - **Red** – increases length by 1 and score by 1.
  - **Yellow** – increases length by 5 and score by 5.
  - **Blue** – gives a speed boost for 10 seconds.
  - **Green** – reverses the snake’s direction (left/right swapped).

- **Obstacles**
  - Stones appear when the player reaches a certain score threshold (e.g., every 10 points).
  - Collision with a stone ends the game.

- **Statistics**
  - Play time (seconds).
  - Food eaten (total items consumed).
  - Money/score accumulated.
  - Additional stats can be tracked.

- **Audio Feedback**
  - Button hover sounds.
  - Button click sounds (different from hover).

- **Preview Panel** (in Settings)
  - A small live view shows the current board size, food count, and colors – all adjustable without launching a game.

---

## Requirements
- Windows OS (the app uses Windows Forms)
- .NET Framework 4.7.2 or higher (or .NET Core / .NET 5+ with Windows Compatibility Pack)
- Visual Studio 2019/2022 (or any C# IDE)

---

## Installation & Running

1. Clone or download the project.
2. Open the solution (`.sln`) in Visual Studio.
3. Build the solution (Ctrl+Shift+B).
4. Run the application (F5).

No external libraries are required – everything uses the standard .NET Framework/Windows Forms.

---

## Game Modes

### Normal Mode (Single Snake)
- One snake controlled by the player.
- Collision with walls, own body, or stones ends the game.
- Eat food to grow and increase score.

### Crazy Mode (Single Snake)
- Collision with walls wraps the snake to the opposite side.
- Collision with own body or stones ends the game.
- Works like the classic “wrap‑around” Snake.

> The mode can be toggled in the Settings form before starting a game.

---

## Controls

- **Arrow Keys (Up, Down, Left, Right)** – move the snake.
- **P** – pause/unpause the game.
- **Esc** – return to main menu (during gameplay).

---

## Settings

| Setting | Description |
|---------|-------------|
| **Board Size** | Small (20×15), Medium (30×20), Large (40×25) – changes grid dimensions. |
| **Initial Snake Length** | Starting length (e.g., 3, 5, 10). |
| **Number of Food Items** | How many food items appear simultaneously on the board. |
| **Speed** | Game tick interval (slower to faster). |
| **Food Colors** | Choose custom colors for each food type (red, yellow, blue, green). |
| **Stone Colors** | Choose the color of obstacles. |
| **Game Mode** | Normal or Crazy. |

All changes are reflected instantly in the **preview panel** (a miniature game area inside the settings window). You can see how the board looks before actually playing.

---

## Game Mechanics

- **Scoring**
  - Red food → +1 point, +1 segment.
  - Yellow food → +5 points, +5 segments.
  - Blue food → +10 points (optional) and a 10‑second speed boost (the snake moves faster).
  - Green food → no score gain, but reverses direction (the snake immediately turns the opposite way).

- **Obstacles (Stones)**
  - Stones appear every time the player earns a certain number of points (configurable in code, default every 10 points).
  - Stones are placed randomly on the grid but not on the snake or existing food.
  - Hitting a stone ends the game immediately.

- **Speed Boost (Blue Food)**
  - The snake’s movement speed increases for 10 seconds.
  - A timer or visual indicator can be shown (optional).
  - After 10 seconds, speed returns to normal.

- **Direction Reversal (Green Food)**
  - Immediately flips the snake’s direction.
  - For example, if moving right, pressing right after eating will move left (but the player can still change direction normally after that).

- **Wrap‑Around (Crazy Mode)**
  - When the snake’s head reaches a border, it reappears on the opposite side.
  - The body segments follow through the wrap – the snake stays intact.

- **Game Over Conditions**
  - Hitting own body.
  - Hitting a wall in Normal mode.
  - Hitting a stone (any mode).

---

## Screens

### MainForm
- Buttons: **Play**, **Scores**, **Prizes**, **Settings**.
- Displays real‑time stats: play time, food eaten, money/score.
- Sound on hover and click.

### GameForm
- The game board with the snake, food, and stones.
- Score display, timer, and speed‑boost indicator.
- Pause functionality.

### ScoreForm
- Shows the last session’s score and time, or a list of high scores (optional).

### PrizesForm
- Shows achievements (e.g., “Eat 10 yellow foods”, “Survive 5 minutes”).

### SettingsForm
- All customizations (board size, speed, colors, etc.).
- **Preview Panel** – a live miniature game area that updates as you change settings. You can see the board size, food colors, and even a demo snake (non‑interactive) to confirm visual changes.

---

## 1v1 Mode (Separate Implementation)

**Important**: The project includes code for a two‑player mode (two snakes on the same grid), but this part **has not yet been integrated** into the main application. The files are present in the solution but are not used in the current build.

- In the 1v1 mode:
  - Two snakes are controlled by two players (e.g., WASD and arrow keys).
  - Collision with walls (in Normal mode) or own body ends the game for that snake.
  - If a snake hits the other snake’s body, it dies.
  - If the two heads collide head‑on, the game ends in a **draw**.
- The implementation is separate and can be tested in a standalone project if needed.
- Future plans may include merging this mode into the main menu.

---

## Future Improvements
- Fully integrate 1v1 mode into the main menu.
- Add network multiplayer.
- Save high scores persistently (to file/database).
- Add more power‑ups (e.g., slow down, invincibility).
- Improve graphics with double buffering for smoother animations.

---

## Credits
Developed as a Windows Forms C# project. All assets (sounds, icons) are placeholders or created for the project.

Enjoy the game! 🐍

