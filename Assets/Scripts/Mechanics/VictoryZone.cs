using System;
using System.Collections;
using System.Collections.Generic;
using Platformer.Gameplay;
using UnityEngine;
using static Platformer.Core.Simulation;
using Platformer.Model;
using Platformer.Core;
using TMPro;

namespace Platformer.Mechanics
{
    public class VictoryZone : MonoBehaviour
    {
        public TextMeshProUGUI text;

        void OnTriggerEnter2D(Collider2D collider)
        {
            var p = collider.gameObject.GetComponent<PlayerController>();
            if (p != null)
            {
                var ev = Schedule<PlayerVictory>();
            }
            text.SetText("0");
        }
    }
}