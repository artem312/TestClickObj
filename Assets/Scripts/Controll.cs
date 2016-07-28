using UnityEngine;
using System.Collections.Generic;

public class Controll : MonoBehaviour {
	float x1,y1;bool haveone=false;
    bool it=true;
	int count=25;
	public GameObject Card1,Card2,Card3,Card4,Card5,Card6;
	List<GameObject> cards=new List<GameObject>();
	 int [] pole = new int[25];
	public void open (float _x, float _y){
		if (_x == x1 && _y == y1)
			return;
		if (haveone) {
			GameObject one=null, two=null;
			foreach (GameObject s in cards) {
				if (s.transform.position.x == x1 && s.transform.position.y == y1)
					one = s;
				 if (s.transform.position.x == _x && s.transform.position.y == _y)
					two = s;
			}
			haveone = false;
			if (one.name.Equals (two.name)) {
				cards.Remove (one);
				cards.Remove (two);
				Destroy (one);
				Destroy (two);
				count -= 2;
			} else {
				one.GetComponent<Card> ().ToBack ();
				two.GetComponent<Card> ().ToBack ();
			}

		} else {
			x1 = _x;
			y1 = _y;
			haveone = true;
		}

	}
    void Setup()
    {
    }
    void Update()
    {
        // RaycastHit hit;
		if (it == true) {
			it = false;
			GameObject r=null;
			for (int i = 0; i < 5; i++) 
				for (int k = 0; k < 5; k++)
				{
					int z = (5 * i) + k;
				pole [z] = Random.Range(1,7);
				
				
				if(pole[z]==1)
						r=(Instantiate(Card1, new Vector3((i - 2) * 2, (k - 2) * 2, -1.9f), Quaternion.identity) as GameObject);
					else
						if(pole[z]==2)
							r=(Instantiate(Card2, new Vector3((i - 2) * 2, (k - 2) * 2, -1.9f), Quaternion.identity) as GameObject);
						else
							if(pole[z]==3)
								r=(Instantiate(Card3, new Vector3((i - 2) * 2, (k - 2) * 2, -1.9f), Quaternion.identity) as GameObject);
							else
								if(pole[z]==4)
									r=(Instantiate(Card4, new Vector3((i - 2) * 2, (k - 2) * 2, -1.9f), Quaternion.identity) as GameObject);
								else
									if(pole[z]==5)
										r=(Instantiate(Card5, new Vector3((i - 2) * 2, (k - 2) * 2, -1.9f), Quaternion.identity) as GameObject);
									else
										if(pole[z]==6)
											r=(Instantiate(Card6, new Vector3((i - 2) * 2, (k - 2) * 2, -1.9f), Quaternion.identity) as GameObject);
					if(r!=null)cards.Add (r);
					Debug.Log (r+"");

			}

		}
    }
    
}
