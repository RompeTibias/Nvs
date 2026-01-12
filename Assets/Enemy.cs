using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public float speed = 2f;
    public EnemySpawner spawner;

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
            Die();
        }

        if (collision.CompareTag("final"))
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    void Die()
    {
        if (spawner != null)
        {
            spawner.SpawnEnemy(); 
        }

        Destroy(gameObject);
    }

    void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
