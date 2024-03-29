﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int kiwis = 0;

    [SerializeField] private Text KiwisText;
    [SerializeField] private AudioSource collectionSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Kiwi"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            kiwis++;
            KiwisText.text = "Kiwis " + kiwis;
        }
    }
}
