FROM mcr.microsoft.com/dotnet/sdk:6.0
COPY . ./src
WORKDIR /src
RUN dotnet build web/myWebApp.csproj -o /app
RUN dotnet publish web/myWebApp.csproj -o /publish
WORKDIR /app
EXPOSE 80
CMD ["./myWebApp"]

