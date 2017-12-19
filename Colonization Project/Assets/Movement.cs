using UnityEngine;

public class Movement : MonoBehaviour {

    public Rigidbody rb;

    Camera cam;

    public Interactable focus;

    public float movement = 300f;

	// Use this for initialization
	void Start () {
		
	}
	
	// FixedUpdate is called once per frame and effects movement
	void FixedUpdate () {
		
        if(Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -movement * Time.deltaTime);
            focus = null;
        }

        if(Input.GetKey("a"))
        {
            rb.AddForce(-movement * Time.deltaTime, 0, 0);
            focus = null;
        }

        if(Input.GetKey("d"))
        {
            rb.AddForce(movement * Time.deltaTime, 0, 0);
            focus = null;
        }

        if(Input.GetKey("w"))
        {
            rb.AddForce(0, 0, movement * Time.deltaTime);
            focus = null;
        }
	}
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                Interactable interactable = hit.collider.GetComponent<Interactable>();
                if (interactable != null)
                {
                    SetFocus(interactable);
                }
            }
        }
    }
    void SetFocus(Interactable newfocus)
    {
        focus = newfocus;
    }
}
