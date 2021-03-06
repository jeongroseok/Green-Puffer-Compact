﻿using GreenPuffer.Accounts;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GreenPuffer.Misc
{
    public class UnityMethods : MonoBehaviour
    {
        public void LoadScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }

        public void ResetPlayerPrefs()
        {
            PlayerPrefs.DeleteAll();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        public void AddCoin(int amount)
        {
            Users.LocalUser.Coin += amount;
        }
    }
}