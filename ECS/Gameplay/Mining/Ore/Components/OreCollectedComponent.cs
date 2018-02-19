﻿using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace Assets.Sources.Gameplay.Mining.Ore.Components
{
    [Event(true), Unity]
    public class OreCollectedComponent : IComponent
    {
        public string id;
        public float amount;
    }
}