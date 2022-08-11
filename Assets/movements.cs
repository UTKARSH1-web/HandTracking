using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movements : MonoBehaviour
{
    // Start is called before the first frame update
    public BallMovements movement;
    void Start()
    {
        print("hey");
    }

    // Update is called once per frame
    void Update()
    {
       if(movement.enabled==true)
        transform.Translate(0,0,10*Time.deltaTime);
         
    }
}
