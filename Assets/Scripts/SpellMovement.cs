using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMovement : MonoBehaviour
{
    public GameObject spell1;
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(spell1);
    }

    // Update is called once per frame
    int speed = 2;
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}
