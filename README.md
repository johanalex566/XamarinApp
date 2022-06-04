Johan Sánchez, clase 8-10

![image](https://user-images.githubusercontent.com/40399697/171969001-dfffdc04-1514-474e-866a-634cb21792d8.png)


![image](https://user-images.githubusercontent.com/40399697/171968817-d5f06992-835b-4a28-84f4-6b6a66ad7fd2.png)


Pendiente realizar operaciones y migración SQLite. Por ahora solo view

Examen Moviles 8 - 10
Junio 02
Desarrolle una aplicación para el cálculo de los pagos en una casa de apuestas.
La aplicación debe ser para móviles y debe almacenar la información en una base de datos sqlite
Se debe almacenar el documento del cliente, el nombre completo del cliente, el nombre del empleado,
la fecha de la apuesta, el valor de la apuesta, el valor de la ganancia, el valor de retención y 
el valor pagado.

Desarrolle una aplicación para calcular los pagos que tiene que realizar una casa de apuestas 
Las apuestas tienen un factor multiplicador para pagar: 2 a 1, 5 a 1, etc. Es decir, cuando se paga 2 a 1, 
le dan 2 pesos al apostador por cada peso apostado.
Sobre la ganancia se hace una retención proporcional a las ganancias obtenidas.
Por ganancias de menos de 300.000, no se hace retención.
Entre 300.000 y 1.000.000 se retiene el 20% de la utilidad,
entre 1.000.001 y 2.000.000 se retiene el 30%
Para ganancias de más de 2 millones se retiene el 35%.

Debe enviar un correo con una carpeta comprimida con su nombre. En la carpeta debe estar los archivos
de extensión .cs y .xaml
Se debe anexar un archivo en word con un pantallazo de la base de datos y las evidencias del funcionamiento
del programa (Si funciona)

****************************************************************************************
****************************************************************************************

Ejemplo: Se realiza una apuesta de $100.000 que paga 13.5 a 1
Valor apuesta: 100.000
Valor ganado: 100.000 * 13.5 = 1.350.000
Deducción: 30%
Valor deducción: 405.000
Valor a pagar: 1.350.000 - 405.000 + 100.000 = 1.045.000 
Se le paga la ganancia, menos la deducción, más lo que apostó.

Respuestas:
Valor apuesta: 100.000
Valor ganancia: 1.350.000
Deducción: 	  405.000
Total a pagar: 	1.045.000

