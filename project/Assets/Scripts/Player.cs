using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;
    public float fireRate = 0.15f;
    private float timer = 0;
    public GameObject Laser;
    public GameObject laserSpawner;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionX = Input.GetAxisRaw("Horizontal");
        playerDirection = new Vector2(directionX, 0).normalized;

        if (Input.GetAxis("Fire1") > 0 && timer > fireRate)
        {
            GameObject gooj;
            gooj = GameObject.Instantiate(Laser, laserSpawner.transform.position, laserSpawner.transform.rotation);
            gooj.transform.Rotate(new Vector3(0, 0, 0));

            timer = 0;
        }

        timer += Time.deltaTime;

    }

    private void FixedUpdate()
    {
        rb.velocity = playerDirection * playerSpeed;
    }
}
