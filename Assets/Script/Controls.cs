using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    private Vector3 movement;
    [SerializeField] float gravity;
    private CharacterController ctrl;
    [SerializeField] float speed;
    private Transform trans;
    void Start()
    {
        ctrl = GetComponent<CharacterController>();
        trans = GetComponent<Transform>();
    }

    void Update()
    {
        Vector3 move = new Vector3 (Input.GetAxis("Horizontal") , 0 , Input.GetAxis("Vertical")).normalized;
        movement = move * Time.deltaTime * speed;
        movement += new Vector3 (0 , gravity * Time.deltaTime , 0);
        ctrl.Move(movement);              

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

