using System;

public class Solution {
    public int[] solution(string[] keyinput, int[] board) {
        int[] pos = new int[2] {0,0};
        foreach(string input in keyinput){
            Move(input, pos, board);
        }    
        
        return pos;
    }
    
    public void Move(string key, int[] pos, int[] board){
        int x=0, y=0;
        int xsize = (board[0]-1)/2;
        int ysize = (board[1]-1)/2;
        
        switch (key)
        {
            case "left": x--; break;
            case "right": x++; break;
            case "up": y++; break;
            case "down": y--; break;
        }
        
        int newPosX = pos[0] + x;
        int newPosY = pos[1] + y;
        pos[0] = (newPosX>0)?Math.Min(xsize, newPosX):Math.Max(-xsize, newPosX);
        pos[1] = (newPosY>0)?Math.Min(ysize, newPosY):Math.Max(-ysize, newPosY);
        
        
    }
}