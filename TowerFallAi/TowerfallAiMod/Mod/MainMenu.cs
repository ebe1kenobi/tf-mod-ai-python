using Microsoft.Xna.Framework;
using Monocle;
using Patcher;
using TowerFall;
using TowerfallAi.Core;
using TowerfallAi.Common;

namespace TowerfallAi.Mod
{
  [Patch]
  public class MyMainMenu : MainMenu
  {
    public MyMainMenu(MenuState state) : base(state) {}

    public override void Update()
    {
      if (AiMod.ModAIEnabled) {
        if (!AiMod.PreUpdate()) {
          TFGame.GameLoaded = false;
          AiMod.AgentConnected = false;
        } else {
          TFGame.GameLoaded = true;
          AiMod.AgentConnected = true;
        }
      }
      base.Update();
    }
  }
}
