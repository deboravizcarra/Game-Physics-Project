using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

    private new Rigidbody rigidbody;
    public float jumpHeight = 20.0f;
    public float jumpSpeed = 10.0f;
    
    void Start() {
         rigidbody = GetComponent<Rigidbody>();
    }
    
    void Update() {
        // jump if left mouse click is pressed
        if (Input.GetKeyDown("space"))
        {
            rigidbody.AddForce(new Vector3(0, jumpHeight, 0) * jumpSpeed);
        }
    }
}
