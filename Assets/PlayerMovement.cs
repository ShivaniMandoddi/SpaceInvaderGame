using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float playerSpeed;
    void Start()
    {
        
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
    }
}
