using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Entity
{
    public float moveSpeed = 5f;

    public override void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0, vertical) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);
    }
}
