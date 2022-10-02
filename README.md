
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

![imagen](Morena.Escudero.Parcial/PrimerParcial/Diagrama.png)

#### Justificaci�n t�cnica:

##### Clases

Se utilizaron 4 clases de instancia: 

* Vuelo contiene una sobrecarga de constructores. 

* Pasajero 

* Empleado 

* Avion

##### Abstracci�n

Utilizado en todas las clases teniendo en cuenta solo atributos que ser�n funcionales para el programa. Como por ejemplo en la clase Empleado, derivada de Persona, 
podr�a tener el atributo DNI como lo tiene Pasajero, sin embargo no es esencial saber el DNI de un Empleado para la funcionalidad del programa por lo que se descarta como 
un posible atributo.

##### Clases y m�todos est�ticos

Se utilizaron 2 clases est�ticas: 

* Hardcodeo: utilizada para la simulaci�n de una base de datos en donde se inicializan datos como literales.

* Aerolinea: se inicializan los datos pre-cargados de la clase Hardcodeo y se realiza la mayor�a de las funciones principales para el correcto funcionamiento del 
programa como c�lculos de ganancias, creaci�n de clientes, etc. Contiene una sobrecarga de m�todos.

A su vez las siguientes clases de instancia contienen m�todos est�ticos: 

* Vuelo GeneradorCodigoVuelo() genera un c�digo alfanum�rico random para que no sea responsabilidad del usuario hacerlo, se muestra en el FrontEnd al agregar un vuelo.

* Pasajero CalcularPrecio(bool, int, string) calcula el precio teniendo en cuenta la duraci�n del vuelo, si el vuelo es nacional o internacional y la clase del pasajero, 
utilizado desde el formulario AltaPasajero. 

##### Namespace

Utilizado para separar el FrontEnd (Vista) con todos los formularios de Windows del BackEnd (Biblioteca) las clases.

##### Encapsulamiento

Utilizado en todas las clases para ocultar el funcionamiento de los atributos, m�todos o de las clases mismas. Utilizo un enumerado para los Destinos, de esa forma es m�s
performante a la hora de trabajar con los origenes y los destinos de los vuelos ya que las variables son siempre las mismas.

##### Colecciones

* List: se utilizan colecciones de tipo List<> en su mayor�a como atributos est�ticos dentro de la clase Aerolinea para 

* Dictionary: se utiliza para crear una colecci�n de empleados, con la Key que es utilizado como un ID se utiliza una funci�n random para la funcionalidad del bot�n 
Autocompletar en el Login. 

##### Herencia

Se aplica una relaci�n de herencia en la clase Persona con sus derivadas Empleado y Pasajero que heredan sus atributos (nombre y apellido) y sus propiedades.

##### Polimorfismo

Se utiliz� 1 clase abstracta: 

* Persona

La cual contiene el m�todo abstracto Calcular() que sobrescriben sus derivadas con el fin de utilizarlo para calcular el dinero gastado en pasajes en Pasajero y para 
calcular las comisiones en Empleado.

Se sobrescriben los m�todos virtual ToString() en todas las clases de instancia con el prop�sito principal de mostrar informaci�n, GetHashCode() en la clase Pasajero 
y Equals() en Pasajero y en Vuelo.

#### Propuesta de valor agregado:

Se agregaron los siguientes extra feature:

* Facturaci�n: luego de que se haga el alta de un pasajero o grupo familiar se elige entre los siguientes m�todos de cobro:

** Tarjeta de cr�dito: se pide el ingreso de los datos de la tarjeta y del titular, seg�n el tipo de tarjeta (Visa, Mastercard o American Express) se mostrar�n las cuotas
con y sin inter�s. Las cuotas que tengan inter�s informan el recargo que se aplica sobre el precio de el/los pasaje/s.

** Tarjeta de d�bito: se piden los datos de la tarjeta y del titular de la misma realizando el pago en 1 cuota sin inter�s.

** Efectivo: se piden datos como la Situaci�n Fiscal, CUIL o CUIT, el domicilio, etc. 

Las ganancias seg�n el m�todo de pago se podr�n ver reflejadas en la secci�n Recaudaci�n dentro de las estad�sticas hist�ricas.

* Filtro DNI: al hacer el alta de un pasajero se pide al usuario que el primer dato que se ingrese sea el DNI, esto se pide para que se realice un buscador entre los 
pasajeros existentes en la "base de datos" de la aerolinea de modo que si se encuentra alguna coincidencia se auto-complete los datos del pasajero como nombre, apellido y 
edad. 

* Filtro aviones disponibles: en vender vuelo, en el momento en que se ingresa el origen, destino, fecha de salida, clase y cantidad de pasajeros se utilizan los datos 
de cantidad de pasajeros, clase, origen y destino para hacer una busqueda en la "base de datos" de la aerolinea sobre los vuelos activos y corrobora que la cantidad de 
asientos disponibles de la clase elegida sea mayor o igual a la cantidad de pasajeros.

* Descuento menores de edad: s�lo se pueden vender pasajes a menores de 12 a�os si est�n acompa�ados por un adulto responsable (mayor de 18 a�os), adem�s se les realiza 
un descuento del 50% del pasaje y si son menores de 2 a�os se les realiza un descuento del 100% del pasaje.