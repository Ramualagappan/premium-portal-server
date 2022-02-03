# premium-portal-server

1) Build project in .NET Core WEB API
2) Configured Dependency Injection
3) Configured Swagger to test
4) Build Unit Test project to test the method

Hosted backend in Azure website:

Swagger screenshot
![image](https://user-images.githubusercontent.com/4916304/151703347-54919289-59f0-4019-990c-76c5a98a5578.png)

Unit test case results:

![image](https://user-images.githubusercontent.com/4916304/152348589-b1334613-e25e-49a5-bfdd-7e258b48fb2d.png)


Create LocalDB name PremiumCalculator

syntax: SqlLocalDB create PremiumCalculator

Performed Code First approach to create below 2 tables & references

Created table with Entity relationship. 

![image](https://user-images.githubusercontent.com/4916304/152349122-2a61e930-611c-4b83-a9da-4201ce06c36a.png)

Execute update-database in repository project 

Execute insert script from Script folder in repository project

OccupationRating table after inserting data

![image](https://user-images.githubusercontent.com/4916304/152349990-972e9189-7bf5-4f8b-94bc-bb0758b8d420.png)

Occupation table after inserting data

![image](https://user-images.githubusercontent.com/4916304/152350064-2d0c5c33-5e85-4ff0-815b-9820eac26efb.png)

CalculatePremium web api method call service using dependency injection, from service using Dbcontext include reference table and fetch data based on selected Occupation corresponding Rating id. Factor will be returned. After getting factor value perform calculation logic using formula and return monthly premium value to front end.


Front end display screenshot:

![image](https://user-images.githubusercontent.com/4916304/152351175-ddf77304-4bf8-4507-86e3-5d63e10f3c01.png)







