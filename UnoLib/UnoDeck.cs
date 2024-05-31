namespace UnoLib;

public class UnoDeck {
  private Queue<UnoCard> Cards {
    get;
  }

  public UnoDeck() {
    Cards = new Queue<UnoCard>();

    GenerateDeck();

    Shuffle();
    Shuffle();
    Shuffle();
  }

  public bool DrawCard(out UnoCard? card) {
    if (Cards.Count == 0) {
      // Deck is empty. Do nothing with the out param, and return false.
      card = null;
      return false;
    }

    card = Cards.Dequeue();
    return true;
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
