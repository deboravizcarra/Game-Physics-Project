using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

    private Rigidbody rigidbody;
    private float jumpspeed = 5;
    
    // Use this for initailization
    void Start() {
         rigidbody = GetComponent<Rigidbody>();
}

    // Update is called once per frame
    void Update() {
        // tekan space untuk Lampat
        if (Input.GetKey(KeyCode.Space)) {
            Vector3 atas = new Vector3(0, 10, 0);
            rigidbody.AddForce(atas * jumpspeed);
        }
        Vector3 gerak = new Vector3 ( 0, Input.GetAxis ("Vertical"));
        rigidbody.AddForce (gerak * jumpspeed);
    }
}
