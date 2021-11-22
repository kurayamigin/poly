using System;
using poly.enums;
using poly.interfaces;

namespace poly
{
    public class Gato : Animal, ITerrestre {
        private const string _noise = "miaw...";
        private const string _commonName = "Gato";
        private const string _scientificName = "Felis catus";
        
        public Gato() {}
        public Gato(string name, COLOR[] colors)
        {
            Noise = _noise;
            CommonName = _commonName;
            ScientificName = _scientificName;
            Name = name;
            Colors = colors;
        }

        //metodos heredados por clase abstracta
        public override void Move(int distance) {
            Camina(distance);
        }


        //metodos implementados por interfaz
        public string Correr() {
            return "running...";
        }

        public string Caminar() {
            return "walking...";
        }

        public void Corre(int distance) {
            base.Move(distance, Correr);
        }
        
        public void Corre(int from, int to) {
            base.Move(from, to, Correr);
        }

        public void Camina(int distance) {
            base.Move(distance, this.Caminar);
        }
        public void Camina(int from, int to) {
            base.Move(from, to, this.Caminar);
        }
        
    }
}