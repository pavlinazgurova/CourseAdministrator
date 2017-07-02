USE [master]
GO
/****** Object:  Database [Courses]    Script Date: 24.6.2017 г. 11:35:14 ч. ******/
CREATE DATABASE [Courses]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Courses', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Courses.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Courses_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Courses_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Courses] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Courses].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Courses] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Courses] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Courses] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Courses] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Courses] SET ARITHABORT OFF 
GO
ALTER DATABASE [Courses] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Courses] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Courses] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Courses] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Courses] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Courses] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Courses] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Courses] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Courses] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Courses] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Courses] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Courses] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Courses] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Courses] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Courses] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Courses] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Courses] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Courses] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Courses] SET  MULTI_USER 
GO
ALTER DATABASE [Courses] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Courses] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Courses] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Courses] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Courses] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Courses]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 24.6.2017 г. 11:35:14 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[CourseID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NULL,
	[LevelOfEducationID] [int] NULL,
	[FormOfEducationID] [int] NULL,
	[Duration] [int] NULL,
	[DepartmentID] [int] NULL,
	[Characterization] [nvarchar](max) NULL,
	[OtherSkills] [nvarchar](max) NULL,
	[OtherPosition] [nvarchar](max) NULL,
	[OtherProfessionalField] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CoursePoosition]    Script Date: 24.6.2017 г. 11:35:14 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CoursePoosition](
	[CoursePoositionID] [int] IDENTITY(1,1) NOT NULL,
	[PositionID] [int] NULL,
	[CourseID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CoursePoositionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CourseProfessionalField]    Script Date: 24.6.2017 г. 11:35:14 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CourseProfessionalField](
	[CourseProfessionalFieldID] [int] IDENTITY(1,1) NOT NULL,
	[CourseID] [int] NULL,
	[ProfessinalFieldID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CourseProfessionalFieldID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CourseSkill]    Script Date: 24.6.2017 г. 11:35:14 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CourseSkill](
	[CourseSkillID] [int] IDENTITY(1,1) NOT NULL,
	[CourseID] [int] NULL,
	[SkillID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CourseSkillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Departments]    Script Date: 24.6.2017 г. 11:35:14 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[DepartmentID] [int] IDENTITY(1,1) NOT NULL,
	[NameDepartments] [nvarchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[DepartmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FormOfEducation]    Script Date: 24.6.2017 г. 11:35:14 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FormOfEducation](
	[FormOfEducationID] [int] IDENTITY(1,1) NOT NULL,
	[NameFormOfEducation] [nvarchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[FormOfEducationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LevelOfEducation]    Script Date: 24.6.2017 г. 11:35:14 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LevelOfEducation](
	[LevelOfEducationID] [int] IDENTITY(1,1) NOT NULL,
	[NameLevelOfEducation] [nvarchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[LevelOfEducationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Login]    Script Date: 24.6.2017 г. 11:35:14 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Positions]    Script Date: 24.6.2017 г. 11:35:14 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Positions](
	[PositionID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[PositionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProfessionalField]    Script Date: 24.6.2017 г. 11:35:14 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProfessionalField](
	[ProfessionalFieldID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[ProfessionalFieldID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Skills]    Script Date: 24.6.2017 г. 11:35:14 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Skills](
	[SkillID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[SkillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[v_CoursePoosition]    Script Date: 24.6.2017 г. 11:35:14 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_CoursePoosition]
as
select p.PositionID, p.Name from CoursePoosition  c inner join Positions p on p.PositionID=c.PositionID
GO
/****** Object:  View [dbo].[v_CourseProfessionalField]    Script Date: 24.6.2017 г. 11:35:14 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_CourseProfessionalField]
as
select p.ProfessionalFieldID, p.Name from CourseProfessionalField c inner join ProfessionalField p on p.ProfessionalFieldID = c.ProfessinalFieldID

GO
/****** Object:  View [dbo].[v_CourseSkills]    Script Date: 24.6.2017 г. 11:35:14 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[v_CourseSkills]
as
select s.SkillID, s.Name from CourseSkill  c inner join Skills s on s.SkillID=c.SkillID
GO
/****** Object:  View [dbo].[v_list_departments]    Script Date: 24.6.2017 г. 11:35:14 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[v_list_departments]
as
select d.DepartmentID, d.NameDepartments from Departments d
union all
select -1, 'Изберете...'
GO
/****** Object:  View [dbo].[v_list_positions]    Script Date: 24.6.2017 г. 11:35:14 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[v_list_positions]
as
select p.PositionID, p.Name from Positions p
union all
select -1, 'Изберете...'
GO
/****** Object:  View [dbo].[v_list_professionalFields]    Script Date: 24.6.2017 г. 11:35:14 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[v_list_professionalFields]
as
select p.ProfessionalFieldID, p.Name from ProfessionalField p
union all
select -1, 'Изберете...'
GO
/****** Object:  View [dbo].[v_list_skills]    Script Date: 24.6.2017 г. 11:35:14 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[v_list_skills] 
as
select s.SkillID, s.Name from Skills s
union all
select -1, 'Изберете...'

GO
SET IDENTITY_INSERT [dbo].[Course] ON 

INSERT [dbo].[Course] ([CourseID], [Name], [LevelOfEducationID], [FormOfEducationID], [Duration], [DepartmentID], [Characterization], [OtherSkills], [OtherPosition], [OtherProfessionalField]) VALUES (1, N'Бизнес информатика и комуникации', 1, 1, 8, 1, N'Специалността "Бизнес информатика и комуникации" има 50 годишна история. Обучението дава теоретична подготовка и приложни знания, целящи завършилите да могат да разработват програмни продукти, да осъществяват дейностите по проектиране, програмиране, внедряване и поддържане на информационни системи, консултиращи и обслужващи различните равнища на бизнес.

В трети курс се изучават задължителните и избираеми факултетни учебни дисциплини: Интернет технологии; Бази от данни; Архитектури на изчислителни системи; Компютърни мрежи и телекомуникации; Операционни системи; Статистическо изследване на зависимости; Основи на разработване на приложни програмни системи; Основи на алгоритмизацията и програмирането; Програмиране в платформено независими среди; Статистически анализ на времеви редове. В четвърти курс се изучават задължителни и избираеми специални учебни дисциплини: Проектиране на информационни системи; Системи за управление на ресурсите на предприятието; Модели за изграждане на интернет приложения; Програмиране в бази данни; Технологии за изграждане на Уеб системи; Проектиране и изграждане на потребителски интерфейси; Бизнес интелигентни системи; Разработка и управление на интегрирани информационни системи; Създаване на системи на базата на клиент-сървър технологии и Уеб услуги; Модели за изграждане на мобилни приложения; Бизнес комуникации; Бизнес процеси и модели; Системи за стратегическо корпоративно управление; Бизнес интелигентни системи; Интелектуална собственост на информационни системи; Информационни технологии във финансови системи; Одит на информационни системи и технологии.', N'След завършване на специалността студентите придобиват знания и умения свързани с:

Разработването на приложения на основата на широко използвани технологии и езици за програмиране .NET/ASP.NET/ASP.MVC/C#, J2EE/Java, HTML/CSS/JavaScript; Разработването на мобилни приложения за Windows и Android; Проектиране, администриране и разработване на база данни; Администриране и поддръжка на компютърни мрежи, системен и приложен софтуер;Анализиране и моделиране на бизнес процеси - BPM; Администриране и внедряване на ERP системи; Проектиране и разработване на аналитични и бизнес интелигенти системи.














', N'Възможни длъжности след завършване: бизнес анализатори и проектанти на информационни системи; разработчици на информационни системи, уеб системи и мобилни приложения; внедрители на информационни системи; администратори на информационни системи; ръководители на ИТ проекти и екипи; QA специалисти и др.


', N'Завършилите специалността могат да се реализират в различни области на стопанската дейност: софтуерни компании, държавна и публична администрация, финансови институции и банки, фирми и учебни заведения.')
INSERT [dbo].[Course] ([CourseID], [Name], [LevelOfEducationID], [FormOfEducationID], [Duration], [DepartmentID], [Characterization], [OtherSkills], [OtherPosition], [OtherProfessionalField]) VALUES (2, N'Финанси', 1, 1, 8, 2, N'Образователната цел на УНСС при организиране на обучението по специалност ”Финанси” - бакалавърска степен е следната: чрез система от взаимнообвързани основни, специални и профилиращи дисциплини да се осигури получаването на комплекс от знания и умения, необходими за работата на специалиста-финансист. Дипломираните бакалаври са подготвени да се реализират на средно управленско ниво във финансовата сфера и да вземат рационални решения на оперативно равнище.

Обучението е подчинено на идеята за осигуряване на общоикономически фундамент и постепенно специализиране и профилиране с цел бързо и ясно адаптиране към променящите се потребности на практиката. Отчетена е и необходимостта от солидна юридическа и счетоводна подготовка и компютърна грамотност. Осигурява се и специализирано обучение по чужди езици. Обучението се осъществява от висококвалифицирани преподаватели, доказали своите способности не само в научно-преподавателската област, но и в практиката. Учебният план за бакалавър по икономика - специалност “Финанси” е с нормативните изисквания в Република България.', N'В резултат на целенасоченото обучение се създават умения за прилагане на методите на:  счетоводен и финансов анализ; математическа обработка; статистически анализ; правен анализ.

Акцентира се върху създаване и развитие на следните качества:  комуникативност; умение за работа в екип; активно отношение към извършваната дейност; стремеж към рационални промени и висока ефективност; способности за непрекъснато актуализиране на знанията.', N'Бакалаврите по икономика - специалност “Финанси” могат да заемат следните длъжност: финансов мениджър; специалист по финанси в бюджетните организации; кредитен инспектор; брокер и дилър; данъчен инспектор; специалист по застраховане; специалист по социално осигуряване; митнически инспектор и  други.', N'Дипломираните бакалаври по икономика - специалност “Финанси” могат да работят в следните сфери:  банкова  система; публична  администрация; на капиталови  пазари; в застраховане; социално осигуряване; финансови служби на предприятията; на финансовия контрол; инвестиционни  дружества и др.')
INSERT [dbo].[Course] ([CourseID], [Name], [LevelOfEducationID], [FormOfEducationID], [Duration], [DepartmentID], [Characterization], [OtherSkills], [OtherPosition], [OtherProfessionalField]) VALUES (3, N'Счетоводство', 2, 1, 3, 2, N'Това е първата официално обособена икономическа специалност в света. В условията на пазарна икономика счетоводството осигурява преобладаващата част от необходимата икономическа информация за вземане на управленски решения чрез използване на богат инструментариум от специфични методи и техники за текущо и периодично отчитане, за вътрешен контрол, икономически анализ, финансово планиране и бюджетиране на дейностите и съставляващите ги операции. 

Учебният план за обучението по счетоводство е изготвен върху основата на съвременните постижения в счетоводната наука и практика. Наред със специалните счетоводни дисциплини сериозно внимание се отделя и на учебните предмети по информатика, финанси и право. Обучението за магистърската програма продължава 3 семестъра. 

В трети курс се изучават задължителни и избираеми факултетни учебни дисциплини: "Финансово счетоводство", "Теория на финансовия контрол", "Управленско счетоводство", "Банково дело", "Одитинг", "Трудово и осигурително право", "Цени и ценообразуване", "Управление на човешките ресурси", "Търговско право", "Счетоводство на осигурителите", "Данъчно облагане и контрол", "Счетоводство на застрахователите" и др.

В четвърти курс се изучават задължителни и избираеми специални учебни дисциплини: "Счетоводство на банките", "Счетоводство в публичния сектор", "Финансово-стопански анализ", "Информационни системи в счетоводството", "Счетоводна политика и финансови отчети", "Административно и финансово право", "Банково и борсово право", "Организация и нормативна база на счетоводството", "Контрол във финансовия сектор", "Митнически контрол", "Финансово-стопански (бизнес) изчисления" и др.', N'Едни от най-важните умения, които се придобиват са познаването на счетоводния закон и работата със счетоводен софтур.', N'Завършилите специалността могат да работят като: специалисти по счетоводство и съставители на финансови отчети, да заемат длъжности и да упражняват дейности като главни счетоводители, данъчни инспектори, одитори от финансовата инспекция и вътрешния контрол, финансови директори, методолози по счетоводство и анализ, консултанти и счетоводители на свободна практика и други.', N'Възможност за работа в предприятия, дружества и организации от финансовия, нефинансовия и публичния сектор.')
INSERT [dbo].[Course] ([CourseID], [Name], [LevelOfEducationID], [FormOfEducationID], [Duration], [DepartmentID], [Characterization], [OtherSkills], [OtherPosition], [OtherProfessionalField]) VALUES (4, N'Бизнес администрация', 1, 2, 8, 3, N'"Бизнес администрация" е една от най-предпочитаните специалности в УНСС, която има аналог в европейското и световното образование. Катедра “Управление” осъществява обучение в бакалавърска степен по учебна програма, напълно съответстваща на практиката в най-престижните световни университети. "Училище за директори" наричат шеговито тази специалност някои. Учебното съдържание осигурява задълбочена теоретична подготовка и управленски компетентности на бъдещите мениджъри.

Всички знания се пречупват през призмата на европейското политическо и икономическо сътрудничество и интеграция. Използват се всички съвременни форми на интерактивно обучение и активно учене: управленски игри, казуси, самостоятелни и групови проекти, разнообразни екипни задачи. Акцентът е поставен върху иновативното мислене, създаването на умения за вземане на решения, ефективните комуникации и технологията на управлението. Катедра “Управление”, която организира обучението на специалистите в тези бакалавърски програми, разполага с отлично подготвени, хабилитирани преподавателски кадри - професори, доценти, главни асистенти – доктори по “Социално управление”, млади и перспективни асистенти. Преподавателският състав участва активно в международния научен обмен и поддържа високо ниво на своята компетентност в областта на управлението.', N'Част от професионалните умения, които се придобиват са работа в екип, лидерство, решаване на конфликти, оформянето и администрирането на бизнес информация, 
работата със съвременни информационни системи и много други.', N'Завършилите специалност "Бизнес администрация" ще могат да се реализират като: ръководители на различни равнища на управление на стопанските организации, функционални и линейни специалисти в управленската йерархия на стопанските организации, съветници (щабни специалисти) на висшето ръководство в стопанските организации, специалисти и експерти по управление в изследователските и развойните звена на стопанските организации, консултанти и експерти по управление и организационно развитие в специализирани фирми и научноизследователски организации, специалисти по управление и администрация в местните и държавни управленски структури.', N'Осигурява се възможност за специализация на студентите в предпочитани от тях области – Управление на човешките ресурси, 
Финанси, Международен бизнес и мениджмънт, Маркетинг, Управление на информационни системи, Право, Търговия, Икономика;')
INSERT [dbo].[Course] ([CourseID], [Name], [LevelOfEducationID], [FormOfEducationID], [Duration], [DepartmentID], [Characterization], [OtherSkills], [OtherPosition], [OtherProfessionalField]) VALUES (5, N'Статистика и иконометрия', 1, 1, 8, 1, N'Обучението по тази специалност има над 60-годишна традиция в УНСС. Целта е подготовката на икономисти за статистическа обработка и анализ на информация с помощта на компютърна техника и специализиран софтуер. Съдържанието на учебните програми отговаря на добрите европейски практики за университетско обучение в областта на приложната статистика и иконометрия.

В трети курс се изучават задължителни и избираеми факултетни дисциплини: "Въведение в иконометрията", "Статистическо изследване на зависимости", "Интернет технологии", "Планиране и организация на извадковите изследвания", "Компютърни архитектури - комуникации и мрежи", "Софтуер за статистически анализ", "Икономическа статистика" и др.

В четвърти курс се изучават задължителни и избираеми специални учебни дисциплини:"Статистически информационни системи", "Статистически анализ на временни редове", "Демографска статистика", "Приложна иконометрия", "Проектиране на статистическите изследвания", Софтуер за статистически анализ" (втора част), "Статистически методи в маркетинговите изследвания", "Статистически методи в социологическите изследвания", "Статистика на околната среда", "Статистически методи в експерименталното дело", "Многомерни методи", "Регионална статистика", "Актюерна статистика", "Методи за стимулиране на творческото мислене", "Статистика на борсовите операции", "Вземане на решения в условията на несигурност". Катедрата осигурява за всички свои студенти стаж в Националния статистически институт и частни фирми, както и възможност за участие в изследователски проекти.', N'Придобиване на умения свързани с извършване на технически задачи, свързани със създаване,поддържане и използване на регистри и извадки за статистически преброявания и изследвания.
', N'
Завършилите тази специалност могат да се специализират като Приложен специалист - математика и приложен специалист - статистика.', N'Завършилите специалността могат да работят във: консултантски фирми (в т.ч. маркетингови агенции, фирми и организации в областта на анализа на финансовото състояние, на обосновката на инвестиционни решения, на оценката на риска, на статистическия контрол на качеството, социологически агенции и др.), банки, осигурителни фондове и застрахователни институти, Националния статистически институт, фондови борси, държавната и общинската администрация, международни организации, европейски институции, неправителствени организации, научни и изследователски институти, експериментални бази, висши и средни училища.')
SET IDENTITY_INSERT [dbo].[Course] OFF
SET IDENTITY_INSERT [dbo].[CoursePoosition] ON 

INSERT [dbo].[CoursePoosition] ([CoursePoositionID], [PositionID], [CourseID]) VALUES (1, 1, 2)
INSERT [dbo].[CoursePoosition] ([CoursePoositionID], [PositionID], [CourseID]) VALUES (2, 2, 2)
INSERT [dbo].[CoursePoosition] ([CoursePoositionID], [PositionID], [CourseID]) VALUES (3, 3, 2)
INSERT [dbo].[CoursePoosition] ([CoursePoositionID], [PositionID], [CourseID]) VALUES (4, 4, 1)
INSERT [dbo].[CoursePoosition] ([CoursePoositionID], [PositionID], [CourseID]) VALUES (5, 5, 1)
INSERT [dbo].[CoursePoosition] ([CoursePoositionID], [PositionID], [CourseID]) VALUES (19, 5, 5)
INSERT [dbo].[CoursePoosition] ([CoursePoositionID], [PositionID], [CourseID]) VALUES (6, 6, 1)
INSERT [dbo].[CoursePoosition] ([CoursePoositionID], [PositionID], [CourseID]) VALUES (7, 7, 3)
INSERT [dbo].[CoursePoosition] ([CoursePoositionID], [PositionID], [CourseID]) VALUES (15, 8, 2)
INSERT [dbo].[CoursePoosition] ([CoursePoositionID], [PositionID], [CourseID]) VALUES (8, 8, 3)
INSERT [dbo].[CoursePoosition] ([CoursePoositionID], [PositionID], [CourseID]) VALUES (9, 10, 4)
INSERT [dbo].[CoursePoosition] ([CoursePoositionID], [PositionID], [CourseID]) VALUES (12, 10, 5)
INSERT [dbo].[CoursePoosition] ([CoursePoositionID], [PositionID], [CourseID]) VALUES (10, 11, 4)
INSERT [dbo].[CoursePoosition] ([CoursePoositionID], [PositionID], [CourseID]) VALUES (29, 12, 1)
INSERT [dbo].[CoursePoosition] ([CoursePoositionID], [PositionID], [CourseID]) VALUES (11, 12, 4)
INSERT [dbo].[CoursePoosition] ([CoursePoositionID], [PositionID], [CourseID]) VALUES (13, 13, 5)
SET IDENTITY_INSERT [dbo].[CoursePoosition] OFF
SET IDENTITY_INSERT [dbo].[CourseProfessionalField] ON 

INSERT [dbo].[CourseProfessionalField] ([CourseProfessionalFieldID], [CourseID], [ProfessinalFieldID]) VALUES (1, 1, 1)
INSERT [dbo].[CourseProfessionalField] ([CourseProfessionalFieldID], [CourseID], [ProfessinalFieldID]) VALUES (2, 1, 2)
INSERT [dbo].[CourseProfessionalField] ([CourseProfessionalFieldID], [CourseID], [ProfessinalFieldID]) VALUES (3, 2, 2)
INSERT [dbo].[CourseProfessionalField] ([CourseProfessionalFieldID], [CourseID], [ProfessinalFieldID]) VALUES (4, 2, 3)
INSERT [dbo].[CourseProfessionalField] ([CourseProfessionalFieldID], [CourseID], [ProfessinalFieldID]) VALUES (5, 2, 4)
INSERT [dbo].[CourseProfessionalField] ([CourseProfessionalFieldID], [CourseID], [ProfessinalFieldID]) VALUES (6, 3, 5)
INSERT [dbo].[CourseProfessionalField] ([CourseProfessionalFieldID], [CourseID], [ProfessinalFieldID]) VALUES (7, 4, 8)
INSERT [dbo].[CourseProfessionalField] ([CourseProfessionalFieldID], [CourseID], [ProfessinalFieldID]) VALUES (8, 4, 9)
INSERT [dbo].[CourseProfessionalField] ([CourseProfessionalFieldID], [CourseID], [ProfessinalFieldID]) VALUES (11, 5, 2)
INSERT [dbo].[CourseProfessionalField] ([CourseProfessionalFieldID], [CourseID], [ProfessinalFieldID]) VALUES (9, 5, 3)
INSERT [dbo].[CourseProfessionalField] ([CourseProfessionalFieldID], [CourseID], [ProfessinalFieldID]) VALUES (10, 5, 10)
SET IDENTITY_INSERT [dbo].[CourseProfessionalField] OFF
SET IDENTITY_INSERT [dbo].[CourseSkill] ON 

INSERT [dbo].[CourseSkill] ([CourseSkillID], [CourseID], [SkillID]) VALUES (1, 1, 3)
INSERT [dbo].[CourseSkill] ([CourseSkillID], [CourseID], [SkillID]) VALUES (2, 1, 4)
INSERT [dbo].[CourseSkill] ([CourseSkillID], [CourseID], [SkillID]) VALUES (3, 1, 5)
INSERT [dbo].[CourseSkill] ([CourseSkillID], [CourseID], [SkillID]) VALUES (4, 2, 1)
INSERT [dbo].[CourseSkill] ([CourseSkillID], [CourseID], [SkillID]) VALUES (5, 2, 2)
INSERT [dbo].[CourseSkill] ([CourseSkillID], [CourseID], [SkillID]) VALUES (7, 3, 2)
INSERT [dbo].[CourseSkill] ([CourseSkillID], [CourseID], [SkillID]) VALUES (6, 3, 6)
INSERT [dbo].[CourseSkill] ([CourseSkillID], [CourseID], [SkillID]) VALUES (8, 4, 8)
INSERT [dbo].[CourseSkill] ([CourseSkillID], [CourseID], [SkillID]) VALUES (9, 4, 9)
INSERT [dbo].[CourseSkill] ([CourseSkillID], [CourseID], [SkillID]) VALUES (10, 4, 10)
INSERT [dbo].[CourseSkill] ([CourseSkillID], [CourseID], [SkillID]) VALUES (12, 5, 2)
SET IDENTITY_INSERT [dbo].[CourseSkill] OFF
SET IDENTITY_INSERT [dbo].[Departments] ON 

INSERT [dbo].[Departments] ([DepartmentID], [NameDepartments]) VALUES (3, N'Администрация и управление')
INSERT [dbo].[Departments] ([DepartmentID], [NameDepartments]) VALUES (1, N'Приложна информатика, комуникации и иконометрия')
INSERT [dbo].[Departments] ([DepartmentID], [NameDepartments]) VALUES (2, N'Финанси, счетоводство и контрол')
SET IDENTITY_INSERT [dbo].[Departments] OFF
SET IDENTITY_INSERT [dbo].[FormOfEducation] ON 

INSERT [dbo].[FormOfEducation] ([FormOfEducationID], [NameFormOfEducation]) VALUES (1, N'Редовно')
INSERT [dbo].[FormOfEducation] ([FormOfEducationID], [NameFormOfEducation]) VALUES (2, N'Задочно')
SET IDENTITY_INSERT [dbo].[FormOfEducation] OFF
SET IDENTITY_INSERT [dbo].[LevelOfEducation] ON 

INSERT [dbo].[LevelOfEducation] ([LevelOfEducationID], [NameLevelOfEducation]) VALUES (1, N'Бакалавър')
INSERT [dbo].[LevelOfEducation] ([LevelOfEducationID], [NameLevelOfEducation]) VALUES (2, N'Магистър')
INSERT [dbo].[LevelOfEducation] ([LevelOfEducationID], [NameLevelOfEducation]) VALUES (3, N'Доктор')
SET IDENTITY_INSERT [dbo].[LevelOfEducation] OFF
INSERT [dbo].[Login] ([UserName], [Password]) VALUES (N'Pavlina', N'123456')
SET IDENTITY_INSERT [dbo].[Positions] ON 

INSERT [dbo].[Positions] ([PositionID], [Name]) VALUES (5, N'QA специалист')
INSERT [dbo].[Positions] ([PositionID], [Name]) VALUES (8, N'Данъчен инспектор')
INSERT [dbo].[Positions] ([PositionID], [Name]) VALUES (11, N'Консултанти и експерти по управление')
INSERT [dbo].[Positions] ([PositionID], [Name]) VALUES (2, N'Кредитен инспектор')
INSERT [dbo].[Positions] ([PositionID], [Name]) VALUES (12, N'Офис мениджър')
INSERT [dbo].[Positions] ([PositionID], [Name]) VALUES (10, N'Преподавателски кадри')
INSERT [dbo].[Positions] ([PositionID], [Name]) VALUES (4, N'Разработчик на информационни системии')
INSERT [dbo].[Positions] ([PositionID], [Name]) VALUES (6, N'Разработчик на уеб/мобилни приложения')
INSERT [dbo].[Positions] ([PositionID], [Name]) VALUES (3, N'Специалист по застраховане')
INSERT [dbo].[Positions] ([PositionID], [Name]) VALUES (7, N'Счетоводител')
INSERT [dbo].[Positions] ([PositionID], [Name]) VALUES (13, N'Финансов анализатор')
INSERT [dbo].[Positions] ([PositionID], [Name]) VALUES (1, N'Финансов мениджър')
SET IDENTITY_INSERT [dbo].[Positions] OFF
SET IDENTITY_INSERT [dbo].[ProfessionalField] ON 

INSERT [dbo].[ProfessionalField] ([ProfessionalFieldID], [Name]) VALUES (1, N'IT')
INSERT [dbo].[ProfessionalField] ([ProfessionalFieldID], [Name]) VALUES (5, N'Дружества от публичния сектор')
INSERT [dbo].[ProfessionalField] ([ProfessionalFieldID], [Name]) VALUES (3, N'Застраховане')
INSERT [dbo].[ProfessionalField] ([ProfessionalFieldID], [Name]) VALUES (10, N'Изследователски институции')
INSERT [dbo].[ProfessionalField] ([ProfessionalFieldID], [Name]) VALUES (4, N'Капиталови пазари')
INSERT [dbo].[ProfessionalField] ([ProfessionalFieldID], [Name]) VALUES (2, N'Публична администрация')
INSERT [dbo].[ProfessionalField] ([ProfessionalFieldID], [Name]) VALUES (8, N'Стратегически мениджмънт')
INSERT [dbo].[ProfessionalField] ([ProfessionalFieldID], [Name]) VALUES (9, N'Частен или обществен сектор на икономиката')
SET IDENTITY_INSERT [dbo].[ProfessionalField] OFF
SET IDENTITY_INSERT [dbo].[Skills] ON 

INSERT [dbo].[Skills] ([SkillID], [Name]) VALUES (10, N'Анализ и оценка на бизнес средата')
INSERT [dbo].[Skills] ([SkillID], [Name]) VALUES (8, N'Вземане на управленски решения')
INSERT [dbo].[Skills] ([SkillID], [Name]) VALUES (4, N'Логическо мислене')
INSERT [dbo].[Skills] ([SkillID], [Name]) VALUES (2, N'Математическа обработка')
INSERT [dbo].[Skills] ([SkillID], [Name]) VALUES (3, N'Писане на качествен програмен код')
INSERT [dbo].[Skills] ([SkillID], [Name]) VALUES (6, N'Работа със счетоводен софтуер')
INSERT [dbo].[Skills] ([SkillID], [Name]) VALUES (5, N'Разработване на бази от данни')
INSERT [dbo].[Skills] ([SkillID], [Name]) VALUES (9, N'Умения за презентиране и общуване')
INSERT [dbo].[Skills] ([SkillID], [Name]) VALUES (1, N'Финансов анализ')
SET IDENTITY_INSERT [dbo].[Skills] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [inxCourse]    Script Date: 24.6.2017 г. 11:35:14 ч. ******/
CREATE UNIQUE NONCLUSTERED INDEX [inxCourse] ON [dbo].[Course]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [indexCoursePoosition]    Script Date: 24.6.2017 г. 11:35:14 ч. ******/
CREATE UNIQUE NONCLUSTERED INDEX [indexCoursePoosition] ON [dbo].[CoursePoosition]
(
	[PositionID] ASC,
	[CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [inxCoursePoosition]    Script Date: 24.6.2017 г. 11:35:14 ч. ******/
CREATE NONCLUSTERED INDEX [inxCoursePoosition] ON [dbo].[CoursePoosition]
(
	[PositionID] ASC,
	[CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [indexCourseProfessionalField]    Script Date: 24.6.2017 г. 11:35:14 ч. ******/
CREATE UNIQUE NONCLUSTERED INDEX [indexCourseProfessionalField] ON [dbo].[CourseProfessionalField]
(
	[CourseID] ASC,
	[ProfessinalFieldID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [inxCourseProfessionalField]    Script Date: 24.6.2017 г. 11:35:14 ч. ******/
CREATE NONCLUSTERED INDEX [inxCourseProfessionalField] ON [dbo].[CourseProfessionalField]
(
	[CourseID] ASC,
	[ProfessinalFieldID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [indexCourseSkill]    Script Date: 24.6.2017 г. 11:35:14 ч. ******/
CREATE UNIQUE NONCLUSTERED INDEX [indexCourseSkill] ON [dbo].[CourseSkill]
(
	[CourseID] ASC,
	[SkillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [inxCourseSkill]    Script Date: 24.6.2017 г. 11:35:14 ч. ******/
CREATE NONCLUSTERED INDEX [inxCourseSkill] ON [dbo].[CourseSkill]
(
	[CourseID] ASC,
	[SkillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [indexDepartments]    Script Date: 24.6.2017 г. 11:35:14 ч. ******/
CREATE UNIQUE NONCLUSTERED INDEX [indexDepartments] ON [dbo].[Departments]
(
	[NameDepartments] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [indexPositions]    Script Date: 24.6.2017 г. 11:35:14 ч. ******/
CREATE UNIQUE NONCLUSTERED INDEX [indexPositions] ON [dbo].[Positions]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [indexProfessionalField]    Script Date: 24.6.2017 г. 11:35:14 ч. ******/
CREATE UNIQUE NONCLUSTERED INDEX [indexProfessionalField] ON [dbo].[ProfessionalField]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [indexSkills]    Script Date: 24.6.2017 г. 11:35:14 ч. ******/
CREATE UNIQUE NONCLUSTERED INDEX [indexSkills] ON [dbo].[Skills]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Course]  WITH CHECK ADD FOREIGN KEY([DepartmentID])
REFERENCES [dbo].[Departments] ([DepartmentID])
GO
ALTER TABLE [dbo].[Course]  WITH CHECK ADD FOREIGN KEY([FormOfEducationID])
REFERENCES [dbo].[FormOfEducation] ([FormOfEducationID])
GO
ALTER TABLE [dbo].[Course]  WITH CHECK ADD FOREIGN KEY([LevelOfEducationID])
REFERENCES [dbo].[LevelOfEducation] ([LevelOfEducationID])
GO
ALTER TABLE [dbo].[CoursePoosition]  WITH CHECK ADD FOREIGN KEY([CourseID])
REFERENCES [dbo].[Course] ([CourseID])
GO
ALTER TABLE [dbo].[CoursePoosition]  WITH CHECK ADD FOREIGN KEY([PositionID])
REFERENCES [dbo].[Positions] ([PositionID])
GO
ALTER TABLE [dbo].[CoursePoosition]  WITH CHECK ADD  CONSTRAINT [fk_CoursePoosition_CourseID] FOREIGN KEY([CourseID])
REFERENCES [dbo].[Course] ([CourseID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CoursePoosition] CHECK CONSTRAINT [fk_CoursePoosition_CourseID]
GO
ALTER TABLE [dbo].[CoursePoosition]  WITH CHECK ADD  CONSTRAINT [fk_CoursePoosition_PositionID] FOREIGN KEY([PositionID])
REFERENCES [dbo].[Positions] ([PositionID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CoursePoosition] CHECK CONSTRAINT [fk_CoursePoosition_PositionID]
GO
ALTER TABLE [dbo].[CourseProfessionalField]  WITH CHECK ADD FOREIGN KEY([CourseID])
REFERENCES [dbo].[Course] ([CourseID])
GO
ALTER TABLE [dbo].[CourseProfessionalField]  WITH CHECK ADD FOREIGN KEY([ProfessinalFieldID])
REFERENCES [dbo].[ProfessionalField] ([ProfessionalFieldID])
GO
ALTER TABLE [dbo].[CourseProfessionalField]  WITH CHECK ADD  CONSTRAINT [fk_CourseProfessionalField_CourseID] FOREIGN KEY([CourseID])
REFERENCES [dbo].[Course] ([CourseID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CourseProfessionalField] CHECK CONSTRAINT [fk_CourseProfessionalField_CourseID]
GO
ALTER TABLE [dbo].[CourseProfessionalField]  WITH CHECK ADD  CONSTRAINT [fk_CourseProfessionalField_ProfessinalFieldID] FOREIGN KEY([ProfessinalFieldID])
REFERENCES [dbo].[ProfessionalField] ([ProfessionalFieldID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CourseProfessionalField] CHECK CONSTRAINT [fk_CourseProfessionalField_ProfessinalFieldID]
GO
ALTER TABLE [dbo].[CourseSkill]  WITH CHECK ADD FOREIGN KEY([CourseID])
REFERENCES [dbo].[Course] ([CourseID])
GO
ALTER TABLE [dbo].[CourseSkill]  WITH CHECK ADD FOREIGN KEY([SkillID])
REFERENCES [dbo].[Skills] ([SkillID])
GO
ALTER TABLE [dbo].[CourseSkill]  WITH CHECK ADD  CONSTRAINT [fk_CourseSkill_CourseID] FOREIGN KEY([CourseID])
REFERENCES [dbo].[Course] ([CourseID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CourseSkill] CHECK CONSTRAINT [fk_CourseSkill_CourseID]
GO
ALTER TABLE [dbo].[CourseSkill]  WITH CHECK ADD  CONSTRAINT [fk_CourseSkill_SkillID] FOREIGN KEY([SkillID])
REFERENCES [dbo].[Skills] ([SkillID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CourseSkill] CHECK CONSTRAINT [fk_CourseSkill_SkillID]
GO
USE [master]
GO
ALTER DATABASE [Courses] SET  READ_WRITE 
GO
