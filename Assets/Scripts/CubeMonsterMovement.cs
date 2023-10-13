using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMonsterMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    int speed = 2;
    void Update()
    {

        transform.Translate(Vector2.up * speed * Time.deltaTime);
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
