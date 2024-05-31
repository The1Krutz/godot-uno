namespace UnoLib.Test;

public class UnoCardTests {
  [Fact]
  public void DefaultCardTest() {
    UnoCard testing = new();
    const string Expected = "Red - Zero"; // default enum value is the first ones

    Assert.Equal(Expected, testing.ToString());
  }

  [Fact]
  public void ToStringWorks() {
    UnoCard testing = new(Color.Red, Value.Five);
    const string Expected = "Red - Five";

    Assert.Equal(Expected, testing.ToString());
  }

  [Theory]
  [InlineData(Color.Red, Value.Three, "Red - Three")]
  [InlineData(Color.Wild, Value.Wild, "Wild - Wild")]
  [InlineData(Color.Blue, Value.DrawTwo, "Blue - DrawTwo")]
  public void ToStringWorksAgain(Color c, Value v, string expected) {
    UnoCard testing = new(c, v);

    Assert.Equal(expected, testing.ToString());
  }
}
