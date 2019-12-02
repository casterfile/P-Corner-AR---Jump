using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRemove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		//		Debug.Log("OnCollisionEnter2D: "+ col.gameObject.tag);
//		if (col.gameObject.tag == "col") {
//			
//		}

		Destroy(col.gameObject);
	}
}
