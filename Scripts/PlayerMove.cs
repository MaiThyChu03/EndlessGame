using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using Unity.VisualScripting;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed=5;
    public float leftRightSpeed =4;
    static public bool canMove = false;
    public bool isJumping=false;
    public bool comingDown=false;
    public GameObject playerObject;
    private bool hasStarted = false;
    void Update()
    {
        transform.Translate(Vector3.forward *Time.deltaTime*moveSpeed,Space.World);
        if ( canMove == true)
            {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
                {
                    if (this.gameObject.transform.position.x > LevelBoundary.leftSide)
                    {
                        transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
                    }
                    }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
                {
                    if (this.gameObject.transform.position.x < LevelBoundary.rightSide)
                    {
                        transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);
                    }
                }
            if (Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.UpArrow)||Input.GetKey(KeyCode.Space))
                {
                    if (isJumping==false)
                    {
                        isJumping=true;
                        playerObject.GetComponent<Animator>().Play("Jump");
                        StartCoroutine(JumpSequece());
                    }
                }
            }
        if (isJumping == true)
            {
                if (comingDown == false)
                {
                    transform.Translate(Vector3.up*Time.deltaTime,Space.World);
                }
                if (comingDown == true)
                {
                    transform.Translate(Vector3.up*Time.deltaTime*-1,Space.World);
                }
            }      
    }
    IEnumerator JumpSequece()
    {
        if (hasStarted) yield break; // Ngăn gọi lại
        hasStarted = true ;
        yield return new WaitForSeconds(0.35f);
        comingDown=true;
        yield return new WaitForSeconds(0.35f);
        isJumping=false;
        comingDown=false;
        playerObject.GetComponent<Animator>().Play("Standard Run");
    }
}
