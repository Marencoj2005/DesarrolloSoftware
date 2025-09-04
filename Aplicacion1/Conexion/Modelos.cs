// para los modelos los atrubutos son publicos
namespace Aplicacion1.Conexion
{
    public class Equipos
    /*[Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Nombre] NVARCHAR(50) NOT NULL,
	[Ciudad] NVARCHAR(50) NOT NULL,*/
    {
        public int Id { get; set; }
        public String? Nombre { get; set; }
        public String? Ciudad { get; set; }
        public List<Jugadores>? Jugadores { get; set; }

        //si una entidad puede albergar varias entidades, dentro de esa entidad crea una lista
    }
    public class Jugadores
    /*[Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Nombre] NVARCHAR(50) NOT NULL,
	[Equipo] INT NOT NULL REFERENCES [Equipos]([Id]),
	[Fecha] SMALLDATETIME NOT NULL DEFAULT GETDATE(),
	[Activo] BIT NOT NULL,
	[Estatura] DECIMAL(10, 2) NOT NULL,*/
    {
        public int Id { get; set; }
        public String? Nombre { get; set; }
        public int Ciudad { get; set; }
        public DateTime Fecha { get; set; }
        public bool Activo { get; set; }
        public decimal Estatura { get; set; }


    }
}
// cuando tenga un entero referencia va a colocar el campo entero con un segundo nombre con el tipo de la clase
// cuando hay una referencia va a colocar el primero como entero y el segundo como tipo de la tabla como referencia
