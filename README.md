# gerenciamento-de-frotas

Aplicação com proposito para gerenciamento de veiculos!~

O que está funcionando?

- Cadastro, remoção e atualização de empresas e filiais.
- Cadastro, remoção e atualização de funcionarios das empresas.

O que está em desenvolvimento no momento?

- Sistema de estatisticas e relatorios
    - O Repositorio e Controladores já foram desenvolvidos
    - Já é possivel visualizar estatisticas sobre as empresas com mais funcionarios, Marcas mais usadas, Modelos mais usados, Disponibilidade de veiculos.


O que falta fazer?

- Sistema de recibos onde serão armazenados as despesas da empresa com gasolina e manutenção dos veiculos.
- Sistema de usuarios locais
- Sistema de comunicação com API mobile.


Instruções para uso

- Instale o Microsoft SQl Server Express em seu computador
- Instale o SSMS para realizar a restauração do Arquivo do banco de dados no servidor
- Execute a aplicação e faça um novo registro.


O que há de novo?
- 27/10/2019 .. 00:57 
- Correção de bug que estava duplicando registros ao atualizar
- Adição de indexação unica para as colunas CNPJ na tabela empresas e na tabela funcionarios os campos CPF, CNH e Numero_Cracha receberam indexação unica

- 29/10/2019
- Já é possivel cadastrar e editar veiculos no banco de dados
- Alteração no design do programa.

- 30/10/2019
- Adição do Padrão MVC para melhor leitura do código.

Prazo para finalizar 26 de Novembro de 2019
