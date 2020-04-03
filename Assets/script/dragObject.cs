using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDrag()
    {
        Vector3 mousePosWorld = new Vector3(Input.mousePosition.x,Input.mousePosition.y,5f);
        Vector3 objectPosition = Camera.main.ScreenToWorldPoint(mousePosWorld);
        transform.position = objectPosition;
    }
    
}
