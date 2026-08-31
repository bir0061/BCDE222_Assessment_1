namespace BCIT615.Assessment1.GamePlayer;

/// <summary>Describes the observable result of a move request.</summary>
public enum MoveResult
{
    GameAlreadyCompleted,
    OutOfBounds,
    InvalidMovement,
    PathBlocked,
    InvalidDestination,
    GameCompleted,
    Success
}
