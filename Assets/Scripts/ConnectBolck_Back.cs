using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectBolck_Back : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        print("10101");
        if (other.gameObject.CompareTag("Number")) {
            
            other.gameObject.transform.SetParent(transform);
        }
    }

}
