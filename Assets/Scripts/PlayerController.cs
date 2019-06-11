using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{

    public float speed;
    public Text eulerText;
    public Text quaternionsText;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Quaternion current = transform.localRotation;
        quaternionsText.text = "Kwaternion sfery: " + current;
        eulerText.text = "Euler sfery: (" + current.eulerAngles.x + ", " + current.eulerAngles.y + ", " + current.eulerAngles.z + ")";


        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }
}
