using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
    Rigidbody RB;
    [SerializeField] private float speed;
    private void Awake()
    {
        RB = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if(transform.position.z>= 30)
        {
            Destroy(this.gameObject);
        }
    }
    private void FixedUpdate()
    {
        RB.velocity = new Vector3(RB.velocity.x, RB.velocity.y, speed) ;
    }
}
