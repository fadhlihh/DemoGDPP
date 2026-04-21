using System;
using System.Collections.Generic;
using UnityEngine;

public class ExampleObjectStruct : MonoBehaviour
{
    [SerializeField]
    public int number = 0;
    [SerializeField]
    public List<Player> exampleList;
    [SerializeField]
    public Player[] exampleArray;
    [SerializeField]
    public Player examplePlayer;

    private void Start()
    {
        string[] nameArray = new string[3];
        nameArray[0] = "Fadhli";
        nameArray[1] = "Budi";
        nameArray[2] = "Pipit";
        nameArray = new string[10];
        // Player[] playerArray = new Player[3];

        // Queue<string> exampleQueue = new Queue<string>();
        // exampleQueue.Enqueue("Fadhli");
        // exampleQueue.Dequeue();

        // for (int i = 0; i < nameArray.Length; i++)
        // {
        //     Debug.Log(nameArray[i]);
        // }


        // // foreach (string name in nameArray)
        // // {
        // //     Debug.Log(name);
        // // }

        // // Debug.Log(nameArray[0]);


        // List<string> nameList = new List<string>();
        // nameList.Add("Fadhli");
        // nameList.Add("Budi");
        // nameList.Add("Pipit");
        // Debug.Log(nameList[0]);

        // for (int i = 0; i < nameList.Count; i++)
        // {
        //     Debug.Log(nameList[i]);
        // }

        // nameList.Remove("Budi");
        // nameList.RemoveAt(0);
        // nameList.Clear();
        // bool isExsist = nameList.Exists((element) => element == "Pipit");
        // string name = nameList.Find((element) => element == "Pipit");

        // List<Player> playerList = new List<Player>();
        // Player player = new Player();
        // player.Name = "Fadhli";

        // playerList.Add(player);
        // Debug.Log(playerList[0].Name);
        // bool isPlayerExsist = playerList.Exists((element) => element.Name == "Fadhli");
    }
}
