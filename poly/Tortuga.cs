using System;
using poly.enums;
using poly.interfaces;

namespace poly
{
    public class Tortuga : Animal, IMarino, ITerrestre {
        private const string _scientificName = "Testudines";
        private const string _commonName = "Tortuga";
        private const string _noise = "aah...";

        public Tortuga(string name, COLOR[] colors) {
            ScientificName = _scientificName;
            CommonName = _commonName;
            Noise = _noise;
            Name = name;
            Colors = colors;
        }

        //metodos heredados por clase abstracta
        public override void Move(int distance) {
            this.
            Nada(distance);
        }

        //Metodos implementados por interfaz
        public string Correr() {
            return "runing...";
        }

        public string Caminar() {
            return "walking...";
        }
    
        public string Nadar() {
            return "swimming...";
        }

        public void Corre(int distance) {
            base.Move(distance, Correr);
        }
        public void Corre(int from, int to) {
            base.Move(from, to, Correr);
        }

        public void Camina(int distance) {
            base.Move(distance, Caminar);
        }
        public void Camina(int from, int to) {
            base.Move(from, to, Caminar);
        }

        public void Nada(int distance) {
            base.Move(distance, Nadar);
        }

        public void Nada(int from, int to) {
            base.Move(from, to, Nadar);
        }

    }
}