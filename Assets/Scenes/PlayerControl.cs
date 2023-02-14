using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    float health = 10f;
    int score = 0;

    bool myBoolean = true;

    float thisIsADecimal = 3.14f;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(thisIsADecimal);
        thisIsADecimal++;
        Debug.Log(thisIsADecimal);
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(3, -1, 12);

        Vector3 newpos = transform.position;


        if (Input.GetKey(KeyCode.D))
        {
            newpos.x++;
        }
      
        if (Input.GetKey(KeyCode.A))
        {
            newpos.x += -1;
        }
        if (Input.GetKey(KeyCode.W))
        {
            newpos.z++;
        }
        if (Input.GetKey(KeyCode.S))
        {
            newpos.z += -1;
        }

        transform.position = newpos;
    }
}
