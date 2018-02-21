﻿using FMOD.Studio;
using Microsoft.Xna.Framework;
using Monocle;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace Celeste.Mod.Ghost {
    public class GhostModuleSettings : EverestModuleSettings {

        public bool Enabled { get; set; } = true;

        [SettingRange(0, 10)]
        public int InnerOpacity { get; set; } = 5;
        [YamlIgnore]
        [SettingIgnore]
        public float InnerOpacityFactor => InnerOpacity / 10f;

        [SettingRange(0, 10)]
        public int OuterOpacity { get; set; } = 1;
        [YamlIgnore]
        [SettingIgnore]
        public float OuterOpacityFactor => OuterOpacity / 10f;

        [SettingRange(1, 10)]
        public int InnerRadius { get; set; } = 4;
        [YamlIgnore]
        [SettingIgnore]
        public float InnerRadiusDist => InnerRadius * InnerRadius * 64f;

        [SettingRange(0, 10)]
        public int BorderSize { get; set; } = 4;
        [YamlIgnore]
        [SettingIgnore]
        public float BorderSizeDist => BorderSize * BorderSize * 64f;

        public bool FloatingHair { get; set; } = false;

        public bool ShowDeaths { get; set; } = false;

    }
}
