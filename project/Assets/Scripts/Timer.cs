using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    alienMovement alienMovement;
    string rowName;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(count());
        alienMovement = GetComponent<alienMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        count();
    }

    IEnumerator count()
    {
        if (gameObject.name == "Row5")
        {
            yield return new WaitForSeconds(1);
            alienMovement.timeUp = 1;
            Debug.Log("in Timer" + rowName);
        }
        if (gameObject.name == "Row4")
        {
            yield return new WaitForSeconds(2);
            alienMovement.timeUp = 1;
            Debug.Log("in Timer" + rowName);
        }
        if (gameObject.name == "Row3")
        {
            yield return new WaitForSeconds(3);
            alienMovement.timeUp = 1;
            Debug.Log("in Timer" + rowName);
        }
        if (gameObject.name == "Row2")
        {
            yield return new WaitForSeconds(4);
            alienMovement.timeUp = 1;
            Debug.Log("in Timer" + rowName);
        }
        if (gameObject.name == "Row1")
        {
            yield return new WaitForSeconds(5);
            alienMovement.timeUp = 1;
            Debug.Log("in Timer" + rowName);
        }






    }

}
