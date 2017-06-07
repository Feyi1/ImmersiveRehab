using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyTouchController : MonoBehaviour {


    private int count;
    public Text countText;
    public string levelToLoad;


    // Update is called once per frame
    void Update()
    {
        transform.localPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);
        transform.localRotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTouch);

       



        }
       
void OnCollisionEnter(Collision col)
{
    if (col.gameObject.tag == "Interactive")
    {
            if (col.gameObject.name == "CollidePlane1" || col.gameObject.name == "CollidePlane2")
            {
                Debug.Log("Bad hit:" + gameObject.name);
                count = count - 1;
                countText.text = " Score:" + count.ToString();

            }
            else if(col.gameObject.name=="CollidePlaneScore")
            {
                Debug.Log("hit:" + gameObject.name);
                count = count + 1;
                countText.text = " Score:" + count.ToString();
            }
       
    }
    if (count == 15)
    {
        Application.LoadLevel(levelToLoad);
    }
}

    
}
