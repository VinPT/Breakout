using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Jobs;
using Unity.Transforms;
using Unity.Mathematics;


public class PaddleSystem : JobComponentSystem
{
    
    protected override JobHandle OnUpdate(JobHandle inputDeps)
    {
        float deltaTime = Time.DeltaTime;

        Entities.ForEach((ref Translation trans, ref PaddleComponent paddle, in PaddleInputComponent paddleInput ) =>
        {
            if (Input.GetKey(paddleInput.leftKey))
                paddle.direction = -1;
            else if (Input.GetKey(paddleInput.rightKey))
                paddle.direction = 1;

            trans.Value.x += paddle.unitsPerSecond * paddle.direction * deltaTime;

        }).Run();


        return inputDeps;
    }
}