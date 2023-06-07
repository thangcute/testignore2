using Humax.ESS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Humax.ESS.Helpers
{
    public class ApiOosHelper
    {
        private string apiURLBase = "";

        public readonly string defaultAvatar = "/img/ava.png";

        private readonly IConfiguration _config;
        public ApiOosHelper(IConfiguration config)
        {
            _config = config;
            apiURLBase = _config.GetSection("AppSettings:apiURLBase").Value;
        }

        public async Task<LoginModel> Login(ISession session, LoginModel model)
        {
            var loginClient = new HttpClient();
            loginClient.BaseAddress = new Uri(apiURLBase);

            var loginReqest = new LoginRequest { UserName = model.UserName, Password = model.Password };

            var postResponse = await loginClient.PostAsJsonAsync("/api/auth", loginReqest);
            if (postResponse.IsSuccessStatusCode)
            {
                var response = await postResponse.Content.ReadFromJsonAsync<ApiResponse<UserInfo>>();
                model.Status = response.Status;
                if (response.Status == 1)
                {
                    session.SetLoggedIn();
                    session.SetToken(response.Token);
                    session.SetCurrentUser(response.Data);

                    return model;
                }
            }

            session.Clear();
            return model;
        }

        public async Task<ApiResponse<T>> Get<T>(ISession session, string requestUri)
        {
            try
            {
                PrepareHttpClient(session);
                var response = await client(session).GetFromJsonAsync<ApiResponse<T>>(requestUri);
                if (response.Status != 1 && (response.Message == "Login Fail" || response.Message == "Phiên đã hết hạn"))
                {
                    session.SetLoggedIn(0);
                    return response;
                }
                return response;
            }
            catch (Exception ex)
            {
                return new ApiResponse<T>
                {
                    Status = 0,
                    Message = ex.Message
                };
            }
        }

        public async Task<ApiResponse<T>> Post<T>(ISession session, string requestUri, object value)
        {
            try
            {
                PrepareHttpClient(session);
                var response = await client(session).PostAsJsonAsync(requestUri, value);

                if (response.IsSuccessStatusCode)
                {
                    var r = await response.Content.ReadFromJsonAsync<ApiResponse<T>>();
                    if (r.Status != 1 && (r.Message == "Login Fail" || r.Message == "Phiên đã hết hạn"))
                    {
                        session.SetLoggedIn(0);
                        return r;
                    }
                    return r;
                }
                else
                    return new ApiResponse<T>
                    {
                        Status = 0,
                        Message = response.ReasonPhrase ?? "Failed to send post request"
                    };
            }
            catch (Exception ex)
            {
                return new ApiResponse<T>
                {
                    Status = 0,
                    Message = ex.Message
                };
            }
        }

        public async Task<ApiResponse<T>> Put<T>(ISession session, string requestUri, object value)
        {
            try
            {
                PrepareHttpClient(session);
                var response = await client(session).PutAsJsonAsync(requestUri, value);

                if (response.IsSuccessStatusCode)
                {
                    var r = await response.Content.ReadFromJsonAsync<ApiResponse<T>>();
                    if (r.Status != 1 && (r.Message == "Login Fail" || r.Message == "Phiên đã hết hạn"))
                    {
                        session.SetLoggedIn(0);
                        return r;
                    }
                    return r;
                }
                else
                    return new ApiResponse<T>
                    {
                        Status = 0,
                        Message = response.ReasonPhrase ?? "Failed to send put request"
                    };
            }
            catch (Exception ex)
            {
                return new ApiResponse<T>
                {
                    Status = 0,
                    Message = ex.Message
                };
            }
        }

        public async Task<ApiResponse<T>> Delete<T>(ISession session, string requestUri, string id)
        {
            try
            {
                PrepareHttpClient(session);
                var response = await client(session).DeleteAsync(requestUri + "/" + id);

                if (response.IsSuccessStatusCode)
                {
                    var r = await response.Content.ReadFromJsonAsync<ApiResponse<T>>();
                    if (r.Status != 1 && r.Message == "Login Fail")
                    {
                        session.SetLoggedIn(0);
                        return r;
                    }
                    return r;
                }
                else
                    return new ApiResponse<T>
                    {
                        Status = 0,
                        Message = response.ReasonPhrase ?? "Failed to send delete request"
                    };
            }
            catch (Exception ex)
            {
                return new ApiResponse<T>
                {
                    Status = 0,
                    Message = ex.Message
                };
            }
        }

        public HttpClient client(ISession session)
        {
            HttpClient client = null;
            client = new HttpClient();
            client.BaseAddress = new Uri(apiURLBase);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("User-Agent", "OOS.Humax.ESS");

            string token = session.GetToken();
            if (!string.IsNullOrEmpty(token))
                client.DefaultRequestHeaders.Add("Token", token);

            return client;
        }

        private void PrepareHttpClient(ISession session)
        {
            return;

            HttpClient client = null;
            if (session.Keys.Contains("client"))
                client = session.Get<HttpClient>("client");

            if (client == null)
            {
                client = new HttpClient();
                client.BaseAddress = new Uri(apiURLBase);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("User-Agent", "OOS.Humax.ESS");

                string token = session.GetToken();
                if (!string.IsNullOrEmpty(token))
                    client.DefaultRequestHeaders.Add("Token", token);

                session.Set("client", client);
            }
        }
    }
}
