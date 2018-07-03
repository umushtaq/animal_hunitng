using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using admob;
//using UnityEngine.Advertisements;
public class VehicleSelection : MonoBehaviour {
	public GameObject left;
	public GameObject right;
	public GameObject unLockBtn;
	public GameObject[] vehicles;
	public int[] prices;
	public GameObject vlockImages, unlockBtns;
	public GameObject NextBtn;
	public GameObject[] UnlockLable;
//	public GameObject lockImageV1;
//	public GameObject lockImageV2;
//	public GameObject lockImageV3;
//	public GameObject lockImageV4;
//	public GameObject lockImageV5;
	public GameObject unlockDialogue;
	public GameObject NoUnlockLevelDialogue;

	public int vIndex;
//	public int priceV1;
//	public int priceV2;
//	public int priceV3;
//	public int priceV4;
//	public int priceV5;

	// Use this for initialization
	void Start () {
		
//		Advertisement.Initialize ("1475113"); //unity ad initialization
//		Admob.Instance ().initAdmob ("ca-app-pub-5865437098022948/7769890261","ca-app-pub-5865437098022948/9246623469");  //ad mob initialization
//		Admob.Instance ().showBannerRelative 
//		(AdSize.Banner,AdPosition.TOP_RIGHT,0);//show banner 
//		Admob.Instance ().loadInterstitial (); //ad mob int loads

//		PlayerPrefs.SetInt ("v0",0);
//		PlayerPrefs.SetInt ("v1",0);
//		PlayerPrefs.SetInt ("v2",0);
//		PlayerPrefs.SetInt ("v3",0);
//		PlayerPrefs.SetInt ("v4",0);
//		PlayerPrefs.SetInt ("VehicleIndex", 0);
		//UnLockVehicles ();
		NextBtn.SetActive (true);





	}
	
	// Update is called once per frame
	void Update () {

		//txtTotalcash.text = "" + PlayerPrefs.GetInt ("TotalCash",0)+ "$";
			
		foreach(GameObject go in vehicles){

			go.SetActive (false);

		}

		vehicles [vIndex].SetActive (true);


		if (vIndex == 0) {

			UnLockVehicles ();
		} 



		if (vIndex == 0 ||  PlayerPrefs.GetInt ("v"+vIndex.ToString(),0) == 1) 
		{
			
			UnlockLable[0].SetActive (false);
			UnlockLable[1].SetActive (false);
		}

		else
		{
			//txtPrice.text = "" + prices [vIndex].ToString ()+ "$";
			if(vIndex==1)
			{
				UnlockLable[0].SetActive (true);
				UnlockLable[1].SetActive (false);
				
			}
			if (vIndex == 2) 
			{
				UnlockLable[0].SetActive (false);
				UnlockLable[1].SetActive (true);
			}
		}
	
	}


//	IEnumerator ShowAdWhenReady()
//	{
//		while (!Advertisement.isReady())
//			yield return null;
//
//		Advertisement.Show ();
//	}

	void UnLockVehicles(){


			vlockImages.SetActive (false);

			unlockBtns.SetActive (false);

		NoUnlockLevelDialogue.SetActive (false);
		unlockDialogue.SetActive (false);
	}
	public void UnlockLevelCheck()
	{
		if (vIndex == 1) {

			if (PlayerPrefs.GetInt ("UnlockLevel", 0) >= 2) {
				unlockDialogue.SetActive (true);
				NoUnlockLevelDialogue.SetActive (false);
			} else {
				NoUnlockLevelDialogue.SetActive (true);
				unlockDialogue.SetActive (false);
			}
		} 
		else 
		{
			if (PlayerPrefs.GetInt ("UnlockLevel", 0) >= 6) {
				unlockDialogue.SetActive (true);
				NoUnlockLevelDialogue.SetActive (false);
			} else {
				NoUnlockLevelDialogue.SetActive (true);
				unlockDialogue.SetActive (false);
			}
		}


	}

	public void UnlockedVehicles()
	{
		switch(vIndex){
		case 0:
			PlayerPrefs.SetInt ("v0",1);
			break;
		case 1:
			PlayerPrefs.SetInt ("v1",1);
			break;
		case 2:
			PlayerPrefs.SetInt ("v2",1);
			break;
		case 3:
			PlayerPrefs.SetInt ("v3",1);
    		break;
//		case 4:
//			PlayerPrefs.SetInt ("v4",1);
//			break;
		}
	}

	public void ButtonClick(string btnName)
	{
		switch (btnName) {
		case "left":
			vIndex--;

			if (vIndex < 0) {

				vIndex = 2;
			}
		
			if (vIndex !=0 && PlayerPrefs.GetInt ("v"+vIndex.ToString(),0) == 0) {
				// condition of if


				vlockImages.SetActive (true);
				unlockBtns.SetActive (true);
				NextBtn.SetActive (false);
			}
			else 
			{
				vlockImages.SetActive (false);
				unlockBtns.SetActive (false);
				NextBtn.SetActive (true);

			}
			PlayerPrefs.SetInt ("VehicleIndex", vIndex);
			break;
		case "right":
			vIndex++;

			if (vIndex > 2) {

				vIndex = 0;
			}
				
			if (vIndex != 0 && PlayerPrefs.GetInt ("v"+vIndex.ToString(),0) == 0) 
			{
				vlockImages.SetActive (true);
				unlockBtns.SetActive (true);
				NextBtn.SetActive (false);
			}else 
			{
				vlockImages.SetActive (false);
				unlockBtns.SetActive (false);
				NextBtn.SetActive (true);
			}
			PlayerPrefs.SetInt ("VehicleIndex", vIndex);


			break;
		case "unlock":
			UnlockLevelCheck ();
			break;
		case "yes":

			UnlockLable[0].SetActive (false);
			UnlockLable[1].SetActive (false);
			UnLockVehicles ();
			UnlockedVehicles ();
			NextBtn.SetActive(true);
			unlockDialogue.SetActive (false);


			break;
		case "no":
			NoUnlockLevelDialogue.SetActive (false);
			unlockDialogue.SetActive (false);
			break;

		}
	}
}
