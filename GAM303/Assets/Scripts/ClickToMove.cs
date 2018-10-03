using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ClickToMove : MonoBehaviour {



    //public float smoothing = 7f;
    //public Vector3 Target

    //{
    //    get { return target; }
    //    set
    //    {
    //        target = value;

    //        StopCoroutine("Movement");
    //        StartCoroutine("Movement", target);
    //    }
    //}


    //private Vector3 target;


    //IEnumerator Movement(Vector3 target)
    //{
    //    while (Vector3.Distance(transform.position, target) > 0.05f)
    //    {
    //        transform.position = Vector3.Lerp(transform.position, target, smoothing * Time.deltaTime);

    //        yield return null;
    //    }
    //}

    //public PropertiesAndCoroutines coroutineScript;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            Physics.Raycast(ray, out hit);

            if (hit.collider.gameObject != null)
            {
                Vector3 newTarget = hit.point + new Vector3(0, 0.5f, 0);
                transform.DOMove(newTarget, 2f);
                //coroutineScript.
                //Target = newTarget;
            }
        }
    }

    //   // Use this for initialization
    //   void Start () {

    //}

    //// Update is called once per frame
    //void Update () {

    //}
}
