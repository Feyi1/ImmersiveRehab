using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_movement2 : MonoBehaviour {
	float timeCounter=0;
    float speed, height, width;
	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {
        speed = 1;
        height = 7;
        width = 7;



        timeCounter += (Time.deltaTime)*speed;
		float x = Mathf.Sin (timeCounter) * height;
        //this does cool stuff
        //float x = Mathf.Sin(timeCounter * height);
        float y = (Mathf.Cos (timeCounter))*width ;
        float z = 0;

		transform.position = new Vector3 (x, y, z);
		



	}







}

