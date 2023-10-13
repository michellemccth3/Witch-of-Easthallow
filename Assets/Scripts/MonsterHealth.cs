using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterHealth : MonoBehaviour
{
    float health;
    public AudioSource collided;
    // Start is called before the first frame update
    void Start()
    {
        health = 3;
    }

    // Update is called once per frame
    //float health = 3;
    void Update()
    {
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Spell") //|| collision.gameObject.tag == "Wall")
        {
            collided.Play();
            health -= 1;
            print(health);
        }
    }

}
