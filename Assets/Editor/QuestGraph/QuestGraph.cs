using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;


public class QuestGraph : EditorWindow{

    private QuestGraphView _graphView;

    [MenuItem("Graph/Quest Graph")]
    public static void OpenQuestGraphWindow(){
        var window = GetWindow<QuestGraph>();
        window.titleContent = new GUIContent("Quest Graph");
    }

    private void OnEnable(){
        _graphView = new QuestGraphView(this){
            name = "Quest Graph",
        };

        _graphView.StretchToParentSize();
        rootVisualElement.Add(_graphView);
    }

    private void OnDisable(){
        rootVisualElement.Remove(_graphView);
    }
}
