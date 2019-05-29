using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BACK_Button : MonoBehaviour {

	
    public void mainMenu(Canvas canvas1)
    {
        canvas1.gameObject.SetActive(true);
        gameObject.SetActive(false);
    }
}
