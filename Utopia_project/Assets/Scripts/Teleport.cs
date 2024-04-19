using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportToScene : MonoBehaviour
{
    public int sceneNumber;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Shaman"))
        {
            SceneManager.LoadScene(sceneNumber);
        }
    }
}