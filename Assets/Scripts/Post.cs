using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.Text;

public class NewBehaviourScript : MonoBehaviour {
    
    private string Nom;
    private string Email;
    private string Comment;
    private string QA;

    public GameObject Afficher;
    public GUIText  Qaaf = null;

    void awaike()
    {
        
    }
    // Use this for initialization
    void Start()
    {

        Qaaf.text = "Hellow";

        Afficher = GameObject.Find("QAAfficher");

        Qaaf = Afficher.GetComponent<GUIText>();

        Qaaf.text = "Text 01";

        Afficher.GetComponent<GUIText>().text = Qaaf.text;

    }

    // Update is called once per frame
    void Update () {

        

    }
}
