using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
            GameObject scoreGO = GameObject.Find("Score") ;
            Text scoreGT = scoreGO.GetComponent<Text>() ;
            int score = int.Parse(scoreGT.text) ;
            score += 1000 ;
            scoreGT.text = score.ToString() ;

        } else {

            SceneManager.LoadScene("Scene0") ;

        }

    }

}
