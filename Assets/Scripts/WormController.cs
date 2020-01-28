using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{
   public void Update()
   {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Player moves Up!");
        }
   }
}
