using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public GameObject sceneOne;
    public GameObject sceneTwo;

    public GameObject homePanel;
    public GameObject gameplayPanel;
    public GameObject finishPanel;
    public GameObject levelPanel;

    public GameObject player1;
    public GameObject player2;
    private Vector3 playerStartPositon;

    public Image levelTwoButtonImage;
    Color currentColour;

    public bool levelOneDone;

    private void Start()
    {
        currentColour = levelTwoButtonImage.color;
        
    }

    public void Gamplay()
    {
        levelPanel.SetActive(true);
    }

    public void Finish()
    {
        currentColour.a = 255;
        levelTwoButtonImage.color = currentColour;
        finishPanel.SetActive(true);
    }

    public void Home()
    {

        homePanel.SetActive(true);
        gameplayPanel.SetActive(false);

    }

    public void PlayAgain()
    {
        homePanel.SetActive(true);
        finishPanel.SetActive(false);
        gameplayPanel.SetActive(false);
    }

    public void LevelOne()
    {
        //player.transform.position = playerStartPositon;
        player1.transform.position = new Vector3(0, 0, 0);
        player2.transform.position = new Vector3(0, 0, 0);
        sceneOne.SetActive(true);
        sceneTwo.SetActive(false);
        homePanel.SetActive(false);
        gameplayPanel.SetActive(true);
        levelPanel.SetActive(false);

    }
    
    public void LevelTwo()
    {
        if (levelOneDone)
        {
            player1.transform.position = new Vector3(0, 0, 0);
            player2.transform.position = new Vector3(0, 0, 0);
            sceneTwo.SetActive(true);
            sceneOne.SetActive(false);
            homePanel.SetActive(false);
            gameplayPanel.SetActive(true);
            levelPanel.SetActive(false);
        }
        

    }

}
