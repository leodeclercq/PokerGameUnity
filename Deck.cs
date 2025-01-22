using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    // Importer la classe carte en liste
    List<Carte> deck = new List<Carte>();
    //Importer valeur et couleur
    List<int> valeurs = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};
    List<string> couleurs = new List<string> {"Coeur", "Carreau", "Pique", "Trefle"};
    void Awake()
    {
        decks();
    }
    public void decks()
    {
        //double boucle pour itérer 52 fois
        foreach ( int valeur in valeurs)
        {
            foreach (string couleur in couleurs)
            {
                deck.Add(new Carte(valeur, couleur));
                Debug.Log($"Carte : {valeur} de {couleur}");
            }
        }
    }
}
