using UnityEngine;
using System.IO;

//necess�rio para leitura do arquivo


public class Mapa : MonoBehaviour
{
    //--------------------------
    public GameObject parede;

    public GameObject teleport;

    public GameObject fakeParede;

    public GameObject playerHero;

    public GameObject playerSlime;
    public GameObject machado;
    public GameObject trave;

    //--------------------------
    // Start is called before the first frame update
    void Start()
    {
        CriaMapa();
    }

    void CriaMapa()
    {
        // -- Comando para ler do arquivo e salvar na matriz de inteiros --
        //meu arquivo � um csv, mas funciona com qualquer extens�o de arquivo
        string arquivo = File.ReadAllText(@"E:\Workspace\Unity\Labirinto\Assets\Scripts\m1.txt");
        int tamanho = 50;
        int[,] mapa = new int[tamanho, tamanho];
        int i = 0, j;

        foreach (var row in arquivo.Split('\n'))
        {
            j = 0;
            //separei meus n�meros com v�rgula, se o de voc�s for espa�o � s� trocar no .Split()
            foreach (var col in row.Trim().Split(','))
            {
                mapa[i, j] = int.Parse(col.Trim());
                j++;
            }

            i++;
        }
        // ----------------------------------------------------------------

        // -- percorre a matriz e insere o objeto quando l� 1 na matriz ---
        for (i = 0; i < tamanho; i++)
        {
            for (j = 0; j < tamanho; j++)
            {
                switch (mapa[i, j])
                {
                    case 1:
                    {
                        //-20 � o ajuste para come�ar na parte superior esquerda
                        //posiciona em 2 de altura, pois o objeto altura 4 tem tamanho 2 para cima e 2 para baixo
                        Vector3 p = new Vector3(i - 20f, 0.0f, j - 20f);
                        Instantiate(parede, p, Quaternion.identity);
                        break;
                    }
                    case 2:
                    {
                        //-20 � o ajuste para come�ar na parte superior esquerda
                        //posiciona em 2 de altura, pois o objeto altura 4 tem tamanho 2 para cima e 2 para baixo
                        Vector3 p = new Vector3(i - 20f, 0.0f, j - 20f);
                        Instantiate(fakeParede, p, Quaternion.identity);
                        break;
                    }
                    case 3:
                    {
                        //-20 � o ajuste para come�ar na parte superior esquerda
                        //posiciona em 2 de altura, pois o objeto altura 4 tem tamanho 2 para cima e 2 para baixo
                        Vector3 p = new Vector3(i - 20f, 0.2f, j - 20f);
                        Instantiate(teleport, p, Quaternion.identity);
                        break;
                    }
                    case 4:
                    {
                        //-20 � o ajuste para come�ar na parte superior esquerda
                        //posiciona em 2 de altura, pois o objeto altura 4 tem tamanho 2 para cima e 2 para baixo
                        Vector3 p = new Vector3(i - 20f, 0.0f, j - 20f);
                        Instantiate(playerHero, p, Quaternion.identity);
                        break;
                    }
                    case 5:
                    {
                        //-20 � o ajuste para come�ar na parte superior esquerda
                        //posiciona em 2 de altura, pois o objeto altura 4 tem tamanho 2 para cima e 2 para baixo
                        Vector3 p = new Vector3(i - 20f, 0.0f, j - 20f);
                        Instantiate(playerSlime, p, Quaternion.identity);
                        break;
                    }
                    case 6:
                    {
                        //-20 � o ajuste para come�ar na parte superior esquerda
                        //posiciona em 2 de altura, pois o objeto altura 4 tem tamanho 2 para cima e 2 para baixo
                        Vector3 p = new Vector3(i - 20f, 0.0f, j - 20f);
                        Instantiate(machado, p, Quaternion.identity);
                        break;
                    }
                    case 7:
                    {
                        //-20 � o ajuste para come�ar na parte superior esquerda
                        //posiciona em 2 de altura, pois o objeto altura 4 tem tamanho 2 para cima e 2 para baixo
                        Vector3 p = new Vector3(i - 20f, 0.0f, j - 20f);
                        Instantiate(trave, p, Quaternion.identity);
                        break;
                    }
                }
            }
        }
        // ----------------------------------------------------------------
    }
}