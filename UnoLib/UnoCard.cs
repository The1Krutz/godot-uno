namespace UnoLib;

public readonly struct UnoCard {
  // Public Fields
  public readonly Color Color;
  public readonly Value Value;

  // Backing Fields

  // Private Fields

  // Constructor
  public UnoCard(Color color, Value value) {
    Color = color;
    Value = value;
  }

  // Public Functions
  public override readonly string ToString() {
    return $"{Enum.GetName(typeof(Color), Color)} - {Enum.GetName(typeof(Value), Value)}";
  }

  // Private Functions
}
