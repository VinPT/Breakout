using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Transforms;
using Unity.Jobs;

/*public class ZSystem : JobComponentSystem
{

    private struct ZJob : IJobForEach<Translation>
    {
        public void Execute(ref Translation objectTranslation)
        {
            objectTranslation.Value.z = 0;
        }
    }
    protected override JobHandle OnUpdate(JobHandle inputDeps)
    {
        var job = new ZJob {};
        return job.Schedule(this, inputDeps);
    }
}*/