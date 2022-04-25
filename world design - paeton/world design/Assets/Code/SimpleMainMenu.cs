using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SimpleMainMenu : MonoBehaviour
{
    public Button startButton;

    private void OnEnable()
    {
        startButton.onClick.AddListener(StartGame);
    }


    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
