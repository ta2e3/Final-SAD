using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GotoIntro(){
        Application.LoadLevel(0);
    }
    public void GotoLVL2(){
        Application.LoadLevel(1);
    }
}
