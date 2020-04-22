using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

    private new Rigidbody rigidbody;
    public float jumpHeight;
    public GameObject ball;
    
    // Use this for initailization
    void Start() {
         rigidbody = GetComponent<Rigidbody>();
}

    // Update is called once per frame
    void Update() {
        // jump if left mouse click is pressed
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpHeight);
            //ball.transform.position = jump;
        }
        //Vector3 gerak = new Vector3 ( 0, Input.GetAxis ("Vertical"));
        //rigidbody.AddForce (gerak * jumpspeed);
    }
}
