using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    public Vector3 _velocity;
    public int _score = 1;
    [SerializeField] string deadlineTag;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _velocity = rb.velocity;
    }
    //éÄàÊÇ…çsÇ¡ÇΩÇÁ
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag(deadlineTag))
        {
            //è¡Ç¶Ç‹Ç∑
            Vanish();
        }
    }

    public void Vanish()
    {
        Destroy(this.gameObject);
    }
}
