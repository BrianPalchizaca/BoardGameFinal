using UnityEngine;

public class Camera_View : MonoBehaviour
{
    [SerializeField] private bool useCameraDrage = false;

    public float dragSpeed = .1f;
    private Vector3 dragOrigin;

    public GameObject View_Map;
    public GameObject Show_Cards;
    public GameObject Roll_Dice;
    public GameObject Go_Back;



    public void Update()
    {

        if (useCameraDrage == true)
        {
            CameraMovement();
        }
        else if (useCameraDrage == false)
        {
            transform.position = new Vector3(11.17f, 10.67f, -2.26f);
        }
    }

    public void CameraMovement()
    {
        if (Input.GetMouseButtonDown(0))
        {
            dragOrigin = Input.mousePosition;
            return;
        }

        if (!Input.GetMouseButton(0)) return;

        Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - dragOrigin);
        Vector3 move = new Vector3(pos.x * dragSpeed, 0, pos.y * dragSpeed);


        transform.Translate(move, Space.World);

    }


    public void ViewMap()
    {
        Roll_Dice.SetActive(false);
        View_Map.SetActive(false);
        Show_Cards.SetActive(false);
        Go_Back.SetActive(true);
        useCameraDrage = true;
    }

    public void GoBack()
    {
        Roll_Dice.SetActive(true);
        View_Map.SetActive(true);
        Show_Cards.SetActive(true);
        Go_Back.SetActive(false);
        useCameraDrage = false;
    }




}
