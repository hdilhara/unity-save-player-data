using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public int level;
    public int helth;
    public float[] position;

    public GameData(GamePlay gamePlay)
    {
        level = gamePlay.level;
        helth = gamePlay.helth;

        position = new float[3];
        position[0] = gamePlay.transform.position.x;
        position[1] = gamePlay.transform.position.y;
        position[2] = gamePlay.transform.position.z;

    }

}
