using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    private float mSpeed = 5.0f;

    private Vector3 mVelocity;
    private Vector3 mRotation;

    public string v = "vertical";
    public string h = "horizontal";

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        mVelocity = Vector3.zero;
        animator.SetFloat(v, 0);
        animator.SetFloat(h, 0);

        if (Input.GetKey(KeyCode.W))
        {
            mVelocity.z = 1.0f;
        } else if (Input.GetKey(KeyCode.S))
        {
            mVelocity.z = -1.0f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            mVelocity.x = 1.0f;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            mSpeed = 5.0f;
            mVelocity.x = -1.0f;
        }

        if ((Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.S)) || (Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.A)))
        {
            animator.SetFloat(v, 1);
        }

        if ((Input.GetKey(KeyCode.LeftShift)) && ((Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.S)) || (Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.A))))
        {
            animator.SetFloat(h, 1);
        }

        transform.Translate(transform.position.x, 0, transform.position.z); 
    }
}
