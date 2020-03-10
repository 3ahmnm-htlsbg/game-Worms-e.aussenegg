using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletTrigger : MonoBehaviour
{
    GameObject healthmanager;
    // Start is called before the first frame update
    void Start()
    {
        healthmanager = GameObject.FindWithTag("Healthmanager");
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PlayerA")
        {
            healthmanager.GetComponent<HealthManager>().BulletHit("A");
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "PlayerB")
        {
            healthmanager.GetComponent<HealthManager>().BulletHit("B");
            Destroy(gameObject);
        }
    }
}
