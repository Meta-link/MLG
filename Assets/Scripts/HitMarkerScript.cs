using UnityEngine;
using System.Collections;

public class HitMarkerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        float x = Random.Range(-300, 300);
        float y = Random.Range(-300, 300);
        transform.localPosition = new Vector3(x, y);
    }
	
	// Update is called once per frame
	void Update ()
    {

    }
}
