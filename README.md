# BCIT615 Assessment 1 – GamePlayer

## Overview

This project is a **GamePlayer** application developed using **C# and .NET 9** for BCIT615 Assessment 1.

The game uses a **6 × 6 board** and includes four pieces:

* Rook
* Bishop
* Knight
* King

The player starts at `(5, 0)` and must reach the target position `(0, 5)`.

## Technologies 

* C#
* .NET 9
* MSTest
* Visual Studio

## Main Features

The GamePlayer can:

* Create a new game
* Check board positions
* Validate piece movements
* Check blocked paths
* Move pieces
* Store successful moves in move history
* Detect game completion
* Prevent moves after the game is completed

## Initial Game State

```text
Start Position:   (5, 0)
Target Position:  (0, 5)
Current Position: (5, 0)
Is Complete:      false
```

## Code Quality

The project uses basic **Object-Oriented Programming (OOP)** principles.

* **Encapsulation:** Game data is kept private where appropriate.
* **Private setters:** Important properties can only be changed by the game.
* **Read-only history:** Move history can be viewed but not directly changed.
* **Separation of responsibilities:** Movement validation and path checking are handled separately.
* **Helper methods:** Methods such as `IsOnBoard()`, `IsValidMove()` and `IsPathBlocked()` make the code easier to understand.

## Testing

MSTest is used to test the GamePlayer.

Tests include:

* Initial game state
* Valid and invalid moves
* Board boundaries
* Rook movement
* Bishop movement
* Knight movement
* King movement
* Blocked paths
* Move history
* Game completion
* Moves after completion

## How to Run

Open the project in **Visual Studio** and use the terminal.

Restore:

```bash
dotnet restore
```

Build:

```bash
dotnet build --no-restore
```

Run tests:

```bash
dotnet test --no-build
```

Run the application:

```bash
dotnet run --project src/BCIT615.Assessment1.GamePlayer.App --no-build
```

## Project Structure

```text
BCIT615.Assessment1.GamePlayer
│
├── .github
│
├── docs
│
├── src
│   │
│   ├── BCIT615.Assessment1.GamePlayer.App
│   │   ├── Program.cs
│   │   └── BCIT615.Assessment1.GamePlayer.App.csproj
│   │
│   ├── BCIT615.Assessment1.GamePlayer.Contracts
│   │   ├── IGamePlayer.cs
│   │   ├── MoveRecord.cs
│   │   ├── MoveResult.cs
│   │   ├── PieceType.cs
│   │   └── Position.cs
│   │
│   └── BCIT615.Assessment1.GamePlayer.Model
│       ├── GamePlayer.cs
│       ├── ReferenceBoardData.cs
│       ├── LEARNER-TASK.md
│       └── BCIT615.Assessment1.GamePlayer.Model.csproj
│
├── tests
│   │
│   ├── BCIT615.Assessment1.GamePlayer.ContractTests
│   │   └── ContractDefinitionTests.cs
│   │
│   └── BCIT615.Assessment1.GamePlayer.ModelTests
│       ├── GamePlayerTests.cs
│       └── ReferenceBoardDataTests.cs
│
├── .gitattributes
├── .gitignore
├── BCIT615.Assessment1.GamePlayer.sln
├── global.json
└── README.md
```

## Author

**Biken Rai**

BCDE222/BCIT615 – Assessment 1
