using UnityEngine;

[CreateAssetMenu(fileName = "MiNuevoTipo", menuName = "PiedraPapelTijera/Crear Nuevo Tipo", order = 0)]
public class ElementType : ScriptableObject
{
    public string elementName;

    public ElementType[] strongAgainst;

    public bool IsStrongAgainst(ElementType other)
    {
        for (int i = 0; i < strongAgainst.Length; i++)
        {
            if (strongAgainst[i] == other)
            {
                return true;
            }
        }

        return false;
    }
}