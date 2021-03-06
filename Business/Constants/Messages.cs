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
        public static string UserRegistered="Kullanıcı kaydı yapıldı";
        public static string UserNotFound ="Kullanıcı Bulunamadı";
        public static string PasswordError ="Parola hatası";
        public static string SuccessfulLogin="Aferin giriş yaptın";
        public static string UserAlreadyExists="Kullanıcı adı var";
        public static string AccessTokenCreated="Token yaratıldı.";
    }
}
