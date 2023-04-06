namespace PageBuilderRCL.Domain.Shared;

[Serializable]
public class AggregateEntity
{
    public AggregateEntity(Guid id)
        => Id = id;

    public Guid Id { get; }
}
