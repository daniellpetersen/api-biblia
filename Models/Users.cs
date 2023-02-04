namespace api_biblia.Models
{
    public class Users
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Token { get; set; }
        public bool? Notifications { get; set; }

    }

    public class User
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Token { get; set; }
        public bool? Notifications { get; set; }
        public string? LastLogin { get; set; }

    }

    public class UpdateUser
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Token { get; set; }
    }

    public class RequestsPerMonth
    {
        public RequestsPerMonth(string? range, string? total)
        {
            Range = range;
            Total = total;
        }

        public string? Range { get; set; }
        public string? Total { get; set; }
    }



    public class UserStats
    {
        public string? LastLogin { get; set;}

        public IEnumerable<RequestsPerMonth>? requestsPerMonth { get; set; }
       

    }

    public class UserDelete
    {
        public string? Msg { get; set; }

    }

}
