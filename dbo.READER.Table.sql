USE [nerds_feed]
GO
/****** Object:  Table [dbo].[READER]    Script Date: 20-07-2020 15:43:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[READER](
	[READER_ID] [int] NOT NULL,
	[R_TYPE] [varchar](20) NULL,
	[R_NAME] [varchar](20) NULL,
	[R_ADDRESS] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[READER_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[READER] ([READER_ID], [R_TYPE], [R_NAME], [R_ADDRESS]) VALUES (1020, N'Student', N'Vee', N'kearny')
INSERT [dbo].[READER] ([READER_ID], [R_TYPE], [R_NAME], [R_ADDRESS]) VALUES (90001, N'STUDENT', N'VISHNU', N'Harrison')
INSERT [dbo].[READER] ([READER_ID], [R_TYPE], [R_NAME], [R_ADDRESS]) VALUES (90002, N'STAFF', N'JOHN', N'Edison')
INSERT [dbo].[READER] ([READER_ID], [R_TYPE], [R_NAME], [R_ADDRESS]) VALUES (90003, N'SENIOR CITIZEN', N'WILLIAM', N'Kearny')
INSERT [dbo].[READER] ([READER_ID], [R_TYPE], [R_NAME], [R_ADDRESS]) VALUES (90004, N'STAFF', N'MATHEWS', N'Harrison')
INSERT [dbo].[READER] ([READER_ID], [R_TYPE], [R_NAME], [R_ADDRESS]) VALUES (90005, N'STUDENT', N'MADHURI', N'Newark')
INSERT [dbo].[READER] ([READER_ID], [R_TYPE], [R_NAME], [R_ADDRESS]) VALUES (90006, N'STAFF', N'JAMES', N'Hoboken')
INSERT [dbo].[READER] ([READER_ID], [R_TYPE], [R_NAME], [R_ADDRESS]) VALUES (90007, N'STUDENT', N'VIKYATH', N'Edison')
INSERT [dbo].[READER] ([READER_ID], [R_TYPE], [R_NAME], [R_ADDRESS]) VALUES (90008, N'SENIOR CITIZEN', N'ALEX', N'Hoboken')
INSERT [dbo].[READER] ([READER_ID], [R_TYPE], [R_NAME], [R_ADDRESS]) VALUES (90009, N'STUDENT', N'BADRI', N'Newark')
INSERT [dbo].[READER] ([READER_ID], [R_TYPE], [R_NAME], [R_ADDRESS]) VALUES (90010, N'STUDENT', N'VISHAL', N'Harrison')
INSERT [dbo].[READER] ([READER_ID], [R_TYPE], [R_NAME], [R_ADDRESS]) VALUES (90011, N'SENIOR CITIZEN', N'SCARLETT', N'Edison')
INSERT [dbo].[READER] ([READER_ID], [R_TYPE], [R_NAME], [R_ADDRESS]) VALUES (90012, N'STAFF', N'KATE', N'Edison')
INSERT [dbo].[READER] ([READER_ID], [R_TYPE], [R_NAME], [R_ADDRESS]) VALUES (90013, N'STUDENT', N'PAUL', N'Kundanhalli')
INSERT [dbo].[READER] ([READER_ID], [R_TYPE], [R_NAME], [R_ADDRESS]) VALUES (90014, N'SENIOR CITIZEN', N'SANDY', N'Hoboken')
INSERT [dbo].[READER] ([READER_ID], [R_TYPE], [R_NAME], [R_ADDRESS]) VALUES (90015, N'STAFF', N'SMITH', N'Trenton')
INSERT [dbo].[READER] ([READER_ID], [R_TYPE], [R_NAME], [R_ADDRESS]) VALUES (90016, N'STUDENT', N'ROSE', N'Trenton')
INSERT [dbo].[READER] ([READER_ID], [R_TYPE], [R_NAME], [R_ADDRESS]) VALUES (90017, N'STAFF', N'NANDAN', N'Edge City')
INSERT [dbo].[READER] ([READER_ID], [R_TYPE], [R_NAME], [R_ADDRESS]) VALUES (90018, N'SENIOR CITIZEN', N'MAX', N'Gotham')
INSERT [dbo].[READER] ([READER_ID], [R_TYPE], [R_NAME], [R_ADDRESS]) VALUES (90019, N'STAFF', N'NANCY', N'Metro Police')
INSERT [dbo].[READER] ([READER_ID], [R_TYPE], [R_NAME], [R_ADDRESS]) VALUES (90020, N'STUDENT', N'RACHID', N'Star City')
INSERT [dbo].[READER] ([READER_ID], [R_TYPE], [R_NAME], [R_ADDRESS]) VALUES (90021, N'STAFF', N'BOB', N'New York')
INSERT [dbo].[READER] ([READER_ID], [R_TYPE], [R_NAME], [R_ADDRESS]) VALUES (90022, N'STUDENT', N'ROSIE', N'Queens')
INSERT [dbo].[READER] ([READER_ID], [R_TYPE], [R_NAME], [R_ADDRESS]) VALUES (90023, N'SENIOR CITIZEN', N'OLIVIA', N'Downtown')
INSERT [dbo].[READER] ([READER_ID], [R_TYPE], [R_NAME], [R_ADDRESS]) VALUES (90024, N'STUDENT', N'JESSICA', N'Star City')
INSERT [dbo].[READER] ([READER_ID], [R_TYPE], [R_NAME], [R_ADDRESS]) VALUES (90025, N'STUDENT', N'GRACE', N'Gotham')
INSERT [dbo].[READER] ([READER_ID], [R_TYPE], [R_NAME], [R_ADDRESS]) VALUES (90026, N'SENIOR CITIZEN', N'DAISY', N'Jersey City')
INSERT [dbo].[READER] ([READER_ID], [R_TYPE], [R_NAME], [R_ADDRESS]) VALUES (90027, N'STAFF', N'STEPHEN', N'Hyderabad')
INSERT [dbo].[READER] ([READER_ID], [R_TYPE], [R_NAME], [R_ADDRESS]) VALUES (90028, N'STUDENT', N'JOSE', N'Hyderabad')
INSERT [dbo].[READER] ([READER_ID], [R_TYPE], [R_NAME], [R_ADDRESS]) VALUES (90029, N'SENIOR CITIZEN', N'STAN', N'Hyderabad')
INSERT [dbo].[READER] ([READER_ID], [R_TYPE], [R_NAME], [R_ADDRESS]) VALUES (90030, N'STAFF', N'JENNIFER', N'Kundanhalli')
GO
ALTER TABLE [dbo].[READER] ADD  DEFAULT (NULL) FOR [R_TYPE]
GO
ALTER TABLE [dbo].[READER] ADD  DEFAULT (NULL) FOR [R_NAME]
GO
ALTER TABLE [dbo].[READER] ADD  DEFAULT (NULL) FOR [R_ADDRESS]
GO
