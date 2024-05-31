namespace UnoLib.Test;

public class PlayerDataTests {
  [Fact]
  public void PlayerCanBeGivenCard() {
    PlayerData player = new("Jim", 2);
    string expected = "Jim (2) cards:";

    Assert.Equal(0, player.Count);
    Assert.Equal(expected, player.ToString());

    player.GiveCard(new UnoCard(Color.Blue, Value.Six));

    expected = "Jim (2) cards:\nBlue - Six";
    Assert.Equal(1, player.Count);
    Assert.Equal(expected, player.ToString());
  }
}
