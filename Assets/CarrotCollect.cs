using UnityEngine;
using UnityEngine.SceneManagement;

public class CarrotCollect : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Avatar"))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
