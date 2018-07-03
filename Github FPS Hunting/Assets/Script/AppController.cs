using UnityEngine;
using System.Collections;

public class AppController : MonoBehaviour {

	// 73 // 112 // 255 // 255
    //texts multirez issue


	public static int loadedLevel = 0;
	public static int loadedVehicle = 0;
	public static bool isStop =false;
	public static bool isPickedUp =false;
	public static bool isDroped =false;
	public static bool isFind =false;
	public static bool isReadyToGo =false;


	public static bool isDialogue = false;
	public static int gamePlayed = 0;
	public static int isPurchased = 0;

	//Puzzle in garrage
	public static int puzzlePiece = 0;
	public static bool puzzleComplete = false;
	//game end
	public static bool gameEnd = false;
	public static bool isCameraCall = false;

	//Pause
	public static bool gamePause = false;

	public static float race = 0.0f;


	public static Vector3 vertexNo ;

	//How much the terrain's edge collider will be up fromthe terrain bottom
	public static float topUp = 0.4f;
	//public static float topUp = 0.0f;
	//public static float topUp = 1.0f;

	public static float colliderUp = 0.1f;

	//Main Menu
	public static int alreadyRated = 0;


//	public static int score = 0;
//	public static int highscore = 0;
	public static bool chartBoostMainMenu = false;
	public static bool isChartBoostDisplayed = false;
	public static bool IsSound = true;
    
	//Terrains Selection
	public static int terrainNumber = 0;
	public static int goToLevel = 0;


	//Cars Selection
	public static int carSelection = 0;
	public static int upgradeNumber = 0;


	//coins
	public static int coinsInThisRun = 0;
	public static int totalCoins = 1000;
//	public static int totalCoins = 10000000;
	//flips
	public static int flips = 0;
	public static int backFlips = 0;
	//Air Time
	public static bool characterGrounded = false;
	public static bool tireFrontGrounded = false;
	public static bool tireRearGrounded = false;
	public static bool carBodyGrounded = false;
	public static int airTime = 0;

	//Back limit reached
	public static bool screenEnd = false;
	//Distance in this run
	public static int distanceCovered = 0;

	//Instantiated Car
	public static GameObject instantiatedCar;
	public static Vector3 instantiatedCarPosition;
	public static int limitInstantiatedLoop ;
	public static bool carInstantiated = false;



	//Character Destroyed
	public static bool characterDestroyed = false;







	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public static float getMWidth(float pWidth )  {
		float w_  = ((pWidth * 100f) / 1280);
		return ((w_ /100.00f) *Screen.width);
	}
	
	public static float getMHeight(float pHeight )  {
		float h_  = ((pHeight * 100f) / 720);
		return ((h_ /100.0f) * Screen.height);
	}
	
	public static float getRWidth(float pWidth ) {
		float w_  = ((pWidth * 100f) / Screen.width);
		return ((w_ /100.0f) * 1280);
		
	}
	
	public static float getRHeight(float pHeight ) {
		float h_  = ((pHeight * 100f) / Screen.height);
		return ((h_ /100.0f) * 720);
	}




	public static void ButtonsOff(GameObject[] offButton , bool trueOrFalse)
	{
		for (int a=0; a<offButton.Length; a++) {
			offButton[a].SetActive(trueOrFalse);
			
		}
	}
	
	
	public static void CollidersOff(GameObject[] offCollider , bool trueOrFalse)
	{
		for (int a=0; a<offCollider.Length; a++) {
			offCollider[a].GetComponent<Collider2D>().enabled = trueOrFalse;
		}
	}




}
