using System.Data;
using AppImposto.Aula05;
using AppImposto.Aula06;
using AppImposto.Aula07;
using AppImposto.Aula08;
using AppImposto.Aula09;

public class TesteDeImpostos 
{
    static void Main(String[] args) 
    {
        NotasMusicais notas = new NotasMusicais();
        var musica = new List<INota>()
        {
            notas.GetNota("do"),
            notas.GetNota("re"),
            notas.GetNota("mi"),
            notas.GetNota("fa"),
            notas.GetNota("fa"),
            notas.GetNota("fa")
        };

        var piano = new Piano();
        piano.Play(musica);
    }
}