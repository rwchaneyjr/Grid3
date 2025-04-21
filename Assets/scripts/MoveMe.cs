using UnityEngine;


public class MoveMe : MonoBehaviour
{

    public float moveSpeed = 2f;

    public GameObject Player;
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Player.transform.Translate(Vector3.right*moveSpeed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Player.transform.Translate(Vector3.left* moveSpeed);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Player.transform.Translate(Vector3.forward* moveSpeed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Player.transform.Translate(Vector3.back* moveSpeed);
        }
    }
}