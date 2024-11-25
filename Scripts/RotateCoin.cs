using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    [SerializeField] int rotateSpeed=30;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,rotateSpeed,0, Space.World);
    }
}
