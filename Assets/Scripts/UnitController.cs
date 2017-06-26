using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitController : MonoBehaviour
{
	public enum UnitType
	{
		Zombie, Soldier, Police, Doctor
	}

	public UnitType myType;
	public int HP; //체력
	public int AP; //공격력
	public int RP; //회복력

	private bool isInMovingState = false;
	private GameObject GM;
	private int floor;
	private int rif;

	private void Start()
	{
		GM = GameObject.Find("GameManager");
		floor = GM.GetComponent<AptCreator>().floor;
		rif = GM.GetComponent<AptCreator>().roomsInFloor;
	}

	private void OnMouseDown()
	{
		isInMovingState = true;
		Debug.Log("My floor : " + transform.parent.gameObject.GetComponent<RoomInfo>().myFloor + ", My room number : " + transform.parent.gameObject.GetComponent<RoomInfo>().myNumber);
		
	}
}