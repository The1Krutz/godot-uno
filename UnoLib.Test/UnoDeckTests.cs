namespace UnoLib.Test;

public class UnoDeckTests {

  [Fact]
  public void DeckInitializesCorrectly() {
    UnoDeck deck = new UnoDeck();

    Assert.Equal(112, deck.Count);
  }

  [Fact]
  public void DeckDisplaysCorrectlyWithOneCard() {
    var oneCardDeck = new List<UnoCard>() { new UnoCard(Color.Blue, Value.Six) };
    UnoDeck deck = new UnoDeck(oneCardDeck);
    string expected = "cards:\nBlue - Six";

    Assert.Equal(1, deck.Count);
    Assert.Equal(expected, deck.ToString());
  }

  [Fact]
  public void DeckDisplaysCorrectlyWithTwoCards() {
    var oneCardDeck = new List<UnoCard>() {
      new UnoCard(Color.Blue, Value.Six),
      new UnoCard(Color.Red, Value.Three)
    };
    UnoDeck deck = new UnoDeck(oneCardDeck);
    string expected = "cards:\nBlue - Six\nRed - Three";

    Assert.Equal(2, deck.Count);
    Assert.Equal(expected, deck.ToString());
  }
}
