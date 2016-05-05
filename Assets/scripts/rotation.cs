using UnityEngine;
using System.Collections;

public class rotation : MonoBehaviour {
    public GameObject obj;
        float Rot;
   public int tilt;
    Vector3 rotate;
    // Use this for initialization
    void Start () {
        Rot = 0;
       
	}
	
	// Update is called once per frame
	void Update ()
    {
        tilt++;
        rotate = new Vector3(tilt, 2, tilt);
        obj.transform.eulerAngles = rotate;
      //  obj.transform.Rotate();  
	}
}
