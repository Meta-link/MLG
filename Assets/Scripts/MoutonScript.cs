using UnityEngine;
using System.Collections;

public class MoutonScript : MonoBehaviour {

    public float vSpeed = 10;
    public float rSpeed = 10;

    private Rigidbody body;
    private Animator anim;

    // Use this for initialization
    void Start () {
        body = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        float vx = Input.GetAxis("Horizontal") * rSpeed;
        float vz = Input.GetAxis("Vertical") * vSpeed;

        var v = body.transform.forward;
        v.y = 0.0f;
        v.Normalize();
        v *= vz;
        v.y = body.velocity.y;
        body.velocity = v;
        body.transform.localEulerAngles = new Vector3(body.transform.localEulerAngles.x, body.transform.localEulerAngles.y + vx, body.transform.localEulerAngles.z);

        if(!anim.GetBool("Walk") && vz != 0)
        {
            anim.SetBool("Walk", true);
        }
        else if(vz == 0)
        {
            anim.SetBool("Walk", false);
        }

        if(Input.GetButtonDown("Jump"))
        {
            anim.SetBool("Attack", true);
        }
    }
}
