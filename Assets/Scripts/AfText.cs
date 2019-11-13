using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AfText : MonoBehaviour
{
     //new
    //public GameObject Afficher;
    public Text UserName = null;
    public Text Time = null;
    public Text QAAficher = null;
    public Text UserShortN = null;
    public GameObject Post = null;
    //public Camera cam = null;


    // Use this for initialization
    void Start()
    {
        UserName.text = "tippaRayman";
        Time.text = "14:36";
        QAAficher.text = "Posting . . . . . ! !!";
        UserShortN.text = "TR";

        Vector2 localpoint = new Vector2(232f, 270);
        Post.gameObject.transform.position = localpoint * 1.37f;

        StartCoroutine(Wait(3.0f));


    }

    //public void changText(string newText)
    //{
    //    float temp = float.Parse(newText);
    //}

    // Update is called once per frame
    void Update()
    {
        

    }

    IEnumerator Wait(float delay)
    {
        yield return new WaitForSeconds(delay);
        Post.gameObject.SetActive(true);
    }

    public void ClickB()
    {
        QAAficher.text = "";
        Debug.Log("oy");
    }
}
