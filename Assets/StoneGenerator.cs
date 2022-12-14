using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject StonePrefeb; //GameObject 선언
    [SerializeField] private Camera backgroundCamera;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {   

            for(int i=0; i< 200; i++){
            // GameObject stone1 = GameObject.Instantiate(StonePrefeb, backgroundCamera.transform.forward*(Random.Range(1, 8)) + Vector3.up*(Random.Range(1, 20))+ Vector3.right*(Random.Range(1, 8))+ Vector3.left*(Random.Range(1, 8)), Quaternion.identity);
            GameObject stone1 = GameObject.Instantiate(StonePrefeb, new Vector3(Random.Range(-15.0f, 15.0f),Random.Range(-20.0f, 20.0f),Random.Range(-20.0f, 20.0f)), Quaternion.identity);
            }

        }
    }
}