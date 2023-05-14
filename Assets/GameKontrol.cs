using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameKontrol : MonoBehaviour
{
    [Header("Settings of player's health")]
    public Image Player_1_Health_Bar;
    float Player_1_Health=100;
    public Image Player_2_Health_Bar;
    float Player_2_Health=100;

    public void Attack(int condition, float attackDamage)
    {
        switch (condition) 
        {
            case 1:
                Player_1_Health -= attackDamage;
                Player_1_Health_Bar.fillAmount = Player_1_Health/100;

                if (Player_1_Health <= 0)
                {
                    Debug.Log("Oyuncu 1 yenildi");
                }
                break;
            case 2:
                Player_2_Health -= attackDamage;
                Player_2_Health_Bar.fillAmount = Player_2_Health/100;

                if (Player_1_Health <= 0)
                {
                    Debug.Log("Oyuncu 1 yenildi");
                }
                break;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
