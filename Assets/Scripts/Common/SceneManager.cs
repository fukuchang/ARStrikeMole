using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommonScript
{
    public static class SceneManager
    {
        public static void GameOverPhase()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(SettingScene.GOAL_SCENE);
        } 
    }

}