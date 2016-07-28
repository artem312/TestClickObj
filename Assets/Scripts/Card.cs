using UnityEngine;
using System.Collections;

public class Card : MonoBehaviour {
	public Material back;
	public Material face;

   int state = 0;
    float rot = 0f;

    void Start () {
		transform.Rotate(0,90,0);
		GetComponent<Renderer>().material = back;

    }

    void Update()
    {
        rot += state * 6;
        transform.Rotate(0, 0, state*6);
		if (rot == 90) {
			
			if (state == 1) {
				
				GetComponent<Renderer> ().material = face;

			}
			else GetComponent<Renderer>().material = back;
		}
        if (rot == 180 || rot==0)
        {
            state = 0;
        }
    }
    void OnMouseDown()
    {
        rotate();
  	}
    void rotate()
    {
       if(rot==180) { state = -1; }
        if (rot == 0) { state = 1; }
    }
}
