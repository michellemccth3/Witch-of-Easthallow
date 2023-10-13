using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    float health = 5;
    void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Monster")
        {
            health -= 5*Time.deltaTime;
            print(health);
        }
        
    }

    void Update()
    {
        if(health <= 0)
        {
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
            //SceneManager.LoadScene("Main Menu");
        }
        if(GameObject.FindGameObjectsWithTag("Monster").Length == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    //void OnCollision(Collision2D collision)
    //{
    //    if(collision.gameObject.name == "Monster")
    //    {
     //       health -= 1;
      //      print(health);
        //}
    //}

}
