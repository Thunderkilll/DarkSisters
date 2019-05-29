using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interract : MonoBehaviour {

    public Text chichaPartscore;
    public Text cappuccinScore;
    public Text teyscore;
    public int scorecappucin = 0;
    public static int scoretey = 0;
    public static int scorechicha = 0;
    void Start()
    {
          scorecappucin = 0;
          scoretey = 0;
          scorechicha = 0;
    }
    void OnCollisionEnter2D(Collision2D other)
    {
      
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "interractbles")
        {


            Debug.Log("interracted with " + col.gameObject.name);
            //el chicha 
            if (col.gameObject.name == "Jabbéd" || col.gameObject.name == "Chicha_Lower_Part" || col.gameObject.name == "Chicha_Upper_Part")
            {
                //add score chicha
                //update UI here score chicha
                scorechicha += 1;
                Debug.Log("chicha part   " + scorechicha);
                chichaPartscore.text = scorechicha.ToString();
                Destroy(col.gameObject);
            }

            //cappucin
            if (col.name == "Cappucin")
            {
                //add score cappucino
                //update UI score cappucin
                scorecappucin += 1;
                Debug.Log("score cappucin " + scorecappucin);
                cappuccinScore.text = scorecappucin.ToString();
                Destroy(col.gameObject);
            }

            //kess el tey 
            if (col.name == "KésTéy")
            {
                //add score cappucino
                //update UI score cappucin

                scoretey += 1;
                Debug.Log("kes tey  " + scoretey);
                teyscore.text = scoretey.ToString();
                Destroy(col.gameObject);
            }


        }
    }


}
