using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.Audio;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    //public AudioClip death;
    public AudioSource owSound;
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<AudioSource> ().playOnAwake = false;
		//GetComponent<AudioSource> ().clip = death;
    }

    // Update is called once per frame
    float health = 5;
    void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Monster")
        {
            owSound.Play();
            health -= 5*Time.deltaTime;
            print(health);
            //owSound.Play();
        }
        
    }

    void Update()
    {
        if(health <= 0)
        {
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
            //SceneManager.LoadScene("Main Menu");
            //AudioSource audio = GetComponent<AudioSource>();
            //audio.clip = death;
            //audio.Play();
            //death.Play();
            //GetComponent<AudioSource> ().Play ();
            //deathSound.Play();
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
