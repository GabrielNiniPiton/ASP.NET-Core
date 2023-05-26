namespace Dev_Piton.Application.ViewModels
{
    public class ProjectViewModel
    {
        public ProjectViewModel(int id, string titlte, DateTime createAt)
        {
            Id = id;
            Titlte = titlte;
            CreateAt = createAt;
        }

        public int Id { get; private set; }
        public string Titlte { get; private set; }
        public DateTime CreateAt { get; private set; }
    }
}