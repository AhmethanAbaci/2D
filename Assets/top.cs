using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class top : MonoBehaviour
{
    float darbeGucu;
    ortadakiKutular ortadakiKutu_Yonetim;
    public ParticleSystem topyokOlmaEfekt; 
   
   
    void Start()
    {
        darbeGucu=20;
        
    }

    // Update is called once per frame
   private void OnTriggerEnter2D(Collider2D collision)
   {
        if(collision.gameObject.CompareTag("ortadakiKutular"))
        {
            collision.gameObject.GetComponent<ortadakiKutular>().darbeAl(darbeGucu);
            Instantiate(topyokOlmaEfekt,collision.gameObject.transform.position,collision.gameObject.transform.rotation);
           
            Destroy(gameObject);
            //GetComponent<CircleCollider2D>().isTrigger = false;
        }
   }
}
