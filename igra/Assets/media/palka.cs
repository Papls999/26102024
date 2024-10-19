using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class palka : MonoBehaviour
{
    public GameObject shar;
    public float speed = 0.1f;
    public Transform cubetransform;
    public float collisionDistance=5.0f;
    // Start is called before the first frame update
    void Start()
    {
        cubetransform = cubetransform.transform;

        
    }

    // Update is called once per frame
    void Update()
    {
       

      if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(speed * -1* Time.deltaTime, 0,0);
        }
      else if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(speed* Time.deltaTime, 0, 0);
        }
      else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, 0,speed* Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        { 
            transform.position += new Vector3(0, 0, speed * -1* Time.deltaTime);
        }
       else if (Input.GetKey(KeyCode.D))
        {
            shar.SetActive(true);
        }
            Vector3 positionThis = transform.position;
        Vector3 positionOther = cubetransform.position;
        if (Vector3.Distance(positionThis, positionOther) < collisionDistance)
        {
            shar.SetActive(false);
        }
    }
}
