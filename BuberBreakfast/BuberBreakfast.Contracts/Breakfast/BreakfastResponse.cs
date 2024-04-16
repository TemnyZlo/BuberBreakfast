namespace BuberBreakfast.Constracts.Breakfast;

public record BreakfastResponse(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    DateTime LastModifiedDateTime,
    List<string> Savory,
    List<string> Sweet);

