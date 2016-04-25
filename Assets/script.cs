using UnityEngine;
using System.Collections;

public class script : MonoBehaviour {
    public GameObject star;
    float starX, starY, starZ;
    float minor, major;
    public float angle;
    public float ang;
    public Texture3D tex;

    // Use this for initialization
	void Start ()
    {
        starX = star.transform.position.x;
        starZ = star.transform.position.z;
        minor = 8.0f;
        major = 14.0f;
        angle = 0;
	}
	
	// Update is called once per frame
	void Update () {

       angle += Time.deltaTime;
        if (angle == 360)
        {
            angle = 0;
        }
                
        gameObject.transform.position = new Vector3(Mathf.Sin(angle)*major +starX, 0, Mathf.Cos(angle)*minor);
      
    }
}