using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager 
{

    public static GameManager Instance;

    
    internal GameObject BulletList;
    public string Bullet = "BULLET";
    
    
    static GameManager()
    {
        Instance = new GameManager();
    }

    
    // Start is called before the first frame update
    
}
