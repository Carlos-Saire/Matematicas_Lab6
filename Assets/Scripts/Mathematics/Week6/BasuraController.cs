using UnityEngine;
using System;
public class BasuraController : MonoBehaviour
{
    private Rigidbody Rd;
    [SerializeField] private float speed;
    public static event Action eventBullet;
    private void Awake()
    {
        Rd = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if(transform.position.z<= -8.85)
        {
            Destroy(this.gameObject);
        }
    }
    private void ActiveEventBullet()
    {
        eventBullet?.Invoke();
    }
    private void FixedUpdate()
    {
        Rd.velocity = new Vector3(Rd.velocity.x, Rd.velocity.y, -speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            print("Entro");
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            ActiveEventBullet();
        }
    }

}
