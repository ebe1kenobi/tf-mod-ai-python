using Microsoft.Xna.Framework;
using Monocle;
using Patcher;
using TowerFall;
using TowerfallAi.Common;
using TowerfallAi.Core;

namespace TowerfallAi.Mod {
  [Patch]
  public class ModPauseMenu : PauseMenu {
    public ModPauseMenu(Level level, Vector2 position, MenuType menuType, int controllerDisconnected = -1) : base(level, position, menuType, controllerDisconnected) { }

    public override void VersusMatchSettingsAndSave() {
      if (AiMod.ModAITraining) {
        AiMod.EndSession();
        return;
      }
      
      Util.GetAction("$original_VersusMatchSettingsAndSave", this)();
    }

    public override void Quit() {
      if (AiMod.ModAITraining) {
        AiMod.EndSession();
        return;
      }

      Util.GetAction("$original_Quit", this)();
    }

    public override void VersusMatchSettings() {
      if (AiMod.ModAITraining) {
        AiMod.EndSession();
        return;
      }

      Util.GetAction("$original_VersusMatchSettings", this)();
    }

    public override void VersusArcherSelect() {

      if (AiMod.ModAITraining) {
        AiMod.EndSession();
        return;
      }

      Util.GetAction("$original_VersusArcherSelect", this)();
    }

    public override void QuestMap() {
      if (AiMod.ModAITraining) {
        AiMod.EndSession();
        return;
      }

      Util.GetAction("$original_QuestMap", this)();
    }

    public override void VersusRematch() {
      if (AiMod.ModAITraining) {
        AiMod.Rematch();
        return;
      }

      Util.GetAction("$original_VersusRematch", this)();
    }

    public override void QuestRestart() {
      if (AiMod.ModAITraining) {
        AiMod.Rematch();
        return;
      }

      Util.GetAction("$original_QuestRestart", this)();
    }

    public override void QuestMapAndSave() {
      if (AiMod.ModAITraining)
      {
        AiMod.EndSession();
        return;
      }

      Util.GetAction("$original_QuestMapAndSave", this)();
    }

    public override void QuitAndSave() {
      if (AiMod.ModAITraining) {
        AiMod.EndSession();
        return;
      }

      Util.GetAction("$original_QuitAndSave", this)();
    }
  }
}
