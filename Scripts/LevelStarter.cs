using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    [SerializeField] GameObject countDown3;
    [SerializeField] GameObject countDown2;
    [SerializeField] GameObject countDown1;
    [SerializeField] GameObject countDownGo;
    [SerializeField] GameObject fadeIn;
    [SerializeField] AudioSource readyFX;
    [SerializeField] AudioSource goFX;
    private bool hasStarted = false;
    // Update is called once per frame
    void Update()
    {
        StartCoroutine(CountSequence());                
    }

    IEnumerator CountSequence()
    {
        if (hasStarted) yield break; // Ngăn gọi lại
        hasStarted = true ; 
        yield return new WaitForSeconds(1.5f);
        countDown3.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1);
        countDown2.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1);
        countDown1.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1);
        countDownGo.SetActive(true);
        goFX.Play();
        PlayerMove.canMove=true;
    }
}
