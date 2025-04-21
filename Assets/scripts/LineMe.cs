using UnityEngine;

public class LineMe : MonoBehaviour
{
    public GameObject cube1;
    public GameObject cube2;
    public LineRenderer line;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        line.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        line.SetPosition(0, cube1.transform.position);
        line.SetPosition(1, cube2.transform.position);
    }
}
