using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase11
{
public class StanleyController02 : EntityBase
{
    //[Header("Stanley")]
    protected override void Update()
    {
        base.Update();
        if (!(state == EntityState.Idle || state == EntityState.Moving))
            return;

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 move = Vector2.zero;
        move.x = horizontal;
        move.y = vertical;

        move.Normalize();

        movement = move;

        if (Input.GetKeyDown(KeyCode.E))
        {
            Punch();
        }
    }
}
}
