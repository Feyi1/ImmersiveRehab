using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule_movement_Hor : MonoBehaviour
{
    float timeCounter = 0;
    float speed, height;
    public float TrackingCapsulePositionx;
    public float TrackingCapsulePositiony;
    public float TrackingCapsulePositionz;
    // Use this for initialization
    void Start()
    {
        speed = 1;
        height = 10;

    }

    // Update is called once per frame
    void Update()
    {


        TrackingCapsulePositionx = GameObject.Find("TrackingCapsule").transform.position.x;
        TrackingCapsulePositiony = GameObject.Find("TrackingCapsule").transform.position.y;
        TrackingCapsulePositionz = GameObject.Find("TrackingCapsule").transform.position.z;

        timeCounter += (Time.deltaTime) * speed;
        float x = TrackingCapsulePositionx;// - 27;
        float y = TrackingCapsulePositiony;
        float z = (Mathf.Cos(timeCounter)) * height;// - 25;



        transform.position = new Vector3(x, y, z);




    }







}
