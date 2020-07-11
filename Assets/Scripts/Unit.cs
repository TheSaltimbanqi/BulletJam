using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public Rigidbody2D rb2d;
    [Header("Stats")]
    public float speed = 0;
    public float attack = 1f;
    public int lives = 3;
    
}
