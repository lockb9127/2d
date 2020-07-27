using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WOMAN : MonoBehaviour
{
    
     public bool isGround;
     public Transform wolke ;
     public Rigidbody2D rig;
     [Range(0,100)]
     public int sp;

     
    

     public void wolks()
     {
    if(rig.velocity.magnitude < 5)
{     
    if (isGround)
{
    if(rig)
    {
    isGround =true;
    rig.AddForce(new Vector2(sp,0));
    transform.localScale=new Vector3(-4,4,4);
    }
        
}
    
    else 
    {
    isGround =false;
    rig.AddForce(new Vector2(-sp,-0));
    transform.localScale=new Vector3(4,4,4);
    }
    

}


}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        wolks();
           
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "牆壁")
        {
            isGround =true;
        }
        
        else
        {
            isGround =false;
        }
       
        
}

}