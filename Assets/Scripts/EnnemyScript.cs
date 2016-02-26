using UnityEngine;
using System.Collections;

public class EnnemyScript : MonoBehaviour {

    private NavMeshAgent nav;

	// Use this for initialization
	void Start () {
        nav = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        nav.SetDestination(GameObject.Find("Mouton_Gameplay").transform.position);
	}
}
