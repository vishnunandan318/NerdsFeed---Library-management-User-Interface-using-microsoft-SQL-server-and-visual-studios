USE [nerds_feed]
GO
/****** Object:  Table [dbo].[JOURNAL_ISSUE]    Script Date: 20-07-2020 15:43:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JOURNAL_ISSUE](
	[DOC_ID] [int] NOT NULL,
	[ISSUE_NO] [int] NOT NULL,
	[SCOPE] [varchar](65) NULL,
PRIMARY KEY CLUSTERED 
(
	[DOC_ID] ASC,
	[ISSUE_NO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[JOURNAL_ISSUE] ([DOC_ID], [ISSUE_NO], [SCOPE]) VALUES (20001, 1, N'The Philosophers Stone')
INSERT [dbo].[JOURNAL_ISSUE] ([DOC_ID], [ISSUE_NO], [SCOPE]) VALUES (20001, 2, N'Chamber Of Secrets')
INSERT [dbo].[JOURNAL_ISSUE] ([DOC_ID], [ISSUE_NO], [SCOPE]) VALUES (20001, 3, N'The Prisoner Of Azkaban')
INSERT [dbo].[JOURNAL_ISSUE] ([DOC_ID], [ISSUE_NO], [SCOPE]) VALUES (20001, 4, N'The Goblet of Fire')
INSERT [dbo].[JOURNAL_ISSUE] ([DOC_ID], [ISSUE_NO], [SCOPE]) VALUES (20001, 5, N'The Order Of The Pheonix')
INSERT [dbo].[JOURNAL_ISSUE] ([DOC_ID], [ISSUE_NO], [SCOPE]) VALUES (20001, 6, N'The Half Blooded Prince')
INSERT [dbo].[JOURNAL_ISSUE] ([DOC_ID], [ISSUE_NO], [SCOPE]) VALUES (20001, 7, N'The Deathly Hallows')
INSERT [dbo].[JOURNAL_ISSUE] ([DOC_ID], [ISSUE_NO], [SCOPE]) VALUES (20002, 1, N'The Fellowship of the Ring')
INSERT [dbo].[JOURNAL_ISSUE] ([DOC_ID], [ISSUE_NO], [SCOPE]) VALUES (20002, 2, N'The Two Towers')
INSERT [dbo].[JOURNAL_ISSUE] ([DOC_ID], [ISSUE_NO], [SCOPE]) VALUES (20002, 3, N'The Return of the King')
INSERT [dbo].[JOURNAL_ISSUE] ([DOC_ID], [ISSUE_NO], [SCOPE]) VALUES (20003, 1, N'A Game of Thrones')
INSERT [dbo].[JOURNAL_ISSUE] ([DOC_ID], [ISSUE_NO], [SCOPE]) VALUES (20003, 2, N'A Clash of Kings')
INSERT [dbo].[JOURNAL_ISSUE] ([DOC_ID], [ISSUE_NO], [SCOPE]) VALUES (20003, 3, N'A Storm of Swords')
INSERT [dbo].[JOURNAL_ISSUE] ([DOC_ID], [ISSUE_NO], [SCOPE]) VALUES (20003, 4, N'A Feast of Crows')
INSERT [dbo].[JOURNAL_ISSUE] ([DOC_ID], [ISSUE_NO], [SCOPE]) VALUES (20003, 5, N'A Dance With Dragons')
INSERT [dbo].[JOURNAL_ISSUE] ([DOC_ID], [ISSUE_NO], [SCOPE]) VALUES (20003, 6, N'The Winds Of Winter')
INSERT [dbo].[JOURNAL_ISSUE] ([DOC_ID], [ISSUE_NO], [SCOPE]) VALUES (20003, 7, N'A Dream of Spring')
INSERT [dbo].[JOURNAL_ISSUE] ([DOC_ID], [ISSUE_NO], [SCOPE]) VALUES (20004, 1, N'The Battle Of FIve Armies')
INSERT [dbo].[JOURNAL_ISSUE] ([DOC_ID], [ISSUE_NO], [SCOPE]) VALUES (20005, 1, N'The Batman Begins')
INSERT [dbo].[JOURNAL_ISSUE] ([DOC_ID], [ISSUE_NO], [SCOPE]) VALUES (20005, 2, N'The Dark Knight')
INSERT [dbo].[JOURNAL_ISSUE] ([DOC_ID], [ISSUE_NO], [SCOPE]) VALUES (20005, 3, N'The Dark Knight Rises')
INSERT [dbo].[JOURNAL_ISSUE] ([DOC_ID], [ISSUE_NO], [SCOPE]) VALUES (20006, 1, N'The Phantom Of Menace')
INSERT [dbo].[JOURNAL_ISSUE] ([DOC_ID], [ISSUE_NO], [SCOPE]) VALUES (20006, 2, N'Attack Of The Clones')
INSERT [dbo].[JOURNAL_ISSUE] ([DOC_ID], [ISSUE_NO], [SCOPE]) VALUES (20006, 3, N'Revenge Of The Sith')
INSERT [dbo].[JOURNAL_ISSUE] ([DOC_ID], [ISSUE_NO], [SCOPE]) VALUES (20006, 4, N'A New Hope')
INSERT [dbo].[JOURNAL_ISSUE] ([DOC_ID], [ISSUE_NO], [SCOPE]) VALUES (20006, 5, N'Empire Strikes Back')
INSERT [dbo].[JOURNAL_ISSUE] ([DOC_ID], [ISSUE_NO], [SCOPE]) VALUES (20006, 6, N'Return Of The Jedi')
INSERT [dbo].[JOURNAL_ISSUE] ([DOC_ID], [ISSUE_NO], [SCOPE]) VALUES (20006, 7, N'The Force Awakens')
INSERT [dbo].[JOURNAL_ISSUE] ([DOC_ID], [ISSUE_NO], [SCOPE]) VALUES (20006, 8, N'The Last Jedi')
INSERT [dbo].[JOURNAL_ISSUE] ([DOC_ID], [ISSUE_NO], [SCOPE]) VALUES (20006, 9, N'The Rise of Skywalker')
GO
ALTER TABLE [dbo].[JOURNAL_ISSUE] ADD  DEFAULT (NULL) FOR [SCOPE]
GO
ALTER TABLE [dbo].[JOURNAL_ISSUE]  WITH CHECK ADD  CONSTRAINT [journal_issue_ibfk_1] FOREIGN KEY([DOC_ID])
REFERENCES [dbo].[JOURNAL_VOLUME] ([DOC_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[JOURNAL_ISSUE] CHECK CONSTRAINT [journal_issue_ibfk_1]
GO
