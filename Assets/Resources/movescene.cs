using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class movescene : MonoBehaviour {

        public void ChangeMenuScene(string sceneName)
        {
            Application.LoadLevel (sceneName);
        }

        public void QuitGame()
        {
            Debug.Log("QUIT");
            Application.Quit();
        }
}

