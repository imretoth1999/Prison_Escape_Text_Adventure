using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextControl : MonoBehaviour {

	public Text text;
	private enum States {cell, mirror, sheets_0, lock_0, false_escape, tiger_dead,whorship};
	private States myState;
	// Use this for initialization
	void Start () {
		myState = States.cell;
		}
	// Update is called once per frame
	void Update () {
		if (myState == States.cell){
			cell();
		}else if (myState == States.sheets_0){
			sheet();
		}else if (myState == States.lock_0){
			lock_0();
		}else if (myState == States.mirror){
			mirror();
		}else if (myState == States.false_escape){
			false_escape();
		}else if (myState == States.tiger_dead){
			tiger_dead();
		}
		else if (myState == States.whorship){
			whorship();
		}
	}
	void cell (){
			text.text = "You are in a prison cell, you don't remember how you got there, "+
				"all that you know is that you must not be here. You see that next to you are dangerous animals"+
					" in small cages. You are now scared and you seek to escape.Around you are sheets"+
					", a mirror and a lock\n\n"+
					"Press S to view Sheets, M to view Mirror and L to view Lock";
			if (Input.GetKeyDown(KeyCode.S)){
				myState = States.sheets_0;
				}else if (Input.GetKeyDown(KeyCode.M)){
					myState = States.mirror;
				}else if (Input.GetKeyDown(KeyCode.L)){
					myState = States.lock_0;
				}	
		}
	void sheet (){
			text.text = "These sheets are way to clean for a prison, maybe they don't want me here to "+
			"punish me.It's way too strange, yesterday I was in the southeastern part of Mexico and now I am here "+
			"\n\nPress R to return to roaming your cell";
			if (Input.GetKeyDown(KeyCode.R)){
				myState = States.cell;
			}
		}
	void mirror (){
		text.text = "You see that you are full with painting on your face. They seem to be way too "+
			"ceremonial. You are actually freaking out and you cause disturbance but only the animals hear you "+
			"\n\nPress R to return to roaming your cell";
		if (Input.GetKeyDown(KeyCode.R)){
			myState = States.cell;
		}
	}
	void lock_0(){
		text.text = "Well it seems that the door can be opened quickly, that was way more easier than I expected"+
			".I don't know if I should leave, maybe I did not search everything to give me a clue for where I am."+
			"\n\nPress R to return to roaming your cell or press L to go out";
		if (Input.GetKeyDown(KeyCode.R)){
			myState = States.cell;
		}else if (Input.GetKeyDown(KeyCode.L)){
			myState = States.false_escape;
		}
	}
	void false_escape(){
		text.text = "You go down the hall and some big guy dressed weird sees you and captures you.Well it could have gone better"+
			".Now he does not take you to the cell but to an arena.This is freaking you out"+
				"\n\nPress Enter to continue the story";
		if (Input.GetKeyDown(KeyCode.Return)){
			myState = States.tiger_dead;
			}
	}
	void tiger_dead(){
		text.text = "This is it. They got me to the arena.I am as good as dead. Now they got a tiger out"+
		". Now it comes to you but the people kill it really fast and bring me his blood. They seem to worship me"+
		"Maybe is because of my body? It is not like theirs at all. Mine is long and I don't have arms. It was weird to"+
		" open the door with my head. Is it because of my wings?"+
				"\n\nPress Enter to continue the story";
		if (Input.GetKeyDown(KeyCode.Return)){
			myState = States.whorship;
			}	
	}
	void whorship(){
		text.text = "They keep calling me Kukulkan. Are they worshiping me as their god? It seems so.Maybe I could " +
					"call the other to come here. Maybe we can make some good use of this humans.I knew it was worth it to visit Earth"+
						"\n\n This is the end!";
		}
}