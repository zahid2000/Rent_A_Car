using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string[] ValidImageFileTypes = { ".JPG", ".JPEG", ".PNG", ".TIF", ".TIFF", ".GIF", ".BMP", ".ICO" };

        public static string CarAdded = "Urun eklendi";
        public static string CarNameInvalid = "Urun ismi gecersiz";
        public static string CarDeleted = "Urun bilgileri silindi";
        public static string CarUpdated = "Urun bilgileri guncellendi";
        public static string MaintenanceTime = "Sistem bakimda";
        public static string CarListed = "Urunler listelendi";

        public static string CarColorAdded = "Renk eklendi";
        public static string CarColorDeleted = "Renk silindi";
        public static string CarColorListed = "Renkler listelendi";
        public static string CarColorUpdated = "Renk guncellendi";

        public static string CarBrandAdded = "Model eklendi";
        public static string CarBrandDeleted = "Model silindi";
        public static string CarBrandListed = "Modeller listelendi";
        public static string CarBrandUpdated = "Model guncellendi";

        public static string UserAdded = "Kullanici eklendi";
        public static string UserDeleted = "Kullanici silindi";
        public static string UserListed = "Kullanicilar listelendi";
        public static string UserUpdated = "Kullanici guncellendi";

        public static string CustomerAdded = "Musteri eklendi";
        public static string CustomerDeleted = "Musteri silindi";
        public static string CustomerListed = "Musteriler listelendi";
        public static string CustomerUpdated = "Musteri guncellendi";

        public static string RentalAdded = "Kiralama bilgisi eklendi";
        public static string RentalDeleted = "Kiralama bilgisi silindi";
        public static string RentalListed = "Kiralama bilgileri listelendi";
        public static string RentalUpdated = "Kiralama bilgisi guncellendi";

        public static string CarImageAdded = "Araba resmi eklendi";
        public static string CarImageDeleted = "Araba resmi silindi";
        public static string CarHaveNoImage = "Id ye uygun araba bulunamadi";
        
        public static string ImageLimitExpiredForCar = "Bir arabaya maksimum 5 fotograf eklene bilir";
        public static string InvalidImageExtension = "Geçersiz dosya uzantısı, fotoğraf için kabul edilen uzantılar" + string.Join(",", ValidImageFileTypes);
        public static string CarImageMustbeExists="Boyle bir resim bulunamadi";
      
        public static string AuthorizationDenied="İcazəniz yoxdur";
        public static string UserNotFoundForEmail="Bu mailə uyğun istifadəçi tapılmadı";
        public static string ClaimsNotFound= "Tələb tapılmadı";
        public static string UserNotFound="Id ye uygun araba bulunamadi";
        public static string PasswordError="Şifrə yalnışdır";
        public static string SuccessfulLogin="Giriş başarılı";
        public static string UserAlreadyExists="İstifadəçi artıq mövcuddur";
        public static string AccessTokenCreated = "Token oluşturuldu";
        public static string UserRegistered = "Qeydiyyat tamamlandı ";
    }
}
