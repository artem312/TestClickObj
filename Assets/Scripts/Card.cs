using UnityEngine;
using System.Collections;

public class Card : MonoBehaviour {
	public Material back;
	public Material face;

   int state = 0;
	bool open=false;
    float rot = 0f;
	int timer=0;
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
			if (open && timer == 30) {
				GameObject.Find ("Plane").GetComponent<Controll> ().open (transform.position.x, transform.position.y);
				open = false;
				timer = 0;
			} else if (open)
				timer++;
        }
    }
	public void ToBack(){
		if (rot == 180)
			rotate ();
		
	}
	public void ToFace(){
		if (rot == 0)
			rotate();
		open =true;
	}
    void OnMouseDown()
    {
		
		ToFace ();
		}
    void rotate()
    {
       if(rot==180) { state = -1; }
        if (rot == 0) { state = 1; }
    }
}
