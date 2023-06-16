using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    private Vector3 movement;
    [SerializeField] float gravity;
    private CharacterController ctrl;
    [SerializeField] float speed;
    void Start()
    {
        ctrl = GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector3 move = new Vector3 (Input.GetAxis("Horizontal") , 0 , Input.GetAxis("Vertical")).normalized;
        movement = move * Time.deltaTime * speed;
        movement += new Vector3 (0 , gravity * Time.deltaTime , 0);
        ctrl.Move(movement);              
    }

}

