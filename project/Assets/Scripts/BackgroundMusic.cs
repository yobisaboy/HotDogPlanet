using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BackgroundMusic : MonoBehaviour
{
    public string Soundtrack = "Background";
    private void Start()
    {
        string soundtrack = Soundtrack;
        AudioManager.instance.Play(soundtrack);
    }
}
