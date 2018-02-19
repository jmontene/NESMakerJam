using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaletteChanger : MonoBehaviour {

	public Palette basePalette;
	public Palette swapPalette;

	Texture2D mColorSwapTex;
	Color[] mSpriteColors;
	SpriteRenderer mSpriteRenderer;

	// Use this for initialization
	void Start () {
		mSpriteRenderer = GetComponent<SpriteRenderer> ();
		InitColorSwapTex ();
		SwapColor (basePalette.color2.r, swapPalette.color2);
		SwapColor (basePalette.color3.r, swapPalette.color3);
		SwapColor (basePalette.color4.r, swapPalette.color4);
		mColorSwapTex.Apply ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void InitColorSwapTex(){
		Texture2D colorSwapTex = new Texture2D (256, 1, TextureFormat.RGBA32, false, false);
		colorSwapTex.filterMode = FilterMode.Point;

		for (int i = 0; i < colorSwapTex.width; ++i) {
			colorSwapTex.SetPixel (i, 0, new Color (0.0f, 0.0f, 0.0f, 0.0f));
		}
		colorSwapTex.Apply ();

		mSpriteRenderer.material.SetTexture ("_SwapTex", colorSwapTex);
		mSpriteColors = new Color[colorSwapTex.width];
		mColorSwapTex = colorSwapTex;
	}

	public void SwapColor(int index, Color color){
		mSpriteColors [index] = color;
		mColorSwapTex.SetPixels (mSpriteColors);
	}

}
