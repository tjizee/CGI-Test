# Instruktioner
.NET 6 krävs, SDK finns att ladda ner här: https://dotnet.microsoft.com/en-us/download/dotnet/6.0

Klona projektet och starta det genom Visual Studio. 

![bild](https://user-images.githubusercontent.com/71646841/167247744-5231ab28-c2ba-4219-8da4-c2a5125322f2.png)

Anrop görs till http://localhost:3000/count. API't tar emot en textinput i body, använd raw och text i postman.

Kommando för curl är **curl -d "textinput" -H "Content-Type: text/plain" http://localhost:3000/count**

Notering: Använder man Windows CMD för curl så verkar inte åäö fungera

![bild](https://user-images.githubusercontent.com/71646841/167247356-05649977-2aa7-4f63-890e-d253b7686f79.png)


