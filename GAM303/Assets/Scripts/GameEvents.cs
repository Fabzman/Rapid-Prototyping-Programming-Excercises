using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameEvents {

    //Declare the events
    public static event Action <int> OnScoreChange = null;

    // Event reporting
    public static void ReportOnScoreChange (int newValue)
    {
        if (OnScoreChange != null)
            OnScoreChange(newValue);
    }

	//// Use this for initialization
	//void Start () {
		
	//}
	
	//// Update is called once per frame
	//void Update () {
		
	//}
}
