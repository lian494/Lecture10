namespace Sovacy.Models
{
    public class Child
    {
        internal bool IsCry {get; set; }
        public string Name {get; set; }
        public void  Cry(Child child)
        {
           System.Console.WriteLine("Child is craying");
            this.IsCry = true;
            System.Threading.Thread.Sleep(1500);
        }
        public void Happy()
       {
            System.Console.WriteLine ("Child is Happy!!!");
       }
    }
}