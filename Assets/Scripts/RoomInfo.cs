using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomInfo : MonoBehaviour
{
	public int myFloor;
	public int myNumber;
	public GameObject[] Unit;

	private GameObject MainCamera;
	private float floorHeight;
	private float roomWidth;
	private bool isUnitCreated;

	private void Awake()
	{
		floorHeight = AptCreator.floorHeight;
		roomWidth = AptCreator.roomWidth;

		myFloor = (int)(transform.position.y / floorHeight) + 1;
		myNumber = (int)(transform.position.x / roomWidth) + 1;
	}

	private void Start()
	{
		MainCamera = GameObject.Find("Main Camera");
		isUnitCreated = false;

		if(isUnitCreated == false)
		{
			CreateUnit_Init();
			TurnManager.GameState = 1;
		}
	}

	private void CreateUnit_Init()
	{
		for(int num = 0; num < Unit.Length; num++)
		{
			if(Unit[num] != null)
			{
				GameObject unit = Instantiate(Unit[num], transform);
				unit.transform.position = unit.transform.position - new Vector3(num * 4f - 6f,0,0);
			}
		}

		isUnitCreated = true;
	}

	private void OnMouseDown()
	{
		MainCamera.transform.position = new Vector3(transform.position.x, transform.position.y, -10f);
		MainCamera.GetComponent<Camera>().orthographicSize = 6f;
	}
}