using UnityEngine;

public class wolk : MonoBehaviour
{
    
    
     public bool isGround;
     public Transform wolke ;
     public Rigidbody2D rig;
     [Range(0,100)]
     public int sp;

    
     
     public void wolds()
     {        
         
    if(rig.velocity.magnitude < 7)
    {
        
    }
{     
    if (isGround)
{
    
    if(rig)
    {
    
    isGround =true;
    rig.AddForce(new Vector2(sp,0));
    transform.localScale=new Vector3(4,4,4);
    SoundManager.instance.JumpAudio();
    }
        
}
    
    else 
    {
    isGround =false;
    rig.AddForce(new Vector2(-sp,0));
    transform.localScale=new Vector3(-4,4,4);
    
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
        wolds();    
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    { 
        
        if(collision.gameObject.name == "woman")
        {
            isGround =true;
        }
        
        else
        {
            isGround =false;
        }
       
        
}

}