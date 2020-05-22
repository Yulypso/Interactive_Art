using UnityEngine;
using System.Collections;

public class positionscript : MonoBehaviour
{
    public GameObject particle;
    public Vector2 targetPosition;
    void Update()
    {
        if (Input.GetMouseButton(0)) //Si on récupère un click gauche ...
        {
            SetTargetPosition(); //fonction qui permet de changer la position de notre personnage
        }
    }

    void SetTargetPosition()
    {
        //Plane plane = new Plane(Vector2.up, transform.position); //permet de créer le point d'arrivé.
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //permet de fixer une caméra sur le personnage et donc de déplacer le personnage avec la caméra main
                                                                     //et donc de créer un point à cette position
        float point = 0f;
        targetPosition = ray.GetPoint(point);
        Debug.Log(targetPosition);
    }
}