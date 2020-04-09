﻿using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.MountAndBlade;

namespace EnhancedMission
{
    public class EnhancedMissionSubModule : MBSubModuleBase
    {
        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {
            base.OnGameStart(game, gameStarterObject);

            game.GameTextManager.LoadGameTexts(BasePath.Name + "Modules/EnhancedMission/ModuleData/module_strings.xml");
        }
    }
}
