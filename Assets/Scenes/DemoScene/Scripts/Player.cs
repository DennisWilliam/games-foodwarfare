using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DNSCoreMechanics.Behaviors.Entities;

public class Player: EntityBehavior2D<EntityTopDown2D> //: EntityBehavior2D
{
    // Start is called before the first frame update
    void Start()
    {
        EBInstance = new EntityTopDown2D();
        InitializeEntityBehaviorRequiredConfigs(5,5);
    }

    // Update is called once per frame
    void Update()
    {
        Move(transform,anim, canDash, movementSpeed, lookAtDirection);
        //  ExecuteDash();
    }

    private void FixedUpdate()
    {
        //Move();
    }
}
