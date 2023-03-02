using System.Collections;
using System.Collections.Generic;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField TMP_InputField;
    public TMP_Text highScore;

    private void Start()
    {
        MenuManager.Instance.LoadHighScore();
        if (MenuManager.Instance != null)
        {
            highScore.text = "High Score : " + MenuManager.Instance.highScoreName + " : " + MenuManager.Instance.highScore;
        }
    }
    public void StartNew()
    {
        MenuManager.Instance.playerName = TMP_InputField.text;
        SceneManager.LoadScene(1);
    }    


    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}
