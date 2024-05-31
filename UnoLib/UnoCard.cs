namespace UnoLib;

public readonly struct UnoCard {
  public readonly Color Color;
  public readonly Value Value;

  public UnoCard(Color color, Value value) {
    Color = color;
    Value = value;
  }

  public override readonly string ToString() {
    return $"{Enum.GetName(typeof(Color), Color)}:{Enum.GetName(typeof(Value), Value)}";
  }
}
