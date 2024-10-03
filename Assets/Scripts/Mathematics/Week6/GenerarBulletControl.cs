using UnityEngine;
using UnityEngine.InputSystem;
public class GenerarBulletControl : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private AudioClipSO Efectos;
    public void GenererBullet(InputAction.CallbackContext context)
    {
        if (context.performed&&Time.timeScale!=0)
        {
            Instantiate(bullet, transform.position, transform.rotation);
            Efectos.PlayOneShoot();
        }
    }
}
