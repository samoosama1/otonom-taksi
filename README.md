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
