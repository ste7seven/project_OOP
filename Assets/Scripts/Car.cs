using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Entity
{
    public float moveSpeed = 10f;

    public override void Move()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
