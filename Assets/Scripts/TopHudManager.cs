using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace PacManGame
{
    public class TopHudManager : MonoBehaviour
    {
        TMP_Text scoreText;

        void Start()
        {
            scoreText = GameObject.Find("Score").GetComponent<TMP_Text>();
        }

        void Update()
        {
            int Score = GameManager.instance.Score;
            scoreText.text = "Score: " + Score;
        }
    }
}

