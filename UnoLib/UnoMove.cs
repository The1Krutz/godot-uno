namespace UnoLib;

public readonly struct UnoMove {
  public readonly int TurnNumber;
  public readonly string PlayerName;
  public readonly UnoCard PlayedCard;

  public UnoMove(
    int turnNumber,
    string playerName,
    UnoCard playedCard
  ) {
    TurnNumber = turnNumber;
    PlayerName = playerName;
    PlayedCard = playedCard;
  }
}
