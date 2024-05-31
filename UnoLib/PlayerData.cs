namespace UnoLib;

public class PlayerData {
  public string name;
  public int id;
  public List<UnoCard> cards;

  public int Count => cards.Count;

  public PlayerData(string name, int id) {
    this.name = name;
    this.id = id;
    cards = new();
  }

  public void GiveCard(UnoCard card) {
    cards.Add(card);
  }

  public override string ToString() {
    return cards.Select((UnoCard card) => card.ToString())
                .Aggregate($"{name} ({id}) cards:", (string accumulator, string value) => $"{accumulator}\n{value}");
  }
}
