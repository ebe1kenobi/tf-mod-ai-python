using Microsoft.Xna.Framework;
using Monocle;
using Patcher;
using TowerFall;
using TowerfallAi.Core;

namespace TowerfallModPlayTag
{
  [Patch]
  public class MyMainMenu : MainMenu
  {
    //Loader a;
    public MyMainMenu(MenuState state) : base(state) {
      //Loader a = new Loader(showMessage: true);
      //Add(a);
    }

    public override void Update()
    {
      if (AiMod.ModAIEnabled) {
        if (!AiMod.PreUpdate()) {
          TFGame.GameLoaded = false;
        } else {
          TFGame.GameLoaded = true;
        }
      }
      base.Update();
    }
  }
}
