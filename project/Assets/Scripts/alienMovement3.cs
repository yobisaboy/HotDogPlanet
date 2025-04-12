using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class alienMovement3 : MonoBehaviour
{
    float timer = 0;
    float timeToMove = 0.8f;
    int checkerL;
    int checkerR;
    public int timeUp = 0;
    float speed;
    //Timer timerScp;
    // Start is called before the first frame update
    public void Start()
    {
        checkerL = 0;
        checkerR = 0;
        speed = 0.1f;
        //StartCoroutine(count());

    }

    public void SpeedUp()
    {
        speed += 0.2f;
    }
    public void Update()
    {
        Debug.Log("Alien speed: " + speed);
        if (checkerL == 0 && checkerR == 0 && timeUp == 1)
        {
            Debug.Log("in Update startMove IF");
            startMove();
        }
        
        if (checkerL == 1)
        {
            Debug.Log("in Update rightMove IF");
            rightMove();
        }

        if (checkerR == 1)
        {
            Debug.Log("in Update leftMove IF");
            leftMove();
        }


    }

    //IEnumerator count()
    //{
    //    yield return new WaitForSeconds(1);
    //}

    public void startMove()
    {
        Debug.Log("startMove method run");
        timer += Time.deltaTime;
        if (timer > timeToMove)
        {
            Debug.Log("in Update first IF");
            transform.Translate(new Vector3(-speed, 0, 0));
            timer = 0;
        }
    }

    public void rightMove()
    {
        Debug.Log("rightMove method run");
        timer += Time.deltaTime;
        if (timer > timeToMove)
        {
            Debug.Log("in rightMove IF");
            transform.Translate(new Vector3(speed, 0, 0));
            timer = 0;
            
        }
    }

    public void leftMove()
    {
        Debug.Log("leftMove method run");
        //Debug.Log("Timer: " + timer);
        //Debug.Log("TimeToMove: " + timeToMove);
        timer += Time.deltaTime;
        if (timer > timeToMove)
        {
            Debug.Log("in leftMove IF");
            transform.Translate(new Vector3(-speed, 0, 0));
            timer = 0;
        }
        
    }



    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.name == "BorderLeft")
        {
            checkerR = 0;
            checkerL = 1;
            Debug.Log("Hit left border then go down");
            transform.Translate(new Vector3(0, -0.1f, 0));
            Debug.Log("Move to right");
        }
        
        if (other.gameObject.name == "BorderRight")
        {
            checkerR = 1;
            checkerL = 0;
            Debug.Log("Hit right border then go down");
            transform.Translate(new Vector3(0, -0.1f, 0));
            Debug.Log("Move to left");
        }


    }

    


}
