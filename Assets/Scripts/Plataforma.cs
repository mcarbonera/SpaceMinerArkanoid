using UnityEngine;

public class Plataforma : MonoBehaviour
{
    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float min = 1.2f;
    [SerializeField] float max = 14.8f;

    // cached reference
    GameStatus meuGameStatus;
    Bolinha minhaBolinha;

    // Start is called before the first frame update
    void Start() {
        meuGameStatus = FindObjectOfType<GameStatus>();
        minhaBolinha = FindObjectOfType<Bolinha>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 plataformaPos = new Vector3(transform.position.x, transform.position.y, -2);
        plataformaPos.x = Mathf.Clamp(GetXPos(), min, max);
        transform.position = plataformaPos;
    }

    private float GetXPos()
    {
        if(meuGameStatus.IsAutoPlayEnabled()) {
            return minhaBolinha.transform.position.x;
        } else {
            return Input.mousePosition.x / Screen.width * screenWidthInUnits;
        }
    }
}
