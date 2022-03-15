using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool isMoving;
    private Vector3 OrgiPos , TargetPos;
    private float timeToMove = 0.2f;
    //public int offset = 1;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.W) && !isMoving){
            StartCoroutine(MovePlayer(Vector3.forward));
        }
        if(Input.GetKey(KeyCode.A) && !isMoving){
           StartCoroutine(MovePlayer(Vector3.left));
        }
        if(Input.GetKey(KeyCode.S) && !isMoving){
            StartCoroutine(MovePlayer(Vector3.back));
        }
        if(Input.GetKey(KeyCode.D) && !isMoving){
            StartCoroutine(MovePlayer(Vector3.right));
        }
     //   float verticalInput = Input.GetAxis("Vertical");
     //   float horizontalInput = Input.GetAxis("Horizontal") ;
      //  transform.Translate(Vector3.forward * verticalInput);
      //  transform.Translate(Vector3.right * horizontalInput);
    }

    private IEnumerator MovePlayer(Vector3 direction){
        isMoving = true;

        float elapsedTime = 0;
        OrgiPos = transform.position;
        TargetPos = OrgiPos + direction;

        while(elapsedTime < timeToMove){
            transform.position = Vector3.Lerp(OrgiPos,TargetPos, (elapsedTime/timeToMove));
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        transform.position = TargetPos;
        isMoving = false;
    }
}