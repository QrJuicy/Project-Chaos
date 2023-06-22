using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class VFXPuller : MonoBehaviour
{
    [SerializeField] VisualEffect _Pull_From_PreFab;
    [SerializeField] AudioSource _Add_SFX;
    private float SpawnInterfal = 6f;

    private void Start()
    {
        SpawnVFX();
    }

    void SpawnVFX()
    {
        Invoke("SpawnVFX",SpawnInterfal);
        //instantiate new vfx
        VisualEffect newSpawnedVFX = Instantiate(_Pull_From_PreFab, transform.position, transform.rotation);
        //play vfx
        newSpawnedVFX.Play();
        
        //destroy vfx
        Destroy(newSpawnedVFX.gameObject, 5f);
        if(_Add_SFX == null) return;
        _Add_SFX.Play();
    }
}