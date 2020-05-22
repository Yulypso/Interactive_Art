using UnityEngine;
using System.Collections;

public class testScript : MonoBehaviour
{
    public GameObject target;
    public Transform onHand;

    public GameObject original;

  //  public float horizontalSpeed = 2;
  //  public float verticalSpeed = 2;

   // public CharacterController controller;
   // public float runSpeed = 40f;
    //float horizontalMove = 0f;


    private void Start()
    {
        original.SetActive(false);

        /*Vector3 pz = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pz.z = 0;
        original.transform.position = pz;*/
    }

    void Update()
    {
        bool down = Input.GetButtonDown("Kebab");
        bool held = Input.GetButton("Kebab");
        bool up = Input.GetButtonUp("Kebab");

        if (down)
        {

            //  clone = Instantiate(target, new Vector3(0, 2, -4), Quaternion.identity);
            // 2 clone = (GameObject)Instantiate(original,Input.mousePosition - new Vector3(0, 2, -4), Quaternion.identity);

            // Invoke("SpawnObject", 0);

            original.SetActive(true);


           //horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

           // controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);

        

        }
        else if (held)
        {
            /*this.transform.position = onHand.transform.position;
            //this.transform.parent = GameObject.Find("FPSController").transform;
            this.transform.parent = GameObject.Find("FirstPersonCharacter").transform;
            */

            /*GetComponent<Rigidbody>().useGravity = false;
            this.transform.position = onHand.transform.position;
            this.transform.parent = GameObject.Find("FirstPersonCharacter").transform;
            */

            //OnMouseDrag();           

         
        }
        else if (up)
        {
            //this.transform.parent = GameObject.Find("FPSController").transform;
            //this.transform.parent = null;

            //  Destroy(clone);

            original.SetActive(false);

        }
        else
        {

        }
    }

  /*  void OnMouseDrag()
    {
        var h = horizontalSpeed * Input.GetAxis("Mouse X");
        original.transform.Translate(h, 0, 0);

        var j = verticalSpeed * Input.GetAxis("Mouse Y");
        original.transform.Translate(0, j, 0);
    }*/

    /*
    void SpawnObject()
    {
        GameObject clone = Instantiate(target, new Vector3(0, 2, -4), Quaternion.identity);
    }*/
}