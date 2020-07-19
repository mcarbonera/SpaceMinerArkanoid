using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    [SerializeField] public GameObject block;

    public int width = 5;
    public int height = 3;
    //public float offsetX = 
    //195 x 150
    //200
    //195/200

    // Start is called before the first frame update
    void Start()
    {
        generateLevel();
    }

    public void generateLevel()
    {
        for (int y = 1; y < height; y++)
        {
            for (int x = 2; x < width; x++)
            {
                var novoBloco = Instantiate(block, new Vector3(195 * x / 200, 0.75f * (y + 6), -2), Quaternion.identity);

                var numCor = Random.Range(0, 5);
                switch (numCor)
                {
                    case 0:
                        novoBloco.GetComponent<SpriteRenderer>().color = Color.red;
                        break;
                    case 1:
                        novoBloco.GetComponent<SpriteRenderer>().color = Color.green;
                        break;
                    case 2:
                        novoBloco.GetComponent<SpriteRenderer>().color = Color.blue;
                        break;
                    case 3:
                        novoBloco.GetComponent<SpriteRenderer>().color = Color.yellow;
                        break;
                    case 4:
                        novoBloco.GetComponent<SpriteRenderer>().color = Color.magenta;
                        break;
                }
            }
        }
    }
    
    /*
    void Update()
    {
        
    }
    */
}
