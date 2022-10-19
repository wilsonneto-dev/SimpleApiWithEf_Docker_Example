FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /app
COPY *.csproj ./
RUN dotnet restore
COPY . ./
RUN dotnet publish -c Release -o out
ENTRYPOINT [ "dotnet", "out/SimpleApiWithEfInDocker.dll" ]