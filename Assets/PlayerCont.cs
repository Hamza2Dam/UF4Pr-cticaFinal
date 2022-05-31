using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCont : MonoBehaviour
{

    public Animator anim;
    private Rigidbody rb;
    public LayerMask layerMask;
    public bool grounded;

    // Start is called before the first frame update
    void Start()
    {
        this.rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

        Grounded();
        Jump();
        Move();
    }

    // salta
    private void Jump()
    {

        if (Input.GetKeyDown(KeyCode.Space) && this.grounded)
        {
            this.rb.AddForce(Vector3.up * 4, ForceMode.Impulse);
        }

    }

    // 
    private void Grounded()
    {
        if (Physics.CheckSphere(this.transform.position + Vector3.down, 0.2f, layerMask))
        {
            this.grounded = true;
        }
        else
        {
            this.grounded = false;

        }

        this.anim.SetBool("jump", !this.grounded);
    }
    
    // moure
    private void Move()
    {
        float verticalAxis = Input.GetAxis("Vertical");
        float horitzontalAxis = Input.GetAxis("Horizontal");

        Vector3 movement = this.transform.forward * verticalAxis + this.transform.right * horitzontalAxis;
        movement.Normalize();

        this.transform.position += movement * 0.06f;

        this.anim.SetFloat("vert", verticalAxis);
        this.anim.SetFloat("horit", horitzontalAxis);


    }
}
