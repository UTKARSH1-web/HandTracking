using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shell : MonoBehaviour
{
    // Start is called before the first frame update
     public Transform player;
    public Text scoretext;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = player.position.z.ToString("0");
    }
}
