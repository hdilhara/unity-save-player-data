using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{

  
    public static void SaveGame(GamePlay game)
    {
        BinaryFormatter formatter = new BinaryFormatter();

        // unity provides path that system independent so
        // we can use this system independently
        string path = Application.persistentDataPath + "/player.fun";

        FileStream stream = new FileStream(path, FileMode.Create);

        GameData data = new GameData(game);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static GameData LoadGame()
    {
        string path = Application.persistentDataPath + "/player.fun";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            GameData gameData = formatter.Deserialize(stream) as GameData;
            stream.Close();

            return gameData;
        }
        else
        {
            Debug.LogError("File is not found in path "+ path);
            return null;
        }
    }

}
