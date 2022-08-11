using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovements : MonoBehaviour
{
    // Start is called before the first frame update
    public UDPReceive udpReceive;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string data=udpReceive.data;
        data=data.Remove(0,1);
        data=data.Remove(data.Length-1,1);
        string[] info=data.Split(',');
        float x=float.Parse(info[0])/100;
        float y=(float)(2.22);
        float z=(float)(80.438);
       
        transform.localPosition=new Vector3(x,y,z);
    }
}
