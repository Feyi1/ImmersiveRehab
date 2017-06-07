using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour {

    //public Vector3 aPosition;
    //public Vector3 bPosition;
    public Vector3 RPowerSpherePosition;
    public Vector3 QuadPosition;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       RPowerSpherePosition = GameObject.Find("RPowerSphere").transform.position;
        QuadPosition = GameObject.Find("Quad").transform.position;

        LineRenderer lineRenderer = GetComponent <LineRenderer>();
        lineRenderer.SetPosition(0, RPowerSpherePosition);
       // lineRenderer.SetWidth(1f, .5f);
        lineRenderer.SetPosition(1, QuadPosition);

    }
}
