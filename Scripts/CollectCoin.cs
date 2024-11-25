using UnityEngine;
using System.Collections.Generic;
using System.Collections;
public class CollectCoin : MonoBehaviour
{
    [SerializeField] AudioSource coinFX;
    void OnTriggerEnter(Collider other)
    {
    
       coinFX.Play();
       CollectableControl.coinCount+=1;
       this.gameObject.SetActive(false); 
    }

}
