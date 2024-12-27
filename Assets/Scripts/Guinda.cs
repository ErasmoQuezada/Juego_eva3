using UnityEngine;

public class Guinda : MonoBehaviour
{
    [SerializeField] private int value;
    private bool hasTriggered;
    private GuindaManager guindaManager;

    private void Start()
    {
        guindaManager = GuindaManager.instance;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !hasTriggered)
        {
        hasTriggered = true;
        guindaManager.ChangeGuindas(value);
        Destroy(gameObject);
        }
    }
}