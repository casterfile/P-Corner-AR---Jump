using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemMove : MonoBehaviour {
	private Transform ItemTargetStart, ItemTargetEnd;

	private float speed = 60;
	private float resize = 100;
	private float TotalSpeed, TotalSpeedTemp;
	float stepGoingBack,step;
	// Use this for initialization
	void Start () {
		ItemTargetStart = GameObject.Find ("ItemTargetStart").GetComponent<Transform>();
		ItemTargetEnd = GameObject.Find ("ItemTargetEnd").GetComponent<Transform>();

		transform.position = new Vector2(ItemTargetStart.position.x, ItemTargetStart.position.y);
		TotalSpeed = (Screen.width / 300.0f) * speed;
		TotalSpeedTemp = TotalSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		TotalSpeed =  TotalSpeedTemp; //(GameController.ScoreCount * 10) +
		step = TotalSpeed * Time.deltaTime;
		stepGoingBack = TotalSpeedTemp * Time.deltaTime;

		transform.position = Vector3.MoveTowards(transform.position, ItemTargetEnd.position, step);
//		Image.rectTransform.sizeDelta = new Vector2(100, 100);

		if(transform.position == ItemTargetEnd.position){
//			Destroy(gameObject);
		}
	}


}
