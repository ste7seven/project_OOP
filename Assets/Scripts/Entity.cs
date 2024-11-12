using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    public Vector3 position;
    public abstract void Move(); // Abstrakte Methode für Bewegung
}
