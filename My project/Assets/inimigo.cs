using Unity.VisualScripting;
using UnityEngine;


    /*public void AtribuirArmadura(ArmaduraDoInimigo armadura)
    {
    
        void Start()
        {
          //  This.armadura = 
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
   } */


    public class Inimigo : Personagem
    {
        public enum ArmaDoInimigo
        {
            ESPADA, MACHADO, ADAGA
        }

        public enum ArmaduraDoInimigo
        {
            MADEIRA, COURO, BRONZE, ACO
        }

        [ SerializeField ]
        private ArmaduraDoInimigo armadura;
        [ SerializeField ]  
        private ArmaDoInimigo arma;

        public void AtribuirArmadura(ArmaduraDoInimigo armadura)
        {
            this.armadura = armadura;
        }

        public ArmaduraDoInimigo Armadura()
        {
            return this.armadura;
        }

        public void AtribuirArma(ArmaDoInimigo arma)
        {
            this.arma = arma;
        }

        public ArmaDoInimigo Arma()
        {
            return this.arma;
        }


        public int DanoDoInimigo()
        {
            int dano = 0;

            switch (arma)
            {
                case ArmaDoInimigo.ESPADA:
                    dano = ataque() + 10;
                    break;
                case ArmaDoInimigo.MACHADO:
                    dano = ataque() + 18;
                    break;
                case ArmaDoInimigo.ADAGA:
                    dano = ataque() + 5;
                    break;
            }
        
            // dano do ataque com a arma
        
            return dano;
        }















        void Start()
        {
        
        }
        void Update()
        {
        
        }
    }



