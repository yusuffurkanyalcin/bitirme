using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Engel : MonoBehaviour
{
    float health = 100;
    public Image healthBar;
    public GameObject HealthCanvas;

    public void getDamage(float damage) {

        health -= damage;
        healthBar.fillAmount = health / 100;

        if (health <= 0) {
            Destroy(gameObject);

        }else{
            StartCoroutine(ExportCanvas());
        }     
    }

    IEnumerator ExportCanvas() {
        if (!HealthCanvas.activeInHierarchy) {
            HealthCanvas.SetActive(true);
            yield return new WaitForSeconds(2);
            HealthCanvas.SetActive(false);
        }
    }
}
