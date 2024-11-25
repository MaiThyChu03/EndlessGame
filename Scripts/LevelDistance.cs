using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class LevelDistance : MonoBehaviour
{
    public GameObject disDisplay;
    public GameObject disEndDisplay;
    public int disRun;
    public bool addingDis = false;
    public float disDelay=0.25f;
    // Update is called once per frame
    void Update()
    {
        if(addingDis==false)
        {
            addingDis=true;
            StartCoroutine(AddingDis());
        }
    }
    IEnumerator AddingDis()
    {
        disRun+=1;
        disDisplay.GetComponent<Text>().text=""+disRun;
        disEndDisplay.GetComponent<Text>().text=""+disRun;
        yield return new WaitForSeconds(disDelay);
        addingDis=false;
    }
}
