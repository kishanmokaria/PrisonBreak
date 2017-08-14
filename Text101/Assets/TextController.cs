using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {cell, mirror, sheets_0, lock_0, cell_mirror, sheet_1, lock_1, corridor_0, stairs_0, floor, closet_door,
						stairs_1, corridor_1, in_closet, stairs_2, corridor_2, corridor_3, courtyard };
	private States myStates;
	void Start () {
	myStates = States.cell;
	}
	
	void Update ()
	{
		print (myStates);
		if (myStates == States.cell) {
			cell ();
		} else if (myStates == States.sheets_0) {
			sheets_0 ();
		} else if (myStates == States.mirror) {
			mirror ();
		} else if (myStates == States.lock_0) {
			lock_0 ();
		} else if (myStates == States.cell_mirror) {
			cell_mirror ();
		} else if (myStates == States.sheet_1) {
			sheets_1 ();
		} else if (myStates == States.lock_1) {
			lock_1 ();
		} else if (myStates == States.corridor_0) {
			corridor_0 ();
		} else if (myStates == States.stairs_0) {
			stairs_0 ();
		} else if (myStates == States.closet_door) {
			closet_door ();
		} else if (myStates == States.floor) {
			floor ();
		} else if (myStates == States.corridor_1) {
			corridor_1 ();
		} else if (myStates == States.stairs_1) {
			stairs_1 ();
		} else if (myStates == States.in_closet) {
			in_closet ();
		} else if (myStates == States.corridor_2) {
			corridor_2 ();
		} else if (myStates == States.stairs_2) {
			stairs_2 ();
		} else if (myStates == States.corridor_3) {
			corridor_3 ();
		} else if (myStates == States.courtyard) {
			courtyard ();
		}
	}
	void cell ()
	{
		text.text = "You are in a prison cell, and you want to escape. There are " +
		"some dirty sheets on the bed, a mirror on the wall, and the door " +
		"is locked from the outside.\n\n" +
		"Press S to view Sheets, M to view Mirror and L to view Lock";
		if (Input.GetKey (KeyCode.S)) {
			myStates = States.sheets_0;
		}
		if (Input.GetKey (KeyCode.M)) {
			myStates = States.mirror;
		}
		if (Input.GetKey (KeyCode.L)) {
			myStates = States.lock_0;
		}
	}
	void sheets_0 ()
	{
		text.text = 	"You can't believe you sleep in these things. Surely it's " +
						"time somebody changed them. The pleasures of a prison life " +
						" I guess! \n\n" + 
						"Press R to Return to roaming your cell";
		if(Input.GetKey (KeyCode.R)){
		myStates = States.cell;
		}
	}
	void mirror ()
	{
		text.text = "This mirror looks very dirty" +
			"I wonder who used to stay in this cell before me, I could use the mirror to see the dirty fingerprints on the keypad\n\n" +
		"Press R to Return to roaming your cell, T to take the mirror";

		if (Input.GetKey (KeyCode.R)) {
			myStates = States.cell;
		} else if (Input.GetKey (KeyCode.T)) {

		myStates = States.cell_mirror;
			}
	}
	void lock_0 ()
	{
		text.text = "The door is locked from the outside, I need to unlock it somehow " +
		"to break out from this prison\n\n" +
		"Press R to return to Roaming your cell";
		if (Input.GetKey (KeyCode.R)) {
			myStates = States.cell;
		}
	}
	void cell_mirror ()
	{
		text.text = "I can use this mirror to check the dirt prints on the lock\n\n" + "Press S to look at the sheets, L to look at the lock";
		if (Input.GetKey (KeyCode.S)) {
			myStates = States.sheet_1;
		} else if (Input.GetKey (KeyCode.L)) {
			myStates = States.lock_1;
		}
	}
	void sheets_1 ()
	{
		text.text = "I can't sleep in this sheet anymore\n\n"
		+ "Press R to return to the Roaming the cell with mirror";
		if (Input.GetKey (KeyCode.R)) {
			myStates = States.cell_mirror;
		}
	}
	void lock_1 ()
	{
		text.text = "I can use this mirror to see from the slit and i can possibly open the door\n\n" +
		"Press O to Open the Door using the reflection or Press R to Return to the Cell";
		if (Input.GetKey (KeyCode.O)) {
			myStates = States.corridor_0;
		}
		 else if (Input.GetKey (KeyCode.R)) {
		 	myStates = States.cell_mirror;
		}
	}
	void corridor_0 ()
	{
		text.text = "You get into the corridor and find a few things to interact with\n\n" +
		"Press S to take the Stairs, F to inspect Floor, C to Open Closet";
		if (Input.GetKey (KeyCode.S)) {
			myStates = States.stairs_0;
		} else if (Input.GetKey (KeyCode.F)) {
			myStates = States.floor;
		} else if (Input.GetKey (KeyCode.C)) {
			myStates = States.closet_door;
		}
	}
	void stairs_0 ()
	{
		text.text = "You go up the stairs and see that there are guards on this floor and they will recognise you in this uniform very"+
					" easily\n\n Press R to Return to the corridor";
		if(Input.GetKey (KeyCode.R))
		myStates = States.corridor_0;
	}
	void closet_door ()
	{
		text.text = "The Closet Door is locked but you can easily see the guard uniforms through the glass\n\n"+
					"Press R to Return to the corridor";
		if(Input.GetKey (KeyCode.R))
		myStates = States.corridor_0;
	}
	void floor ()
	{
		text.text = "There is a Hairclip on the floor \n\n Press H to take the Hairclip or Press R to Return to the corridor";
		if(Input.GetKey (KeyCode.R))
		myStates = States.corridor_0;
		else if(Input.GetKey (KeyCode.H))
		myStates = States.corridor_1;
	}
	void corridor_1 ()
	{
		text.text = "Now you have the Hairclip, it's up to you what you wanna do with it\n\n"
					+"Press S to go up the stairs, P to Open the Closet with the Hairclip";
		if(Input.GetKey (KeyCode.S))
		myStates = States.stairs_1;
		else if(Input.GetKey (KeyCode.P))
		myStates = States.in_closet;
	}
	void stairs_1 ()
	{
		text.text = "You go up the stairs and see that there are guards on this floor and they will recognise you in this uniform very"+
					" easily\n\n Press R to Return to the corridor";
		if(Input.GetKey (KeyCode.R))
		myStates = States.corridor_1;
	}
	void in_closet ()
	{
		text.text = "There is Guard Uniform in the closet\n\n"+
					"Press R to return to the Corridor Or D to Dress as a Guard";
		if(Input.GetKey (KeyCode.R))
		myStates = States.corridor_2;
		else if(Input.GetKey (KeyCode.D))
		myStates = States.corridor_3;
	}
	void corridor_2 ()
	{
		text.text = "The corridor is still empty and there is still stairs to the upper floor\n\n"+
					"Press S to use the Stairs or Press R to Return to the corridor ";
		if(Input.GetKey (KeyCode.R))
		myStates = States.corridor_2;
		else if(Input.GetKey (KeyCode.S))
		myStates = States.stairs_2;
	}
	void stairs_2 ()
	{
	text.text = "Don't you think that without a Guard's Uniform you can't fool other guards\n\n"+
				"Press R to Return to the corridor";
		if(Input.GetKey (KeyCode.R))
		myStates = States.corridor_2;
	}
	void corridor_3 ()
	{
		text.text = "The Uniform fits perfectly\n\n"+
					"Press U to Undress or S to take the Stairs";
		if(Input.GetKey (KeyCode.U))
		myStates = States.in_closet;
		else if(Input.GetKey (KeyCode.S))
		myStates = States.courtyard;
	}
	void courtyard ()
	{
		text.text = "You have fooled all the guards and now you are free\n\nYOU WON";
	}
}
