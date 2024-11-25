using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;
public class CollectableControl : MonoBehaviour
{
    public static int coinCount;
    [SerializeField] GameObject coinDisplay;
    [SerializeField] GameObject coinEndDisplay;
    // Update is called once per frame
    void Update()
    {
        coinDisplay.GetComponent<Text>().text="" + coinCount;
        coinEndDisplay.GetComponent<Text>().text= "" + coinCount;

    }
}
