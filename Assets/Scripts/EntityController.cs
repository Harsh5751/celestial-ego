﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EntityController : MonoBehaviour
{
    private string Tag = "Protein";
    private float Increase = 0.1f;
    public Text Letters;

    private int Score = 0;

    public int getScore() {
        return Score;
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == Tag) {
            transform.localScale += new Vector3(Increase, Increase, Increase);
            Destroy(other.gameObject);
            Score += GetComponent<ProteinPointBlob>().getProteinValue();
            Letters.text = "Protein Currency: " + Score;
        }
    }
}
