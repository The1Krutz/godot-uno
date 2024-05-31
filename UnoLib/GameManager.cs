namespace UnoLib;

public class GameManager {
  public List<Player> players;
  public int currentPlayerIndex;
  public UnoDeck deck;
  public UnoCard showingCard;
  public List<UnoMove> moveHistory;
  public bool isGameStarted;

  private Random rng;

  public GameManager() {
    players = new();
    deck = new UnoDeck();
    moveHistory = new();
    isGameStarted = false;

    rng = new Random();
  }

  /// <summary>
  /// Add a player, if there's room in the game. Otherwise do nothing
  /// </summary>
  public bool AddPlayer(Player player) {
    if (players.Count < 10) {
      players.Add(player);
      return true;
    } else {
      return false;
    }
  }

  public void StartGame() {
    // assign first player at random
    int firstPlayerIndex = rng.Next(0, players.Count);
    currentPlayerIndex = players[firstPlayerIndex].id;

    // deal 7 cards to each player
    for (int i = 0; i < 7; i++) {
      foreach (var player in players) {
        player.GiveCard(deck.DrawCard());
      }
    }

    // turn over the first card
    showingCard = deck.DrawCard();

    isGameStarted = true;
  }
}
