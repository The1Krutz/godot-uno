using Godot;

namespace UnoGame;

/// <summary>
/// Manages the movement between menu screens
/// </summary>
public partial class MainMenu : MarginContainer {
  // Signals
  [Signal]
  public delegate void StartGameEventHandler(int playerCount);

  // Exports

  // Public Fields

  // Backing Fields

  // Private Fields
  private CanvasItem titleMenu;
  private CanvasItem startMenu;
  private Dictionary<Menus, CanvasItem> menuMap;
  private CanvasItem currentMenu;

  // Constructor

  // Lifecycle Hooks

  // Called when the node enters the scene tree for the first time.
  public override void _Ready() {
    titleMenu = GetNode<CanvasItem>("TitleMenu");
    startMenu = GetNode<CanvasItem>("StartMenu");

    currentMenu = titleMenu;

    menuMap = new(){
      { Menus.Title, titleMenu },
      { Menus.Start, startMenu }
    };

    SetDefaultMenuVisibility();
  }

  // Public Functions
  public void OnSwitchMenu(Menus targetMenu) {
    GD.Print($"switching to new menu {targetMenu}");

    CanvasItem newMenu = menuMap[targetMenu];

    currentMenu.Visible = false;
    newMenu.Visible = true;

    currentMenu = newMenu;
  }

  public void OnStartGamePressed(int playerCount) {
    EmitSignal(SignalName.StartGame, playerCount);
  }

  // Private Functions
  private void SetDefaultMenuVisibility() {
    titleMenu.Visible = true;
    startMenu.Visible = false;
  }
}

public enum Menus {
  Title,
  Start
}
