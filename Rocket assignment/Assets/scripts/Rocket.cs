using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Rocket : MonoBehaviour
{
    [SerializeField]
    public Transform transform;
    public Rigidbody m_rigidbody;



    private bool power;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float v = CrossPlatformInputManager.GetAxis("Vertical");
        m_rigidbody.AddForce(0, v, 0);


        float h = CrossPlatformInputManager.GetAxis("Horizontal");
        //rigid.AddForce(0, 0, h * 0.2f);
        transform.Rotate(0, 0, h*0.5f);

        power = CrossPlatformInputManager.GetButton("Jump");
        if (power)
        {
            m_rigidbody.AddRelativeForce(0, 3, 0);
        }

    }
}
