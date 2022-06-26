using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Platformer.Gameplay;
using static Platformer.Core.Simulation;
namespace Platformer.Mechanics
{
    public class CollectItem : MonoBehaviour
    {
        public Collider2D collider2d;
        public GameObject TextGameObject;
        private TextMeshProUGUI text;
        public AudioSource audioSource;
        public AudioClip collectClip;

        void Start()
        {
            collider2d = GetComponent<Collider2D>();
            audioSource = GetComponent<AudioSource>();
            text = TextGameObject.GetComponent<TextMeshProUGUI>();
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            text.SetText(int.Parse(text.text) + 1 + "");
            Schedule<CoinCollect>().coin = this;
        }
    }
}