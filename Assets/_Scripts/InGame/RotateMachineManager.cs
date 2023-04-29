using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMachineManager : MonoBehaviour
{
    public float rotateSpeed = 40f;
    public void Rotate(float degreespersec)
    {
        this.transform.Rotate(new Vector3(0,degreespersec,0)*rotateSpeed*Time.deltaTime);
    }
}
