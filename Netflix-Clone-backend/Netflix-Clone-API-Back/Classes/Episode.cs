namespace Netflix_Clone_API_Back.Classes
{
    public class Episode
    {
        private int id;
        private string nameEpisodes;
        private int nbEpisodes;
        private string lien;
        private int saisonId;
        private string saisonImg;
        private string saisonLien;
        private DateTime saisonAnnees;

        public Episode()
        {

        }


        public Episode(int id, string nameEpisodes, int nbEpisodes, string lien, int saisonId, string saisonImg, string saisonLien, DateTime saisonAnnees)
        {
            this.id = id;
            this.nameEpisodes = nameEpisodes;
            this.nbEpisodes = nbEpisodes;
            this.lien = lien;
            this.saisonId = saisonId;
            this.saisonImg = saisonImg;
            this.saisonLien = saisonLien;
            this.saisonAnnees = saisonAnnees;
        }

        public int Id { get => id; set => id = value; }
        public string NameEpisodes { get => nameEpisodes; set => nameEpisodes = value; }
        public int NbEpisodes { get => nbEpisodes; set => nbEpisodes = value; }
        public string Lien { get => lien; set => lien = value; }
        public int SaisonId { get => saisonId; set => saisonId = value; }
        public string SaisonImg { get => saisonImg; set => saisonImg = value; }
        public string SaisonLien { get => saisonLien; set => saisonLien = value; }
        public DateTime SaisonAnnees { get => saisonAnnees; set => saisonAnnees = value; }


        public override string ToString()
        {
            return $"ID : {Id} \tTitle : {NameEpisodes} \n NbEpisodes : {NbEpisodes} \n Lien : {Lien} \n SaisonId : {SaisonId} \n SaisonImg : {SaisonImg} \n SaisonLien : {SaisonLien} \n SaisonAnnees : {SaisonAnnees}";
        }


    }
}
