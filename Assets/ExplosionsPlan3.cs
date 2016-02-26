using UnityEngine;
using System.Collections;

public class ExplosionsPlan3 : MonoBehaviour {

    private GameObject explosions;

	// Use this for initialization
	void Start () {
        explosions = GameObject.Find("EXPLOSIONS");
        explosions.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
	    if(Time.realtimeSinceStartup > 1.5)
        {
            explosions.SetActive(true);
        }
	}
}
