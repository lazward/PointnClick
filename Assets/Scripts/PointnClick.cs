using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointnClick : MonoBehaviour
{

    public GameObject redPrefab ;
    public GameObject bluePrefab ;

    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0 ; i < 20 ; i++) {

            GameObject ball ;

            Vector3 position = Vector3.zero + new Vector3(Random.Range(-8, 8), 1f, Random.Range(-3, -1)) ;

            if (Random.Range(0,2) == 0) {

                ball = Instantiate(redPrefab, position, Quaternion.identity)as GameObject ;


            } else {

                ball = Instantiate(bluePrefab, position, Quaternion.identity)as GameObject ;

            }

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
