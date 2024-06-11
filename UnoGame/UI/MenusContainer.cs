using Godot;

namespace UnoGame;

/// <summary>
/// Manages the movement between menu screens
/// </summary>
public partial class MenusContainer : CenterContainer {
  // Signals

  // Exports

  // Public Fields

  // Backing Fields

  // Private Fields
  private CanvasItem TitleMenu;
  private CanvasItem StartMenu;
  private Dictionary<Menus, CanvasItem> MenuMap;
  private CanvasItem CurrentMenu;

  // Constructor

  // Lifecycle Hooks

  // Called when the node enters the scene tree for the first time.
  public override void _Ready() {
    TitleMenu = GetNode<CanvasItem>("TitleMenu");
    StartMenu = GetNode<CanvasItem>("StartMenu");

    CurrentMenu = TitleMenu;

    MenuMap = new(){
      { Menus.Title, TitleMenu },
      { Menus.Start, StartMenu }
    };

    GD.Print($"got menus: {TitleMenu}, {StartMenu}");
  }

  // Public Functions
  public void OnSwitchMenu(Menus targetMenu) {
    GD.Print($"switching to new menu {targetMenu}");

    CanvasItem newMenu = MenuMap[targetMenu];

    CurrentMenu.Visible = false;
    newMenu.Visible = true;
  }

  // Private Functions
}

public enum Menus {
  Title,
  Start,
  Options
}
