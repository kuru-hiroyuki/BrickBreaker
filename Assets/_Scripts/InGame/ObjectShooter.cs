using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectShooter : MonoBehaviour
{
    //球を発射出来る回数
    public int _bulletCount = 50;

    public BulletTextManager _bulletTextManager;

    public UnityEngine.Events.UnityEvent OnFinished;

    //発射するオブジェクト
    public GameObject _bullet;

    public GameObject _bulletInstance;

    public PlayerScore _scoreManager;

    Rigidbody rb;

    [SerializeField] Camera _camera;

    [SerializeField] Vector3 _startPointTest;
    [SerializeField] float _speed;
    [SerializeField] Vector3 _initialVelocity;

    IEnumerator FinishCoroutine(float time)
    {
        yield return new WaitForSeconds(time);
        OnFinished.Invoke();
        yield break;
    }

    public void Shoot(Vector3 startpoint,Vector3 velocity)
    {
        _bulletInstance = Instantiate(_bullet);
        rb = _bulletInstance.GetComponent<Rigidbody>();
        _bulletInstance.GetComponent<BulletManager>()._scoreManager = _scoreManager;
        rb.position = startpoint;
        rb.velocity = velocity;
    }

    public void ShotBrick()
    {
        if (_bulletCount > 0)
        {
            Shoot(_camera.transform.position, _camera.transform.forward * _speed + _initialVelocity);
            _bulletCount--;
        }
        else
        {
            //球を撃ち終えたら10秒待ってからゲームを終了します
            StartCoroutine(FinishCoroutine(10f));
        }
        _bulletTextManager.UpdateText(_bulletCount);
    }
}
