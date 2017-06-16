using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M_laser2_3 : MonoBehaviour {



    //public Vector3 aPosition;
    //public Vector3 bPosition;
    public Vector3 polePost;
    public Vector3 centerpost;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



        polePost = GameObject.Find("RCylinderInner3").transform.position;
        centerpost = GameObject.Find("leftCyl_inner3").transform.position;
        LineRenderer lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.SetPosition(0, polePost);
        // lineRenderer.SetWidth(1f, .5f);
        lineRenderer.SetPosition(1, centerpost);


    }
}
