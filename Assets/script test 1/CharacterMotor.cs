using UnityEngine;
using System.Collections;

public class CharacterMotor : MonoBehaviour
{
    public float speed = 10; //vitesse de deplacement
    public Vector3 targetPosition; //vecteur pour se déplacer 

    public bool isMoving; //bool qui permet de décider si oui ou non le perso doit se déplacer

    const int LEFT_MOUSE_BUTTON =0; //0 pour click gauche et 1 pour click droit

    void Start()
    {
        targetPosition = transform.position; //permet de définir targetPosition par notre position actuelle
        isMoving = false; //permet de dire au début que notre personage ne bouge pas au début

    }

    void Update()
    {
        if (Input.GetMouseButton(LEFT_MOUSE_BUTTON)) //Si on récupère un click gauche ...
        {
            SetTargetPosition(); //fonction qui permet de changer la position de notre personnage
        }

        if (isMoving)
        {
            MovingPlayer(); //si déplace, alors on utilise la fonction déplacer personage
        }
    }
    void SetTargetPosition()
    {
        Plane plane = new Plane(Vector3.forward, transform.position); //permet de créer le point d'arrivé.
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //permet de fixer une caméra sur le personnage et donc de déplacer le personnage avec la caméra main
        //et donc de créer un point à cette position
        float point = 0f;

        if (plane.Raycast(ray, out point))
        {
            targetPosition = ray.GetPoint(point);
            isMoving = true;
        }
    }


    void MovingPlayer()
    {
        //transform.LookAt(targetPosition); //permet de faire pivoter le personnage vers la direction de déplacement
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        //(Point A, Point B, vitesse * temps(temps == 1))

        if (transform.position == targetPosition)
        {
            isMoving = false;


            //Debug.DrawLine(transform.position, targetPosition, Color.red); //permet de tracer une ligne rouge de déplacement.
        }
    }
}
