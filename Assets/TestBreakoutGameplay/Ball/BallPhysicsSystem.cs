using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Transforms;
using Unity.Jobs;
using UnityEngine;

public class BallPhysicsSystem : JobComponentSystem
{

    private float speed = 2f;
    Renderer rend;
    int colorPicker = 0;


    private struct BallJob : IJobForEach<Ball>
    {
        public Entity thisGameObject;

        public void Execute(ref Ball c0)
        {
            throw new System.NotImplementedException();
        }
    }
    protected override JobHandle OnUpdate(JobHandle inputDeps)
    {
        //var job = new BallJob { thisGameObject =  };
        //return job.Schedule(this, inputDeps);
        return inputDeps;
    }
}

