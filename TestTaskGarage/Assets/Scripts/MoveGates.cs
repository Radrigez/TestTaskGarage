using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGates : MonoBehaviour
{
    public float speedRotate;
    public float rotate;


    void Start()
    {
      
    }

    void Update()
    {
     MoveRotation();
    }

    private void MoveRotation()
    {
       transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, rotate, 0), Time.deltaTime);
    }



}
