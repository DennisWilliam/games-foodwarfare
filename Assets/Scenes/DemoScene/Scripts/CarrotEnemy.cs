using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using DNSCoreMechanics.AI;
public class CarrotEnemy : EntityAITopDown2D //: EnemyCoreAI
{
    // Start is called before the first frame update
    void Start()
    {
        EBInstance = new EntityTopDown2D();
        InitializeEntityBehaviorRequiredConfigs(5,5);
        distanceBetween = 20;
        //initializeEnemyCoreAIRequiredConfigs("Player", "BulletsContainer");
    }

    // Update is called once per frame
    void Update()
    {
        Chase();
        RotateFowardsAnotherEntity();
       // ChasePlayer();
        //AttackTarget();
    }
}
