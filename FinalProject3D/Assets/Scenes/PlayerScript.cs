using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerscript : MonoBehaviour
{
   
public float moveSpeed = 5f;
public float sprintSpeed = 7f;
public float currentSpeed;

public float baseSpeed = 5f;
private Rigidbody myRigidbody;
    private Vector3 movementDirection;
    private GameObject capsule;
  private Vector3 scaleChange, positionChange;
    // Start is called before the first frame update
    void Start()
    
    {
     
     myRigidbody = GetComponent<Rigidbody>(); 
     
    }

    // Update is called once per frame
    void Update()
    {

      if (Input.GetKey(KeyCode.LeftShift))
      {
moveSpeed = sprintSpeed;
      }

      if (Input.GetKeyUp(KeyCode.LeftShift))
      {
        moveSpeed = baseSpeed;
      }
 Vector3 movementDirection = Vector3.zero;

     if (Input.GetKey(KeyCode.W))
     {
      movementDirection += Vector3.forward;
     }

     if (Input.GetKey(KeyCode.S))
     {
      movementDirection += Vector3.back; 
     }

     if (Input.GetKey(KeyCode.A))

     {
movementDirection += Vector3.left;
     }
     if (Input.GetKey(KeyCode.D))
     {
      movementDirection += Vector3.right;
     }
      transform.position = transform.position + movementDirection * moveSpeed * Time.deltaTime;

      if (Input.GetKeyDown(KeyCode.N))
      {
      myRigidbody.AddForce(Vector3.up * 10f, ForceMode.Impulse);
      }
      if (Input.GetKey(KeyCode.X))
      {
        scaleChange = new Vector3(-0.1f, -0.1f, -0.1f);
        transform.localScale += Time.deltaTime *scaleChange;
      }
      
    }  
}