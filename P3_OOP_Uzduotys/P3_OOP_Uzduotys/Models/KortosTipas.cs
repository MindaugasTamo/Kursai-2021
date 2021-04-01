namespace P3_OOP_Uzduotys.Models
{
    public class KortosTipas
    {
        public KortosTipas(string pavadinimas, int akiuSkaicius)
        {
            Pavadinimas = pavadinimas;
            AkiuSkaicius = akiuSkaicius;
        }

        public string Pavadinimas { get; set; }
        public int AkiuSkaicius { get; set; }
    }
}
