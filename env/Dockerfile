FROM mcr.microsoft.com/dotnet/sdk:5.0.202
ENV LANG en_US.UTF-8
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT false

WORKDIR /src
COPY . .
RUN chmod +x env/runner.sh
ENTRYPOINT ["env/runner.sh"]
