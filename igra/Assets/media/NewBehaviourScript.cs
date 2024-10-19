using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject shar;
    public Transform cubetransform;
    public float collisionDistance = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        cubetransform = cubetransform.transform;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 positionThis = transform.position;
        Vector3 positionOther = cubetransform.position;
        if (Vector3.Distance(positionThis, positionOther) < collisionDistance)
        {
            shar.SetActive(false);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            shar.SetActive(true);
        }


    }
}
