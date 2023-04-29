using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class SystemFunctions : MonoBehaviour
{
    public PlayerInput playerInput;
    public string playActionMap;
    public string UIActionName;

    public bool isLoading = false;

    public string _anotherSceneName;
public void SetTimeScale(float value)
    {
        Time.timeScale = value;
    }
    public void ChangeActionMap()
    {
        playerInput.SwitchCurrentActionMap(UIActionName);
    }

    public void ReloadThisScene()
    {
        if(!isLoading)
        SceneManager.LoadSceneAsync(gameObject.scene.name);
        isLoading = true;
    }
    public void BackToTitle()
    {
        if(!isLoading)
        SceneManager.LoadSceneAsync(_anotherSceneName);
        isLoading = true;
    }
    public void EndGame()
    {
        Application.Quit();
    }

    private void Awake()
    {
        SetTimeScale(1f);
    }
}
