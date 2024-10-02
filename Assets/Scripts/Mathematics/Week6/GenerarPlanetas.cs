using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarPlanetas : MonoBehaviour
{
    [SerializeField] private GameObject Planeta;
    [SerializeField] private float minX;
    [SerializeField] private float maxX;
    float currentX;
    [SerializeField] private float minY;
    [SerializeField] private float maxY;
    float currentY;
    Vector3 newTransform;
    private void Start()
    {
        Invoke("Generar", 0.1f);
    }
    private void Generar()
    {
        currentX = Random.Range(minX, maxX);
        currentY = Random.Range(minY, maxY);
        newTransform = new Vector3(currentX, currentY, transform.position.z);
        Instantiate(Planeta,newTransform, transform.rotation);
        Invoke("Generar", 1f);
    }
}
