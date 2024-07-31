using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyuncu : MonoBehaviour
{
    public GameObject top;
    public GameObject topCikisNoktasi;
    public ParticleSystem topatisEfekt;
    public AudioSource ses;
    public AudioClip topSes;
    void Start()
    {
        ses=gameObject.AddComponent<AudioSource>();
        ses.clip=topSes;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            Instantiate(topatisEfekt,topCikisNoktasi.transform.position,topCikisNoktasi.transform.rotation);
            GameObject topObje =Instantiate(top,topCikisNoktasi.transform.position,topCikisNoktasi.transform.rotation);
            Rigidbody2D rg = topObje.GetComponent<Rigidbody2D>();
            rg.AddForce(new Vector2(2f,0f)*10f,ForceMode2D.Impulse);
            topatisEfekt.Play();
            ses.Play();
            
        }
    }
}
