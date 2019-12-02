using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftRight : MonoBehaviour {
	private Transform ItemTargetRigth, ItemTargetLeft;

	private float speed = 60;
	private float resize = 100;
	private float TotalSpeed, TotalSpeedTemp;
	float stepGoingBack,step;
	public string ParentObject;
	bool isLeft = false;
	bool isPlayerHit = false;
	// Use this for initialization
	void Start () {
		ItemTargetRigth = GameObject.Find (ParentObject+"/Rigth").GetComponent<Transform>();
		ItemTargetLeft = GameObject.Find (ParentObject+"/Left").GetComponent<Transform>();

//		transform.position = new Vector2(ItemTargetStart.position.x, ItemTargetStart.position.y);
		TotalSpeed = (Screen.width / 500.0f) * speed;
		TotalSpeedTemp = TotalSpeed;
	}

	// Update is called once per frame
	void Update () {
		TotalSpeed =  TotalSpeedTemp; //(GameController.ScoreCount * 10) +
		step = TotalSpeed * Time.deltaTime;
		stepGoingBack = TotalSpeedTemp * Time.deltaTime;

//		if(transform.position.x == ItemTargetEnd.position.x){
//			isLeft = false;
//		}
//		else if(transform.position.x == ItemTargetStart.position.x){
//			isLeft = true;
//		}
		print ("isLeft: "+ isLeft);


		if (isLeft == false) {

			transform.position = Vector3.MoveTowards (transform.position, ItemTargetLeft.position, step);
		} else {
			transform.position = Vector3.MoveTowards(transform.position, ItemTargetRigth.position, step);
		}

	}
	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag == "Right"){
			isLeft = false;
		}

		if(col.gameObject.tag == "Left"){
			isLeft = true;
		}

		if(col.gameObject.tag == "Player"){
			col.gameObject.transform.parent = transform;
			isPlayerHit = true;
		}

	}
}
