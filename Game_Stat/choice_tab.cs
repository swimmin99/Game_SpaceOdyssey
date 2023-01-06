using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choice_tab : MonoBehaviour
{
    private RectTransform graphContainer;
    private Window_Graph call;
    private List<int> valueList;

    public void viewGraph(){
        Debug.Log("viewGraph called");
        call = GameObject.Find("Window_Graph").GetComponent<Window_Graph>();
        graphContainer = GameObject.Find("Window_Graph").transform.Find("graphContainer").GetComponent<RectTransform>();
        
        call.initShowGraph();
        
        GameObject clickObject = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;

        if (clickObject.name == "Button_pop")
            valueList =  new List<int>() {5,98, 56, 45, 13, 8, 7};
        else if (clickObject.name == "Button_prov")
            valueList =  new List<int>() {1,2,3,4,5}; 
        else if (clickObject.name == "Button_resource")
            valueList =  new List<int>() {100, 76, 32, 94, 81};
        call.ShowGraph(valueList);
    }
}