using UnityEngine;

public class Movement : MonoBehaviour {

    public Rigidbody rb;

    public float movement = 10000f;
    public Interactable focus;
    private float focusChange;

	// Use this for initialization
	void Start () {
        focusChange = 10;
	}
	
	// FixedUpdate is called once per frame and effects movement
	void FixedUpdate ()
    {
        if(Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -movement * Time.deltaTime);
        }

        if(Input.GetKey("a"))
        {
            rb.AddForce(-movement * Time.deltaTime, 0, 0);
        }

        if(Input.GetKey("d"))
        {
            rb.AddForce(movement * Time.deltaTime, 0, 0);
        }

        if(Input.GetKey("w"))
        {
            rb.AddForce(0, 0, movement * Time.deltaTime);
        }
        if (Input.GetKey("q"))
        {
            //jumpkey here
        }
	}
    
    void SetFocus(Interactable newFocus)
    {
        focus = newFocus;
    }
    void RemoveFocus()
    {
        focus = null;
    }
}
