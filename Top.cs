using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;


public class Top : MonoBehaviour
{

    public GameObject TopYokOlmaEfekt;
    public GameObject  gameControl = GameObject.FindGameObjectsWithTag("GameKontrol")[0];
    float damage = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Engeller")) {
            collision.GetComponent<Engel>().getDamage(damage);
            Destroy(gameObject);
            //GetComponent<CircleCollider2D>().isTrigger = false;
        }
        if (collision.gameObject.CompareTag("Player_1_Tower")) {
            gameControl.Attack(1,damage);
            Destroy(gameObject);
            GetComponent<CircleCollider2D>().isTrigger = false;
        }
        if (collision.gameObject.CompareTag("Player_2_Tower")) {
            gameControl.Attack(2,damage);
            Destroy(gameObject);
            GetComponent<CircleCollider2D>().isTrigger = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
