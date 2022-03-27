using System.Collections;
using UnityEngine;

public class EnemyBulletMovement : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
   
    GameObject player;
    void Update()
    {
        transform.Translate(Vector2.down * 3f * Time.deltaTime);
    }
    private void OnBecameInvisible()
    {
        StartCoroutine("DestroyBullet");

        //Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            player=collision.gameObject ;
            collision.gameObject.SetActive(false);
            StartCoroutine("PlayerActive");
        }
    }
    IEnumerator PlayerActive()
    {
        yield return (new WaitForSeconds(1));
        player.SetActive(true);
        
    }
    IEnumerator DestroyBullet()
    {
        yield return (new WaitForSeconds(2));
        Destroy(gameObject);
    }
}