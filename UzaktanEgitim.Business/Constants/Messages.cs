using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzaktanEgitim.Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Bakım saati";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductNameAlreadyExists = "Aynı isimde ürün zaten var";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string CategoryCountExceeded = "Kategori sayısı 15'i geçtiği için ürün ekleyemezsiniz";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kayıt gerçekleştirildi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı zaten var";
        public static string AccessTokenCreated = "Token Oluşturuldu";
    }
}
