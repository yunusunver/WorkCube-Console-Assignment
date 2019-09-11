# WorkCube-Console-Assignment

Örnek uygulama şu şekilde senaryoya sahip

5 adet bankanın sanal poslarını kullanmak istemekteyiz. Bir ekrandan standart kredi kartı bilgilerini müşteri girecek ve aşağıdaki alanlar elimizde olacak.

- Adı
- Kredi Kart No
- Son Kul.Tarihi
- CVV
- Tutar

Ekranı hazırlamanıza gerek yok bir fonksiyondan bu verileri alarak işleme başlayabilirsiniz. Bankalar şu işlemleri yapmaktalar.

- Pay: Kredi kartı tahsilatı
- TriDPay: 3D kredi kartı tahsilatı (pay ile farkı olmayacak örnek te sadece adı bu olsun)
- Cancel: Gün içinde yapılan işlemi iptal etme (PayId ile iptal edecek bir fonksiyon değerini manuel verebiliriz)
- Refund: İptal sürecini aşmış veya iptal kabul etmeyen bankalar iade sürecine girer (PayId ile iptal edecek bir fonksiyon değerini manuel verebiliriz)

Bu 4 fonksiyon üzerine aşağıdaki bankaların kullanabildiği işlemler şunlardır

- ABank: Pay, TriDPay, Refund
- BBank: Pay,Cancel,Refund
- CBank: TriDPay,Cancel,Refund
- DBank: Pay, TriDPay,Cancel

Bu 4 banka şu iki ödeme geçit servisini kullanmakta

- Gateway1: Pay, TriDPay, Refund
- Gateway2: TriDPay, Cancel, Refund

Aşağıdaki bankalar varsayılan olarak şu gatewayleri kullanır diğer durumlarda işlemi karşılayan herhangi bir gateway i kullanabilir

- ABank: Gateway1
- BBank: Gateway1
- CBank: Gateway2
- DBank: Gateway2

Altın kuralı unutma! Cancel işlemi yapamayan banka veya gateway refund işlemi yapar.

Uygulama console da şu şekilde çalışabilir, bir ekranda yapılması istenen işlem listesi gelir, buradan işlem seçilir ardından banka seçilir ve adımlar uygulanır.

Örnek1: Pay - BBank seçilir ve kredi kartı bilgileri girilir. Ekrana xxx tutarı BBank ile Gateway1 üzerinden Pay işlemi ile xxxx nolu kredi kartından çekilmiştir yazar

Örnek2: Cancel - ABank seçilir ve payid değeri elle girilir. Ekrana xxx payid ile yapılan işlem ABank ile Gateway1 üzerinden Refund edilmiştir yazar.

## Uygulama Görüntüsü
![WorkCubeApp](https://user-images.githubusercontent.com/24482512/64687449-2fdffc00-d493-11e9-9c6c-78ae3f98abe3.PNG)
