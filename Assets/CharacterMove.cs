using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {
    const string RIGHT_TRIGGER = "right";
    const string LEFT_TRIGGER = "Left";
    const string IDLE_TRIGGER = "Idle";
    public Animator anim;
    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.D))
        {
            if(anim.GetCurrentAnimatorStateInfo(0).IsName("Rotate_Right")==false)
            transform.Translate(Vector3.right * speed);
    
        }
        if(Input.GetKey(KeyCode.D))
        {
            anim.SetTrigger(RIGHT_TRIGGER);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed);
            
        }
        if(Input.GetKey(KeyCode.A))
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("Rotate_Right") == false)
                anim.SetTrigger(LEFT_TRIGGER);
        }
	}
}
