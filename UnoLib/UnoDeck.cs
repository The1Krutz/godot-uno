namespace UnoLib;

public class UnoDeck {
  private Queue<UnoCard> Cards {
    get;
  }

  public int Count => Cards.Count;

  /// <summary>
  /// Default constructor
  /// Generates a black deck and shuffles it a few times
  /// Use this in most cases
  /// </summary>
  public UnoDeck() {
    Cards = new Queue<UnoCard>();

    GenerateDeck();

    Shuffle();
    Shuffle();
    Shuffle();
  }

  /// <summary>
  /// Constructor that allows for a deck override
  /// Use this for restoring a specific deck state
  /// </summary>
  /// <param name="cards">Deck override</param>
  public UnoDeck(List<UnoCard> cards) {
    Cards = new Queue<UnoCard>();

    while (cards.Count > 0) {
      Cards.Enqueue(cards[0]);
      cards.RemoveAt(0);
    }
  }

  /// <summary>
  /// Draw a card and return it. Only call this if the deck is guaranteed to have cards in it at this point (ie: dealing at the start of the game)
  /// </summary>
  public UnoCard DrawCard() {
    if (Cards.Count == 0) {
      throw new Exception("Deck is empty!");
    }

    return Cards.Dequeue();
  }

  /// <summary>
  /// Draw a card and maybe return it. This is the safe version to call during gameplay where the deck could possibly be empty.
  /// </summary>
  public bool DrawCard(out UnoCard card) {
    if (Cards.Count == 0) {
      // Deck is empty. Default card will not be used, and return false.
      card = new UnoCard();
      return false;
    }

    card = Cards.Dequeue();
    return true;
  }

  public override string ToString() {
    return Cards.Select((UnoCard card) => card.ToString())
                .Aggregate("cards:", (string accumulator, string value) => $"{accumulator}\n{value}");
  }

  private void GenerateDeck() {
    Cards.Clear();

    List<Color> basicColors = new(){
      Color.Red,
      Color.Blue,
      Color.Green,
      Color.Yellow
    };
    List<Value> basicValues = new(){
      Value.One,
      Value.Two,
      Value.Three,
      Value.Four,
      Value.Five,
      Value.Six,
      Value.Seven,
      Value.Eight,
      Value.Nine,
      Value.DrawTwo,
      Value.Reverse,
      Value.Skip
    };
    List<Value> wildValues = new() {
      Value.Wild,
      Value.DrawFour,
      Value.ThemedWild
    };

    foreach (Color color in basicColors) {
      Cards.Enqueue(new UnoCard(color, Value.Zero));

      foreach (Value value in basicValues) {
        for (int i = 0; i < 2; i++) {
          Cards.Enqueue(new UnoCard(color, value));
        }
      }
    }

    foreach (Value value in wildValues) {
      for (int i = 0; i < 4; i++) {
        Cards.Enqueue(new UnoCard(Color.Wild, value));
      }
    }
  }

  private void Shuffle() {
    List<UnoCard> cardList = new();

    // move the cards queue into a list for shuffling
    while (Cards.Count > 0) {
      cardList.Add(Cards.Dequeue());
    }

    // apply the shuffle
    Random rand = new();

    int n = cardList.Count;
    while (n > 1) {
      n--;
      int k = rand.Next(n + 1);
      (cardList[n], cardList[k]) = (cardList[k], cardList[n]);
    }

    // move back into a queue
    while (cardList.Count > 0) {
      Cards.Enqueue(cardList[0]);
      cardList.RemoveAt(0);
    }
  }
}
