using Dev_Piton.Core.Entities;

namespace Dev_Piton.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>()
            {
                new Project("Meu projeto ASPNET Core 1", "Minha descricao de projeto 1", 1, 1, 10000),
                new Project("Meu projeto ASPNET Core 2", "Minha descricao de projeto 2", 1, 1, 20000),
                new Project("Meu projeto ASPNET Core 3", "Minha descricao de projeto 3", 1, 1, 30000)
            };

            Users = new List<User>()
            {
                new User("Gabriel Piton", "gabrielpiton@dev_piton.com.br", new DateTime(1994, 3, 10)),
                new User("Gabriee Lima", "gabrielelima@dev_piton.com.br", new DateTime(1993, 4, 11)),
                new User("Dog Apollo", "dogapollo@dev_piton.com.br", new DateTime(2023, 2, 20)),
            };

            Skills = new List<Skill>()
            {
                new Skill("Desenvolvedor de software"),
                new Skill("Assistente Pesso Juridica"),
                new Skill("Morder"),
            };
        }

        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
        public List<ProjectComment> ProjectComments { get; set; }
    }
}