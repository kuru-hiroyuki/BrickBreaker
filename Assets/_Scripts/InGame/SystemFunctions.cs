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
        SceneManager.LoadSceneAsync(gameObject.scene.name);
    }
    public void BackToTitle()
    {
        SceneManager.LoadSceneAsync(_anotherSceneName);
    }
    public void EndGame()
    {
        Application.Quit();
    }
}
