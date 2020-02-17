using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision coll) {

        if ((this.gameObject.tag == "Red" && coll.gameObject.tag == "Red") || (this.gameObject.tag == "Blue" && coll.gameObject.tag == "Blue")) {

            Destroy(coll.gameObject) ;

        } else {

            SceneManager.LoadScene("Scene0") ;

        }

    }

}
