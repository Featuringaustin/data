namespace Database;
public class UserProfile
{
    public int Id {get; init;}
    public int UserId {get; init;}
    public string? FirstName {get; init;}
    public string? LastName {get; init;}
    public string? DOB {get; init;}

    public override string ToString()
    {
        return $"{Id}|{UserId}:{FirstName},{LastName} born {DOB}";
    }
}