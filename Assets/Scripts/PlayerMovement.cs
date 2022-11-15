using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    Vector3 destinPos;
    public float moveAmount;
    Rigidbody pRigidBody;
    int position = 1;
    bool keyIsPressed = false;
    // Start is called before the first frame update
    void Start()
    {
        pRigidBody = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        //pRigidBody.AddForce(Vector3.forward * moveSpeed);

        destinPos.y = 1;//pRigidBody.position.y;
        destinPos.z = pRigidBody.position.z + (moveSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.A) && position > 0 && !keyIsPressed) 
        {
            keyIsPressed = true;
            position--;
            //pRigidBody.AddForce(-moveAmount, ForceMode.Impulse);
            destinPos.x -= moveAmount;
            //pRigidBody.MovePosition(destinPos);
        }
        else if (Input.GetKeyDown(KeyCode.D) && position < 2 && !keyIsPressed)
        {
            keyIsPressed = true;
            position++;
            //pRigidBody.AddForce(-moveAmount, ForceMode.Impulse);
            destinPos.x += moveAmount;
            
        } else
        {
            keyIsPressed = false;
        }

        pRigidBody.MovePosition(destinPos);
    }
}
