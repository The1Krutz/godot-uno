using Godot;

namespace UnoGame;

/// <summary>
/// Handles the Start Game menus. Also manages the starting conditions for the game since this is where they're all set
/// </summary>
public partial class StartMenu : VBoxContainer {
  // Signals
  [Signal]
  public delegate void SwitchMenuEventHandler(Menus targetMenu);

  // Exports

  // Public Fields

  // Backing Fields

  // Private Fields
  private int playerCount = 2;
  private Label playerCountLabel;

  // Constructor

  // Lifecycle Hooks

  // Called when the node enters the scene tree for the first time.
  public override void _Ready() {
    playerCountLabel = GetNode<Label>("GameOptions/PlayerCountLabel");
  }

  // Public Functions
  public void OnBackToTitlePressed() {
    EmitSignal(SignalName.SwitchMenu, (int)Menus.Title);
  }

  public void OnPlayerCountChanged(float value) {
    playerCount = (int)value;

    playerCountLabel.Text = $"Players: {playerCount}";
  }

  // Private Functions
}
