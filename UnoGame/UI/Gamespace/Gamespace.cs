using Godot;

namespace UnoGame;

/// <summary>
/// template
/// </summary>
public partial class Gamespace : MarginContainer {
  // Signals

  // Exports

  // Public Fields

  // Backing Fields

  // Private Fields

  // Constructor

  // Lifecycle Hooks

  // Called when the node enters the scene tree for the first time.
  public override void _Ready() {
    GD.Print("Ready");
  }

  // Called every frame. 'delta' is the elapsed time since the previous frame.
  public override void _Process(double delta) {
  }

  // Public Functions
  public void StartGame(int playerCount) {
    GD.Print($"starting game with options: {playerCount}");
  }

  // Private Functions
}
