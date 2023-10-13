using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpell : MonoBehaviour
{
    public GameObject spell;
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(spell);
        //SpellMovement sm = gameObject.AddComponent(typeof(SpellMovement)) as SpellMovement;
        //SpellMovement sm = gameObject.AddComponent<SpellMovement>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(spell, transform.position, Quaternion.identity);
            //SpellMovement sm = gameObject.addComponent<SpellMovement>();
        }
    }
}
