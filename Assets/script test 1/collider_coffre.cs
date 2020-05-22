using UnityEngine;
using System.Collections;

public class collider_coffre : MonoBehaviour
{
    public GameObject activation;
    public GameObject desactivation;
    public GameObject desactivation_capteur;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Capsule")
        {
            activation.SetActive(true);
            desactivation.SetActive(false);
            desactivation_capteur.SetActive(false);
            
        }
    }
}