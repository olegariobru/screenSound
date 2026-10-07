# Screen Sound — C#

Aplicação de console para cadastrar bandas, registrar avaliações e consultar a média das notas. Desenvolvida como projeto de estudo durante um curso de C# da Alura.

## Demonstração

![Menu do Screen Sound](https://github.com/olegariobru/screenSound/assets/50889311/2ab50da0-cce5-4d3d-80ac-64c927219098)

## Funcionalidades

- Cadastro e listagem de bandas.
- Registro de notas por banda.
- Cálculo da média de avaliações.
- Navegação por menu no terminal.

## Tecnologias e conceitos

C#, .NET, funções, listas e dicionários. O projeto atualmente utiliza o alvo `net6.0`, definido em `Program/Program.csproj`.

## Como executar

Pré-requisito: ambiente .NET capaz de compilar e executar o alvo `net6.0`.

```bash
git clone https://github.com/olegariobru/screenSound.git
cd screenSound
dotnet run --project Program/Program.csproj
```

Para compilar:

```bash
dotnet build Program/Program.csproj
```

## Organização

- `Program.sln`: solução.
- `Program/Program.csproj`: configuração do projeto.
- `Program/Program.cs`: menu e operações sobre bandas.

## Limitações e próximos passos

Os registros ficam em memória e são perdidos ao encerrar o programa. Ainda não há testes automatizados. As próximas melhorias incluem validação de entradas, persistência e atualização do alvo .NET.

As pastas `bin/` e `obj/` existentes são produtos de compilação; o código-fonte está em `Program/Program.cs`.

## Como contribuir

Abra uma issue com o problema ou a melhoria proposta. Para enviar código, crie um fork e uma branch, mantenha a alteração focada e abra um pull request explicando o resultado e como verificou o funcionamento.

## Licença

Este repositório ainda não contém um arquivo `LICENSE`. A licença de uso e redistribuição precisa ser formalizada pelo autor.

## Autor

[Bruno Olegário](https://github.com/olegariobru) · [LinkedIn](https://www.linkedin.com/in/bolgarimacedo/)
