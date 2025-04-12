using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ignore : MonoBehaviour
{
    //Set the speed number in the Inspector window
    //public float m_Speed;
    Rigidbody2D m_Rigidbody;

    void Start()
    {
        //Fetch the Rigidbody component from the GameObject
        m_Rigidbody = GetComponent<Rigidbody2D>();
        //Ignore the collisions between layer 0 (default) and layer 8 (custom layer you set in Inspector window)
        Physics.IgnoreLayerCollision(0, 8);
    }

    void Update()
    {
      
    }

    public static void IgnoreLayerCollision(int layer1, int layer2, bool ignore = true)
    {

    }

    //Detect when there is a collision
    void OnCollisionStay2D(Collision2D collide)
    {
        //Output the name of the GameObject you collide with
        Debug.Log("I hit the GameObject : " + collide.gameObject.name);
    }
}
