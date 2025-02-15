using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{

    public GameObject camera;
    public float distanse = 15;
    GameObject objact;
    bool canPickup;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) PickUp();
        if (Input.GetKeyDown(KeyCode.Q)) Drop();
    }

    void PickUp()
    {
        RaycastHit hit;

        if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hit, distanse)) ;
        {
            if (hit.transform.tag == "pickupItems")
            {
                if (canPickup) Drop();
                objact = hit.transform.gameObject;
                objact.GetComponent<Rigidbody>().isKinematic = true;
                objact.transform.parent = transform;
                objact.transform.localPosition = Vector3.zero;
                canPickup = true;
            }
        }
    }

    void Drop()
    {
        objact.transform.parent = null;
        objact.GetComponent<Rigidbody>().isKinematic = false;
        canPickup = false;
        objact = null;  
    }
}
