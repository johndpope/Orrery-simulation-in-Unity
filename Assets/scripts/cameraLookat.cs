using UnityEngine;
using System.Collections;

public class cameraLookat : MonoBehaviour
{
    public TextMesh text;
    bool look = false;
    void OnMouseDown()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (!look)
            {
                look = true;
            }
            else
            {
                look = false;
            }
        }
        if (!look)
        {
            Camera.main.fieldOfView = 50;
            Camera.main.transform.LookAt(Vector3.zero);
            Camera.main.transform.position = new Vector3(1.42f, 44.0f, -87.0f);
        }
    }
  void  OnMouseOver()
    {
        text.text = gameObject.name;
    }
    void OnMouseExit()
    {
        float time = Time.time;
        if (time <= (Time.time + 50000))
        {
            text.text = "";
        }
    }
    void Update()
    {
          if (look)
            {
            //    gameObject.transform.position = earth.transform.position;
            Camera.main.fieldOfView = 5;
            Camera.main.transform.LookAt(gameObject.transform);
            //  Camera.main.transform.position = gameObject.transform.position;
            }
        if (Input.GetButtonDown("Fire1"))
        {
            if (Time.timeScale == 1.0F)
                Time.timeScale = 0.7F;
            else
                Time.timeScale = 1.0F;
            Time.fixedDeltaTime = 0.02F * Time.timeScale;
        }
    }
}

