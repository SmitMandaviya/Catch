using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerscript : MonoBehaviour
{

    private Rigidbody2D rg;
    private float xinput;
    [SerializeField] private int movement;
    [SerializeField] Spawner spawner;

    
    void Start()
    {
       rg = GetComponent<Rigidbody2D>();
        spawner.spawner();
    }


    void FixedUpdate()
    {
        xinput = Input.GetAxisRaw("Horizontal");

        if (xinput != 0)
        {
            rg.AddForce(new Vector2(xinput * movement, 0f));
        }

    }

   
}
