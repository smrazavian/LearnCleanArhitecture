namespace GenericDomain
{
    public abstract class AggreagetRoot<Tkey>
    {
        public Tkey Id { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
