using System.Collections;
using System.Collections.Generic;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField TMP_InputField;
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    private void Start()
    {
        MenuManager.Instance.playerName = TMP_InputField.text;
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
