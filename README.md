
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

![imagen](Morena.Escudero.Parcial/PrimerParcial/Diagrama.png)

#### Justificación técnica:

##### Clases

Se utilizaron 4 clases de instancia: 

* Vuelo contiene una sobrecarga de constructores. 

* Pasajero 

* Empleado 

* Avion

##### Abstracción

Utilizado en todas las clases teniendo en cuenta solo atributos que serán funcionales para el programa. Como por ejemplo en la clase Empleado, derivada de Persona, 
podría tener el atributo DNI como lo tiene Pasajero, sin embargo no es esencial saber el DNI de un Empleado para la funcionalidad del programa por lo que se descarta como 
un posible atributo.

##### Clases y métodos estáticos

Se utilizaron 2 clases estáticas: 

* Hardcodeo: utilizada para la simulación de una base de datos en donde se inicializan datos como literales.

* Aerolinea: se inicializan los datos pre-cargados de la clase Hardcodeo y se realiza la mayoría de las funciones principales para el correcto funcionamiento del 
programa como cálculos de ganancias, creación de clientes, etc. Contiene una sobrecarga de métodos.

A su vez las siguientes clases de instancia contienen métodos estáticos: 

* Vuelo GeneradorCodigoVuelo() genera un código alfanumérico random para que no sea responsabilidad del usuario hacerlo, se muestra en el FrontEnd al agregar un vuelo.

* Pasajero CalcularPrecio(bool, int, string) calcula el precio teniendo en cuenta la duración del vuelo, si el vuelo es nacional o internacional y la clase del pasajero, 
utilizado desde el formulario AltaPasajero. 

##### Namespace

Utilizado para separar el FrontEnd (Vista) con todos los formularios de Windows del BackEnd (Biblioteca) las clases.

##### Encapsulamiento

Utilizado en todas las clases para ocultar el funcionamiento de los atributos, métodos o de las clases mismas. Utilizo un enumerado para los Destinos, de esa forma es más
performante a la hora de trabajar con los origenes y los destinos de los vuelos ya que las variables son siempre las mismas.

##### Colecciones

* List: se utilizan colecciones de tipo List<> en su mayoría como atributos estáticos dentro de la clase Aerolinea para 

* Dictionary: se utiliza para crear una colección de empleados, con la Key que es utilizado como un ID se utiliza una función random para la funcionalidad del botón 
Autocompletar en el Login. 

##### Herencia

Se aplica una relación de herencia en la clase Persona con sus derivadas Empleado y Pasajero que heredan sus atributos (nombre y apellido) y sus propiedades.

##### Polimorfismo

Se utilizó 1 clase abstracta: 

* Persona

La cual contiene el método abstracto Calcular() que sobrescriben sus derivadas con el fin de utilizarlo para calcular el dinero gastado en pasajes en Pasajero y para 
calcular las comisiones en Empleado.

Se sobrescriben los métodos virtual ToString() en todas las clases de instancia con el propósito principal de mostrar información, GetHashCode() en la clase Pasajero 
y Equals() en Pasajero y en Vuelo.

#### Propuesta de valor agregado:

Se agregaron los siguientes extra feature:

* Facturación: luego de que se haga el alta de un pasajero o grupo familiar se elige entre los siguientes métodos de cobro:

** Tarjeta de crédito: se pide el ingreso de los datos de la tarjeta y del titular, según el tipo de tarjeta (Visa, Mastercard o American Express) se mostrarán las cuotas
con y sin interés. Las cuotas que tengan interés informan el recargo que se aplica sobre el precio de el/los pasaje/s.

** Tarjeta de débito: se piden los datos de la tarjeta y del titular de la misma realizando el pago en 1 cuota sin interés.

** Efectivo: se piden datos como la Situación Fiscal, CUIL o CUIT, el domicilio, etc. 

Las ganancias según el método de pago se podrán ver reflejadas en la sección Recaudación dentro de las estadísticas históricas.

* Filtro DNI: al hacer el alta de un pasajero se pide al usuario que el primer dato que se ingrese sea el DNI, esto se pide para que se realice un buscador entre los 
pasajeros existentes en la "base de datos" de la aerolinea de modo que si se encuentra alguna coincidencia se auto-complete los datos del pasajero como nombre, apellido y 
edad. 

* Filtro aviones disponibles: en vender vuelo, en el momento en que se ingresa el origen, destino, fecha de salida, clase y cantidad de pasajeros se utilizan los datos 
de cantidad de pasajeros, clase, origen y destino para hacer una busqueda en la "base de datos" de la aerolinea sobre los vuelos activos y corrobora que la cantidad de 
asientos disponibles de la clase elegida sea mayor o igual a la cantidad de pasajeros.

* Descuento menores de edad: sólo se pueden vender pasajes a menores de 12 años si están acompañados por un adulto responsable (mayor de 18 años), además se les realiza 
un descuento del 50% del pasaje y si son menores de 2 años se les realiza un descuento del 100% del pasaje.