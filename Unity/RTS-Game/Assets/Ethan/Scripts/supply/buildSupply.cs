﻿/*
 * Name: Ethan Herndon
 * Date: 11/8/2020
 * Class: CST 426
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildSupply : MonoBehaviour
{
    //TODO: CHECK IF SUPPLY IS DESTROYED THEN REMOVE FROM LIST

    public GameObject thePrefab;
  
    void Start()
    {
        
    }

    void Update()
    {

        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f);
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 wordPos;
            Ray ray = Camera.main.ScreenPointToRay(mousePos);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 1000f))
            {
                if (hit.collider.gameObject.tag == "supply")
                {
                    Debug.Log("cannot comply!");
                    return;
                }
                wordPos = hit.point;
            }
            else
            {
                wordPos = Camera.main.ScreenToWorldPoint(mousePos);
            }
            Instantiate(thePrefab, wordPos + Vector3.up * 1f, Quaternion.identity);
            //supplyBuildings = GameObject.FindGameObjectsWithTag("supply");
        }

      

    }

}