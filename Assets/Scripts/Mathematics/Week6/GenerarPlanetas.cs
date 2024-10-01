using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarPlanetas : MonoBehaviour
{
    [SerializeField] private GameObject Planeta;
    private void Start()
    {
        Invoke("Generar", 5f);
    }
    private void Generar()
    {

    }
}
