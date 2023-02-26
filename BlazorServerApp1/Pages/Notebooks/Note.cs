namespace BlazorServerApp1.Pages.Notebooks
{
    public class Note
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Text { get; set; } = "";
        public string Color { get; set; } = "";
        public bool IsEditing { get; set; } = false;
        public bool IsDeleting { get; set; } = false;
    }
}
