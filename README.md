# API .Net Core 2.0 -> Entity Framework + MVC

Este projeto se baseia na construção de uma API que realiza CRUD, este tem como foco aprender a utilizar melhor tecnologias as quais não domino totalmente.
O projeto tem como base o vídeo "Step by Step Tutorial - .Net Core MVC REST API" (https://www.youtube.com/watch?v=mUAZ-EbGBOg&t=1s), do canal de Les Jackson
***
## O que este projeto é?
***
Esse projeto é uma simples API que tem como função guardar, atualizar e pegar comandos úteis a desenvolvedores, no meu caso tentarei usar esse projeto para lembrar comandos úteis do git e do dotnet sendo rodado direto no visual studio code.
***
## Como rodar? 

Primeiro de tudo, esse projeto pede para que você tenha algumas dependências instaladas pelo NuGet, confira-as no CommandApi.csproj
Em segundo lugar, use as migrations que já criei para adicionar um banco de dados de acordo com o dbContext, essa migration só criara as tabelas, esse projeto não tem uma massa para teste pronta sempre que rodado (ainda). 
Use : dotnet ef database update;
Adicione manualmente no seu client SQL algum insert para teste, exemplo:
```sql
insert into Command values 
(
	1,
	"Make a github repository correspondent to a local git",
	"Enter a folder that has a git and execute it",
	"Git on windows and linux",
    "git remote add origin {project link}"
);
insert into Command values 
(
	2,
	"Add changes to a git branch before comitting",
	"Enter a folder that has a git and execute it",
	"Git on windows and linux",
    "add {files you want to add, can use '.' to add everything}"
);
select * from command;
```
Se algum erro acontecer, verifique se está usando sua base de dados.

Depois disso, use no CLI : dotnet run 
Use um aplicativo como insomnia e postman e acesse suas rotas,
***
## Contribua
Pull requests de todos os tipos são bem vindos, por exemplo, se quiser, pode incluir práticas de design pattern ou arquitetura de software no meu código a fim de indicar onde posso melhorar em certos aspectos.