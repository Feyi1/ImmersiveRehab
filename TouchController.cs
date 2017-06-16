using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchController : MonoBehaviour
{

    private int count;
    public Text countText;
    public string levelToLoad;


    // Update is called once per frame
    void Update()
    {
        transform.localPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);
        transform.localRotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTouch);

        float distance;
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        // if (Physics.Raycast(ray, out hit) && Input.GetMouseButtonDown(0) && hit.transform.name == "Play")

        if (Physics.Raycast(ray, out hit))
        {
            ParticleSystem.MainModule settings = GetComponent<ParticleSystem>().main;
            distance = hit.distance;
            if (hit.collider.tag == "Interactive")
            {
                Debug.Log("hit:" + hit.collider.name);
                count = count + 1;
                countText.text = " Score:" + count.ToString();
                ///colored particle effect for recticle

                //settings.startColor = new ParticleSystem.MinMaxGradient(Color.red);
            }

            else if (hit.collider.tag != "Interactive")
            {

                // settings.startColor = new ParticleSystem.MinMaxGradient(Color.white);
            }
            else { }



        }
        /*
void OnCollisionEnter(Collision col)
{
    if (col.gameObject.tag == "Interactive")
    {
        Debug.Log("hit:" +gameObject.name);
        count = count + 1;
        countText.text = " Score:" + count.ToString();
    }
    if (count == 500)
    {
        Application.LoadLevel(levelToLoad);
    }
}
*/
    }
}
