﻿using System;

namespace PRACTICA_OIB
{
    public class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            string salt = BCrypt.Net.BCrypt.GenerateSalt(); // Генерируем соль с помощью BCrypt
            return BCrypt.Net.BCrypt.HashPassword(password, salt); // Хешируем с использованием соли
        }

        public static bool VerifyPassword(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }
    }
}
