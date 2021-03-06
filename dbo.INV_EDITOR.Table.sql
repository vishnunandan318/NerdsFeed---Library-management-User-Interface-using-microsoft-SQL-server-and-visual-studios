USE [nerds_feed]
GO
/****** Object:  Table [dbo].[INV_EDITOR]    Script Date: 20-07-2020 15:43:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INV_EDITOR](
	[DOC_ID] [int] NOT NULL,
	[ISSUE_NO] [int] NOT NULL,
	[IE_NAME] [varchar](65) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DOC_ID] ASC,
	[ISSUE_NO] ASC,
	[IE_NAME] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20001, 1, N'Chris Coloumbus')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20001, 2, N'Chris Coloumbus')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20001, 3, N'Alfanso Cuaron')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20001, 4, N'Mike Newell')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20001, 5, N'David Yates')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20001, 6, N'Alfanso Cuaron')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20001, 6, N'David Yates')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20001, 6, N'Mike Newell')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20001, 7, N'Chris Coloumbus')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20001, 7, N'David Yates')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20002, 1, N'Fran Walsh')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20002, 1, N'Tim Sanders')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20002, 2, N'Ian Mckellan')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20002, 3, N'Billy Boyd')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20002, 3, N'Elijah Wood')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20003, 1, N'Tom Hallman')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20003, 2, N'Roy Dotrice')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20003, 2, N'Steve Youll')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20003, 3, N'Balon Greyjoy')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20003, 3, N'Manice Ryder')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20003, 4, N'Arianna Martell')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20003, 4, N'Lisa Kidman')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20003, 5, N'John Lee,')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20003, 5, N'Robert Dwine')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20003, 6, N'Graham Norton')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20003, 6, N'Sir Elliot')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20003, 7, N'Dana Swift')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20004, 1, N'Billy Boyd')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20004, 1, N'Elijah Wood')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20004, 1, N'Kevin Hearne')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20005, 1, N'David S Goyver')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20005, 2, N'Jonathon Nolan')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20005, 3, N'David S Goyver')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20005, 3, N'Jonathon Nolan')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20006, 1, N'Joe Schreiber')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20006, 1, N'Ryder Windham')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20006, 2, N'Alexander Freed')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20006, 3, N'Matt Forbeck')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20006, 4, N'Adam Gidwitz')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20006, 5, N'Ryder Windham')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20006, 6, N'Michael Kogge')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20006, 7, N'Adam Gidwitz')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20006, 7, N'Elizabeth Schaefer')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20006, 8, N'Tom Angleberger')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20006, 9, N'Chris Coloumbus')
INSERT [dbo].[INV_EDITOR] ([DOC_ID], [ISSUE_NO], [IE_NAME]) VALUES (20006, 9, N'David Yates')
GO
ALTER TABLE [dbo].[INV_EDITOR]  WITH CHECK ADD  CONSTRAINT [inv_editor_ibfk_1] FOREIGN KEY([DOC_ID], [ISSUE_NO])
REFERENCES [dbo].[JOURNAL_ISSUE] ([DOC_ID], [ISSUE_NO])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[INV_EDITOR] CHECK CONSTRAINT [inv_editor_ibfk_1]
GO
