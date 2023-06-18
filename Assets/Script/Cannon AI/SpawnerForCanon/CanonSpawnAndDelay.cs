using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonSpawnAndDelay : MonoBehaviour
{

    public SearchAndDestroy SnD;
    [SerializeField]
    private GameObject CanonBall;
    [SerializeField]
    private float SpawnInterfal = 3f;
    // Start is called before the first frame update
    void Start()
    {
        CanonBallSpawn();
    }

  private void CanonBallSpawn()
  {
    if (SnD.dead == false)
    {
    Instantiate(CanonBall, transform.position ,Quaternion.identity);
    Invoke("CanonBallSpawn",SpawnInterfal);
    }
  }
}

