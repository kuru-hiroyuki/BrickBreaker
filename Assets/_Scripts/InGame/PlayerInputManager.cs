using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputManager : MonoBehaviour
{
    //�C���X�y�N�^�ŕ\������ϐ�
    #region
    //�W���C�X�e�B�b�N���͂̐��f�[�^
    [SerializeField] Vector2 _joystickInput;
    [SerializeField] Vector2 _rightjoystickInput;
    public RotateMachineManager rotateMachine;
    public CameraManager cameraManager;
   
    #endregion

    //public�Ȋ֐�
    #region
    /// <summary>
    /// �v���C���[�C���v�b�g���Őݒ肷��
    /// �X�e�B�b�N�̓��͂��ς������M����������
    /// </summary>
    /// <param name="context"></param>
    public void OnStickInputChanged(InputAction.CallbackContext context)
    {
        _joystickInput = context.ReadValue<Vector2>();
        Debug.Log("���X�e�B�b�N���͂�����܂���");
    }
    public void OnRightStickInputChanged(InputAction.CallbackContext context)
    {
        _rightjoystickInput = context.ReadValue<Vector2>();
        Debug.Log("�E�X�e�B�b�N���͂�����܂���");
    }
    #endregion

    //private�Ȋ֐�
    #region

    #endregion

    //�R���[�`��
    #region
    #endregion


    //Unity�̊֐�
    #region
    // Update is called once per frame
    void Update()
    {
        cameraManager.Rotate(_rightjoystickInput);
        rotateMachine.Rotate(_joystickInput.x);
    }
    #endregion
}
