using System.Data.Entity;

namespace Test.Test.Domain
{
    public class DataBaseInitializer : DropCreateDatabaseAlways<DataBaseContext>
    {
        protected override void Seed(DataBaseContext context)
        {
            context.SaveChanges();
        }
    }
}