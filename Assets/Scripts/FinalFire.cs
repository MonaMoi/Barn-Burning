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
    public Transform Spawnpoint12;
    public GameObject Prefab12;
    public Transform Spawnpoint13;
    public GameObject Prefab13;
    public Transform Spawnpoint14;
    public GameObject Prefab14;
    public Transform Spawnpoint15;
    public GameObject Prefab15;
    public Transform Spawnpoint16;
    public GameObject Prefab16;
    public Transform Spawnpoint17;
    public GameObject Prefab17;
    public Transform Spawnpoint18;
    public GameObject Prefab18;
    public Transform Spawnpoint19;
    public GameObject Prefab19;
    public Transform Spawnpoint20;
    public GameObject Prefab20;
    public Transform Spawnpoint21;
    public GameObject Prefab21;
    public Transform Spawnpoint22;
    public GameObject Prefab22;
    public Transform Spawnpoint23;
    public GameObject Prefab23;
    public Transform Spawnpoint24;
    public GameObject Prefab24;
    

    // Erstellung einer Instanz beim Betreten des Triggers.
    void OnTriggerEnter (Collider other)
    {
        StartCoroutine("SpawnFire");
    }

    private IEnumerator SpawnFire(){

        Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
        yield return new WaitForSeconds(0.4F);
        Instantiate(Prefab1, Spawnpoint1.position, Spawnpoint1.rotation);
        yield return new WaitForSeconds(0.4F);
        Instantiate(Prefab2, Spawnpoint2.position, Spawnpoint2.rotation);
        yield return new WaitForSeconds(0.4F);
        Instantiate(Prefab3, Spawnpoint3.position, Spawnpoint3.rotation);
        yield return new WaitForSeconds(0.3F);
        Instantiate(Prefab4, Spawnpoint4.position, Spawnpoint4.rotation);
        yield return new WaitForSeconds(0.3F);
        Instantiate(Prefab5, Spawnpoint5.position, Spawnpoint5.rotation);
        yield return new WaitForSeconds(0.3F);
        Instantiate(Prefab6, Spawnpoint6.position, Spawnpoint6.rotation);
        yield return new WaitForSeconds(0.3F);
        Instantiate(Prefab7, Spawnpoint7.position, Spawnpoint7.rotation);
        yield return new WaitForSeconds(0.3F);
        Instantiate(Prefab8, Spawnpoint8.position, Spawnpoint8.rotation);
        yield return new WaitForSeconds(0.3F);
        Instantiate(Prefab9, Spawnpoint9.position, Spawnpoint9.rotation);
        yield return new WaitForSeconds(0.2F);
        Instantiate(Prefab10, Spawnpoint10.position, Spawnpoint10.rotation);
        yield return new WaitForSeconds(0.2F);
        Instantiate(Prefab11, Spawnpoint11.position, Spawnpoint11.rotation);
        yield return new WaitForSeconds(0.2F);
        Instantiate(Prefab12, Spawnpoint12.position, Spawnpoint12.rotation);
        yield return new WaitForSeconds(0.2F);
        Instantiate(Prefab13, Spawnpoint13.position, Spawnpoint13.rotation);
        yield return new WaitForSeconds(0.2F);
        Instantiate(Prefab14, Spawnpoint14.position, Spawnpoint14.rotation);
        yield return new WaitForSeconds(0.2F);
        Instantiate(Prefab15, Spawnpoint15.position, Spawnpoint15.rotation);
        yield return new WaitForSeconds(0.2F);
        Instantiate(Prefab16, Spawnpoint16.position, Spawnpoint16.rotation);
        yield return new WaitForSeconds(0.2F);
        Instantiate(Prefab17, Spawnpoint17.position, Spawnpoint17.rotation);
        yield return new WaitForSeconds(0.2F);
        Instantiate(Prefab18, Spawnpoint18.position, Spawnpoint18.rotation);
        yield return new WaitForSeconds(0.2F);
        Instantiate(Prefab19, Spawnpoint19.position, Spawnpoint19.rotation);
        yield return new WaitForSeconds(0.2F);
        Instantiate(Prefab20, Spawnpoint20.position, Spawnpoint20.rotation);
        yield return new WaitForSeconds(0.2F);
        Instantiate(Prefab21, Spawnpoint21.position, Spawnpoint21.rotation);
        yield return new WaitForSeconds(0.2F);
        Instantiate(Prefab22, Spawnpoint22.position, Spawnpoint22.rotation);
        yield return new WaitForSeconds(0.2F);
        Instantiate(Prefab23, Spawnpoint23.position, Spawnpoint23.rotation);
        yield return new WaitForSeconds(0.2F);
        Instantiate(Prefab24, Spawnpoint24.position, Spawnpoint24.rotation);
    }
}
