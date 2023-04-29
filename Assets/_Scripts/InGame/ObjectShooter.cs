using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectShooter : MonoBehaviour
{
    //発射するオブジェクト
    public GameObject _bullet;

    public GameObject _bulletInstance;

    Rigidbody rb;

    [SerializeField] Camera _camera;

    [SerializeField] Vector3 _startPointTest;
    [SerializeField] float _speed;
    [SerializeField] Vector3 _initialVelocity;

    public void Shoot(Vector3 startpoint,Vector3 velocity)
    {
        _bulletInstance = Instantiate(_bullet);
        rb = _bulletInstance.GetComponent<Rigidbody>();
        rb.position = startpoint;
        rb.velocity = velocity;
    }

    public void ShotTest()
    {
        Shoot(_camera.transform.position,_camera.transform.forward*_speed + _initialVelocity);
    }
}
