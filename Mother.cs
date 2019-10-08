namespace Sovacy.Models
{
    public class Mother 
    {
        public bool Feed{get; set;}
        public void MustEat(Child child)
        {
           
            this.Feed = true;
            System.Threading.Thread.Sleep(2000);
        }
        public void Eat (Child child)
        {
            if(this.Feed == true)
            {
                System.Console.WriteLine("Mother feeds child!");
                  System.Threading.Thread.Sleep(1500);

            }
        }
    }
}