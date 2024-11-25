using UnityEngine;
using System.Collections.Generic;
using System.Collections;
public class ObstacleCollision : MonoBehaviour
{
    [SerializeField] GameObject thePlayer;
    [SerializeField] GameObject charModel;
    [SerializeField] AudioSource crashThud;
    [SerializeField] GameObject mainCam;
    [SerializeField] GameObject levelControl;
    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled=false;
        thePlayer.GetComponent<PlayerMove>().enabled=false;
        charModel.GetComponent<Animator>().Play("Stumble Backwards");
        levelControl.GetComponent<LevelDistance>().enabled=false;
        crashThud.Play();
        mainCam.GetComponent<Animator>().enabled=true;
        levelControl.GetComponent<EndRunSequence>().enabled=true;
    }

}
