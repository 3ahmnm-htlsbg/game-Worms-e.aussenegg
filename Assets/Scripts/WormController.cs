using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{

    private Rigidbody rbA;
    private Rigidbody rbB;
    public GameObject PlayerA;
    public GameObject PlayerB;
    public GameObject projectile;


    public void Start()
    {
      rbA = PlayerA.GetComponent<Rigidbody>();
      rbB = PlayerB.GetComponent<Rigidbody>();
      PlayerA = GameObject.FindGameObjectWithTag("PlayerA");
      PlayerB = GameObject.FindGameObjectWithTag("PlayerB");
    }
    [SerializeField] private GameObject spawnCubeA;
    [SerializeField] private GameObject BazookaA;
    [SerializeField] private GameObject spawnCubeB;
    [SerializeField] private GameObject BazookaB;

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
            if (Input.GetKey(KeyCode.W))
            {
                rbA.AddForce(0f, 2.5f, 0f, ForceMode.Impulse);
            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                GameObject clone = Instantiate(projectile, spawnCubeA.transform.position, spawnCubeA.transform.rotation);
                Rigidbody rbProjectile = clone.GetComponent<Rigidbody>();
                rbProjectile.AddForce(BazookaA.transform.up * 400f);
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
            if (Input.GetKey(KeyCode.I))
            {
                rbB.AddForce(0f, 2.5f, 0f, ForceMode.Impulse);
            }
            if (Input.GetKeyDown(KeyCode.U))
            {
                GameObject clone = Instantiate(projectile, spawnCubeB.transform.position, spawnCubeB.transform.rotation);
                Rigidbody rbProjectile = clone.GetComponent<Rigidbody>();
                rbProjectile.AddForce(BazookaB.transform.up * 400f);
            }
        }
       
    }
}
