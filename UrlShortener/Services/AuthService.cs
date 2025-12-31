﻿using UrlShortener.Models;
using UrlShortener.Repositories;
using UrlShortener.Services.Interfaces;

namespace UrlShortener.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _repository;

        public AuthService(IAuthRepository repository)
        {
            _repository = repository;
        }

        public Task<User?> GetByEmailAsync(string email)
        {
            return _repository.GetByEmailAsync(email);
        }

    }
}
