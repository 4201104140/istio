namespace ListenTogether.Domain;

public class Room
{
    private const int Length = 5;
    private const string ValidCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    private readonly Random _randGenerator = Random.Shared;

    public Room()
    {
        Code = GenerateRoomCode();
    }

    public string Code { get; private set; }

    private string GenerateRoomCode()
    {
        return new string(Enumerable.Repeat(ValidCharacters, Length)
            .Select(s => s[_randGenerator.Next(s.Length)])
            .ToArray());
    }
}
