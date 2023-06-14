using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    private CharacterController ctrl;
    [SerializeField] float speed;
    void Start()
    {
        ctrl = GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector3 move = new Vector3 (Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
        ctrl.Move(move * Time.deltaTime * speed);
    }

}
