USE [master]
GO
/****** Object:  Database [db_escuela]    Script Date: 9/3/2019 14:41:10 ******/
CREATE DATABASE [db_escuela]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_escuela', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\db_escuela.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'db_escuela_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\db_escuela_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [db_escuela] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_escuela].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_escuela] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_escuela] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_escuela] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_escuela] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_escuela] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_escuela] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_escuela] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_escuela] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_escuela] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_escuela] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_escuela] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_escuela] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_escuela] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_escuela] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_escuela] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_escuela] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_escuela] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_escuela] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_escuela] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_escuela] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_escuela] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_escuela] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_escuela] SET RECOVERY FULL 
GO
ALTER DATABASE [db_escuela] SET  MULTI_USER 
GO
ALTER DATABASE [db_escuela] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_escuela] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_escuela] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_escuela] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_escuela] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'db_escuela', N'ON'
GO
ALTER DATABASE [db_escuela] SET QUERY_STORE = OFF
GO
USE [db_escuela]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [db_escuela]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 9/3/2019 14:41:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Curso]    Script Date: 9/3/2019 14:41:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Curso](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MateriaId] [int] NOT NULL,
	[HorarioInicio] [datetime] NULL,
	[HorarioFin] [datetime] NULL,
	[ProfesorId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Curso] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estudiante]    Script Date: 9/3/2019 14:41:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estudiante](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [varchar](150) NOT NULL,
	[Apellidos] [varchar](150) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Activo] [bit] NOT NULL,
	[Genero] [char](1) NOT NULL,
	[Altura] [float] NULL,
	[Salario] [decimal](10, 2) NULL,
 CONSTRAINT [PK_dbo.Estudiante] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstudianteCurso]    Script Date: 9/3/2019 14:41:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstudianteCurso](
	[CursoId] [int] NOT NULL,
	[EstudianteId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.EstudianteCurso] PRIMARY KEY CLUSTERED 
(
	[CursoId] ASC,
	[EstudianteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Materia]    Script Date: 9/3/2019 14:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materia](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](150) NOT NULL,
 CONSTRAINT [PK_dbo.Materia] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profesor]    Script Date: 9/3/2019 14:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [nvarchar](150) NOT NULL,
	[Apellidos] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_dbo.Profesor] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [IX_MateriaId]    Script Date: 9/3/2019 14:41:11 ******/
CREATE NONCLUSTERED INDEX [IX_MateriaId] ON [dbo].[Curso]
(
	[MateriaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProfesorId]    Script Date: 9/3/2019 14:41:11 ******/
CREATE NONCLUSTERED INDEX [IX_ProfesorId] ON [dbo].[Curso]
(
	[ProfesorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_CursoId]    Script Date: 9/3/2019 14:41:11 ******/
CREATE NONCLUSTERED INDEX [IX_CursoId] ON [dbo].[EstudianteCurso]
(
	[CursoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_EstudianteId]    Script Date: 9/3/2019 14:41:11 ******/
CREATE NONCLUSTERED INDEX [IX_EstudianteId] ON [dbo].[EstudianteCurso]
(
	[EstudianteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Curso] ADD  DEFAULT ((0)) FOR [ProfesorId]
GO
ALTER TABLE [dbo].[Curso]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Curso_dbo.Materia_MateriaId] FOREIGN KEY([MateriaId])
REFERENCES [dbo].[Materia] ([Id])
GO
ALTER TABLE [dbo].[Curso] CHECK CONSTRAINT [FK_dbo.Curso_dbo.Materia_MateriaId]
GO
ALTER TABLE [dbo].[Curso]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Curso_dbo.Profesor_ProfesorId] FOREIGN KEY([ProfesorId])
REFERENCES [dbo].[Profesor] ([Id])
GO
ALTER TABLE [dbo].[Curso] CHECK CONSTRAINT [FK_dbo.Curso_dbo.Profesor_ProfesorId]
GO
ALTER TABLE [dbo].[EstudianteCurso]  WITH CHECK ADD  CONSTRAINT [FK_dbo.EstudianteCurso_dbo.Curso_CursoId] FOREIGN KEY([CursoId])
REFERENCES [dbo].[Curso] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EstudianteCurso] CHECK CONSTRAINT [FK_dbo.EstudianteCurso_dbo.Curso_CursoId]
GO
ALTER TABLE [dbo].[EstudianteCurso]  WITH CHECK ADD  CONSTRAINT [FK_dbo.EstudianteCurso_dbo.Estudiante_EstudianteId] FOREIGN KEY([EstudianteId])
REFERENCES [dbo].[Estudiante] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EstudianteCurso] CHECK CONSTRAINT [FK_dbo.EstudianteCurso_dbo.Estudiante_EstudianteId]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_estudiante]    Script Date: 9/3/2019 14:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_del_estudiante]
	-- Add the parameters for the stored procedure here
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM Estudiante WHERE Id = @Id;

	DELETE FROM Estudiante WHERE Id = @Id;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_estudiante]    Script Date: 9/3/2019 14:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_upd_estudiante]
	-- Add the parameters for the stored procedure here
	@Id int,
	@FechaNacimiento date,
	@Activo bit = 1,
	@Altura float,
	@Salario decimal(10,2)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [dbo].[Estudiante]
	   SET [FechaNacimiento] = @FechaNacimiento
		  ,[Activo] = @Activo
		  ,[Altura] = @Altura
		  ,[Salario] = @Salario
	 WHERE Id = @Id;



END
GO
USE [master]
GO
ALTER DATABASE [db_escuela] SET  READ_WRITE 
GO
