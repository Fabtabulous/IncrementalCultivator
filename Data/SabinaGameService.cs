
using System.Diagnostics;
using System.Numerics;

namespace IncrementalCultivator.Data;


public class SabinaGameService
{


    public SabinaGameState gameState;

    private SabinaGameBigIntStuff bigIntStuff = new SabinaGameBigIntStuff();

    public void setup()
    {

        gameState = new SabinaGameState();


    }


    public void tick()
    {

        foreach(Iterable getsTicked in gameState.properties)
        {

            getsTicked.tick();

        }

    }
 







}

