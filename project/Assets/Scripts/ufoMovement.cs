using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ufoMovement : MonoBehaviour
{
    public float ufoSpeed;
    float timer = 0;
    float timeToMove = 0.8f;
    private Rigidbody2D rb;
    private Vector2 ufoDirection;
    int check;
    GameObject uFO;
    int location;
    int randFall;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        check = 0;

        uFO = GameObject.Find("UFO");
        uFO.gameObject.transform.localScale = Vector3.zero;
        rb.gravityScale = 0;
        location = Random.Range(-9, 9);
        Debug.Log("Start location: " + location);
        randFall = Random.Range(1, 10);
        StartCoroutine(count());
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update: normalized");
        if (check == 0)
        { 
            ufoDirection = new Vector3(-0.1f, 0, 0).normalized;
        }
        count();
    }

    IEnumerator count()
    {
        Debug.Log("Start counting: " + randFall + "sec");
        yield return new WaitForSeconds(randFall);
        Activate();
        
    }

    private void FixedUpdate()
    {
        rb.velocity = ufoDirection * ufoSpeed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.name == "BorderLeftUFO")
        {
            Debug.Log("UFO: Hit left");
            ufoDirection = new Vector3(0.1f, 0, 0).normalized;
            check = 1;
        }

        if (other.gameObject.name == "BorderRightUFO")
        {
            Debug.Log("UFO: Hit right");
            ufoDirection = new Vector3(-0.1f, 0, 0).normalized;
            check = 1;
        }


    }

    public void Activate()
    {
        Debug.Log("UFO appear");
        Debug.Log("Activate location: " + location);
        uFO.gameObject.transform.localScale = new Vector3(1, 1, 1);
        uFO.gameObject.transform.position = new Vector3(location, 5.8f, 0);
        Debug.Log("UFO position: " + transform.position);
    }

 
}
