-- Acesso à aplicação Online --

1. Endereço no Azure para aceder ao aplicativo : http://axadocarrier.azurewebsites.net/
2. Credenciais para autenticação perante o aplicativo : 
  .Username : Teste1, Password: Password1234! 
  .Username : Teste2, Password: Password1234!

-- Instalação --

1. A solução tem 4 projectos, que têm dependências para bibliotecas externas (nuget packages)
2. Abrir a solução no Visual Studio e efectuar Build da Solution, para assim ser feito o Restore dos Nuget Packages
3. No Web.Config do projecto WEB "AxadoCarrier", substituir os placeholders relativos às Connection Strings
3.1  <add name="AxadoCarrierDBContext" connectionString="Data Source={DataSource};Initial Catalog=AxadoCarrierDBContext;User ID={User};Password={Password};Trusted_Connection=False;MultipleActiveResultSets=True;" providerName="System.Data.SqlClient" />
     <add name="AxodoCarrierIdentityDbContext" connectionString="Data Source={DataSource};Initial Catalog=AxodoCarrierIdentityDbContext;User ID={User};Password={Password};Trusted_Connection=False;MultipleActiveResultSets=True;" providerName="System.Data.SqlClient" />
3.2 {DataSource} representa a instância de Base de Dados. No meu caso usei .\SQLEXPRESS 
3.3 {User} representa o nome do utilizador SQL Server
3.4 {Password} representa a password relativa ao {User} SQL Server
4. Não é necessário instalar Base de Dados, pois a 1ª vez que é criado o DBContext, o schema e inicialização de alguns dados, são feitos
de forma automática
5. A target Framework é a v4.5
