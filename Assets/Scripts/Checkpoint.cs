using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour
{
    public float threshold = -50f;

    void Update()
    {
        if (transform.position.y < threshold)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);   
        }
    }
}
