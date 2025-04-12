using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScene : MonoBehaviour
{
    int currentId;
    
    // Start is called before the first frame update
    void Start()
    {
        currentId = SceneManager.GetActiveScene().buildIndex;
        
    }
    private void Update()
    {
        if (Input.GetAxis("Fire2") > 0 && currentId == 0)
        {
            Debug.Log("in LoadScene");
            SceneManager.LoadScene(1);
        }

        if (Input.GetAxis("Fire2") > 0 && currentId == 2)
        {
            Debug.Log("Going back to the startScene");
            SceneManager.LoadScene(0);
        }

        if (Input.GetAxis("Fire2") > 0 && currentId == 3)
        {
            Debug.Log("Going back to the startScene");
            SceneManager.LoadScene(0);
        }

        

    }
}
