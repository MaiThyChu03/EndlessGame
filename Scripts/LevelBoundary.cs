using UnityEngine;
using System.Collections.Generic;
using System.Collections;
public class LevelBoundary : MonoBehaviour
{
    public static float leftSide =-10;
    public static float rightSide=10;
    public float internalLeft;
    public float internalRight;
    void Update()
    {
        internalLeft=leftSide;
        internalRight=rightSide;
    }
}
