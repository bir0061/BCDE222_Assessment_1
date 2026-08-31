namespace BCIT615.Assessment1.GamePlayer;

/// <summary>Records one successful game movement.</summary>
public readonly record struct MoveRecord(
    int SequenceNumber,
    Position From,
    Position To,
    PieceType MovementPiece);