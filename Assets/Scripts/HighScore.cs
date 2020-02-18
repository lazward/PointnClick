using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{

    public static int highScore = 0 ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Text gt = this.GetComponent<Text>() ;
        gt.text = "HighScore:" + highScore.ToString() ;

        if (highScore > PlayerPrefs.GetInt("PointnClickHS")) {

            PlayerPrefs.SetInt("PointnClickHS", highScore) ;

        }
        
    }

    void Awake() {

        if (PlayerPrefs.HasKey("PointnClickHS")) {

            highScore = PlayerPrefs.GetInt("PointnClickHS") ;

        }

        PlayerPrefs.SetInt("PointnClickHS", highScore) ;

    }
}
