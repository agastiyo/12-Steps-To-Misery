using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

public class DialogueNode : BaseNode {
	[Input] public int entry;
	[Output] public int exit;
	public string characterName;
	public string characterDialogue;
	public Sprite characterImage;
	public Sprite background;

	public override string GetString() {
		return $"{characterName} says {characterDialogue}";
	}
}