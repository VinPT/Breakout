using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

[GenerateAuthoringComponent]
public struct PaddleComponent : IComponentData
{
    public float unitsPerSecond;
    public int size;
    public int direction;
    public bool reverse;

    

}