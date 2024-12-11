using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float sprintSpeed = 7f;
    public float baseSpeed = 5f;
    public float jumpPower = 10f;

    private Rigidbody myRigidbody;
    private Vector3 movementDirection; 

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        // Sprint handling
        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = sprintSpeed;
        }
        else
        {
            moveSpeed = baseSpeed;
        }

        // Get input directions
        movementDirection = Vector3.zero; 
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

        // Calculate and apply velocity
        myRigidbody.velocity = movementDirection * moveSpeed; 

        // Jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }

        // Scale change (example)
        if (Input.GetKey(KeyCode.X)) 
        {
            Vector3 scaleChange = new Vector3(-0.1f, -0.1f, -0.1f);
            transform.localScale += Time.deltaTime * scaleChange;
        }
    }
}

