using UnityEngine.SceneManagement;
using UnityEngine;

public class gotonextscene : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(2);
    }

}