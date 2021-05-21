using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator animator;
    public GameObject sparkle;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        sparkle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("magic");

            sparkle.SetActive(true);
            StartCoroutine(stopSparkles());
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }  else if (Input.GetKey(KeyCode.S))
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles = new Vector3(0, 90, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles = new Vector3(0, -90, 0);
        }
        
    }

    IEnumerator stopSparkles()
    {
       yield return new WaitForSeconds(2.4f);
       sparkle.SetActive(false);
    }
}
