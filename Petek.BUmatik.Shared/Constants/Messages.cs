using Petek.BUmatik.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Petek.BUmatik.Shared.Constants
{
    public static class Messages
    {
        public static string StudentAdded = "Öğrenci bilgisi eklendi.";
        public static string StudentUpdated = "Öğrenci bilgisi güncellendi.";
        public static string StudentDeleted = "Öğrenci bilgisi silindi.";
        public static string StudentNameInvalid= "Öğrenci ismi geçersiz.";
        public static string StudentBandNumberAlreadyExists = "Band numrasına kayıtlı bir öğrenci zaten mevcut.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kayıt oluşturuldu.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Şifre hatalı.";
        public static string SuccessfulLogin = "Login başarılı.";
        public static string UserAlreadyExists = "Oturum zaten açık.";
        public static string AccessTokenCreated = "Token oluşturuldu.";
    }
}
