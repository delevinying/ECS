using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
public class ECSMain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var entityManager = World.Active.GetOrCreateManager<EntityManager>();

        var sample = entityManager.CreateArchetype(typeof(CountData));

        entityManager.CreateEntity(sample);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
