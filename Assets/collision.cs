using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collision : MonoBehaviour
{
   public AudioSource ss;
    public BallMovements movement;
    void Start()
    {
      ss=GetComponent<AudioSource>();
    }
   void OnCollisionEnter(Collision coll)
   {
        
      if(coll.collider.tag=="obstacle")
      {
         movement.enabled=false;
        Debug.Log("here");
         Debug.Log("yuvi");
          ss.Stop();
       
         Application.Quit();
      }
       ss.Play();
   //    if(coll.gameObject.tag=="obstacle"){
   //    movement.enabled=false;
   //    if(movement.enabled==false){
   //  
   //    }
   //    }
   }
  
}
