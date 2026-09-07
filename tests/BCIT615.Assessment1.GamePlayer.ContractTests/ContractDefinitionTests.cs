using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BCIT615.Assessment1.GamePlayer.ContractTests;

[TestClass]
public sealed class ContractDefinitionTests
{
    [TestMethod]
    public void PieceType_ContainsOnlyRequiredPieces()
    {
        PieceType[] values = Enum.GetValues<PieceType>();

        CollectionAssert.AreEqual(
            new[] { PieceType.Rook, PieceType.Bishop, PieceType.Knight, PieceType.King },
            values);
    }

    [TestMethod]
    public void MoveResult_OrderMatchesValidationPrecedence()
    {
        MoveResult[] values = Enum.GetValues<MoveResult>();

        CollectionAssert.AreEqual(
            new[]
            {
                MoveResult.GameAlreadyCompleted,
                MoveResult.OutOfBounds,
                MoveResult.InvalidMovement,
                MoveResult.PathBlocked,
                MoveResult.InvalidDestination,
                MoveResult.GameCompleted,
                MoveResult.Success
            },
            values);
    }

    [TestMethod]
    public void Position_ValueEquality_UsesRowAndColumn()
    {
        var first = new Position(2, 3);
        var second = new Position(2, 3);

        Assert.AreEqual(first, second);
    }
}
