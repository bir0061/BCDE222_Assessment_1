using System;
using System.Collections.Generic;
using BCIT615.Assessment1.GamePlayer.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BCIT615.Assessment1.GamePlayer.ModelTests;

[TestClass]
public sealed class ReferenceBoardDataTests
{
    [TestMethod]
    public void ReferenceBoardData_HasExpectedDefinition()
    {
        Assert.AreEqual(6, ReferenceBoardData.Rows);
        Assert.AreEqual(6, ReferenceBoardData.Columns);
        Assert.AreEqual(new Position(5, 0), ReferenceBoardData.Start);
        Assert.AreEqual(new Position(0, 5), ReferenceBoardData.Target);
        Assert.AreEqual(4, ReferenceBoardData.Pieces.Count);
        Assert.AreEqual(PieceType.Rook, ReferenceBoardData.Pieces[new Position(5, 0)]);
    }

    [TestMethod]
    public void Pieces_WhenCastToDictionary_RemainsReadOnly()
    {
        var dictionary = (IDictionary<Position, PieceType>)ReferenceBoardData.Pieces;

        Assert.IsTrue(dictionary.IsReadOnly);
        Assert.ThrowsException<NotSupportedException>(() =>
            dictionary.Add(new Position(0, 0), PieceType.King));
    }
}