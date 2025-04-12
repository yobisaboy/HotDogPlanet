using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enermyDestroybyContact : MonoBehaviour
{
    //public ScoreManager scoreManager;
    //int destroy = 0;
    // Start is called before the first frame update
    //Collider2D eLaser, alien;
    public int changeScene = 0;
    void Start()
    {
        //eLaser = GameObject.FindGameObjectWithTag("eLaser").GetComponent<Collider2D>();
        //alien = GameObject.FindGameObjectWithTag("Alien").GetComponent<Collider2D>();
        //IgnoreCollision(eLaser, alien);
    }

    //public static void IgnoreCollision(Collider2D collider1, Collider2D collider2, bool ignore = true)
    //{
    //    collider1.gameObject.SetActive(ignore);
    //    collider2.gameObject.SetActive(ignore);

    //}

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D other)//something has collided
    {
        //create explosion
        //Instantiate(explosion, transform.position, transform.rotation);       

        if (other.gameObject.tag == "Border")
        {
            AudioManager.instance.Play("Destroy");
            Destroy(this.gameObject);
        }

        if (other.gameObject.tag == "Player")
        {
            Debug.Log("enermy hit Player");
            AudioManager.instance.Play("Destroy");
            Destroy(other.gameObject);
            SceneManager.LoadScene(3);
            Destroy(this.gameObject);
            
        }

        if (other.gameObject.tag == "Bunker")
        {
            //need to add "gradually become destroyed"
            //Destroy(other.gameObject);
            AudioManager.instance.Play("Destroy");
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }

        if(other.gameObject.name == "BorderLeftIN")
        {
            Destroy(this.gameObject);
        }

        if (other.gameObject.name == "BorderRightIN")
        {
            Destroy(this.gameObject);
        }
    }
}
