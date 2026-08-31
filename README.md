# BCIT615 Assessment 1 - Learner Starter v0.5

## Authority and environment
Use the exact released **BCIT615 Assessment 1 Game Player Technical Specification** published with this starter. Use .NET SDK **9.0.316** as pinned in `global.json`, unless teaching staff issue a centrally controlled replacement.

## Supplied and frozen
Do not edit, delete, rename, split, merge, relocate, or reproduce:
- files in `src/BCIT615.Assessment1.GamePlayer.Contracts/`;
- `src/BCIT615.Assessment1.GamePlayer.Model/ReferenceBoardData.cs`;
- supplied baseline tests.

## Learner-owned work
Create your own Model implementation and risk-based MSTest tests. Suggested names:
- `src/BCIT615.Assessment1.GamePlayer.Model/BoardGamePlayer.cs`
- `src/BCIT615.Assessment1.GamePlayer.Model/GamePlayerFactory.cs`
- `tests/BCIT615.Assessment1.GamePlayer.ModelTests/BoardGamePlayerConstructionTests.cs`
- `tests/BCIT615.Assessment1.GamePlayer.ModelTests/BoardGamePlayerMovementTests.cs`
- `tests/BCIT615.Assessment1.GamePlayer.ModelTests/BoardGamePlayerStateTests.cs`

These names support professional organisation but do not prescribe the internal algorithm. The supplied baseline tests check only contracts and reference data and are **not sufficient learner testing evidence**.

## Commands
```text
dotnet restore
dotnet build --no-restore
dotnet test --no-build
dotnet run --project src/BCIT615.Assessment1.GamePlayer.App
```