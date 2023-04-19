# Controle-de-oficina

Microsserviços de Apis com simulação de leitura e processamento de QrCode com integração com banco de dados.


Foi criada uma Api de cadastro de serviços, que faz integração com uma segunda Api que faz a simulação de leitura de QrCode, através de uma pasta com os QrCodes sendo gerados automaticamente ao iniciar a aplicação  esendo escolhido de maneira randomica dentre os arquivos de QrCodes disponiveis. Os dados são os mesmos encontrados no banco de dados e que ao fazer a leitura através de um endpoint, pode ser validado acessando outro endpoint para comparação das informações presentes e então trazer o veículo e cliente cadastrado.

A Api principal tem endpoints que lista todos os serviços em execução, mostra o serviço em detalhes de acordo com id, filtra também todos os veículos ao qual um funcionário está trabalhando ou trabalhou, e faz a atualização do status e finaliza a hora do serviço ao passar também o id.

Tem script pronto com as modelagens das tabelas, e os dados são preenchidos automaticamnete ao iniciar a aplicação, se as tabelas estiverem vazias.


Acesso ao banco
username = postgres
password = 123456789
