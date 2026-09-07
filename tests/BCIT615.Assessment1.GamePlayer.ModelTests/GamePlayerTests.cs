using BCIT615.Assessment1.GamePlayer.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BCIT615.Assessment1.GamePlayer.ModelTests;

[TestClass]
public sealed class GamePlayerTests
{
    [TestMethod]
    public void NewGame_HasCorrectInitialState()
    {
        var game = new GamePlayer();

        Assert.AreEqual(new Position(5, 0), game.StartPosition);
        Assert.AreEqual(new Position(0, 5), game.TargetPosition);
        Assert.AreEqual(new Position(5, 0), game.CurrentPosition);
        Assert.IsFalse(game.IsComplete);
        Assert.AreEqual(0, game.MoveHistory.Count);
    }

    [TestMethod]
    public void TryMove_RookCanMoveHorizontally()
    {
        var game = new GamePlayer();

        var result = game.TryMove(new Position(5, 2));

        Assert.AreEqual(MoveResult.Success, result);
        Assert.AreEqual(new Position(5, 2), game.CurrentPosition);
        Assert.AreEqual(PieceType.Rook, game.GetPieceAt(new Position(5, 2)));
    }

    [TestMethod]
    public void TryMove_RookCannotMoveDiagonally()
    {
        var game = new GamePlayer();

        var result = game.TryMove(new Position(4, 1));

        Assert.AreEqual(MoveResult.InvalidMovement, result);
        Assert.AreEqual(new Position(5, 0), game.CurrentPosition);
    }

    [TestMethod]
    public void TryMove_RookCannotMoveThroughBlockingPiece()
    {
        var game = new GamePlayer();

        var result = game.TryMove(new Position(5, 5));

        Assert.AreEqual(MoveResult.PathBlocked, result);
        Assert.AreEqual(new Position(5, 0), game.CurrentPosition);
    }

    [TestMethod]
    public void TryMove_OutOfBounds_ReturnsOutOfBounds()
    {
        var game = new GamePlayer();

        var result = game.TryMove(new Position(6, 0));

        Assert.AreEqual(MoveResult.OutOfBounds, result);
        Assert.AreEqual(new Position(5, 0), game.CurrentPosition);
    }

    [TestMethod]
    public void TryMove_ToOccupiedPosition_ReturnsInvalidDestination()
    {
        var game = new GamePlayer();

        var result = game.TryMove(new Position(5, 3));

        Assert.AreEqual(MoveResult.InvalidDestination, result);
        Assert.AreEqual(new Position(5, 0), game.CurrentPosition);
    }

    [TestMethod]
    public void TryMove_ValidMove_IsAddedToMoveHistory()
    {
        var game = new GamePlayer();

        var result = game.TryMove(new Position(4, 0));

        Assert.AreEqual(MoveResult.Success, result);
        Assert.AreEqual(1, game.MoveHistory.Count);

        var move = game.MoveHistory[0];

        Assert.AreEqual(1, move.SequenceNumber);
        Assert.AreEqual(new Position(5, 0), move.From);
        Assert.AreEqual(new Position(4, 0), move.To);
        Assert.AreEqual(PieceType.Rook, move.MovementPiece);
    }

    [TestMethod]
    public void TryMove_ReachingTarget_CompletesGame()
    {
        var game = new GamePlayer();

        // Move the rook up to row 0.
        Assert.AreEqual(
            MoveResult.Success,
            game.TryMove(new Position(0, 0)));

        // Move the rook across to the target.
        var result = game.TryMove(new Position(0, 5));

        Assert.AreEqual(MoveResult.GameCompleted, result);
        Assert.AreEqual(new Position(0, 5), game.CurrentPosition);
        Assert.IsTrue(game.IsComplete);
    }

    [TestMethod]
    public void TryMove_AfterCompletion_IsRejected()
    {
        var game = new GamePlayer();

        game.TryMove(new Position(0, 0));
        game.TryMove(new Position(0, 5));

        var result = game.TryMove(new Position(1, 5));

        Assert.AreEqual(MoveResult.GameAlreadyCompleted, result);
        Assert.AreEqual(new Position(0, 5), game.CurrentPosition);
    }

    [TestMethod]
    public void Restart_RestoresInitialStateAndClearsHistory()
    {
        var game = new GamePlayer();

        game.TryMove(new Position(4, 0));
        game.TryMove(new Position(3, 0));

        game.Restart();

        Assert.AreEqual(new Position(5, 0), game.CurrentPosition);
        Assert.IsFalse(game.IsComplete);
        Assert.AreEqual(0, game.MoveHistory.Count);
        Assert.AreEqual(PieceType.Rook,
            game.GetPieceAt(new Position(5, 0)));
    }
}