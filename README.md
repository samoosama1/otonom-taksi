# otonom-taksi

## Genel Bakış
Bu proje, kod kalitesini ve iş birliğini korumak için korumalı dallar ve bir pull request iş akışı kullanılarak yapılandırılmıştır. Ana dal (main) korumalıdır ve yalnızca pull request'ler aracılığıyla güncellenebilir.

## Dal Koruması
`main` dalı, kod tabanının bütünlüğünü korumak için korumalıdır. `main` dalına doğrudan push yapmak yasaktır. Tüm değişiklikler, gözden geçirilecek ve onaylanacak pull request'ler aracılığıyla yapılmalıdır.

## İş Akışı
1. **Dal Oluştur**: İlgili görev için yeni bir dal oluşturun. Dal isimlendirmesi şu şekilde olmalıdır: `dev/<görev>/<alt_görev>`. Örneğin, `dev/simulation/model` veya `dev/algorithm/parking`.
2. **Geliştir**: Değişikliklerinizi yapın ve dalınıza commit edin.
3. **Pull Request**: Değişiklikleriniz hazır olduğunda, dalınızı `main` dalına birleştirmek için bir pull request açın.
4. **Gözden Geçirme**: Pull request, ekip üyeleri tarafından gözden geçirilecektir. Geri bildirimlere göre gerekli değişiklikleri yapın.
5. **Birleştirme**: Onaylandıktan sonra, pull request `main` dalına birleştirilecektir.

## Dallar
- **main**: Korumalı ana dal.

## Katkı Yönergeleri
- Çalışmanız için her zaman yeni bir dal oluşturun.
- Dal isimlendirmesi şu şekilde olmalıdır: `dev/<görev>/<alt_görev>`.
- Kodunuzun projenin kodlama standartlarına uygun olduğundan emin olun.
- Açık ve öz commit mesajları yazın.
- Değişiklikleriniz için bir pull request açın ve gözden geçirme talep edin.
- Geri bildirimleri ele alın ve gerekli revizyonları yapın.

Bu iş akışını takip ederek, yüksek kaliteli bir kod tabanı ve ekip üyeleri arasında etkili bir iş birliği sağlayabiliriz.

## 1. Repoyu Klonlama
Öncelikle, projeyi yerel bilgisayarınıza klonlamanız (indirmeniz) gerekmektedir.

```bash
git clone https://github.com/samoosama1/otonom-taksi.git 
```

## 2. Proje Dizinine Gitme
Klonlama işlemi tamamlandıktan sonra, proje klasörüne gitmeniz gerekir:

cd otonom-taksi

## 3. Yeni Bir Branch Oluşturma ve O Branch'e Geçme
Yaptığınız özellik veya düzeltme için yeni bir branch oluşturun ve bu branch'e geçin:

```bash
git checkout -b benim-ozellik-branchim
```

benim-ozellik-branchim yerine, yaptığınız işleme uygun, açıklayıcı bir isim verin. Örneğin, park algorithması üzerinde çalışıyorsanız dev/algoritma/park-etme gibi.

## 4. Mevcut Bir Branch'e Geçme
Eğer belirli bir branch üzerinde çalışmanız gerekiyorsa, o branch'e geçebilirsiniz:

```bash
git checkout main  # veya başka bir branch adı (ör: "develop")
```

main veya develop gibi genel branch'ler yerine, zaten var olan ve size atanan bir görevle ilgili olan bir branch'e geçmeniz gerekebilir.

## 5. Değişiklikleri Yapma
Bu adımda, projenin kodunda gerekli değişiklikleri yaparsınız:

## 6. Değişiklikleri Staging Area'ya Ekleme
Değişikliklerinizi commit'lemeden önce, onları "staging area"ya eklemeniz gerekir:

```bash
git add .  # Tüm değiştirilmiş ve yeni dosyaları ekler.
```

## 7. Değişiklikleri Commit'leme
Hazırladığınız değişiklikleri artık commit'leyebilirsiniz:

git commit -m "Yaptığım değişikliklerin açıklaması"

Commit mesajınızda ne yaptığınızı kısa ve öz bir şekilde açıklayın. Örneğin: dönme fonksiyonu eklendi.

## 8. Branch'i Remote'a Push'lama
Değişikliklerinizi commit'ledikten sonra, branch'inizi remote repoya (GitHub'a) göndermelisiniz:

```bash
git push origin benim-ozellik-branchim  # Yeni bir branch'i ilk kez push'larken bu kullanılır.
```

Eğer branch daha önce push'landıysa, sadece şunu kullanabilirsiniz:

```bash
git push
```

## 9. Pull Request Oluşturma

Değişikliklerinizi remote'a push'ladıktan sonra, GitHub üzerinde main'e "pull request" (birleştirme isteği) oluşturmanız gerekmektedir. Bu, değişikliklerinizin incelenmesi ve onaylanması için gereklidir.

Önemli Notlar
Her zaman branch'lerinizi güncel tutun: 

```bash
git pull origin main
```

Commit mesajlarınız açıklayıcı olsun.

Pull request oluşturmadan önce değişikliklerinizi test edin.

Takım lideriniz veya diğer geliştiriciler pull request'inizi inceleyip onaylayacaktır.

Takım olarak belirlediğiniz kodlama stili, branch isimlendirme kuralları veya commit mesajı formatı gibi standartlara uyun.


