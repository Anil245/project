using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitApplication : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
       {
        Debug.Log("We pushed escape");
        Application.Quit();
       }


    }
}
