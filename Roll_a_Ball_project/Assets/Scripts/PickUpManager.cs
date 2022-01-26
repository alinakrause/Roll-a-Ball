using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpManager : MonoBehaviour
{
    public GameObject pickUp;
    public static int pickUps = 10;
    // Start is called before the first frame update
    void Start()
    {
        for (int i=0 ; i < pickUps; i++)
        {
            Instantiate(pickUp, new Vector3(Random.Range(-9,9),0.5f,Random.Range(-9,9)),Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
