using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndRunSequence : MonoBehaviour
{
    [SerializeField] GameObject liveCoins;
    [SerializeField] GameObject liveDis;
    [SerializeField] GameObject endScreen;
    [SerializeField] GameObject fadeOut;

    void Start()
    {
        StartCoroutine(EndSequence());
    }   

    IEnumerator EndSequence()
    {
        yield return new WaitForSeconds(3);
        liveCoins.SetActive(false);
        liveDis.SetActive(false);
        endScreen.SetActive(true);
        yield return new WaitForSeconds(3);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);
    }
    
}
