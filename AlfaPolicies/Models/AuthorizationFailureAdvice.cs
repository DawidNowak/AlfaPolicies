using Rsk.Enforcer.PEP;

namespace SecureMVCApp.Models;

[EnforcerAdvice("AuthorizationFailure")]
public class AuthorizationFailureAdvice
{
    [PolicyAttribute("Advice", "AuthorizationFailureMessage")]
    public string Message { get; set; }
}