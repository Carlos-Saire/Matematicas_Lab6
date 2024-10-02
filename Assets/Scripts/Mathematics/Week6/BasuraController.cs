using UnityEngine;
using System;
public class BasuraController : MonoBehaviour
{
    private Rigidbody rigidbody;
    [SerializeField] private float speed;
    public static event Action eventBullet;
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
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
        rigidbody.velocity = new Vector3(rigidbody.velocity.x, rigidbody.velocity.y, -speed);
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
