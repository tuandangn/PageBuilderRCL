namespace PageBuilderRCL.Domain.Shared;

[Serializable]
public class PageBuilderRclAggregateEntity
{
    public PageBuilderRclAggregateEntity(Guid id)
        => Id = id;

    public Guid Id { get; }
}
