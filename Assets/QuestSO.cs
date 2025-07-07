using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewQuestSO", menuName = "Quests/NewQuest")]
public class QuestSO : ScriptableObject{
    public enum QuestStatus {
        Inactive,
        Active,
        Complete
    }
    
    public string Desc;
    public int ID;
    public QuestStatus CurrentStatus;
    public int NumberOfQuestsNeededToMarkAsComplete = 1; //only if NumberOfQuestsNeededToMarkAsComplete quest nodes have reached this node, this node will then activate. Allows for quests of type "Find 4 things"
    public List<QuestSO> NextQuests; //quests to be activated after this one is complete
}
