using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using DotNetCoreApi.Data.Configurations;
using DotNetCoreApi.Model;
using System.Text;

namespace DotNetCoreApi.Data.Context
{
    public class DBCon : DbContext
    {
        public DBCon(DbContextOptions options) : base(options)
        {
        }

        public DbSet<EmployeeMasterModel> EmployeeMasterSet { get; set; }

        public virtual void Commit()
        {
            try
            {
                base.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                var sb = new StringBuilder();
                sb.AppendLine($"DbUpdateException error details - {e?.InnerException?.InnerException?.Message}");

                foreach (var eve in e.Entries)
                {
                    sb.AppendLine($"Entity of type {eve.Entity.GetType().Name} in state {eve.State} could not be updated");
                }
                var logFilePath = AppDomain.CurrentDomain.BaseDirectory + "\\errors.txt";
                System.IO.File.AppendAllText(logFilePath, sb.ToString());
                throw; // Rethrow the exception if necessary
            }
            catch (SqlException e)
            {
                var outputLines = new List<string>();

                outputLines.Add(string.Format("{0}: Error: \"{1}\" ", DateTime.Now, e.ToString() + " " + e.InnerException.Message));

                System.IO.File.AppendAllLines(AppDomain.CurrentDomain.BaseDirectory + "\\errors.txt", outputLines);

                throw e;
            }
            catch (Exception e)
            {

                var outputLines = new List<string>();

                outputLines.Add(string.Format("{0}: Error: \"{1}\"", DateTime.Now, e.ToString() + " " + e.InnerException.Message));

                System.IO.File.AppendAllLines(AppDomain.CurrentDomain.BaseDirectory + "\\errors.txt", outputLines);

                throw e;
            }
        }

        /* This method is use for Model Configuration */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new EmployeeMasterConfig());
        }
    }
}
