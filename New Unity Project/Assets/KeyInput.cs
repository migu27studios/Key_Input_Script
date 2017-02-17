using UnityEngine;
using System.Collections;

public class KeyInput : MonoBehaviour {

   void start ()
    {

    }
	
	// Update is called once per frame.     Keep Update for a MINIMUM.
	void Update ()
    {
        if (Input.GetKey(KeyCode.A))
        {
            print("I hit A.");
        }
       /* else 
        {
            print("No input");
        } */
	}
}
