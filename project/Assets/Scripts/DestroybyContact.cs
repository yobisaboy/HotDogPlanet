using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroybyContact : MonoBehaviour
{
    public ScoreManager scoreManager;
    int destroy = 0;
    alienMovement speed1,speed2, speed3, speed4, speed5;
    //alienMovement alienMovement;
    // Start is called before the first frame update
    void Start()
    {
        //alienMovement = GameObject.Find("Row").GetComponent<alienMovement>();
        
    }

    void SpeedAlien()
    {
        speed1 = GameObject.Find("Row1").GetComponent<alienMovement>();
        speed2 = GameObject.Find("Row2").GetComponent<alienMovement>();
        speed3 = GameObject.Find("Row3").GetComponent<alienMovement>();
        speed4 = GameObject.Find("Row4").GetComponent<alienMovement>();
        speed5 = GameObject.Find("Row5").GetComponent<alienMovement>();
        speed1.SpeedUp();
        speed2.SpeedUp();
        speed3.SpeedUp();
        speed4.SpeedUp();
        speed5.SpeedUp();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Alien speed: " + speed1);
        Debug.Log("Alien speed: " + speed2);
        Debug.Log("Alien speed: " + speed3);
        Debug.Log("Alien speed: " + speed4);
        Debug.Log("Alien speed: " + speed5);
    }
    public void OnCollisionEnter2D(Collision2D other)//something has collided
    {
        //create explosion
        //Instantiate(explosion, transform.position, transform.rotation);
        if (other.gameObject.tag == "Alien")
        {
            Debug.Log("Laser touch " + other.gameObject.name + " and destroyed it");
            AudioManager.instance.Play("Destroy");
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            
        }

        if (other.gameObject.tag == "Border")
        {
            AudioManager.instance.Play("Destroy");
            Destroy(this.gameObject);
        }

        if (other.gameObject.tag == "UFO")
        {
            Debug.Log("Laser hit UFO");
            AudioManager.instance.Play("Destroy");
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }

        if (other.gameObject.tag == "Enermy")
        {
            Debug.Log("Laser hit Enermy");
            AudioManager.instance.Play("Destroy");
            SpeedAlien();
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }

        if (other.gameObject.tag == "Bunker")
        {
            AudioManager.instance.Play("Destroy");
            Destroy(this.gameObject);
        }

        if (other.gameObject.tag == "eLaser")
        {
            Debug.Log("Laser hit eLaser");
            AudioManager.instance.Play("Destroy");
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }


    }
}
