using UnityEngine;
using System.Collections;

public class time : MonoBehaviour
{

    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            if (Time.timeScale == 1.0F)
                Time.timeScale = 10.1F;
            else
                Time.timeScale = 1.0F;
            Time.fixedDeltaTime = 0.0002F * Time.timeScale;
        }
    }
}