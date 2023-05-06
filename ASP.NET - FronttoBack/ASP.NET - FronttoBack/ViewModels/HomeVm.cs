using ASP.NET___FronttoBack.Models;

namespace ASP.NET___FronttoBack.ViewModels
{
    public class HomeVm
    {
        public List<Service> Services { get; set; }
        public List<Feature> Features { get; set; }
        public List<Project> Projects { get; set; }
        public List<Expert> Experts { get; set; }
        public List<Client> Clients { get; set; }
    }
}
