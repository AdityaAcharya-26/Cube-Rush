using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gamehasEnded = false;
    public GameObject completeLevelUI;
    

   
    public void CompleteLevel ()
    {
        completeLevelUI.SetActive(true);
    }
    public void EndGame()
    {
        if(gamehasEnded == false)
        {
            gamehasEnded = true;
            print("GAME OVER");
            Invoke("Restart", 1.5f);
        }

        
    }
    void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
   
}
