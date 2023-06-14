using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Common.ValueObjects;
using BuberDinner.Domain.DinnerAggregate.ValueObjects;
using BuberDinner.Domain.HostAggregate.ValueObjects;
using BuberDinner.Domain.MenuAggregate.Entities;
using BuberDinner.Domain.MenuAggregate.ValueObjects;
using BuberDinner.Domain.MenuReviewAggregate.ValueObjects;

namespace BuberDinner.Domain.MenuAggregate;

public sealed class Menu : AggregateRoot<MenuId>
{
    private readonly List<MenuSection> _sections = new();
    private readonly List<DinnerId> _dinnerIds = new();
    private readonly List<MenuReviewId> _menuReviewIds = new();

    public string Name { get; private set; }
    public string Description { get; private set; }
    public AverageRating AverageRating { get; private set; }

    public IReadOnlyList<MenuSection> Sections => _sections.AsReadOnly();

    public HostId HostId { get; private set; }

    public IReadOnlyList<DinnerId> DinnerIds => _dinnerIds.AsReadOnly();
    public IReadOnlyList<MenuReviewId> MenuReviewIds => _menuReviewIds.AsReadOnly();
    public DateTime CreatedDateTime { get; private set; }
    public DateTime UpdatedDateTime { get; private set; }

    private Menu(
        MenuId id,
        HostId hostId,
        string name,
        string description,
        AverageRating averageRating,
        List<MenuSection> sections) : base(id)
    {
        HostId = hostId;
        Name = name;
        Description = description;
        AverageRating = averageRating;
        _sections = sections;
    }

    public static Menu Create(
        string name,
        string description,
        HostId hostId,
        List<MenuSection>? sections = null)
    {
        return new(
            MenuId.CreateUnique(),
            hostId,
            name,
            description,
            AverageRating.CreateNew(),
            sections ?? new());
    }

#pragma warning disable CS8618
    private Menu()
    {
    }
#pragma warning restore CS8618
}