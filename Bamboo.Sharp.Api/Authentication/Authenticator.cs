using System;
using RestSharp;

namespace Bamboo.Sharp.Api.Authentication
{
    internal static class Authenticator
    {
        private static string _userName;
        private static string _password;

        internal static RestClient Setup(string userName, string password)
        {
            _userName = userName;
            _password = password;

            return Authenticate();
        }

        internal static RestClient Authenticate()
        {
            if (string.IsNullOrEmpty(_userName))
                throw new ArgumentNullException("userName");
            if (string.IsNullOrEmpty(_password))
                throw new ArgumentNullException("password");

            return new RestClient
            {
                Authenticator = new HttpBasicAuthenticator(_userName, _password),
            };
        }
    }
}
