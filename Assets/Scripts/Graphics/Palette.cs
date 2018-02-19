using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Palette", menuName = "NES/Graphics/Palette", order = 1)]
public class Palette : ScriptableObject {
	public Color32 color1;
	public Color32 color2;
	public Color32 color3;
	public Color32 color4;
}
