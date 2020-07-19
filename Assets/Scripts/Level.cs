using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int breakableBlocks;
    [SerializeField] Blocks blocks;
    [SerializeField] GameStatus gameStatus;
    [SerializeField] Bolinha bolinha;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CountBreakableBlocks()
    {
        breakableBlocks++;
    }

    public void SubtractBreakableBlocks()
    {
        breakableBlocks--;
        if(breakableBlocks <= 0)
        {
            blocks.generateLevel();
            bolinha.reinicializarBolinha();
            gameStatus.addLevelNumber();
            if(gameStatus.getLifes() < gameStatus.getMaxLifes())
            {
                gameStatus.addLifes();
            }
        }
    }
}
