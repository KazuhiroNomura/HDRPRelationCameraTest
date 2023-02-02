using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box移動 : MonoBehaviour
{
    private float speed = 5.0f;
    private bool flag;
 
    void Update()
    {
        if(transform.position.z >= 3)
            flag = true;
 
        else if(transform.position.z <= -3)
            flag = false;
        
        if(flag)
            transform.position = 
                Vector3.MoveTowards(transform.position, new Vector3(transform.position.x,transform.position.y,transform.position.z-3f), speed * Time.deltaTime);
 
        else if(!flag)
            transform.position =
                Vector3.MoveTowards(transform.position, new Vector3(transform.position.x,transform.position.y,transform.position.z+13f), speed * Time.deltaTime);
    }

}
