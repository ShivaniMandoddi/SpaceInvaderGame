using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletMovement : MonoBehaviour
{
    // Start is called before the first frame update
        // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * 3f * Time.deltaTime);
    }
}
