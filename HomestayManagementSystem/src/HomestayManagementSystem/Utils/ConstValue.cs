using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using HomestayManagementSystem.Models;

namespace HomestayManagementSystem.Utils
{
    public class ConstValue
    {
        public static readonly string AuthenticationScheme = "HomestayManagementSystemInstance";

        public static readonly string UserIdKey = "UserId";
        public static readonly string PermissionIdKey = "PermissionId";
        public static readonly string SiteLocationsKey = "SiteLocations";
        public static readonly string UserInfoKey = "UserInfo";

        public static readonly string DefaultPassword = "*";

        public enum PermissionType
        {
            Developer = 1,
            Admin = 2,
            User = 3
        }

        public enum FileType
        {
            HomestayContract,
            HomestayEvaluation,
            HomestayPoliceCheck,
            HomestayProfile,
            StudentProfile,
        }

        public static string GetUserName(User user)
        {
            return $"{user?.FirstName} {user?.LastName}";
        }

        public static string GetHomestayFamilyName(Homestay homestay)
        {
            return $"{homestay?.FirstName} {homestay?.LastName}";
        }

        public static string GetStudentName(Student student)
        {
            return $"{student?.FirstName} {student?.LastName}";
        }

        public static string GetFileLocation(FileType fileType)
        {
            return Path.Combine("Upload", GetFolderName(fileType));
        }

        public static string GetImageFileUrl(FileType fileType, string fileName)
        {
            return $"~/Upload/{GetFolderName(fileType)}/{fileName}";
        }

        private static string GetFolderName(FileType fileType)
        {
            var folderName = string.Empty;

            switch (fileType)
            {
                case FileType.HomestayContract:
                    folderName = "HomestayContact";
                    break;
                case FileType.HomestayEvaluation:
                    folderName = "HomestayEvaluation";
                    break;
                case FileType.HomestayPoliceCheck:
                    folderName = "HomestayPoliceCheck";
                    break;
                case FileType.HomestayProfile:
                    folderName = "HomestayProfile";
                    break;
                case FileType.StudentProfile:
                    folderName = "StudentProfile";
                    break;
            }
            return folderName;
        }

        public static string GetHash(string text)
        {
            // SHA512 is disposable by inheritance.
            using (var sha256 = SHA256.Create())
            {
                // Send a sample text to hash.
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(text));
                // Get the hashed string.
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
    }
}
