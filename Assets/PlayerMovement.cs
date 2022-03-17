using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float playerSpeed;
    public GameObject bulletSpawn;
    public GameObject enemy;
    void Start()
    {
        for (int i=0;i<4;i++)
            for(int j=0;j<5;j++)
            {
                Instantiate(enemy, new Vector2(-7.6f + j, 4.03f-i), Quaternion.identity);
            }
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        transform.Translate(inputX * playerSpeed*Time.deltaTime, 0f, 0f);
        if (transform.position.x < -8.0f)
            transform.position = new Vector2(-8.0f, transform.position.y);
        if (transform.position.x > 8.0f)
            transform.position = new Vector2(8.0f, transform.position.y);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletSpawn, transform.position+new Vector3(0.01f,0.5f,0f), Quaternion.identity);
           
            
        }
        
    }
}
