using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;
public class script : MonoBehaviour {
    // gameobject and its positions
 
    //  public StreamWriter write;
    public GameObject star;
    public  float starX, starY, starZ;
    public StreamWriter write;
    // length and width of an ellipse
    public float minor, major;
    public float angle;
    public bool moon;
    public float planetNo;
    // amout of orbit inclination from suns equator
    public float orbitalInclinationDeg;
    // Use this for initialization
    public float degAngle;
	void Start ()
    {
        write = new StreamWriter(File.Open(gameObject.name + ".csv", FileMode.Create));
        angle = 0;
    }
	
	// Update is called once per frame
	void Update () {
        starX = star.transform.position.x;
        starZ = star.transform.position.z;
        degAngle = angle * Mathf.Rad2Deg;
        
        if (moon)
        {
            angle += Mathf.Deg2Rad * 5;
        }
        else
        {
            angle += Mathf.Deg2Rad / planetNo;
        
        }
        if (angle >= (Mathf.Deg2Rad*360))
        {
            angle = 0;
        }
       
        // makes the object that the script is attatched to orbit around a planet/star object
        gameObject.transform.position = new Vector3(Mathf.Sin(angle)*major +starX, Mathf.Cos(angle)*Mathf.Deg2Rad* orbitalInclinationDeg, Mathf.Cos(angle)*minor + starZ);

    
            if ((angle * Mathf.Rad2Deg) != 360)
            {
                StringBuilder sb = new StringBuilder();
                string param1 = gameObject.transform.position.x.ToString();
                string param2 = gameObject.transform.position.z.ToString();
                sb.AppendLine(string.Format("{0}, {1}", param1, param2));
                write.Write(sb.ToString());

            }
          
        
      
    }
}