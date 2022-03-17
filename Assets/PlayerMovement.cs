using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float playerSpeed;
    public GameObject bulletSpawn;
    public GameObject enemy;
    string[] enemyList;
    public GameObject enemyBullet;
    float time;
    Rigidbody2D rb;
    public GameObject player;
    Vector3 playerPosition;
    void Start()
    {

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                var enem = Instantiate(enemy, new Vector2(-7.6f + j, 4.03f - i), Quaternion.identity);
                enem.name = "Enemy" + i + j;
                //Debug.Log(enem.name); 

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        transform.Translate(inputX * playerSpeed * Time.deltaTime, 0f, 0f);
        if (transform.position.x < -8.0f)
            transform.position = new Vector2(-8.0f, transform.position.y);
        if (transform.position.x > 8.0f)
            transform.position = new Vector2(8.0f, transform.position.y);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletSpawn, transform.position + new Vector3(0.01f, 0.5f, 0f), Quaternion.identity);

        }
        time = time + Time.deltaTime;
        if (time >= 4f)
        {

            int i = Random.Range(0, 3);
            int j = Random.Range(0, 4);
            GameObject enemy = GameObject.Find("Enemy" + i + j);
            Vector3 enemyPosition = enemy.transform.position;
            Instantiate(enemyBullet, enemyPosition + new Vector3(0f, -0.245f, 0f), Quaternion.identity);
            //Debug.Log("Bullet launching from"+enemy.name);
            time = 0f;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "EnemyBullet")
        {
           playerPosition=gameObject.transform.position;
            Destroy(gameObject);
            Destroy(collision.gameObject);
            
            
        }
    }
   
}
