using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Start is called before the first frame update
    
    
    int flag = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (flag == 0)
        {
            transform.Translate(Vector2.right * 2f * Time.deltaTime);
        }
        else if(flag==1)
        {
            transform.Translate(Vector2.left * 2f * Time.deltaTime);
        }
        if(transform.position.x>8.0f)
        {
           
            transform.position = new Vector2(transform.position.x, transform.position.y - 1);
            flag = 1;
        }
        if (transform.position.x < -8.0f)
        {
            
            transform.position = new Vector2(transform.position.x, transform.position.y - 1);
            flag = 0;
        }
        if(transform.position.y<-4.6f)
        {
            //Destroy(gameObject);
        }
    }
}
