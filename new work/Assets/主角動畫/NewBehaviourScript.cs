using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int health;
    public float speed;
    public float dazedTime;
    public float startDazedTime; 
    
        
    
    
    public Animator an;
    public GameObject bloodEffect;


    // Start is called before the first frame update
    void Start()
    {
        an =GetComponent<Animator>();
        an.SetBool("run",true);        
    }

    // Update is called once per frame
    void Update()
    {
        if(dazedTime<=0)
        {
            speed=5;
        }
        else
        {
            speed=0;
            dazedTime -=Time.deltaTime;
        }

        if(health<=0)
        {
            Destroy(gameObject);
        }
        transform.Translate(Vector2.left*speed*Time.deltaTime);
        }
      

   

    public void TakeDamage(int damage)
    {
        dazedTime=startDazedTime;
        Instantiate(bloodEffect,transform.position,Quaternion.identity);
        health -=damage;
        Debug.Log("damage TAKEN !");
    }
}


