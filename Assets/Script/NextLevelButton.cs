using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelButton : MonoBehaviour
{
    private void OnEnable()
    {
        //check next scene, jika ga ada buttonnya di hide
        var currentScene = SceneManager.GetActiveScene();
        //array of string
        int currentLevel = int.Parse(currentScene.name.Split("Level ")[1]);
        int nextLevel = currentLevel + 1;

        var nextScene = SceneUtility.GetBuildIndexByScenePath("Level " + nextLevel);
        if (nextScene == -1)
            this.gameObject.SetActive(false);

    }
    public void NextLevel()
    {
        var currentScene = SceneManager.GetActiveScene();
        int currentLevel = int.Parse(currentScene.name.Split("Level ")[1]);
        int nextLevel = currentLevel + 1;
        SceneManager.LoadScene("Level " + nextLevel);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    //part 2 16.07
}
