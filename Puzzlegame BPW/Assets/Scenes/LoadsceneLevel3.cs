using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadsceneLevel3 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("GOGOGOGO SCENE");
        SceneManager.LoadScene("Levels 3");
    }
}
