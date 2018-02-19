using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PaletteSet", menuName = "NES/Graphics/PaletteSet", order = 2)]
public class PaletteSet : ScriptableObject {
	public Palette[] palettes;
}
