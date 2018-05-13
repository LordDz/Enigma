﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Enigma.Components.Base_Classes.Buildings;
using Assets.Enigma.Components.Base_Classes.Buildings.Barrack.Stats;

namespace Assets.Enigma.Components.UI.Buildings
{
    public class ButtonBuildingBarrack : ButtonBuilding
    {
        protected override void Init()
        {
            buildingStats = new BuildingStatsBarrack();
            base.Init();
        }
    }
}