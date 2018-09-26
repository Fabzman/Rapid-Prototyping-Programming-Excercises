using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TweeningFun : MonoBehaviour {

    public GameObject cube;
    public float tweenSpeed = 2f;
	
	// Update is called once per frame
	void Update ()
    {
		if  (Input.GetKeyDown(KeyCode.A))
        {
            cube.transform.DOScale(4, tweenSpeed);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            cube.transform.DOMoveX(10, tweenSpeed);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            cube.transform.DOPunchPosition(Vector3.forward * 5, tweenSpeed,10,1);
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            Camera.main.DOShakePosition(tweenSpeed, 3, 10, 90);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            cube.GetComponent<Renderer>().material.DOColor(Color.blue, tweenSpeed);
        }
    }


}
