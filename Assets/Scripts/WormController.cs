using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{

    private Rigidbody rbA;
    private Rigidbody rbB;
    public GameObject PlayerA;
    public GameObject PlayerB;

    public void Start()
    {
      rbA = PlayerA.GetComponent<Rigidbody>();
      rbB = PlayerB.GetComponent<Rigidbody>();
      PlayerA = GameObject.FindGameObjectWithTag("PlayerA");
      PlayerB = GameObject.FindGameObjectWithTag("PlayerB");
    }

    public void Update()
    {
        if(PlayerA == true)
        {
            if (Input.GetKey(KeyCode.A))
            {
                rbA.AddForce(-2.5f, 0f, 0f, ForceMode.Impulse);
            }
            if (Input.GetKey(KeyCode.D))
            {
                rbA.AddForce(2.5f, 0f, 0f, ForceMode.Impulse);
            }
            
        }

        if(PlayerB == true)
        {
            if (Input.GetKey(KeyCode.J))
            {
                rbB.AddForce(-2.5f, 0f, 0f, ForceMode.Impulse);
            }
            if (Input.GetKey(KeyCode.L))
            {
                rbB.AddForce(2.5f, 0f, 0f, ForceMode.Impulse);
            }
        }
       
    }
}
