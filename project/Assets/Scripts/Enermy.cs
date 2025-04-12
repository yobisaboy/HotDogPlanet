using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enermy : MonoBehaviour
{
    private Rigidbody2D rb;
    public float fireRate = 0.15f;
    private float timer = 0;
    public GameObject Laser;
    public GameObject laserSpawner;
    enermyMovement enermyMovement;
    int shoot;
    int randShoot;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        enermyMovement = GetComponent<enermyMovement>();
        shoot = enermyMovement.shoot;
    }

    // Update is called once per frame
    void Update()
    {
        //if(shoot == 1)
        //{
        //    Debug.Log("Shoot is " + shoot);
        //    count();
        //}
        count();
        
    }

    public void Activate()
    {
        StartCoroutine(count());
    }
    public void Shoot()
    {
        if (timer > fireRate)
        {
            randShoot = Random.Range(-10, 0);
            GameObject gooj;
            gooj = GameObject.Instantiate(Laser, laserSpawner.transform.position, laserSpawner.transform.rotation);
            gooj.transform.Rotate(new Vector3(0, 0, 0));

            timer = randShoot;
        }

        timer += Time.deltaTime;
        

    }
    public IEnumerator count()
    {
        yield return new WaitForSeconds(2);
        Shoot();
        Debug.Log("In count");

    }

  

}
