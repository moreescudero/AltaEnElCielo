
# Alta en el cielo 




#### Sobre mi:

 

#### Resumen:

La aplicaci�n se encarga de simular un ambiente de trabajo para una aerolinea, donde el empleado podr� agregar y vender vuelos a un cliente, visualizar pasajeros 
y consultar estad�sticas hist�ricas como vuelos finalizados, clientes con mayor concurrencia, ganancias totales, las comisiones de cada empleado, entre otros datos.

Al abrir el programa primero el usuario debe loggearse con un usuario y contrase�a personal. Se agrego un bot�n de autocompletado para acelerar el acceso a la 
aplicaci�n. Cuando se accede al menu principal, informa en una barra superior el usuario con el que se ingres� y la fecha actual. Desde el menu se puede acceder a las tres 
funcionalidades principales del programa que son: **visualizar vuelos**, **vender un pasaje** y **estad�sticas hist�ricas**. Si desea finalizar el programa puede presionar
el bot�n salir o cerrar sesi�n si desea cambiar de usuario manteniendo una persistencia de datos.

Ingresando en visualizar vuelos se cargar�n todos los vuelos activos en una grilla con todos los datos correspondientes a cada uno ordenados en columnas, seleccion�ndolos 
desde la primer columna se habilitar� un bot�n para ver los pasajeros de ese vuelo en espec�fico. Tambi�n desde esta ventana se puede agregar un vuelo permitiendo elegir
el origen, el destino y la fecha de salida, en funci�n de esta �ltima mencionada se mostrar�n los aviones disponibles. Una vez agregado el vuelo se actualizar� la grilla 
con el nuevo vuelo.

En vender un pasaje primero se deber� elegir el origen, destino, la fecha de salida deseada, la clase y la cantidad de pasajeros que contendr� el grupo familiar. Si se 
encontraron vuelos que contengan asientos disponibles seg�n la clase del grupo familiar y, adem�s, que coincidan con el origen y el destino elegidos se mostrar� en una 
grilla, *la fecha de salida puede diferir de la deseada*, si no se encontraron vuelos lo informar�. Si se desea tambi�n se puede agregar un vuelo seg�n los datos ya
ingresados mientras la fecha de salida sea mayor a dentro de una semana ya que no se pueden programar vuelos con menor antelaci�n. Una vez elegido el vuelo podremos ingresar 
los datos de los pasajeros y su cantidad de equipaje junto con el peso del mismo, cada vez que se cargue un pasajero podremos ver el precio bruto y neto del pasaje. Si 
el pasajero es mejor de 12  a�os se le aplicar� un descuento y si es menor a 2 a�os viajar� gratis, en ambos casos deben estar acompa�ados por un adulto responsable.
Una vez cargado todo el grupo familiar acceder� a elegir el medio de pago pudiendo elegir entre tarjeta de cr�dito, d�bito y efectivo. 

Por �ltimo, en las estad�sticas hist�ricas podemos visualizar los vuelos finallizados y, seg�n el vuelo que se seleccione, la lista de pasajeros correspondiente. Tambi�n 
cuenta con una secci�n de ver estad�sticas en donde podemos elegir entre visualizar: 

* las recaudaciones de la aerolinea seg�n distintas categor�as como por ejemplo ganancias por vuelos internacionales, por vuelos nacionales, ganancia 
seg�n medio de pago, etc. 

* los pasajeros totales de la aerolinea. 

* los destinos por facturaciones 

* los pasajeros m�s frecuentes 

* la informaci�n de los aviones

* la informaci�n completa de la aerolinea, como empleados con sus comisiones, vuelos con mayor recaudaci�n, etc.


#### Diagrama de clases:

![imagen](Morena.Escudero.PrimerParcial/Diagrama.jpg)

#### Justificaci�n t�cnica:



#### Propuesta de valor agregado: