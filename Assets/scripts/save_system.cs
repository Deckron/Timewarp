
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class save_system
{
    public static void savePlayer(player_manager player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.txt";
        FileStream stream = new FileStream(path, FileMode.Create);
        player_data data = new player_data(player);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static player_data LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.txt";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            player_data data =formatter.Deserialize(stream) as player_data;

            stream.Close();

            return data;
            
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
