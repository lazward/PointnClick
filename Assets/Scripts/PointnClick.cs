using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PointnClick : MonoBehaviour
{

    public GameObject redPrefab ;
    public GameObject bluePrefab ;
    public float timer = 30.0f ;
    public static int ballsLeft = 20 ;

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
        
        GameObject.Find("Score").GetComponent<Text>().text = "0" ;
        GameObject.Find("Timer").GetComponent<Text>().text = timer.ToString("F0") ;
        
    }

    // Update is called once per frame
    void Update()
    {

        timer -= Time.deltaTime ;
        if (ballsLeft == 0) {

            GameObject scoreGO = GameObject.Find("Score") ;
            Text scoreGT = scoreGO.GetComponent<Text>() ;
            int score = int.Parse(scoreGT.text) ;
            score += ((int)timer * 2000) ;
            scoreGT.text = score.ToString() ;
            SceneManager.LoadScene("Scene0") ;

        }

        if (timer < 0) {

            SceneManager.LoadScene("Scene0") ;

        }

        GameObject.Find("Timer").GetComponent<Text>().text = timer.ToString("F0") ;
        
    }
}
