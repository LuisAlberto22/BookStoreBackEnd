namespace BookStore.Entities.Interfaces
{
    public abstract class StatusableModel : BaseModel
    {
        public int StatusId { get; set; }
        public Status Status { get; set; }
    }
}
