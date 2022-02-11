using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kanat : MonoBehaviour
{
    public GameObject MyKanat;
    public GameObject Enemy;
    public GameObject I;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
            MyKanat.transform.position = Vector3.MoveTowards(MyKanat.transform.position, I.transform.position, 2.0F * Time.deltaTime);
        //else MyKanat.transform.position = Vector3.MoveTowards(MyKanat.transform.position, Enemy.transform.position, 2.0F * Time.deltaTime);
    }
}
