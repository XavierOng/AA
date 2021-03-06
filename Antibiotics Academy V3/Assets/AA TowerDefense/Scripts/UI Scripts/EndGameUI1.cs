﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TowerDefense
{
    public class EndGameUI1 : MonoBehaviour
    {
        public void TriggerRestart()
        {
            SceneManager.LoadScene(9); // restart tower defense game
        }

        public void TriggerQuit() // win tower defense
        {
            // back to hub
            GameManager.surgeonStage = 3;
            GameManager.npclawyerStage = 1;

            if (ThemeSelectScreen.IsYJ == true)
            {
                SceneManager.LoadScene(7); // go back to hospital
            }
            else if (ThemeSelectScreen.IsClassic == true)
            {
                SceneManager.LoadScene(14); // go back to hospital
            }
            else if (ThemeSelectScreen.IsTrixy == true)
            {
                SceneManager.LoadScene(16); // go back to hospital
            }
        }

        public void TriggerQuitLost()
        {
            if (ThemeSelectScreen.IsYJ == true)
            {
                SceneManager.LoadScene(7); // back to main
            }
            else if (ThemeSelectScreen.IsClassic == true)
            {
                SceneManager.LoadScene(14); // back to main
            }
            else if (ThemeSelectScreen.IsTrixy == true)
            {
                SceneManager.LoadScene(16); // back to main
            }
            GameManager.surgeonStage = 0;
        }
    }
}
