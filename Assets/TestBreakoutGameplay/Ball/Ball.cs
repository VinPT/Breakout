using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public struct Ball : IComponentData
{
    public float speed;
    public int color; //we need something better than this
}
