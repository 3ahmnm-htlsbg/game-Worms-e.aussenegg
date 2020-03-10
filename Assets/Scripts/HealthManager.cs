using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Text healthAText;
    public Text healthBText;
    int healthA;
    int healthB;

    void Start()
    {
        healthA = 5;
        healthB = 5;
    }
    public void BulletHit(string player)
    {
        if(player == "A")
        {
            healthA -= 1;
        }
        if (player == "B")
        {
            healthB -= 1;
        }
        UpdateText();
    }
    void UpdateText()
    {
        healthAText.text = healthA.ToString();
        healthBText.text = healthB.ToString();
    }
}
