package com.test.pacman;

import java.io.BufferedReader;
import java.io.FileReader;
import java.util.ArrayList;

public class LevelConstruct {

    public ArrayList<Vector2> GetLevel(String path){
        ArrayList<Vector2> result = new ArrayList<Vector2>();
        try(BufferedReader br = new BufferedReader(new FileReader(path))) {
            try{
                String s;
                while((s = br.readLine()) != null){
                    if (!s.isEmpty() && !s.startsWith("//") && !s.equals("walls:")){
                        s = s.replaceAll(" ", "");
                        Vector2 vec = ReadingVec(s);
                        if(vec != null) {
                            result.add(vec);
                        }
                    }
                }
            }
            catch(Exception e){
                e.printStackTrace();
            }
        }
        catch(Exception e){
            e.printStackTrace();
        }

        return result;
    }
    public Vector2 ReadingVec(String s){
        if (s != null && !s.isEmpty()) {
            String[] s_array = s.split(";");
            if (s_array.length == 2) {
                return new Vector2(Integer.parseInt(s_array[0]), Integer.parseInt(s_array[1]));
            } else {
                return null;
            }
        }
        else{
            return null;
        }
    }
}
