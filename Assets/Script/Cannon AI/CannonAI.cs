using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CannonAI : MonoBehaviour
{
    
    public UI ui;
    public SearchAndDestroy SnD;
    [SerializeField] private Transform movePos;
    private NavMeshAgent navMeshAgent;
    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        SnD = movePos.GetComponent<SearchAndDestroy>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SnD.dead == false && ui.start == true)
        {
            navMeshAgent.destination = movePos.position;
        }
    }
}
