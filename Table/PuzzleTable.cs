using System.Collections.Generic;
using UnityEngine;

public class PuzzleTable : MonoBehaviour
{
    public List<Transform> slots; // Lista de slots
    public AudioClip successSound; // Som de sucesso ☻
    public AudioClip errorSound; // Som de erro ☺

    public void PlaceSymbol(Symbol symbol, Transform slot)
    {
        if (PlayerInventory.ContainsSymbol(symbol) && IsCorrectSlot(symbol, slot))
        {
            // Ação de sucesso
            AudioSource.PlayClipAtPoint(successSound, transform.position);
            // Aqui é a lógica para minimizar a tela ou desbloquear algo ☻
            PlayerInventory.RemoveSymbol(symbol); // Remove do inventário
        }
        else
        {
            AudioSource.PlayClipAtPoint(errorSound, transform.position);
            ResetSymbols(); // Aqui é para reposicionar os símbolos nos seus devidos lugares ☻
        }
    }

    private bool IsCorrectSlot(Symbol symbol, Transform slot)
    {
        // Gente, verifica se o símbolo corresponde ao slot e modifique conforme a lógica do mapa e objetos(apaga esse comentario depois) ☻
        return true; 
    }

    private void ResetSymbols()
    {
        // Aqui vai a lógica para reposicionar os símbolos ☻
    }
}
