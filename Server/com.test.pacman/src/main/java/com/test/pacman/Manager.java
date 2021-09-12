package com.test.pacman;

import java.util.ArrayList;

public class Manager {

    private ArrayList<Vector2> arr = new ArrayList<>();
    private Vector2[] wallArray;
    public Vector2 curPosition = new Vector2(1,1);
    public float speed = 6;

    public void CreateLevel(){
        LevelConstruct construct = new LevelConstruct();
        String path = "pacman_field.txt";
        arr = construct.GetLevel(path);
    }
    public Vector2 MapInfo(){
        return arr.get(0);
    }
    public Vector2[] LevelInfo(){
        wallArray = new Vector2[arr.size() - 1];
        for(int i = 1; i < arr.size(); i++){
            wallArray[i - 1] = arr.get(i);
        }
        return wallArray;
    }
    public Vector2 TransformPosition(int input){
        int posX = 0, posY = 0;
        switch (input){
            case 1:{
                posY = 1;
                break;
            }
            case 2:{
                posX = 1;
                break;
            }
            case 3:{
                posY = -1;
                break;
            }
            case 4:{
                posX = -1;
                break;
            }
        }
        for (Vector2 vector2 : wallArray) {
            if (vector2.x == curPosition.x + posX && vector2.y == curPosition.y + posY) {
                return curPosition;
            }
        }
        curPosition = new Vector2(curPosition.x + posX, curPosition.y + posY);
        return curPosition;
    }
}