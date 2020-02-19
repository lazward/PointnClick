using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public bool isHeld = false ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y < -5) {

            transform.position = Vector3.zero + new Vector3(Random.Range(-8, 8), 1f, Random.Range(-3, -1)) ;

        }

        if (!isHeld) {

            return ;

        }

        Vector3 pos = Input.mousePosition;
        pos.z = transform.position.z - Camera.main.transform.position.z;
        pos = Camera.main.ScreenToWorldPoint(pos);
        pos.y = 8;
        transform.position = pos;

        if (Input.GetMouseButtonUp(0)) {
            
            isHeld = false ;

        }
        
    }

    void OnMouseDown() {

        isHeld = true ;

    }
    
}
