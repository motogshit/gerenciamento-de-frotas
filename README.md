# Gerenciamento de Frotas

- Conecte ao arquivo de banco de dados .MDF ou ao servidor SQL Express com as tabelas presentes no Arquivo BancoDeDadosSQL.sql
- Adicione dentro da pasta model um novo item ADO.NET Entity Framework > Nome: systemDB> Code First From Database > Selecione a sua fomra de conexão desejada (Arquivo ou Servidor de banco de dados) >Selecione Todas as tabelas
- Compile o seu programa!

# Em caso de erro no ReportViewer 
- Abra o gerenciador de pacotes NuGet e adicione ao projeto o componente Microsoft.ReportingServices.ReportViewerControl.Winforms V150.1400.0
- Compile e execute

# Caso o seu ambiente não possua o Microsoft RDLC Report Designer para Visual Studio
- Abra o Visual Studio
- Abra o menu Extensões > Gerenciar Extensões
- Busque por: Microsoft Rdlc Report Designer
- Instale a extensão > feche o Visual Studio
- Um dialogo sera aberto > Aperte em modificar e aguarde o fim da instalação
- Agora abra o projeto e compile o programa!