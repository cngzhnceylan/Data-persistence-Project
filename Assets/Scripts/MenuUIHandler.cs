using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    
    public TMP_InputField InputField;
    public TextMeshProUGUI bestScoreText;
     

private void Start()
{
    
    bestScoreText.text="Best Score : "+DataManager.Instance.playerName+" : "+DataManager.Instance.bestScore;
}

public void StartNew()
{
    SceneManager.LoadScene(1);

}

public void Quit()
{
    #if UNITY_EDITOR
    EditorApplication.ExitPlaymode();
    #else
    Application.Quit();
    #endif
}
public void SetName()
{
    DataManager.Instance.currentPlayerName=InputField.text;
}
}
