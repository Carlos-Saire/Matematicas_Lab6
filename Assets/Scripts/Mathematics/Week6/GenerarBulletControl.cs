using UnityEngine;
using UnityEngine.InputSystem;
public class GenerarBulletControl : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    public void GenererBullet(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }
    }
}
