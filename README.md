# Instruktioner
.NET 6 krävs och SDK finns att ladda ner här: https://dotnet.microsoft.com/en-us/download/dotnet/6.0

Klona projektet och starta det genom Visual Studio.

Anrop görs till http://localhost:3000/count. API't tar emot en textinput i body, använd raw och text i postman.

Kommando för curl är *curl -d "textinput" -H "Content-Type: text/plain" http://localhost:3000/count*

Notering: Använder man Windows CMD för curl så verkar inte åäö fungera

![bild](https://user-images.githubusercontent.com/71646841/167213466-ee91bec7-900b-4d72-b488-0a0bb5482cfb.png)

