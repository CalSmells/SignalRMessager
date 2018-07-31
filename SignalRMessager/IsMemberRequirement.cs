using Microsoft.AspNetCore.Authorization;

namespace SignalRMessager
{
    public class IsMemberRequirement : IAuthorizationRequirement
    {
        public int GroupId { get; private set; }

        public IsMemberRequirement()
        {

        }
    }
}