using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMove : MonoBehaviour
{
    // Start is called before the first frame update
   private int sceneBuildIndex;

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
       
        SceneManager.LoadScene(2);
        }
    }

