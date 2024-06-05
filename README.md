<div class="container">
        <header>
            <h1>Mesajlaşma Uygulaması</h1>
            <p>Bu proje, .NET, SignalR ve Angular kullanılarak geliştirilmiş bir mesajlaşma uygulamasıdır. Bu uygulama, kullanıcıların gerçek zamanlı olarak mesajlaşmasını sağlar ve modern web teknolojileri ile oluşturulmuştur.</p>
        </header>
        <nav>
            <ul>
                <li><a href="#ozellikler">Özellikler</a></li>
                <li><a href="#teknolojiler">Kullanılan Teknolojiler</a></li>
                <li><a href="#kurulum">Kurulum</a></li>
                <li><a href="#kullanim">Kullanım</a></li>
            </ul>
        </nav>
        <section id="ozellikler">
            <h2>Özellikler</h2>
            <ul>
                <li>Gerçek zamanlı mesajlaşma</li>
                <li>Kullanıcılar arasında özel sohbetler</li>
                <li>Mesaj geçmişi</li>
            </ul>
        </section>
        <section id="teknolojiler">
            <h2>Kullanılan Teknolojiler</h2>
            <ul>
                <li><a href="https://docs.microsoft.com/en-us/dotnet/core/" target="_blank">.NET Core</a></li>
                <li><a href="https://docs.microsoft.com/en-us/aspnet/core/signalr/introduction?view=aspnetcore-5.0" target="_blank">SignalR</a></li>
                <li><a href="https://docs.microsoft.com/en-us/dotnet/core/" target="_blank">MsSQL</a></li>
                <li><a href="https://angular.io/" target="_blank">Angular</a></li>
                <li><a href="https://docs.microsoft.com/en-us/ef/core/" target="_blank">Entity Framework Core</a></li>
            </ul>
        </section>
        <section id="kurulum">
            <h2>Kurulum</h2>
            <ol>
                <li>Bu repository'i klonlayın:
                    <pre><code>git clone https://github.com/enesdorukbasi/ChatApp.git</code></pre>
                </li>
                <li>Proje dizinine gidin:
                    <pre><code>cd ChatApp</code></pre>
                </li>
                <li>API projesini başlatmak için gerekli bağımlılıkları yükleyin:
                    <pre><code>cd ChatAppServer.WebAPI
dotnet restore
dotnet build
dotnet ef database update
dotnet run</code></pre>
                </li>
                <li>Angular uygulamasını başlatmak için gerekli bağımlılıkları yükleyin:
                    <pre><code>cd ChatAppClient
npm install
ng serve</code></pre>
                </li>
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
          </div>