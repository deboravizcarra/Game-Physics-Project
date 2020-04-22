using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;

    public Transform camPivot;
    float heading = 0;
    public Transform cam;
    Vector2 input;

    public Text countText;
    public Text winText;

    private Rigidbody rb;
    private int count;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        /*
        Vector3 movement = new Vector3(moveVertical, 0.0f, -moveHorizontal);
        rb.AddForce(movement * speed);
        */
        //camera oriented player input
        heading += Input.GetAxis("Mouse X") * Time.deltaTime * 100;
        camPivot.rotation = Quaternion.Euler(0, heading, 0);

        input = new Vector2(moveHorizontal, moveVertical);
        input = Vector2.ClampMagnitude(input, 1);

        Vector3 camF = cam.forward;
        Vector3 camR = cam.right;

        camF.y = 0;
        camR.y = 0;
        camF = camF.normalized;
        camR = camR.normalized;

        rb.AddForce((camF * input.y + camR * input.x) * speed);
        //transform.position += (camF * input.y + camR * input.x) * Time.deltaTime * 5;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 12)
        {
            winText.text = "You Win!";
        }
    }
}
