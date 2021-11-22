namespace poly.interfaces
{
    public interface ITerrestre {
        string Correr();
        string Caminar();
        
        void Corre(int distance);
        void Corre(int from, int to);
        
        void Camina(int distance);
        void Camina(int from, int to);

    }

}