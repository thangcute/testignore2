using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Humax.ESS.Models;
using Microsoft.AspNetCore.Http;

namespace Humax.ESS.Helpers
{
    public static class SessionHelper
    {
        const string SessionKeyUserInfo = "_UserInfo";

        const string SessionKeyLoggedIn = "_LoggedIn";

        const string SessionKeyToken = "_Token";

        public static void Set<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T Get<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default : JsonSerializer.Deserialize<T>(value);
        }

        public static bool HasLoggedIn(this ISession session)
        {
            return session.GetInt32(SessionKeyLoggedIn) == 1;
        }

        public static bool HasPermission(this ISession session, string permission)
        {
            var currentUser = session.Get<UserInfo>(SessionKeyUserInfo);
            if (currentUser != null && currentUser.Permissions != null)
                currentUser.Permissions.Contains(permission);

            return false;
        }

        public static void SetLoggedIn(this ISession session, int loggedIn = 1)
        {
            session.SetInt32(SessionKeyLoggedIn, loggedIn);
        }

        public static UserInfo GetCurrentUser(this ISession session)
        {
            return session.Get<UserInfo>(SessionKeyUserInfo);
        }

        public static void SetCurrentUser(this ISession session, UserInfo userInfo)
        {
            session.Set(SessionKeyUserInfo, userInfo);
        }

        public static string GetToken(this ISession session)
        {
            return session.GetString(SessionKeyToken);
        }

        public static void SetToken(this ISession session, string token)
        {
            session.SetString(SessionKeyToken, token);
        }
    }
}
