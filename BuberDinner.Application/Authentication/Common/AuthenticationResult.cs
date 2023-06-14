using BuberDinner.Domain.UserAggregate;

namespace BuberDinner.Application.Authentication.Common;

public record AuthenticationResult(
    User user,
    string Token
);