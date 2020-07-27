
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
   public static SoundManager instance;
   
   public AudioSource audioSource;
   [SerializeField]
   private AudioClip jumpAudio, hurtAudio, cherryAudio;
   
   private void Awake()
   {
       instance= this;
   }
   
   public void JumpAudio()
   {
       audioSource.clip = jumpAudio;
       audioSource.Play();
   }
   
}
