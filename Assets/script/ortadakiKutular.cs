using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // Gerekli kütüphane eklendi

public class ortadakiKutular : MonoBehaviour
{
    public float saglik;
    public Image healthbar;
    public GameObject saglikCanvas;
    public ParticleSystem patlamaefekt;

    void Start()
    {
        saglik = 100;
        healthbar.fillAmount = saglik / 100;  
    }


    public void darbeAl(float darbeGucu)
    {
        saglik -= darbeGucu;       
        healthbar.fillAmount = saglik / 100;  
        saglikCanvas.SetActive(true);
        if (saglik<=0)
        {
            
            Instantiate(patlamaefekt,gameObject.transform.position,gameObject.transform.rotation);
            patlamaefekt.Play();
            Destroy(gameObject);
        }
        else
        {
            StartCoroutine(canvasCikar());
        }
            
    
        
    }
    IEnumerator canvasCikar()
    {
        if(!saglikCanvas.activeInHierarchy)
        {
            saglikCanvas.SetActive(true);
            yield return new WaitForSeconds(2);
            saglikCanvas.SetActive(false);
        }
    }
}

