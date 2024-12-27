using UnityEngine;
using UnityEngine.SceneManagement; 

public class LevelReset : MonoBehaviour
{
    [SerializeField] private string targetObjectTag = "DeadlyObject";

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag(targetObjectTag)) 
        {
            ResetLevel();
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag(targetObjectTag)) 
        { 
            ResetLevel();
        }
    }

    private void ResetLevel() {
        Debug.Log("Nivel reiniciado por colisión con: " + targetObjectTag);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
