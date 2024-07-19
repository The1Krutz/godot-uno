using Godot;

namespace UnoGame;

/// <summary>
/// template
/// </summary>
public partial class Base : Control {
  // Signals

  // Exports

  // Public Fields

  // Backing Fields

  // Private Fields
  private CanvasItem mainMenu;
  private Gamespace gamespace;
  private CanvasItem currentScreen;

  // Constructor

  // Lifecycle Hooks

  // Called when the node enters the scene tree for the first time.
  public override void _Ready() {
    mainMenu = GetNode<CanvasItem>("MainMenu");
    gamespace = GetNode<Gamespace>("Gamespace");
    currentScreen = mainMenu;

    SetDefaultVisibililty();
  }

  // Called every frame. 'delta' is the elapsed time since the previous frame.
  public override void _Process(double delta) {
  }

  // Public Functions
  public void OnStartGame(int playerCount) {
    SwitchToGamespace();
    gamespace.StartGame(playerCount);
  }

  // Private Functions
  private void SetDefaultVisibililty() {
    mainMenu.Visible = true;
    gamespace.Visible = false;
  }

  private void SwitchToGamespace() {
    mainMenu.Visible = false;
    gamespace.Visible = true;
  }
}
