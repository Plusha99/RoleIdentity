namespace RoleIdentity.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; } = new byte[32];
        public byte[] PasswordSalt { get; set; } = new byte[32];
        public string? VerificationToken { get; set; }
        public DateTime? VerifiedAt { get; set; }
        public string? PasswordResetToken { get; set; }
        public DateTime? ResetTokenExpies { get; set; }
        public Role Role { get; set; } = Role.User;
    }

    public enum Role
    {
        Admin,
        User,
        Editor
    }
}
