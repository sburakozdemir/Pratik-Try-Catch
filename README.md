# Try-Catch Kare Hesaplayıcı

Bu basit C# konsol uygulaması, kullanıcıdan bir sayı alır ve bu sayının karesini hesaplar. Program, hata yönetimi için try-catch bloklarını kullanarak güvenli bir şekilde çalışır.

## Özellikler

- Kullanıcıdan sürekli olarak sayı girişi alır
- Girilen sayının karesini hesaplar ve gösterir
- Geçersiz girişleri (sayı olmayan girişler) yakalar ve kullanıcıya bildirir
- Çok büyük veya çok küçük sayıları kontrol eder
- Kullanıcıya programdan çıkış seçeneği sunar

## Nasıl Kullanılır

1. Programı çalıştırın
2. İstendiğinde bir sayı girin
3. Program, girdiğiniz sayının karesini gösterecektir
4. Yeni bir sayı girmek için herhangi bir tuşa basın
5. Programdan çıkmak için 'q' tuşuna basın

## Hata Yönetimi

Program aşağıdaki hata türlerini ele alır:

- **FormatException**: Kullanıcı sayı yerine harf veya özel karakter girerse
- **OverflowException**: Girilen sayı int veri tipinin sınırları dışındaysa
- **Diğer Hatalar**: Öngörülemeyen diğer hatalar için genel bir hata yakalayıcı

## Örnek Kullanım

```
Bir sayı giriniz (Çıkış için 'q' yazın): 5
5 sayısının karesi: 25

Bir sayı giriniz (Çıkış için 'q' yazın): abc
Geçersiz giriş! Lütfen bir sayı giriniz.

Bir sayı giriniz (Çıkış için 'q' yazın): 1000000000000
Girilen sayı çok büyük veya çok küçük!

Bir sayı giriniz (Çıkış için 'q' yazın): q
Program sonlandırılıyor...
```
