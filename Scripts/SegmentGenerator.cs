using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class SegmentGenerator : MonoBehaviour
{
    public GameObject[] segment;
    [SerializeField] int zPos=100;
    [SerializeField] bool creatingSegment = false;
    [SerializeField] int segmentNum;
    void Update()
    {
        if (creatingSegment==false)
        {
            creatingSegment=true;
            StartCoroutine(SegmentGen());
        }
    }

    IEnumerator SegmentGen()
    {
        segmentNum=Random.Range(0,4);
        Instantiate(segment[segmentNum],new Vector3(0,0,zPos), Quaternion.identity);
        zPos+=100;
        yield return new WaitForSeconds(3);
        creatingSegment=false;
    }

}
