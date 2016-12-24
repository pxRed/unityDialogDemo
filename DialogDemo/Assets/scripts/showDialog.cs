using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class showDialog : MonoBehaviour {
    public GameObject panel;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    /// <summary>
    /// 显示dialog
    /// </summary>
    public void sDialog() 
    {     
        panel.SetActive(true);
    }
    /// <summary>
    /// 关闭dialog
    /// </summary>
    public void cDialog()
    {
        panel.SetActive(false);
    }
}
