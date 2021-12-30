using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeReader : MonoBehaviour
{
    public DialogueGraph graph;

    private void Start()
    {
        foreach (BaseNode b in graph.nodes) {
            if (b.GetString() == "start") {
                graph.current = b;
                break;
                //make this node the starting point
            }
        }
    }
}
