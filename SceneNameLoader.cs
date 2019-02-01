using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNameLoader : MonoBehaviour
{
    public string _scenename;
    //public Animator anim;

    //public void FadeToLevel(string _scenename)
    //{

    //    anim.SetTrigger("FadeOut");

    //}

    public void OnTriggerEnter2D(Collider2D col) {

        
        SceneManager.LoadScene(_scenename);
    
    }
        


}
