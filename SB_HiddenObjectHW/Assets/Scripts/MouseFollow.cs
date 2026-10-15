using UnityEngine;
using UnityEngine.InputSystem;


public class MouseFollow : MonoBehaviour
{
    public float minX;
    public float minY;
    public float maxX;
    public float maxY;


    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        
        if(mousePosition.x > minX && mousePosition.x < maxX)
        {
            transform.position = new Vector3(mousePosition.x, transform.position.y, transform.position.z);
        }

        if(mousePosition.y > minY && mousePosition.y < maxY)
        {
            transform.position = new Vector3(transform.position.x, mousePosition.y, transform.position.z);
        }


    }

}
