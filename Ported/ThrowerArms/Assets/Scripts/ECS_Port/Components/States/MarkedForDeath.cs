﻿using System;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

[Serializable]
public struct MarkedForDeath : IComponentData
{
    public float Timer;
}
