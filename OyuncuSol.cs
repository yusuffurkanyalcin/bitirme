using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuSol : MonoBehaviour
{
    public GameObject top;
    public GameObject TopBaslangicNoktasi;
    public ParticleSystem TopAtisEfekt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(TopAtisEfekt, TopBaslangicNoktasi.transform.position, TopBaslangicNoktasi.transform.rotation);
            GameObject triggeredTop = Instantiate(top, TopBaslangicNoktasi.transform.position, TopBaslangicNoktasi.transform.rotation);
            Rigidbody2D rg = triggeredTop.GetComponent<Rigidbody2D>();
            rg.AddForce(new Vector2(2f,0f)*10f, ForceMode2D.Impulse);
            TopAtisEfekt.Play();
        }   
    }
}
