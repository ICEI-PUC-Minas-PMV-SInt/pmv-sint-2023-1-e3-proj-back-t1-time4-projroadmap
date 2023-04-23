# Especificações do Projeto

Os detalhes levantados nesse processo foram consolidados na forma de personas e histórias de usuários.

## Personas

As personas levantadas durante o processo de entendimento do problema são apresentadas abaixo.
Enumere e detalhe as personas da sua solução. Para tanto, baseie-se tanto nos documentos disponibilizados na disciplina e/ou nos seguintes links:

||descrição|
|--|--|
|![image](https://user-images.githubusercontent.com/22857183/232915484-2bae653c-88f9-4a27-a4e9-edeebd28d68c.png)| **João Pedro**, 24 anos, solteiro, graduando do 4º período do curso de Sistemas de Informação; atualmente trabalha como atendente de balcão em uma lanchonete no centro de Belo Horizonte e está em busca de uma oportunidade para trabalhar na área em que está se graduando, mas se sente inseguro para realizar os testes técnicos das entrevistas. Aplicativos: Instagram, Whatsapp, Aplicativos de banco, Duolingo. |
|![image](https://user-images.githubusercontent.com/22857183/232915859-6909b756-e2b6-49ee-aad4-b92d39237f2d.png)|**Aretha**, 32 anos, graduada em Design, atualmente está no segundo curso de graduação tecnológica, em Sistemas para a Internet. Ela deseja unir o seu conhecimento de design gráfico aos da nova graduação, de modo a se especializar em Desenvolvimento Front-end. Aplicativos: Youtube, Udemy, Gran Concursos questões.|
|![image](https://user-images.githubusercontent.com/22857183/232915820-a3b8f1fd-5081-4aab-88cd-fddbc29a0e54.png)|**Amanda Ribeiro**, 28 anos, recém-graduada em Análise e Desenvolvimento de Sistemas e já atuou profissionalmente no desenvolvimento de sistemas. Atualmente encontra-se desempregada e está em busca de recolocação no mercado de trabalho. Aplicativos: Linkedin, Fast-Food, sites de compra como Amazon, Passei direto.|
|![image](https://user-images.githubusercontent.com/22857183/232915884-6fbe4485-cb7f-4506-be37-e442480e68bc.png)|**Wallace**, 40 anos. Formado em pedagogia e trabalha em uma escola na periferia da cidade de Sabará, mas pretende fazer uma transição de carreira para trabalhar com desenvolvimento de sistemas. Estuda pela internet, pois precisa de flexibilidade nos estudos para conciliá-lo com o atual trabalho e família. Aplicativos: Focus Concursos, MercadoLivre, Telegram, Trello. |
|![image](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-1-e3-proj-back-t1-time4-projroadmap/blob/ad39883f46f0a1e49ae872126d564cb9b6ff2967/docs/img/Eduardo.jpg)|**Eduardo**, 19 anos. Estudante de programação que está se preparando para ingressar no mercado de trabalho. Ele utiliza diversos recursos online para aprimorar seus conhecimentos em programação, como cursos, tutoriais e testes. Ao finalizar cada teste, Luiz tem o hábito de verificar seu resultado para avaliar seu progresso e identificar os pontos que precisa melhorar. Aplicativos: Caixa, Cursera Aliexpress, Udemy. |
|![image](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-1-e3-proj-back-t1-time4-projroadmap/blob/ad39883f46f0a1e49ae872126d564cb9b6ff2967/docs/img/Fabiana.jpg)|**Fabiana**, 23 anos. desenvolvedora front-end que está sempre em busca de novos conhecimentos e ferramentas para aprimorar suas habilidades. Ela frequentemente usa sites de teste de conhecimentos em programação front-end para avaliar seu nível de conhecimento.. Aplicativos: Wester Union, Twitter, Skype. |
|![image](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-1-e3-proj-back-t1-time4-projroadmap/blob/ad39883f46f0a1e49ae872126d564cb9b6ff2967/docs/img/Gabriel.jpg)|**Gabriel**, 32 anos. Analista de sistemas que está sempre em busca de novas tecnologias e ferramentas para aprimorar suas habilidades. No entanto, ele se preocupa bastante com a segurança das plataformas que utiliza. Aplicativos: LinkedIn, Cursera, Calm, Gympass. |


## Histórias de Usuários

A partir da compreensão do dia a dia das personas identificadas para o projeto, foram registradas as seguintes histórias de usuários.

A partir da compreensão do dia a dia das personas identificadas para o projeto, foram registradas as seguintes histórias de usuários.


|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|João Pedro | Como um usuário que está visitando o site pela primeira vez, eu gostaria de ver uma explicação clara e concisa do objetivo do site na página principal. | Para que eu possa entender se o propósito do site atende aos meus objetivos.|
|Aretha | quero encontrar testes desafiadores em áreas relevantes aos meus objetivos | para me especializar em Desenvolvimento Front-end|
|Amanda Ribeiro       | quero uma plataforma online que ofereça, de forma prática, questões de múltipla escolha para aprimorar o meu conhecimento programação front-end. | para conseguir uma recolocação no mercado de trabalho. |
|Wallace | quero ter a opção de voltar às questões anteriores | para revisar minhas respostas antes de submetê-las para avaliação. |
|Eduardo | preciso visualizar meu resultado ao fim de cada teste | para avaliar meu progresso nos estudos. |
|Fabiana | preciso de recursos que facilitem a navegação | para poder explorar todo o conteúdo do site de forma descomplicada. |
|Gabriel | quero uma plataforma online segura que exija autenticação para acessar ao conteúdo | para me sentir mais seguro ao utilizar o site. |

## Requisitos

Os requisitos deste projeto priorizam uma plataforma com interface de usuário simplificada e eficiente. É importante enfatizar a utilização correta do modelo MVC e do framework ASP.NET, bem como a implementação adequada de classes, métodos e banco de dados


### Requisitos Funcionais
A tabela a seguir apresenta os requisitos do projeto, identificando a prioridade em que os mesmos devem ser entregues.

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-01|O site deve apresentar, em sua página principal, um texto explicativo e conciso quanto ao seu propósito. | Alta|
|RF-02|O site deve permitir, na página inicial, a escolha dos temas de testes disponíveis. | Alta|
|RF-03|Ao selecionar um tema, o sistema deve carregar o questionário selecionado, sem a necessidade de outro botão para confirmar a escolha.| Média|
|RF-04|O sistema deverá possibilitar a revisão das questões antes de submeter o questionário para avaliação. | Média|
|RF-05|O sistema deve apresentar ao usuário uma página com seus erros e acertos após submeter o questionário para avaliação. | Alta|
|RF-06|O sistema deve permitir retornar à home page a partir de qualquer página do site. | Média|
|RF-07|O sistema deve exigir autenticação para o acesso à sessão de todos os usuários. | Alta|

### Requisitos não Funcionais
A tabela a seguir apresenta os requisitos não funcionais que o projeto deverá atender.

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-01|O site deve ser publicado em um ambiente acessível na Internet | Alta|
|RNF-02|O site deverá ser responsivo, permitindo a visualização adequada em dispositivos móveis, como smartphones e tablets..| Alta|
|RNF-03|O site deve ter bom nível de contraste entre os elementos da tela.| Média|
|RNF-04|O site deve ser compatível com os principais navegadores do mercado, incluindo Google Chrome, Mozilla Firefox, Microsoft Edge e Safari.| Alta|
|RNF-05|As questões devem ser apresentadas ao usuário em sequência, uma de cada vez, para garantir a facilidade de uso e evitar sobrecarga cognitiva.| Alta|
|RNF-06|Os temas de questões oferecidos ao usuário são, HTML, CSS e JavaScript.| Média|
|RNF-07|O código HTML deve implementar, mesmo que minimamente, boas práticas de acessibilidade.| Média|


## Restrições

As questões que limitam a execução desse projeto e que se configuram como obrigações claras para o desenvolvimento do projeto em questão, são apresentadas na tabela a seguir:

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|RE-01|O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data final do projeto.|
|RE-02|A equipe não pode subcontratar o desenvolvimento do trabalho.|
|RE-03|Não é permitido o uso de plataformas, low-code e no-code.|


## Diagrama de Casos de Uso
![image](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-1-e3-proj-back-t1-time4-projroadmap/blob/b3a1f9e04f514c64a4195874a91c168bd206738a/docs/img/Diagrama-casos-de-uso-v3.png)


 
