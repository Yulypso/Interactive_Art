using UnityEngine;
using System.Collections;

public class collider_coffre_fin : MonoBehaviour
{
    public GameObject activation;
    public GameObject desactivation;
    public GameObject activation_capteur;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Umbrella")
        {
            activation.SetActive(true);
            desactivation.SetActive(false);
            activation_capteur.SetActive(true);

        }
    }
}