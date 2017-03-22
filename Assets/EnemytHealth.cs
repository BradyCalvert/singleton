using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemytHealth : MonoBehaviour {
    public int maxHealth=10;
        int currentealth;

	// Use this for initialization
	void Start () {
        currentealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GetShot(int damage)
    {
        currentealth -= damage;
        if(currentealth<=0)
        {
            //add score
            TestSingleton.instance.playerScore += 1; ;

            currentealth = maxHealth;
        }
    }
}
