using UnityEngine.SceneManagement;
using UnityEngine;

public class jumptocredits : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(4);
    }

}