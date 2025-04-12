using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class enermyMovement : MonoBehaviour
{
    public float ufoSpeed;
    float timer = 0;
    float timeToMove = 0.8f;
    private Rigidbody2D rb;
    private Vector2 enermyDirection;
    int check;
    public int shoot;
    Enermy Enermy;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Enermy = GetComponent<Enermy>();
        check = 0;
        shoot = 0;

        rb.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (check == 0)
        {
            enermyDirection = new Vector3(-0.1f, 0, 0).normalized;
        }

        if (shoot == 1 )
        {
            Debug.Log("Update Shoot: " + shoot);
            Enermy.Activate();
        }

    }


    private void FixedUpdate()
    {
        rb.velocity = enermyDirection * ufoSpeed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.name == "BorderLeftUFO")
        {
            Debug.Log("Enermy: Hit left");
            enermyDirection = new Vector3(0.1f, 0, 0).normalized;
            check = 1;
            shoot = 1;
        }

        if (other.gameObject.name == "BorderRightUFO")
        {
            Debug.Log("Enermy: Hit right");
            enermyDirection = new Vector3(-0.1f, 0, 0).normalized;
            check = 1;
            shoot = 1;
        }


    }


 
}
