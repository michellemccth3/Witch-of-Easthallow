using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float speed = 2;
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
        //transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
