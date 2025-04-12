using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class alienKill : MonoBehaviour
{
    
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Alien hit Player");
            Destroy(other.gameObject);
            SceneManager.LoadScene(3);
            Destroy(this.gameObject);
        }

        if (other.gameObject.tag == "Bunker")
        {
            Debug.Log("Alien hit Player");
            Destroy(other.gameObject);
            SceneManager.LoadScene(3);
            Destroy(this.gameObject);
        }
    }
}
