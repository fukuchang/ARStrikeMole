﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CommonScript
{
    public static class SceneManager
    {
        public static void GameOverPhase()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(SettingScene.GOAL_SCENE);
        }

        public static void GameStartPhase()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(SettingScene.GAME_SCENE);
        }

    }

}