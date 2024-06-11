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
    GD.Print("start game pressed!");

    EmitSignal(SignalName.SwitchMenu, (int)Menus.Start);
  }

  public void OnOptionsPressed() {
    GD.Print("options pressed!");

    EmitSignal(SignalName.SwitchMenu, (int)Menus.Options);
  }

  public void OnExitPressed() {
    GD.Print("exit pressed!");

    GetTree().Root.PropagateNotification((int)NotificationWMCloseRequest);
    GetTree().Quit();
  }

  // Private Functions
}
