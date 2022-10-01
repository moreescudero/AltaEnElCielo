
# Alta en el cielo 




#### Sobre mi:

 

#### Resumen:

La aplicación se encarga de simular un ambiente de trabajo para una aerolinea, donde el empleado podrá agregar y vender vuelos a un cliente, visualizar pasajeros 
y consultar estadísticas históricas como vuelos finalizados, clientes con mayor concurrencia, ganancias totales, las comisiones de cada empleado, entre otros datos.

Al abrir el programa primero el usuario debe loggearse con un usuario y contraseña personal. Se agrego un botón de autocompletado para acelerar el acceso a la 
aplicación. Cuando se accede al menu principal, informa en una barra superior el usuario con el que se ingresó y la fecha actual. Desde el menu se puede acceder a las tres 
funcionalidades principales del programa que son: **visualizar vuelos**, **vender un pasaje** y **estadísticas históricas**. Si desea finalizar el programa puede presionar
el botón salir o cerrar sesión si desea cambiar de usuario manteniendo una persistencia de datos.

Ingresando en visualizar vuelos se cargarán todos los vuelos activos en una grilla con todos los datos correspondientes a cada uno ordenados en columnas, seleccionándolos 
desde la primer columna se habilitará un botón para ver los pasajeros de ese vuelo en específico. También desde esta ventana se puede agregar un vuelo permitiendo elegir
el origen, el destino y la fecha de salida, en función de esta última mencionada se mostrarán los aviones disponibles. Una vez agregado el vuelo se actualizará la grilla 
con el nuevo vuelo.

En vender un pasaje primero se deberá elegir el origen, destino, la fecha de salida deseada, la clase y la cantidad de pasajeros que contendrá el grupo familiar. Si se 
encontraron vuelos que contengan asientos disponibles según la clase del grupo familiar y, además, que coincidan con el origen y el destino elegidos se mostrará en una 
grilla, *la fecha de salida puede diferir de la deseada*, si no se encontraron vuelos lo informará. Si se desea también se puede agregar un vuelo según los datos ya
ingresados mientras la fecha de salida sea mayor a dentro de una semana ya que no se pueden programar vuelos con menor antelación. Una vez elegido el vuelo podremos ingresar 
los datos de los pasajeros y su cantidad de equipaje junto con el peso del mismo, cada vez que se cargue un pasajero podremos ver el precio bruto y neto del pasaje. Si 
el pasajero es mejor de 12  años se le aplicará un descuento y si es menor a 2 años viajará gratis, en ambos casos deben estar acompañados por un adulto responsable.
Una vez cargado todo el grupo familiar accederá a elegir el medio de pago pudiendo elegir entre tarjeta de crédito, débito y efectivo. 

Por último, en las estadísticas históricas podemos visualizar los vuelos finallizados y, según el vuelo que se seleccione, la lista de pasajeros correspondiente. También 
cuenta con una sección de ver estadísticas en donde podemos elegir entre visualizar: 

* las recaudaciones de la aerolinea según distintas categorías como por ejemplo ganancias por vuelos internacionales, por vuelos nacionales, ganancia 
según medio de pago, etc. 

* los pasajeros totales de la aerolinea. 

* los destinos por facturaciones 

* los pasajeros más frecuentes 

* la información de los aviones

* la información completa de la aerolinea, como empleados con sus comisiones, vuelos con mayor recaudación, etc.


#### Diagrama de clases:

![imagen](Morena.Escudero.PrimerParcial/Diagrama.jpg)

#### Justificación técnica:



#### Propuesta de valor agregado: