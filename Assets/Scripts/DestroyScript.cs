using UnityEngine;
using System.Collections;

public class DestroyScript : MonoBehaviour {

    public float time = 1f;

    void Awake()
    {
        Destroy(gameObject, time);
    }

    // Use this for initialization
    void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	}
}
