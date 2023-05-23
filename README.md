# This is Challenge By Coodesh

O desafio consiste em criar uma aplicação que receba uma lista em arquivo txt, normalize os dados e transforme esses dados para efetuar a persistência no banco.

A aplicação que eu criei foi uma server-client com o backend sendo uma API em .Net 5 com Swagger para ajudar na documentação dos endpoints. Já no front eu fiz em React 18.2.0.

## ENDPOINTS DISPONÍVEIS:
### /Save
![image](https://github.com/Gabrielrlf/ChallengeByCoodesh/assets/49160989/35c5c84c-15b9-4fc6-9d7e-bdb62c023b00)
Neste endpoint você envia uma string base64 que transforma em string e depois "serializa" em um objeto para após efetuar a persistência do dado.

### /GetAll
![image](https://github.com/Gabrielrlf/ChallengeByCoodesh/assets/49160989/2e845937-cfca-414f-a71b-c397301999f0)
Um endpoint que retorna todos as transações existentes. 

## Tecnologias utilizadas

<table>
  <tr>
    <td>.NET 5</td>
    <td>C#</td>
    <td>Swagger</td>
    <td>EF CORE</td>
    <td> AutoMapper </td>
    <td>SQLite</td>
    <td>Repository Patterns</td>
    <td>Modelagem DDD</td>
    <td>ReactJS + Vite</td>
    <td>Docker</td>
</table>

Menção honrosa para a biblioteca react-data-grid: https://adazzle.github.io/react-data-grid/#/common-features
Vídeo falando sobre a aplicação: https://www.loom.com/share/7e92ee9f66aa40b4b67f4155145b988a
