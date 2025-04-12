using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{

    public Text playerScoreText;
    int alienScore;
    int ufoScore;
    int enermyScore;
    int alientxtScore;
    int ufotxtScore;
    int enermytxtScore;
    
    int totalScore;

    // Start is called before the first frame update

    private void Start()
    {
        alienScore = GameObject.FindGameObjectsWithTag("Alien").Length;
        ufoScore = GameObject.FindGameObjectsWithTag("UFO").Length;
        enermyScore = GameObject.FindGameObjectsWithTag("UFO").Length;
    }

    private void Update()
    {
        alienScore = GameObject.FindGameObjectsWithTag("Alien").Length;
        ufoScore = GameObject.FindGameObjectsWithTag("UFO").Length;
        enermyScore = GameObject.FindGameObjectsWithTag("Enermy").Length;
        Debug.Log("Alien remain: " + alienScore);
        Debug.Log("UFO remain: " + ufoScore);
        Debug.Log("Enermy remain: " + enermyScore);
        PlayerGoal();
    }
    public void PlayerGoal()
    {
        alientxtScore = (40 - alienScore)*2;
        ufotxtScore = (1 - ufoScore) * 10;
        enermytxtScore = (1 - ufoScore) * 5;
        totalScore = alientxtScore + ufotxtScore;
        playerScoreText.text =totalScore.ToString();
        CheckScore();
    }

    // Update is called once per frame
    void CheckScore()
    {
        if(alienScore + ufoScore == 0)
        {
            SceneManager.LoadScene(2 );
        }
        
    }
}
