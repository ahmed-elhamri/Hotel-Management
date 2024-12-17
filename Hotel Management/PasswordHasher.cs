using System;
using System.Security.Cryptography;
using System.Text;

public static class PasswordHasher
{
    private const int SaltSize = 16; // 128-bit
    private const int KeySize = 32; // 256-bit
    private const int Iterations = 10000;

    public static string HashPassword(string password)
    {
        // Generate a random salt
        using var rng = RandomNumberGenerator.Create();
        var salt = new byte[SaltSize];
        rng.GetBytes(salt);

        // Hash the password
        using var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256);
        var key = pbkdf2.GetBytes(KeySize);

        // Combine salt and key
        var hash = new byte[SaltSize + KeySize];
        Array.Copy(salt, 0, hash, 0, SaltSize);
        Array.Copy(key, 0, hash, SaltSize, KeySize);

        // Return the hash as a Base64 string
        return Convert.ToBase64String(hash);
    }

    public static bool VerifyPassword(string password, string hashedPassword)
    {
        var hashBytes = Convert.FromBase64String(hashedPassword);

        // Extract salt
        var salt = new byte[SaltSize];
        Array.Copy(hashBytes, 0, salt, 0, SaltSize);

        // Extract key
        var key = new byte[KeySize];
        Array.Copy(hashBytes, SaltSize, key, 0, KeySize);

        // Hash the provided password with the same salt
        using var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256);
        var keyToCheck = pbkdf2.GetBytes(KeySize);

        // Compare the result with the original key
        return CryptographicOperations.FixedTimeEquals(key, keyToCheck);
    }
}
