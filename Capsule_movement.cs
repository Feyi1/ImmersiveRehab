using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule_movement : MonoBehaviour {
	float timeCounter=0;
    float speed, height;
    public float TrackingCapsulePositionx;
    public float TrackingCapsulePositionz;
    // Use this for initialization
    void Start () {
        speed = 1;
        height =15 ;

	}

	// Update is called once per frame
	void Update () {


        TrackingCapsulePositionx = GameObject.Find("TrackingCapsule").transform.position.x;
        TrackingCapsulePositionz = GameObject.Find("TrackingCapsule").transform.position.z;

        timeCounter += (Time.deltaTime)*speed;
        float x = TrackingCapsulePositionx;// - 27;
		float y = (Mathf.Cos (timeCounter))*height;
        float z = TrackingCapsulePositionz;// - 25;

       

		transform.position = new Vector3 (x, y, z);




	}







}
