﻿using Microsoft.AspNetCore.Authorization;

namespace ApiClient.Configurations.Authorization
{
    internal class ActionAuthorizationRequirement : IAuthorizationRequirement
    {
        public ActionAuthorizationRequirement(string action)
        {
            Action = action;
        }

        public string Action { get; }
    }
}
