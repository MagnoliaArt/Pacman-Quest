using Google.Protobuf.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelConstruct : MonoBehaviour
{
    [SerializeField] List<Vector2> constructorArray = new List<Vector2>();
    [SerializeField] Transform StorageWalls;
    [SerializeField] GameObject WallGo;
    [SerializeField] Button StartButton;
    public int step = 25;
    public Vector2 offset;
    Controller ct;
    public void Construct(RepeatedField<int> wallMsgX, RepeatedField<int> wallMsgY)
    {
        for(int i = 0; i < wallMsgX.Count; i++)
        {
            constructorArray.Add(new Vector2(wallMsgX[i] * step, wallMsgY[i] * step));        
        }  
    }
    public void StartGame()
    {
        StartButton.gameObject.SetActive(false);
        CreateLevel();
    }
    void CreateLevel()
    {
        Debug.Log("CreateLevel");
        for (int i = 0; i < constructorArray.Count; i++) {
            Vector2 vec = constructorArray[i];
            GameObject go = Instantiate(WallGo, StorageWalls);
            go.GetComponent<RectTransform>().anchoredPosition = vec;
            go.name = "wall" + i;
        }
        offset = new Vector2(StorageWalls.GetComponent<RectTransform>().anchoredPosition.x / step,
            StorageWalls.GetComponent<RectTransform>().anchoredPosition.y / step);

        ct = GetComponent<Controller>();
        ct.StartController(step, offset);
    }
}
