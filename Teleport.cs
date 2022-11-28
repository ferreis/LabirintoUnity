using System.IO;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    private int _randX;
    private int _randZ;
    private bool _conseguiuTeleportar = false;
    private Vector3 _locaTeleport;

    private void OnTriggerEnter(Collider other)
    {
        string arquivo = File.ReadAllText(@"E:\Workspace\Unity\Labirinto\Assets\Scripts\m1.txt");
        int tamanho = 41;
        int[,] mapa = new int[tamanho, tamanho];
        int x = 0, z;
        foreach (var row in arquivo.Split('\n'))
        {
            z = 0;
            //separei meus n�meros com v�rgula, se o de voc�s for espa�o � s� trocar no .Split()
            foreach (var col in row.Trim().Split(','))
            {
                mapa[x, z] = int.Parse(col.Trim());
                z++;
            }

            x++;
        }

        do
        {
            _randX = Random.Range(0, 40);
            _randZ = Random.Range(0, 40);

            _locaTeleport = new Vector3(_randX - 20, 0.2f, _randZ - 20);

            if (mapa[_randX, _randZ] != 1)
            {
                other.transform.position = _locaTeleport;

                _conseguiuTeleportar = true;
            }
        } while (_conseguiuTeleportar == false);
    }
}