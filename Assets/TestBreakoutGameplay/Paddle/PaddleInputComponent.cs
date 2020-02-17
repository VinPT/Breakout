using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

[GenerateAuthoringComponent]
public struct PaddleInputComponent : IComponentData
{
    public KeyCode leftKey;
    public KeyCode rightKey;

}
