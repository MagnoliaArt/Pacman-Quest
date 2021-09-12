using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] RectTransform pacman;

    [SerializeField] Vector2 curPos;
    private Vector2 target;
    private int step = 0;
    private Vector2 offset;
    private NetworkClient network;
    private float speed;

    private bool moving = false;

    DirectionScript _direction = new DirectionScript();
    public void StartController(int step, Vector2 offset)
    {
        pacman.gameObject.SetActive(true);
        this.step = step;
        this.offset = offset;
        network = GetComponent<NetworkClient>();
    }
    void Update()
    {
        if (!pacman.gameObject.activeInHierarchy)
        {
            return;
        }
        
        if (!moving)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                if (_direction.InputCheck(1))
                {
                    network.Send(1);
                    return;
                }
            }            
            if (Input.GetKey(KeyCode.DownArrow))
            {
                if (_direction.InputCheck(3))
                {
                    network.Send(3);
                    return;
                }
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                if (_direction.InputCheck(2))
                {
                    network.Send(2);
                    return;
                }
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                if (_direction.InputCheck(4))
                {
                    network.Send(4);
                    return;
                }
            }
            _direction.InputCheck(0);
        }
        else
        {        
            if (curPos != target)
            {
                curPos = Vector2.MoveTowards(curPos, target, speed * Time.deltaTime);
                pacman.anchoredPosition = (curPos + offset) * step;
            }
            else
            {
                moving = false;
            }
        }
    }
    public void TransfromPacman(int x, int y, float speed) 
    {
        if (curPos != new Vector2(x, y))
        {
            target = new Vector2(x, y);
            moving = true;
            this.speed = speed;
        }
        else
        {
            _direction.GuiltyDirection();
        }
    }
    
}