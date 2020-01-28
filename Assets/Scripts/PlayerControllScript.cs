using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllScript : MonoBehaviour
{
    public float speed = 18;

    private Rigidbody rig;

    public void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    public void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");


        Vector3 movement = new Vector3(hAxis, vAxis, 0) * speed * Time.deltaTime;
        rig.MovePosition(transform.position + movement);
    }
}
