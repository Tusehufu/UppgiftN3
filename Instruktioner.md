# Requirements 
Node.js
Vue CLI
# Nuget packages:
Dapper
Microsoft.AspNetCore.SpaServices.Extensions
Swashbuckle.AspNetCore
Microsoft.Extensions.ApiDescription.Server
Microsoft.Extensions.FileProviders.Abstractions
Microsoft.Extensions.FileProviders.Physical
Microsoft.Extensions.FileSystemGlobbing
Microsoft.Extensions.Primitives
Microsoft.OpenApi
Swashbuckle.AspNetCore.Swagger
Swashbuckle.AspNetCore.SwaggerGen
Swashbuckle.AspNetCore.SwaggerUI

### Installation av vue cli:
Jobba kommandot i kommandotolken.
npm install -g @vue/cli

### Hur man startar projektet
Högerklicka på mappen clientapp i visual studio och öppna den i file explorer. Töm sedan sökvägsfältet och skriv in "cmd ."
I kommandotolken som öppnas skriver du in "npm run serve". Då byggs programmet.
Sedan trycker du på kör programmet knappen i visual studio, välj http. 

När programmet körs öppnas API sidan på localhost/5050, ändra adressen till det som visas i kommandotolken från clientmappen. Förmodligen http://localhost:8080/.