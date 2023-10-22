using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TowerHealth : MonoBehaviour
{
     public Image healthBar;
     public float healthAmount;

     private void Start()
     {
         healthAmount = 100f;
     }

     public void TakeDemage(float demage)
     { 
         healthAmount -= demage;
         healthBar.fillAmount = healthAmount / 100f;

         if (healthAmount <= 0)
         {
             SceneManager.LoadScene("DeathScene");
         }
     }
}
