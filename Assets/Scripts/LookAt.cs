using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class LookAt : MonoBehaviour
{  
    public Transform target;
    public Transform obiekt;
    public Text eulerText;
    public Text quaternionsText;
    ///private Text quaternions;


    void Update()
    {
        Quaternion current = transform.localRotation;
        quaternionsText.text = "Kwaternion szescianu: " + current;
        eulerText.text = "Euler szescianu: (" + current.eulerAngles.x + ", " + current.eulerAngles.y + ", " + current.eulerAngles.z + ")";

        Vector3 relativePos = target.position - transform.position;
        transform.rotation = Quaternion.LookRotation(relativePos);
    }
}
