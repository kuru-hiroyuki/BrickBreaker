using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject _camera;
    public float speed;
    public Vector2 Max;

    

    public void Rotate(Vector2 input)
    {
        Vector2 rotation = new Vector2(input.x * Max.x ,input.y * Max.y);

        _camera.transform.localEulerAngles =new Vector3(-rotation.y,rotation.x,0); 
    }
    Vector2 ClampVector2(Vector2 value,Vector2 Min,Vector2 Max)
    {
        float x = Mathf.Clamp(value.x,Min.x,Max.x);
        float y = Mathf.Clamp(value.y,Min.y,Max.y);
        return new Vector2(x,y);
    }
}
