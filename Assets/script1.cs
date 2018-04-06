using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class script1 : MonoBehaviour {
    public int coinPickups = 0;
    public Text coinCounter;
    GameObject Camera;
    Animator anim;
    Rigidbody rigid;

    // Use this for initialization
    void Start () {
        UpdateCounter();
        Camera = GameObject.FindGameObjectWithTag("MainCamera");
        anim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void UpdateCounter()
    {
        coinCounter.text = coinPickups.ToString();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "coin")
        {
            Counter.count += 1;
            //UpdateCounter();
        }
        
        //UpdateCounter();
    }
}