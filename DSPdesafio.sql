

-- Tabla: Restaurante
CREATE TABLE Restaurante (
    RestauranteID INT PRIMARY KEY,
    Nombre VARCHAR(255),
    Direccion VARCHAR(255),
    Telefono VARCHAR(20),
    Horario VARCHAR(100),
    TipoCocina VARCHAR(100)
);

-- Tabla: Clientes
CREATE TABLE Clientes (
    ClienteID INT PRIMARY KEY,
    Nombre VARCHAR(255),
    Direccion VARCHAR(255),
    Telefono VARCHAR(20),
    CorreoElectronico VARCHAR(255),
    RestauranteID INT,
    FOREIGN KEY (RestauranteID) REFERENCES Restaurante(RestauranteID)
);

-- Tabla: Empleados
CREATE TABLE Empleados (
    EmpleadoID INT PRIMARY KEY,
    Nombre VARCHAR(255),
    Puesto VARCHAR(100),
    Salario DECIMAL(10, 2),
    HorarioLaboral VARCHAR(100),
    RestauranteID INT,
    FOREIGN KEY (RestauranteID) REFERENCES Restaurante(RestauranteID)
);

-- Tabla: Pedidos
CREATE TABLE Pedidos (
    PedidoID INT PRIMARY KEY,
    ClienteID INT,
    FechaHora DATETIME,
    Estado VARCHAR(50),
    FOREIGN KEY (ClienteID) REFERENCES Clientes(ClienteID)
);

-- Tabla: Productos
CREATE TABLE Productos (
    ProductoID INT PRIMARY KEY,
    Nombre VARCHAR(255),
    Descripcion VARCHAR(500),
    Precio DECIMAL(10, 2),
    CategoriaID INT,
    FOREIGN KEY (CategoriaID) REFERENCES CategoriasProductos(CategoriaID)
);




-- Tabla: Ofertas
CREATE TABLE Ofertas (
    OfertaID INT PRIMARY KEY,
    Nombre VARCHAR(255),
    PorcentajeDescuento DECIMAL(5, 2),
    FechasValidas VARCHAR(100),
    ProductoID INT,
    FOREIGN KEY (ProductoID) REFERENCES Productos(ProductoID)
);

-- Tabla: EstadisticasBar
CREATE TABLE EstadisticasBar (
    EstadisticasID INT PRIMARY KEY,
    Ingresos DECIMAL(10, 2),
    BebidasPopulares VARCHAR(500),
    RestauranteID INT,
    FOREIGN KEY (RestauranteID) REFERENCES Restaurante(RestauranteID)
);

-- Tabla: MetodosPago
CREATE TABLE MetodosPago (
    MetodoPagoID INT PRIMARY KEY,
    Nombre VARCHAR(100)
);

-- Tabla: CategoriasProductos
CREATE TABLE CategoriasProductos (
    CategoriaID INT PRIMARY KEY,
    Nombre VARCHAR(100),
    Descripcion VARCHAR(500)
);

-- Tabla: EventosEspeciales
CREATE TABLE EventosEspeciales (
    EventoID INT PRIMARY KEY,
    NombreEvento VARCHAR(255),
    FechaEvento DATE,
    Descripcion VARCHAR(500)
);

-- Tabla: ProveedoresServicios
CREATE TABLE ProveedoresServicios (
    ProveedorID INT PRIMARY KEY,
    NombreEmpresa VARCHAR(255),
    TipoServicio VARCHAR(100),
    Contacto VARCHAR(255)
);

-- Tabla: ProgramaLealtadFidelidad
CREATE TABLE ProgramaLealtadFidelidad (
    ClienteID INT PRIMARY KEY,
    PuntosAcumulados INT,
    NivelMembresia VARCHAR(50),
    Beneficios VARCHAR(500)
);

-- Tabla: MenusEspeciales
CREATE TABLE MenusEspeciales (
    MenuID INT PRIMARY KEY,
    NombreMenu VARCHAR(255),
    PlatosIncluidos VARCHAR(500),
    Precio DECIMAL(10, 2)
);



CREATE TABLE HistorialPedidos (
    ClienteID INT,
    ProductoID INT,
    TotalPagado DECIMAL(10, 2),
    FOREIGN KEY (ClienteID) REFERENCES Clientes(ClienteID),
    FOREIGN KEY (ProductoID) REFERENCES Productos(ProductoID)
);








-- Tabla: Ingredientes
CREATE TABLE Ingredientes (
    IngredienteID INT PRIMARY KEY,
    Nombre VARCHAR(255),
    CantidadEnStock DECIMAL(10, 2),
    Proveedor VARCHAR(255)
);

-- Tabla: Mesas
CREATE TABLE Mesas (
    MesaID INT PRIMARY KEY,
    NumeroMesa INT,
    Capacidad INT,
    Ubicacion VARCHAR(255)
);

-- Tabla: Reservas
CREATE TABLE Reservas (
    ReservaID INT PRIMARY KEY,
    FechaHoraReserva DATETIME,
    ClienteID INT,
    NumeroComensales INT,
    FOREIGN KEY (ClienteID) REFERENCES Clientes(ClienteID)
);

-- Tabla: OpinionesComentarios
CREATE TABLE OpinionesComentarios (
    OpinionID INT PRIMARY KEY,
    Texto VARCHAR(500),
    Fecha DATE,
    Calificacion INT
);

-- Tabla: Proveedores
CREATE TABLE Proveedores (
    ProveedorID INT PRIMARY KEY,
    NombreEmpresa VARCHAR(255),
    Direccion VARCHAR(255),
    Telefono VARCHAR(20),
    ProductosSuministrados VARCHAR(500)
);

-- Tabla: PromocionesEspeciales
CREATE TABLE PromocionesEspeciales (
    PromocionID INT PRIMARY KEY,
    NombrePromocion VARCHAR(255),
    Detalles VARCHAR(500)
);




