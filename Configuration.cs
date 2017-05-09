﻿using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace coolpuppy24.simpledeathmessages
{
    public class Configuration : IRocketPluginConfiguration
    {
        public string DeathMessagesColor;
        public bool ShowSuicideMSG;
        public bool EnableExpOnKill;
        public int ExpOnKill;

        public void LoadDefaults()
        {
            DeathMessagesColor = "Red";
            ShowSuicideMSG = true;
            EnableExpOnKill = true;
            ExpOnKill = 100;
        }
    }
}

