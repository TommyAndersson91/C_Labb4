namespace C_lab4
{ 
public class Country
    {
        public Country[] Countries { get; set; }
        public string Name { get; set; }
        public string Currency { get; set; }
        public double Population { get; set; }
        public string PictureUrl { get; set; }
        public string Description { get; set; }

    public Country(string name, string currency, double population, string pictureurl, string description)
        {
            this.Name = name;
            this.Currency = currency;
            this.Population = population;
            this.PictureUrl = pictureurl;
            this.Description = description;
        }
    }
}
