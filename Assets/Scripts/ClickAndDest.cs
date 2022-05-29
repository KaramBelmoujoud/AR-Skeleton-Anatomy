using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;


public class ClickAndDest : MonoBehaviour
{


    void Update()
            {
        //GameObject.Find("GameObject").GetComponent<DragObject>().enabled = true;
        //GetComponent<onClickForScaling>().enabled = true;
        if (Input.GetMouseButtonDown(0))
                {
                  RaycastHit hit;
                 Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);


            if (Physics.Raycast(ray, out hit))
                {
                    GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("hasInfo");
                    foreach (GameObject target in gameObjects)
                    {

                    //GameObject.Destroy(target);
                    BoxCollider bc = hit.collider as BoxCollider;
                        if (bc != null)
                        {
                        //target.SetActive(false);
                        
                            //bc.gameObject.SetActive(false);

                            
                        //Instantiate(bc.gameObject, new Vector3(0, -1, 1), transform.rotation);
                        }

                    }

                }
            }
        
    }
}
