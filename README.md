<div class="container">
        <header>
            <h1>Mesajlaşma Uygulaması</h1>
            <p>Bu proje, .NET SignalR ve Angular kullanılarak geliştirilmiş bir mesajlaşma uygulamasıdır. Bu uygulama, kullanıcıların gerçek zamanlı olarak mesajlaşmasını sağlar ve modern web teknolojileri ile oluşturulmuştur.</p>
        </header>
        <nav>
            <ul>
                <li><a href="#ozellikler">Özellikler</a></li>
                <li><a href="#teknolojiler">Kullanılan Teknolojiler</a></li>
                <li><a href="#kurulum">Kurulum</a></li>
                <li><a href="#kullanim">Kullanım</a></li>
                <li><a href="#katkida-bulunma">Katkıda Bulunma</a></li>
                <li><a href="#lisans">Lisans</a></li>
            </ul>
        </nav>
        <section id="ozellikler">
            <h2>Özellikler</h2>
            <ul>
                <li>Gerçek zamanlı mesajlaşma</li>
                <li>Kullanıcı kimlik doğrulaması</li>
                <li>Kullanıcılar arasında özel sohbetler</li>
                <li>Mesaj geçmişi</li>
                <li>Responsive tasarım</li>
            </ul>
        </section>
        <section id="teknolojiler">
            <h2>Kullanılan Teknolojiler</h2>
            <ul>
                <li><a href="https://docs.microsoft.com/en-us/dotnet/core/" target="_blank">.NET Core</a></li>
                <li><a href="https://docs.microsoft.com/en-us/aspnet/core/signalr/introduction?view=aspnetcore-5.0" target="_blank">SignalR</a></li>
                <li><a href="https://angular.io/" target="_blank">Angular</a></li>
                <li><a href="https://docs.microsoft.com/en-us/ef/core/" target="_blank">Entity Framework Core</a></li>
                <li><a href="https://getbootstrap.com/" target="_blank">Bootstrap</a></li>
            </ul>
        </section>
        <section id="kurulum">
            <h2>Kurulum</h2>
            <ol>
                <li>Bu repository'i klonlayın:
                    <pre><code>git clone https://github.com/kullanici-adi/proje-adi.git</code></pre>
                </li>
                <li>Proje dizinine gidin:
                    <pre><code>cd proje-adi</code></pre>
                </li>
                <li>API projesini başlatmak için gerekli bağımlılıkları yükleyin:
                    <pre><code>cd backend
dotnet restore
dotnet build
dotnet ef database update
dotnet run</code></pre>
                </li>
                <li>Angular uygulamasını başlatmak için gerekli bağımlılıkları yükleyin:
                    <pre><code>cd frontend
npm install
ng serve</code></pre>
                </li>
                <li>Tarayıcınızda <a href="http://localhost:4200" target="_blank">http://localhost:4200</a> adresine gidin.</li>
            </ol>
        </section>
        <section id="kullanim">
            <h2>Kullanım</h2>
            <ol>
                <li>Ana sayfada, mevcut bir hesabınız yoksa kayıt olun veya giriş yapın.</li>
                <li>Sohbet başlatmak için bir kullanıcı seçin.</li>
                <li>Mesajlarınızı yazın ve gönderin. Mesajlar gerçek zamanlı olarak karşı tarafa iletilecektir.</li>
            </ol>
        </section>
        <section id="katkida-bulunma">
            <h2>Katkıda Bulunma</h2>
            <p>Katkılarınızı memnuniyetle karşılıyoruz! Lütfen aşağıdaki adımları izleyin:</p>
            <ol>
                <li>Projeyi fork edin</li>
                <li>Yeni bir branş oluşturun (<code>git checkout -b yeni-ozellik</code>)</li>
                <li>Değişikliklerinizi commit edin (<code>git commit -m 'Yeni özellik ekle'</code>)</li>
                <li>Branşınızı push edin (<code>git push origin yeni-ozellik</code>)</li>
                <li>Bir Pull Request oluşturun</li>
            </ol>
        </section>
        <section id="lisans">
            <h2>Lisans</h2>
            <p>Bu proje MIT Lisansı ile lisanslanmıştır. Daha fazla bilgi için <code>LICENSE</code> dosyasına bakın.</p>
        </section>
    </div>