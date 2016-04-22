using UnityEngine;
using System.Collections;

public class rotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(Vector3.right);
        GameObject earth =GameObject.FindGameObjectWithTag("earth");
        
    }
}
