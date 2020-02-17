using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Transforms;
using Unity.Jobs;

public class BrickSystem : JobComponentSystem
{
   // protected override void OnUpdate()
   // {
   //     Entities.ForEach((ref BrickComponent brick, ref RotationEulerXYZ euler) =>
   //     {
   //         euler.Value.y += brick.radiansPerSecond + Time.DeltaTime;
   //     });
   // }
    private struct BrickJob : IJobForEach<RotationEulerXYZ, BrickComponent>
    {
        public float deltaTime;
        public bool direction;
        public void Execute(ref RotationEulerXYZ euler, ref BrickComponent brick)
        {
            if (direction)
                euler.Value.y-= (brick.radiansPerSecond + deltaTime);
            else
                euler.Value.y += (brick.radiansPerSecond + deltaTime);
        }
    }
    protected override JobHandle OnUpdate(JobHandle inputDeps)
    {
        var job = new BrickJob { deltaTime = Time.DeltaTime, direction = Input.GetKey(KeyCode.A)  };
        return job.Schedule(this, inputDeps);
    }
}
