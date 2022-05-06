using UnityEngine;
using System.Collections;
using System;
using GoogleMobileAds.Api;

public class ReklamInterstitial : MonoBehaviour
{
	private InterstitialAd reklamObjesi;
	
	void Start()
	{
		YeniReklamAl( null, null );
		StartCoroutine( ReklamiGoster() );

	}
	

	void Update () {
		StartCoroutine( ReklamiGoster() );
	}
	
	IEnumerator ReklamiGoster()
	{
		while( !reklamObjesi.IsLoaded() )
			yield return null;
		
		reklamObjesi.Show();
	}
	
	public void YeniReklamAl( object sender, EventArgs args )
	{
		if( reklamObjesi != null )
			reklamObjesi.Destroy();
		
		reklamObjesi = new InterstitialAd( "ca-app-pub-2794486044782728/6537050098" );
		reklamObjesi.AdClosed += YeniReklamAl;
		
		AdRequest reklamiAl = new AdRequest.Builder().Build();
		reklamObjesi.LoadAd( reklamiAl );
	}
}