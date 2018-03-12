# Desafio
Project is a WebAPI developed using .Net Core and postgres Database. 
The objective was to test myself into the tecnology.

##What does your API do?
Manage a Custumer´s list.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites
* .Net Core Framework
* Visual Studio 2017 / Visual Studio Code
* PostgreSQL server if you want, it´s possible to use InMemoryDatabase. 


```
services.AddEntityFrameworkNpgsql().AddDbContext<DesafioContext>
                (options => options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));
                
                #or
                
                
services.AddDbContext<DesafioContext>(options => options.UseInMemoryDatabase("DesafioDB"));
```

## Automated Tests

Some tests are already implemented into Desafio solution
just need to run the tests

## Deployment
This Project was ment to be deployed on Heroku service.
It also cam be deployed on any server, becouse .Net Core is multi-plataform.

## Built With
* [Visual Studio 2017](https://www.visualstudio.com/pt-br/downloads/) - IDE
* [.Net Core](https://www.microsoft.com/net/download/windows) - The framework used
* [Heroku](https://www.heroku.com) - Cloud Application Platform
* [GitHub](https://github.com/) - Used to visibility and versioning web repository
* [Postman](https://www.getpostman.com/) -  API Development Environmen]

## Versioning
For the versions available, see the [Desafio](https://github.com/GesualdoCrocco/Desafio). 

# Desafio API Sample Calls
## GET - GetAll
```
curl --request GET \
  --url https://gesualdodesafio.herokuapp.com/api/Customer/
```
Chamada retorna todos os registros armazenados.


## GET - GetById
```
curl --request GET \
  --url https://gesualdodesafio.herokuapp.com/api/Customer/1 \
  --header 'Content-Type: application/json'
```
Chamada obtem um registro expecífico atravéz do ID.


## POST - Inser/Update
```
curl --request POST \
  --url https://gesualdodesafio.herokuapp.com/api/Customer/ \
  --header 'content-type: multipart/form-data; boundary=----WebKitFormBoundary7MA4YWxkTrZu0gW' \
  --form 'name=Bonie Taylor' \
  --form email=bonie@hotmail.com
```
Chamada Insert/Update Tem como chave única o EMAIL, se não existe Acrescenta, se existe atualiza o registro.


## PUT - Inser/Update
```
curl --request PUT \
  --url https://gesualdodesafio.herokuapp.com/api/Customer/ \
  --header 'content-type: multipart/form-data; boundary=----WebKitFormBoundary7MA4YWxkTrZu0gW' \
  --form 'name=Bonie Taylor Madson' \
  --form email=bonie@hotmail.com
```
Chamada Put Insert/Update, Dependendo da existência do email.


## License

This project is not licensed under any License - so feel free to use it. 

