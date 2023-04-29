using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputManager : MonoBehaviour
{
    //インスペクタで表示する変数
    #region
    //ジョイスティック入力の生データ
    [SerializeField] Vector2 _joystickInput;
    [SerializeField] Vector2 _rightjoystickInput;
    public RotateMachineManager rotateMachine;
    public CameraManager cameraManager;
   
    #endregion

    //publicな関数
    #region
    /// <summary>
    /// プレイヤーインプット側で設定する
    /// スティックの入力が変わったら信号が送られる
    /// </summary>
    /// <param name="context"></param>
    public void OnStickInputChanged(InputAction.CallbackContext context)
    {
        _joystickInput = context.ReadValue<Vector2>();
        Debug.Log("左スティック入力がされました");
    }
    public void OnRightStickInputChanged(InputAction.CallbackContext context)
    {
        _rightjoystickInput = context.ReadValue<Vector2>();
        Debug.Log("右スティック入力がされました");
    }
    #endregion

    //privateな関数
    #region

    #endregion

    //コルーチン
    #region
    #endregion


    //Unityの関数
    #region
    // Update is called once per frame
    void Update()
    {
        cameraManager.Rotate(_rightjoystickInput);
        rotateMachine.Rotate(_joystickInput.x);
    }
    #endregion
}
