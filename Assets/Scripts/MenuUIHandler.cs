using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    public Button startButton;
    public InputField inputName;

    // Start is called before the first frame update
    void Start()
    {
        // Les commandes pour accéder au bouton sont bonnes !!!
        //startButton = GameObject.Find("StartButton").GetComponent<Button>();
        startButton = gameObject.GetComponentInChildren<Button>();
        //inputName = GameObject.Find("InputName").GetComponent<InputField>();
        inputName = gameObject.GetComponentInChildren<InputField>();
        //GameObject.Find("StartButton").gameObject.SetActive(false);




        //startButton.interactable = false;
        DisableStartButton();
    }

    public void StartNewGame()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetStartButtonState()
    {
        if (inputName.text.Length > 0)
        {
            EnableStartButton();
        }
        else
        {
            DisableStartButton();
        }
    }

    public void EnableStartButton()
    {
        startButton.interactable = true;
    }

    public void DisableStartButton()
    {
        startButton.interactable = false;
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
