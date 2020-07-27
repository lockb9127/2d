using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animator : MonoBehaviour
{
    public Animator Anim;
    public AudioClip attack1;
    public AudioClip attack2;
    public AudioSource add;
    public Transform tran;
    public SpriteRenderer pa;


 public void Tran()
 {
    bool iswalk =false;
     if(Input.GetKey(KeyCode.RightArrow))
     {
         iswalk =true;
         Anim.SetInteger("run",1);
         this.gameObject.transform.position+=new Vector3(0.1f,0,0);
         if(pa.flipX==true)
         {
             
             pa.flipX=false;
             gameObject.transform.position+=new Vector3(0.8f,0,0);
         }
     }
     if(Input.GetKey(KeyCode.LeftArrow))
     {
          iswalk =true;
          Anim.SetInteger("run",1);
         this.gameObject.transform.position+=new Vector3(-0.1f,0,0);
           if(pa.flipX==false)
         {
              
             pa.flipX=true;
             gameObject.transform.position+=new Vector3(-0.8f,0,0);
         }
     }
         
              if(iswalk)
           {
               if(Anim.GetInteger("run")==0)
               Anim.SetInteger("run",1);
           }
           else
           {
               if(Anim.GetInteger("run")==1)
               Anim.SetInteger("run",0);
           
         }
     }
 

  public void anim2()
    {

        bool key1 =Input.GetKeyDown(KeyCode.Z);
        Anim.SetBool("Attack2",key1);
        
        if(Input.GetKeyDown(KeyCode.Z))
        {
          add.PlayOneShot(attack2);
        }
    }
    public void anim()
    {

        bool key =Input.GetKeyDown(KeyCode.Space);
        Anim.SetBool("攻擊",key);
        if(Input.GetKeyDown(KeyCode.Space))
        {
          add.PlayOneShot(attack1,1);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        anim();
        anim2();
        Tran();
        
         
    }
        
    
}
