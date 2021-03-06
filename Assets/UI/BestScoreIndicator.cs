﻿using GreenPuffer.Accounts;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

namespace GreenPuffer.UI
{
    class BestScoreIndicator : MonoBehaviour
    {
        [SerializeField]
        private Text scoreText;

        private void Awake()
        {
            Users.LocalUser.PropertyChanged += OnUserPropertyChanged;
            UpdateUI();
        }

        private void OnDestroy()
        {
            Users.LocalUser.PropertyChanged -= OnUserPropertyChanged;
        }

        private void OnUserPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "BestScore")
            {
                UpdateUI();
            }
        }

        private void UpdateUI()
        {
            scoreText.text = Users.LocalUser.BestScore.ToString("#,##0");
        }
    }
}