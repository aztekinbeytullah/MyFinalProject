using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime="Sistem bakımda";
        public static string ProductListed="Ürünler listelendi.";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameIsInvalid;
        public static string ProductNameAlreadyExists="Bu ürün ismi kullanılıyor";
        public static string CategoryLimitExceded="Maximum kategori sayısına ulaşıldığından ürün eklemesi yapılamaz";
        public static string AuthorizationDenied="Yetkiniz yok";
        internal static string UserRegistered;
        internal static User UserNotFound;
        internal static User PasswordError;
        internal static string SuccessfulLogin;
        internal static string UserAlreadyExists;
        internal static string AccessTokenCreated;
    }
}
