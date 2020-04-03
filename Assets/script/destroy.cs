using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public GameObject startPointStage2;

    void Start()
    {
        transform.position = new Vector3(-10.01f, 1.1565f, 9.58f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject goalgameObject;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("WIN");
    }
    void OnCollisionEnter(Collision Des)
    {
        if (Des.gameObject.name == "player")
        {
            Destroy(GameObject.Find("target"));
        }
        if (Des.gameObject.name =="player")
        {
            Destroy(GameObject.Find("target2"));
        }
    }
    
}
