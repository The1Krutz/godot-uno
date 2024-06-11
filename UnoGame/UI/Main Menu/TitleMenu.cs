using Godot;

namespace UnoGame;

/// <summary>
/// Button handlers for the title menu screen
/// </summary>
public partial class TitleMenu : VBoxContainer {
  // Signals
  [Signal]
  public delegate void SwitchMenuEventHandler(Menus targetMenu);

  // Exports

  // Public Fields

  // Backing Fields

  // Private Fields

  // Constructor

  // Lifecycle Hooks

  // Called when the node enters the scene tree for the first time.
  public override void _Ready() {
  }

  // Public Functions
  public void OnStartGamePressed() {
    EmitSignal(SignalName.SwitchMenu, (int)Menus.Start);
  }

  public void OnExitPressed() {
    GetTree().Root.PropagateNotification((int)NotificationWMCloseRequest);
    GetTree().Quit();
  }

  // Private Functions
}
