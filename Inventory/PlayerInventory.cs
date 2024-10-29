using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public static List<Symbol> collectedSymbols = new List<Symbol>();

    public static void AddSymbol(Symbol symbol)
    {
        collectedSymbols.Add(symbol);
        // Aqui vocês podem mudar a lógica para atualizar a interface ☻

    public static void RemoveSymbol(Symbol symbol)
    {
        collectedSymbols.Remove(symbol);
        // Aqui podem atualizar a interface do usuário, se necessário ☻
    }

    public static bool ContainsSymbol(Symbol symbol)
    {
        return collectedSymbols.Contains(symbol);
    }
}
