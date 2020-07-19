using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{
    [SerializeField] GameStatus gameStatus;
    [SerializeField] Bolinha bolinha;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameStatus.getLifes() > 1) {
            gameStatus.subLifes();
            bolinha.reinicializarBolinha();
        } else {
            SceneManager.LoadScene("GameOver");
        }
    }
}
