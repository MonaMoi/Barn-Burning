using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Start der einzelnen Feuerpunte beim Betreten des Triggers.
public class FinalFire : MonoBehaviour
{
    // Variablen zur örtlichen Bestimmung und zum Laden des gewünschten Prefabs.
    public Transform Spawnpoint;
    public GameObject Prefab;
    public Transform Spawnpoint1;
    public GameObject Prefab1;
    public Transform Spawnpoint2;
    public GameObject Prefab2;
    public Transform Spawnpoint3;
    public GameObject Prefab3;
    public Transform Spawnpoint4;
    public GameObject Prefab4;
    public Transform Spawnpoint5;
    public GameObject Prefab5;
    public Transform Spawnpoint6;
    public GameObject Prefab6;
    public Transform Spawnpoint7;
    public GameObject Prefab7;
    public Transform Spawnpoint8;
    public GameObject Prefab8;
    public Transform Spawnpoint9;
    public GameObject Prefab9;
    public Transform Spawnpoint10;
    public GameObject Prefab10;
    public Transform Spawnpoint11;
    public GameObject Prefab11;

    // Erstellung einer Instanz beim Betreten des Triggers.
    void OnTriggerEnter (Collider other)
    {
        Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
        Instantiate(Prefab1, Spawnpoint1.position, Spawnpoint1.rotation);
        Instantiate(Prefab2, Spawnpoint2.position, Spawnpoint2.rotation);
        Instantiate(Prefab3, Spawnpoint3.position, Spawnpoint3.rotation);
        Instantiate(Prefab4, Spawnpoint4.position, Spawnpoint4.rotation);
        Instantiate(Prefab5, Spawnpoint5.position, Spawnpoint5.rotation);
        Instantiate(Prefab6, Spawnpoint6.position, Spawnpoint6.rotation);
        Instantiate(Prefab7, Spawnpoint7.position, Spawnpoint7.rotation);
        Instantiate(Prefab8, Spawnpoint8.position, Spawnpoint8.rotation);
        Instantiate(Prefab9, Spawnpoint9.position, Spawnpoint9.rotation);
        Instantiate(Prefab10, Spawnpoint10.position, Spawnpoint10.rotation);
        Instantiate(Prefab11, Spawnpoint11.position, Spawnpoint11.rotation);


    }

}
