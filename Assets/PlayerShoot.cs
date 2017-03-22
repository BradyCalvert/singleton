using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerShoot : MonoBehaviour {
    public int damage;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Ray shootRay = new Ray(transform.position, transform.forward);
        Debug.DrawRay(shootRay.origin, shootRay.direction);
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            //shoot a ray
            RaycastHit hit;
            if(Physics.Raycast(shootRay,out hit, 10f))
            {
                if(hit.transform.CompareTag("Enemy"))
                {
                    hit.transform.GetComponent<EnemytHealth>().GetShot(damage);
                }
            }
 



           // GameObject.Find("Enemy").GetComponent<EnemytHealth>().GetShot(damage);


        }
        if (TestSingleton.instance.playerScore > 5)
        {
            SceneManager.LoadScene("scene2");
        }

    }
}
