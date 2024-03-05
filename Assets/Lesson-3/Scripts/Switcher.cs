using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Switcher : MonoBehaviour
{
    public Pokedex PokeContainer;
    public TMP_Text PokeName;
    public Image PokeImg;
    private int actualIndex = -1;

    public PokeInfo GetNextPoke()
    {
        actualIndex = (actualIndex + 1) % PokeContainer.Pokemon.Count;

        return PokeContainer.Pokemon[actualIndex];
    }

    public void SetPokeUI()
    {
        PokeInfo info = GetNextPoke();
        PokeName.text = info.Name;
        PokeImg.sprite = info.PkmImg;
    }
}
