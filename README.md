# gerenciamento-de-frotas

Aplicação com proposito para gerenciamento de veiculos!~

O que está funcionando?

- Cadastro, remoção e atualização de empresas e filiais.
- Cadastro, remoção e atualização de funcionarios das empresas.
- Sistema de cadastro, atualização, aluguel e devolução de veiculos.

O que está em desenvolvimento no momento?

<<<<<<< HEAD
- Sistema de estatisticas e relatorios
    - O Repositorio e Controladores já foram desenvolvidos
    - Já é possivel visualizar estatisticas sobre as empresas com mais funcionarios, Marcas mais usadas, Modelos mais usados, Disponibilidade de veiculos.
=======
- Sistema em geral
    - Falta desenvolver o controlador para DESATIVAÇÃO de empresas e suas devidas propriedades (Funcionarios e veiculos além das suas dividas). 

- Sistema de receita( recibos e cobranças )
    - Falta desenvolver o banco de dados
    - Falta desenvolver a integração com a aplicação
    - Falta desenvolver as Views relacionadas
    - Falta desenvolver as Classes e Modelos

- Observações 
    - Alterar a tabela de alugados na coluna Devolvido_em de NOT NULL para NULL, pois a coluna só deve ser preenchida depois dias após a criação do registro e não no momento em que o registro foi criado.
    - O sistema de cadastrato de veiculos não permitira a remoção de dados por motivos de controle de informações. Por isto não será possivel remover um veiculo do banco de dados pois existem informações que dependem da existencia desse registro. Veiculos que forem "Removidos" na verdade receberão um status de Inativo atraves de uma coluna no banco de dados.
    - Numero_cracha da tabela funcionarios Não pode ter indexaçao unica devido ao fato de poder repetir o valor só que em empresas diferentes... A mudança sera aplicada em breve.
>>>>>>> cf1e47252329c7e3b700fe88895380fc756b96e8


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
