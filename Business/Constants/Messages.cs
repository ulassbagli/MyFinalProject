using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün  olabilir.";
        public static string ProductNameAlreadyExists = "Bu isimde zaten bir ürün var!";
        public static string CheckIfCountOfCategoryExist="Bu kategoride 15'den fazla ürün ekleyemezsiniz.";
        public static string AuthorizationDenied="Yetkiniz yok!";
        public static string UserRegistered="Kayıt Olundu!";
        public static string UserNotFound="Kullanıcı Bulunamadı!";
        public static string PasswordError="Hatalı Şifre!";
        public static string SuccessfulLogin="Giriş Başarılı!";
        public static string UserAlreadyExists="Kullanıcı Zaten Var!";
        public static string AccessTokenCreated="Token Oluşturuldu!";
    }
}
