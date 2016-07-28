using UnityEngine;
using System.Collections;

public class Controll : MonoBehaviour {

    bool it=true;
    public GameObject Card;
	 int [][] pole = new int[5][];
    void Setup()
    {
       
    }
    void Update()
    {
        // RaycastHit hit;
        if (it == true)
        {
            it = false;
            for (int i = 0; i < 5; i++)
                for (int k = 0; k < 5; k++)
                    Instantiate(Card, new Vector3((i - 2) * 2, (k - 2) * 2, -1.9f), Quaternion.identity);

        }

        
    }
    
}
