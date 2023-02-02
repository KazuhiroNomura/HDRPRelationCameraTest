using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Dropdown_Click : MonoBehaviour{
    private Dropdown Dropdown;
    //private TextMeshPro TextMeshPro;
    private TMP_Dropdown TextMeshPro;
    private GameObject Plane;
    // Start is called before the first frame update
    void Start(){
        this.TryGetComponent(out this.Dropdown);
        this.TryGetComponent(out this.TextMeshPro);
        this.Plane=GameObject.Find("Plane").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnValueChanged(int value){
        var オフセット=float.Parse(this.TextMeshPro.options[value].text);
        this.Plane.transform.position=new Vector3(オフセット,0f,0f);
    }
}
