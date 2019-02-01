using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
public class CountSystem : ComponentSystem
{
    struct Group{
        public int length;
        public ComponentDataArray<CountData> countData;
    }

    [Inject] Group group;
    protected override void OnUpdate(){
        for (int i = 0; i < group.length; i++)
        {
            var countData = group.countData[i];
            countData.count++;
            group.countData[i] = countData;
        }
    }
}

//class CountData : IComponentData
//{
//    public int count;
//}
