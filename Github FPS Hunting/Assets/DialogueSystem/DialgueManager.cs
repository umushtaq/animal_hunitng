using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialgueManager : MonoBehaviour {

	public Dialogue dialogue;
	public Animator animator;
	public Text nameText;
	public Text dialogueText;
	private Queue<string> sentences; 
	private int levelvalue;
	private float waitTime = 0.07f;
	void Start () {
	//	PlayerPrefs.DeleteAll ();
		levelvalue = PlayerPrefs.GetInt ("Level");
		sentences = new Queue<string> ();
		Invoke ("StartDialogueSystem",2f);
	}

	void StartDialogueSystem()
	{
		
		if (!PlayerPrefs.HasKey("FirstTime")) 
		{
			Timer.timer.SetActive (false);
			GameManager.Instance.CF2Panel.SetActive(false);
			bl_HudManager.instance.Huds[levelvalue].Hide=true;
			StartDialogue (dialogue);
			Debug.Log ("FirstAttempt");
			PlayerPrefs.SetInt ("FirstTime",1);
		}
	}
	public void StartDialogue(Dialogue dialogue )
	{
		animator.SetBool ("IsOpen",true);
		Debug.Log ("Starting Conversation "+ dialogue.name);
		nameText.text = dialogue.name;
		sentences.Clear();

		foreach(string sentence in dialogue.sentences)
		{
			sentences.Enqueue (sentence);
		}

		DisplayNextSentence ();
	}

	public void DisplayNextSentence()
	{
		if (sentences.Count == 0) 
		{
			EndDialogue ();
			return;
			Debug.Log ("EndDialogue");
		}

		string sentence= sentences.Dequeue ();
		StopAllCoroutines ();
		StartCoroutine (TypeSentence (sentence));
	//	dialogueText.text = sentence;
	}

	IEnumerator TypeSentence(string sentence)
	{
		dialogueText.text = "";
		foreach (char letter in sentence.ToCharArray()) 
		{
			dialogueText.text += letter;
			yield return new WaitForSeconds(waitTime);
		}
	}
	void EndDialogue ()
	{
		Timer.timer.SetActive (true);
		instantiateLion.instance.FleshAwake ();
		animator.SetBool ("IsOpen",false);
		bl_HudManager.instance.Huds[levelvalue].Hide=false;
		GameManager.Instance.CF2Panel.SetActive(true);
	}
}
