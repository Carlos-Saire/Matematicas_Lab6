using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField] private string name;
    public void Scene()
    {
        SceneManager.LoadScene(name);
    }
}
