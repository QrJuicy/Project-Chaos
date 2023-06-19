using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigidbodyCtrl : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    private Transform trans;
    public float speed;
    private float horizontalInput;
    private float verticalInput;
    public Vector3 movement;
    public Animator anim;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        trans = GetComponent<Transform>();
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
       movement = new Vector3((horizontalInput), 0f ,(verticalInput));
       Vector3 MoveVector = trans.TransformDirection(movement) * speed;
       rb.velocity = new Vector3(MoveVector.x, rb.velocity.y, MoveVector.z);

        if(Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0)
        {
            anim.SetTrigger("idle");
        } 
        else
        {
            anim.SetTrigger("running");
        }


        if(Input.GetAxis("Horizontal") > 0)
        {
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }

        if(Input.GetAxis("Horizontal") < 0)
        {
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        }   

        
    }
}
