using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    int coins;

    public GameObject Counter;
    // Start is called before the first frame update
    void Start()
    {
        coins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Counter.GetComponent<UnityEngine.UI.Text>().text = "SCORE: "+coins.ToString();

    }

    void OnTriggerStay(Collider other)
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(destroyObject());
        }
    }

    IEnumerator destroyObject()
    {
        yield return new WaitForSeconds(2.4f);
        Destroy(gameObject);
    }
}
