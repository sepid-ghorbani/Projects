USE [PrintingDB]
GO
/****** Object:  StoredProcedure [dbo].[Alerts_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Alerts_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[Alerts] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[Alerts_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Alerts_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[Alerts]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Alerts_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Alerts_Insert]
	@Id int output,
	@Text nvarchar(MAX) ,
	@Date datetime ,
	@Viewed bit ,
	@UserId int 

AS

INSERT [dbo].[Alerts]
(
	[Text],
	[Date],
	[Viewed],
	[UserId]

)
VALUES
(
	@Text,
	@Date,
	@Viewed,
	@UserId

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[Alerts_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Alerts_SelectAll]
AS

	SELECT 
		[Id], [Text], [Date], [Viewed], [UserId]
	FROM [dbo].[Alerts]






GO
/****** Object:  StoredProcedure [dbo].[Alerts_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Alerts_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [Text], [Date], [Viewed], [UserId] FROM [dbo].[Alerts] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[Alerts_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Alerts_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [Text], [Date], [Viewed], [UserId]
	FROM [dbo].[Alerts]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Alerts_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Alerts_Update]
	@Id int,
	@Text nvarchar(MAX),
	@Date datetime,
	@Viewed bit,
	@UserId int

AS

UPDATE [dbo].[Alerts]
SET
	[Text] = @Text,
	[Date] = @Date,
	[Viewed] = @Viewed,
	[UserId] = @UserId
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[BladeTypes_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BladeTypes_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[BladeTypes] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[BladeTypes_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BladeTypes_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[BladeTypes]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[BladeTypes_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BladeTypes_Insert]
	@Id int output,
	@Name nvarchar(MAX) 

AS

INSERT [dbo].[BladeTypes]
(
	[Name]

)
VALUES
(
	@Name

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[BladeTypes_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BladeTypes_SelectAll]
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[BladeTypes]






GO
/****** Object:  StoredProcedure [dbo].[BladeTypes_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BladeTypes_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [Name] FROM [dbo].[BladeTypes] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[BladeTypes_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BladeTypes_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[BladeTypes]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[BladeTypes_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BladeTypes_Update]
	@Id int,
	@Name nvarchar(MAX)

AS

UPDATE [dbo].[BladeTypes]
SET
	[Name] = @Name
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[BuyAndPreparingPaper_Report]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BuyAndPreparingPaper_Report]
    @OrderReceiverId INT = NULL ,
    @SourceId INT = NULL ,
    @DestinationId INT = NULL ,
    @MaterialTypeId INT = NULL ,
    @MaterialTypeGramazhId INT = NULL ,
    @PaperWidthId INT = NULL ,
    @PaperHeightId INT = NULL ,
    @StartDate DATETIME = NULL ,
    @EndDate DATETIME = NULL
AS
    SELECT  *
    INTO    #tmpReportData
    FROM    ( SELECT    N'خرید کاغذ' AS OperationType ,
                        j.Id AS JobId ,
                        [dbo].[CalculatePersianDate](j.CreateDate) AS JobCreateDate ,
                        o.Name AS [Source] ,
                        i.Name AS Destination ,
                        m.Name AS MaterialType ,
                        mg.Name AS MaterialTypeGramazh ,
                        pw.Name AS PaperWidth ,
                        ph.Name AS PaperHeight ,
                        lc.Name AS LeafCount
              FROM      [dbo].[BuyPaper] bp
                        INNER JOIN dbo.Jobs j ON j.Id = bp.JobId
                        INNER JOIN dbo.OrderReceivers o ON o.Id = bp.OrderReceiverId
                        INNER JOIN dbo.Institute i ON i.Id = bp.InstituteId
                        INNER JOIN dbo.MaterialTypes m ON m.Id = bp.MaterialTypeId
                        INNER JOIN dbo.MaterialTypeGramazh mg ON mg.Id = bp.MaterialTypeGramazhId
                        INNER JOIN dbo.PaperWidth pw ON pw.Id = bp.PaperWidthId
                        INNER JOIN dbo.PaperHeight ph ON ph.Id = bp.PaperHeightId
                        INNER JOIN dbo.LeafCount lc ON lc.Id = bp.LeafCountId
              WHERE     ( bp.OrderReceiverId = @OrderReceiverId
                          OR @OrderReceiverId IS NULL
                        )
                        AND ( bp.InstituteId = @DestinationId
                              OR @DestinationId IS NULL
                            )
                        AND ( bp.MaterialTypeId = @MaterialTypeId
                              OR @MaterialTypeId IS NULL
                            )
                        AND ( bp.MaterialTypeGramazhId = @MaterialTypeGramazhId
                              OR @MaterialTypeGramazhId IS NULL
                            )
                        AND ( bp.PaperWidthId = @PaperWidthId
                              OR @PaperWidthId IS NULL
                            )
                        AND ( bp.PaperHeightId = @PaperHeightId
                              OR @PaperHeightId IS NULL
                            )
                        AND ( j.CreateDate >= @StartDate
                              OR @StartDate IS NULL
                            )
                        AND ( j.CreateDate <= @EndDate
                              OR @EndDate IS NULL
                            )
              UNION
              SELECT    N'تامین کاغذ' AS OperationType ,
                        j.Id AS JobId ,
                        [dbo].[CalculatePersianDate](j.CreateDate) AS JobCreateDate ,
                        fi.Name AS [Source] ,
                        ti.Name AS Destination ,
                        m.Name AS MaterialType ,
                        mg.Name AS MaterialTypeGramazh ,
                        pw.Name AS PaperWidth ,
                        ph.Name AS PaperHeight ,
                        p.LeafCount
              FROM      [dbo].[PreparingPaper] p
                        INNER JOIN dbo.Jobs j ON j.Id = p.JobId
                        INNER JOIN dbo.Institute fi ON fi.Id = p.FromInstituteId
                        INNER JOIN dbo.Institute ti ON ti.Id = p.ToInstituteId
                        INNER JOIN dbo.MaterialTypes m ON m.Id = p.MaterialTypeId
                        INNER JOIN dbo.MaterialTypeGramazh mg ON mg.Id = p.MaterialTypeGramazhId
                        INNER JOIN dbo.PaperWidth pw ON pw.Id = p.PaperWidthId
                        INNER JOIN dbo.PaperHeight ph ON ph.Id = p.PaperHeightId
              WHERE     ( p.FromInstituteId = @SourceId
                          OR @SourceId IS NULL
                        )
                        AND ( p.ToInstituteId = @DestinationId
                              OR @DestinationId IS NULL
                            )
                        AND ( p.MaterialTypeId = @MaterialTypeId
                              OR @MaterialTypeId IS NULL
                            )
                        AND ( p.MaterialTypeGramazhId = @MaterialTypeGramazhId
                              OR @MaterialTypeGramazhId IS NULL
                            )
                        AND ( p.PaperWidthId = @PaperWidthId
                              OR @PaperWidthId IS NULL
                            )
                        AND ( p.PaperHeightId = @PaperHeightId
                              OR @PaperHeightId IS NULL
                            )
                        AND ( j.CreateDate >= @StartDate
                              OR @StartDate IS NULL
                            )
                        AND ( j.CreateDate <= @EndDate
                              OR @EndDate IS NULL
                            )
            ) AS tb


    SELECT  CAST(ROW_NUMBER() OVER ( ORDER BY JobId DESC ) AS NVARCHAR(50)) AS RowNum ,
            OperationType ,
            JobId ,
            JobCreateDate ,
            [Source] ,
            Destination ,
            MaterialType ,
            MaterialTypeGramazh ,
            PaperWidth ,
            PaperHeight ,
            LeafCount
    FROM    #tmpReportData
    ORDER BY JobId DESC
	



GO
/****** Object:  StoredProcedure [dbo].[BuyPaper_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BuyPaper_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[BuyPaper] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[BuyPaper_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BuyPaper_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[BuyPaper]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[BuyPaper_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BuyPaper_Insert]
	@Id int output,
	@JobId int ,
	@OrderReceiverId int ,
	@Row int ,
	@MaterialTypeId int ,
	@MaterialTypeGramazhId int ,
	@PaperWidthId int ,
	@PaperHeightId int ,
	@ParagraphCount int = null ,
	@LeafCountId int ,
	@Fee money = null ,
	@SumCostType int ,
	@SumCost money = null ,
	@InstituteId int ,
	@InvoiceRow nvarchar(50) = null ,
	@InvoiceNum nvarchar(50) = null ,
	@InvoiceCost money = null,
	@Description nvarchar(MAX) = null

AS

INSERT [dbo].[BuyPaper]
(
	[JobId],
	[OrderReceiverId],
	[Row],
	[MaterialTypeId],
	[MaterialTypeGramazhId],
	[PaperWidthId],
	[PaperHeightId],
	[ParagraphCount],
	[LeafCountId],
	[Fee],
	[SumCostType],
	[SumCost],
	[InstituteId],
	[InvoiceRow],
	[InvoiceNum],
	[InvoiceCost],
	[Description]

)
VALUES
(
	@JobId,
	@OrderReceiverId,
	@Row,
	@MaterialTypeId,
	@MaterialTypeGramazhId,
	@PaperWidthId,
	@PaperHeightId,
	@ParagraphCount,
	@LeafCountId,
	@Fee,
	@SumCostType,
	@SumCost,
	@InstituteId,
	@InvoiceRow,
	@InvoiceNum,
	@InvoiceCost,
	@Description

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[BuyPaper_ReportById]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BuyPaper_ReportById]
@Id int
AS
DECLARE @jobId int
SET @jobId = (SELECT JobId FROM dbo.BuyPaper WHERE Id =@Id); 

WITH cte AS (
SELECT N'خرید کاغذ' + cast(Row_number() OVER(ORDER BY bp.Id) as nvarchar(50)) AS Row ,bp.Id
	   FROM dbo.BuyPaper bp
	   WHERE bp.JobId = @jobId)

SELECT bp.[Id],
	  (SELECT Row FROM cte WHERE Id = @Id) AS Row,j.Code,
	  J.Name AS job,J.Id AS JobId,dbo.CalculatePersianDate(j.CreateDate) AS CreateDatePersian,
	  c.NAME AS CustomerName,
	  o.Name AS OrderReceiver,mt.Name AS MaterialType, mtg.Name AS MaterialTypeGramazh,
	  pw.Name AS  PaperWidth,ph.Name AS PaperHeight,ParagraphCount,lc.Name AS LeafCount,
	  Fee,(CASE WHEN SumCostType=1 THEN N'کاغذ های کیلویی'
				WHEN SumCostType=2 THEN N'بندی بسته ای'
				WHEN SumCostType=3 THEN N'برگی' END) AS SumCostType,
	  SumCost,i.Name AS Institute,InvoiceRow,InvoiceNum,InvoiceCost,bp.Description
       
  FROM [dbo].BuyPaper bp
  INNER JOIN dbo.Jobs J ON J.Id = bp.JobId
  INNER JOIN dbo.Customers c ON c.Id = j.CustomerId
  INNER JOIN dbo.OrderReceivers O ON O.Id = bp.OrderReceiverId
  INNER JOIN dbo.MaterialTypes mt ON mt.Id = bp.MaterialTypeId
  INNER JOIN dbo.MaterialTypeGramazh mtg ON mtg.Id = bp.MaterialTypeGramazhId
  INNER JOIN dbo.PaperWidth pw ON pw.Id = bp.PaperWidthId
  INNER JOIN dbo.PaperHeight ph ON ph.Id = bp.PaperHeightId
  INNER JOIN dbo.LeafCount lc ON lc.Id = bp.LeafCountId
  INNER JOIN dbo.Institute i ON i.Id = bp.InstituteId
  

  
WHERE bp.Id = @Id





GO
/****** Object:  StoredProcedure [dbo].[BuyPaper_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BuyPaper_SelectAll]
AS

	SELECT 
		[Id], [JobId], [OrderReceiverId], [Row], [MaterialTypeId], [MaterialTypeGramazhId], [PaperWidthId], [PaperHeightId], [ParagraphCount], [LeafCountId], [Fee], [SumCostType], [SumCost], [InstituteId], [InvoiceRow], [InvoiceNum], [InvoiceCost],[Description]
	FROM [dbo].[BuyPaper]






GO
/****** Object:  StoredProcedure [dbo].[BuyPaper_SelectAll_ForGrid]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BuyPaper_SelectAll_ForGrid]
@JobId int
AS

	SELECT 
		p.[Id], N'خرید کاغذ' + cast(Row_number() OVER(ORDER BY p.Id) as nvarchar(50)) as PaperSeries,
		o.Name as OrderReceiverName,  [SumCost] , i.Name as InstituteName,
		mt.Name AS MaterialTypeName
	FROM [dbo].[BuyPaper] p
	inner join [dbo].[OrderReceivers] o on p.OrderReceiverId = o.Id
	inner join [dbo].[Institute] i on p.InstituteId = i.Id
	inner join [dbo].[MaterialTypes] mt on p.MaterialTypeId = mt.Id
	
	where p.JobId = @JobId






GO
/****** Object:  StoredProcedure [dbo].[BuyPaper_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BuyPaper_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [JobId], [OrderReceiverId], [Row], [MaterialTypeId], [MaterialTypeGramazhId], [PaperWidthId], [PaperHeightId], [ParagraphCount], [LeafCountId], [Fee], [SumCostType], [SumCost], [InstituteId], [InvoiceRow], [InvoiceNum], [InvoiceCost],[Description] FROM [dbo].[BuyPaper] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[BuyPaper_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BuyPaper_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [JobId], [OrderReceiverId], [Row], [MaterialTypeId], [MaterialTypeGramazhId], [PaperWidthId], [PaperHeightId], [ParagraphCount], [LeafCountId], [Fee], [SumCostType], [SumCost], [InstituteId], [InvoiceRow], [InvoiceNum], [InvoiceCost],[Description]
	FROM [dbo].[BuyPaper]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[BuyPaper_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BuyPaper_Update]
	@Id int,
	@JobId int,
	@OrderReceiverId int,
	@Row int,
	@MaterialTypeId int,
	@MaterialTypeGramazhId int,
	@PaperWidthId int,
	@PaperHeightId int,
	@ParagraphCount int = null,
	@LeafCountId int,
	@Fee money = null,
	@SumCostType int,
	@SumCost money = null,
	@InstituteId int,
	@InvoiceRow nvarchar(50) = null,
	@InvoiceNum nvarchar(50) = null,
	@InvoiceCost money = null,
	@Description nvarchar(max)=null

AS

UPDATE [dbo].[BuyPaper]
SET
	[JobId] = @JobId,
	[OrderReceiverId] = @OrderReceiverId,
	[Row] = @Row,
	[MaterialTypeId] = @MaterialTypeId,
	[MaterialTypeGramazhId] = @MaterialTypeGramazhId,
	[PaperWidthId] = @PaperWidthId,
	[PaperHeightId] = @PaperHeightId,
	[ParagraphCount] = @ParagraphCount,
	[LeafCountId] = @LeafCountId,
	[Fee] = @Fee,
	[SumCostType] = @SumCostType,
	[SumCost] = @SumCost,
	[InstituteId] = @InstituteId,
	[InvoiceRow] = @InvoiceRow,
	[InvoiceNum] = @InvoiceNum,
	[InvoiceCost] = @InvoiceCost,
	[Description]=@Description
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Cartex_Report_BaseOnCustomer]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Cartex_Report_BaseOnCustomer]
    @CustomerId INT = NULL ,
    @JobName NVARCHAR(MAX) = NULL ,
    @JobCode NVARCHAR(MAX) = NULL ,
    @InputInvoiceStatus INT = NULL ,
    @OutputInvoiceStatus INT = NULL ,
    @DeliveryStatus INT = NULL ,
    @OutputInvoiceNum NVARCHAR(MAX) = NULL ,
    @StartDate DATETIME = NULL ,
    @EndDate DATETIME = NULL
AS
    SELECT  ROW_NUMBER() OVER ( PARTITION BY CartexId ORDER BY Id ) AS RowNum ,
            *
    INTO    #tmpProductDelivery
    FROM    dbo.ProductDelivery

    SELECT  ROW_NUMBER() OVER ( PARTITION BY CartexId ORDER BY Id ) AS RowNum ,
            *
    INTO    #tmpProductionOrder
    FROM    dbo.ProductionOrder

    SELECT  *
    INTO    #tmpReportData
    FROM    ( SELECT    c.JobCode ,
                        c.JobName ,
                        c.CustomerId ,
                        cu.Name AS CustomerName ,
                        po.OrderDate ,
                        [dbo].[CalculatePersianDate](po.OrderDate) AS OrderDatePersian ,
                        po.OrderCount ,
                        NULL AS DeliveryCount ,
                        NULL AS DeliveryDatePersian ,
                        NULL AS OutputInvoiceNum ,
                        NULL AS OutputInvoiceCost ,
                        NULL AS InputInvoiceNum ,
                        NULL AS InputInvoiceCost ,
                        NULL AS InputInvoiceStatus ,
                        NULL AS OutputInvoiceStatus ,
                        0 AS DeliveryStatus
              FROM      dbo.Cartexes c
                        INNER JOIN dbo.Customers cu ON c.CustomerId = cu.Id
                        INNER JOIN #tmpProductionOrder po ON po.CartexId = c.Id
                        LEFT JOIN #tmpProductDelivery pd ON po.RowNum = pd.RowNum
                                                            AND po.CartexId = pd.CartexId
			 WHERE pd.Id IS NULL 
              UNION
              SELECT    c.JobCode ,
                        c.JobName ,
                        c.CustomerId ,
                        cu.Name AS CustomerName ,
                        ( po.OrderDate ) AS OrderDate ,
                        [dbo].[CalculatePersianDate](po.OrderDate) AS OrderDatePersian ,
                        po.OrderCount AS OrderCount ,
                        pd.DeliveryCount ,
                        [dbo].[CalculatePersianDate](pd.DeliveryDate) AS DeliveryDatePersian ,
                        pd.OutputInvoiceNum ,
                        pd.OutputInvoiceCost ,
                        pd.InputInvoiceNum ,
                        pd.InputInvoiceCost ,
                        ( CASE WHEN ( pd.InputInvoiceCost > 0 ) THEN 1
                               ELSE 0
                          END ) AS InputInvoiceStatus ,
                        ( CASE WHEN ( pd.OutputInvoiceCost > 0 ) THEN 1
                               ELSE 0
                          END ) AS OutputInvoiceStatus ,
                        1 AS DeliveryStatus
              FROM      dbo.Cartexes c
                        INNER JOIN dbo.Customers cu ON c.CustomerId = cu.Id
                        INNER JOIN #tmpProductDelivery pd ON pd.CartexId = c.Id
                        INNER JOIN #tmpProductionOrder po ON po.RowNum = pd.RowNum
                                                             AND po.CartexId = pd.CartexId
            ) AS ct




    SELECT  CAST(ROW_NUMBER() OVER ( ORDER BY OrderDate DESC ) AS NVARCHAR(50)) AS RowNum ,
            JobCode ,
            JobCode ,
            JobName ,
            CustomerName ,
            OrderDatePersian ,
            OrderCount ,
            DeliveryCount ,
            DeliveryDatePersian ,
            OutputInvoiceNum ,
            OutputInvoiceCost ,
            InputInvoiceNum ,
            InputInvoiceCost
    FROM    #tmpReportData
    WHERE   ( CustomerId = @CustomerId
              OR @CustomerId IS NULL
            )
            AND ( JobName LIKE '%' + @JobName + '%'
                  OR @JobName IS NULL
                )
            AND ( JobCode LIKE '%' + @JobCode + '%'
                  OR @JobCode IS NULL
                )
            AND ( ( OutputInvoiceNum <> ''
                    AND OutputInvoiceNum LIKE '%' + @OutputInvoiceNum + '%'
                  )
                  OR @OutputInvoiceNum IS NULL
                )
            AND ( ( OrderDate IS NOT NULL
                    AND OrderDate >= @StartDate
                  )
                  OR @StartDate IS NULL
                )
            AND ( ( OrderDate IS NOT NULL
                    AND OrderDate <= @EndDate
                  )
                  OR @EndDate IS NULL
                )
            AND ( ( InputInvoiceStatus IS NOT NULL
                    AND InputInvoiceStatus = @InputInvoiceStatus
                  )
                  OR @InputInvoiceStatus IS NULL
                )
            AND ( ( OutputInvoiceStatus IS NOT NULL
                    AND OutputInvoiceStatus = @OutputInvoiceStatus
                  )
                  OR @OutputInvoiceStatus IS NULL
                )
            AND ( ( DeliveryStatus IS NOT NULL
                    AND DeliveryStatus = @DeliveryStatus
                  )
                  OR @DeliveryStatus IS NULL
                )
    ORDER BY OrderDate DESC 
          








GO
/****** Object:  StoredProcedure [dbo].[Cartex_Report_BaseOnOrderReceiver]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Cartex_Report_BaseOnOrderReceiver]
    @JobTypeId INT = NULL ,
    @LevelName NVARCHAR(MAX) = NULL ,
    @OrderReceiverId INT = NULL ,
    @InputInvoiceStatus INT = NULL ,
    @InputInvoiceNum NVARCHAR(MAX) = NULL ,
    @CustomerId INT = NULL ,
    @JobName NVARCHAR(MAX) = NULL ,
    @JobCode NVARCHAR(MAX) = NULL ,
    @DeliveryStatus INT = NULL ,
    @StartDate DATETIME = NULL ,
    @EndDate DATETIME = NULL
AS
    SELECT  ROW_NUMBER() OVER ( PARTITION BY CartexId ORDER BY Id ) AS RowNum ,
            *
    INTO    #tmpProductDelivery
    FROM    dbo.ProductDelivery

    SELECT  ROW_NUMBER() OVER ( PARTITION BY CartexId ORDER BY Id ) AS RowNum ,
            *
    INTO    #tmpProductionOrder
    FROM    dbo.ProductionOrder

    SELECT  *
    INTO    #tmpReportData
    FROM    ( SELECT    c.JobCode ,
                        c.JobName ,
                        c.CustomerId ,
                        cu.Name AS CustomerName ,
                        NULL AS OrderDate ,
                        NULL AS OrderDatePersian ,
                        NULL AS OrderCount ,
                        NULL AS DeliveryCount ,
                        NULL AS DeliveryDatePersian ,
                        NULL AS InputInvoiceNum ,
                        NULL AS InputInvoiceCost ,
                        NULL AS InputInvoiceDatePersian ,
                        NULL AS InputInvoiceStatus ,
                        NULL AS DeliveryStatus ,
                        o.Name AS OrderReceiverName ,
                        N'موجودی اولیه' AS LevelName ,
                        ps.JobTypesId ,
                        ps.ToOrderReceiversId AS OrderReceiversId
              FROM      dbo.Cartexes c
                        INNER JOIN dbo.Customers cu ON c.CustomerId = cu.Id
                        INNER JOIN [dbo].[PrimaryStock] ps ON ps.CartexId = c.Id
                        INNER JOIN dbo.OrderReceivers o ON ps.ToOrderReceiversId = o.Id
              UNION
              SELECT    c.JobCode ,
                        c.JobName ,
                        c.CustomerId ,
                        cu.Name AS CustomerName ,
                        po.OrderDate ,
                        [dbo].[CalculatePersianDate](po.OrderDate) AS OrderDatePersian ,
                        po.OrderCount ,
                        pd.DeliveryCount AS DeliveryCount ,
                        [dbo].[CalculatePersianDate](pd.DeliveryDate) AS DeliveryDatePersian ,
                        NULL AS InputInvoiceNum ,
                        NULL AS InputInvoiceCost ,
                        NULL AS InputInvoiceDatePersian ,
                        NULL AS InputInvoiceStatus ,
                        ( CASE WHEN pd.Id IS NOT NULL THEN 1
                               ELSE 0
                          END ) AS DeliveryStatus ,
                        o.Name AS OrderReceiverName ,
                        N'سفارش تولید' AS LevelName ,
                        ps.JobTypesId ,
                        ps.ToOrderReceiversId AS OrderReceiversId
              FROM      dbo.Cartexes c
                        INNER JOIN dbo.Customers cu ON c.CustomerId = cu.Id
                        INNER JOIN #tmpProductionOrder po ON po.CartexId = c.Id
                        LEFT JOIN #tmpProductDelivery pd ON po.CartexId = pd.CartexId
                                                            AND po.RowNum = pd.RowNum
                        LEFT JOIN dbo.View_PrimaryStock ps ON ps.CartexId = c.Id
                        LEFT JOIN dbo.OrderReceivers o ON ps.ToOrderReceiversId = o.Id
              UNION
              SELECT    c.JobCode ,
                        c.JobName ,
                        c.CustomerId ,
                        cu.Name AS CustomerName ,
                        po.OrderDate AS OrderDate ,
                        [dbo].[CalculatePersianDate](po.OrderDate) AS OrderDatePersian ,
                        po.OrderCount AS OrderCount ,
                        pd.DeliveryCount ,
                        [dbo].[CalculatePersianDate](pd.DeliveryDate) AS DeliveryDatePersian ,
                        pd.InputInvoiceNum ,
                        pd.InputInvoiceCost ,
                        [dbo].[CalculatePersianDate](pd.InputInvoiceDate) AS InputInvoiceDatePersian ,
                        ( CASE WHEN ( pd.InputInvoiceCost > 0 ) THEN 1
                               ELSE 0
                          END ) AS InputInvoiceStatus ,
                        1 AS DeliveryStatus ,
                        o.Name AS OrderReceiverName ,
                        N'تحویل محصول' AS LevelName ,
                        ps.JobTypesId ,
                        ps.ToOrderReceiversId AS OrderReceiversId
              FROM      dbo.Cartexes c
                        INNER JOIN dbo.Customers cu ON c.CustomerId = cu.Id
                        INNER JOIN #tmpProductDelivery pd ON pd.CartexId = c.Id
                        INNER JOIN #tmpProductionOrder po ON po.RowNum = pd.RowNum
                                                             AND po.CartexId = pd.CartexId
                        LEFT JOIN dbo.View_PrimaryStock ps ON ps.CartexId = c.Id
                        LEFT JOIN dbo.OrderReceivers o ON ps.ToOrderReceiversId = o.Id
            ) AS ct




    SELECT  CAST(ROW_NUMBER() OVER ( ORDER BY OrderDate DESC ) AS NVARCHAR(50)) AS RowNum ,
            JobCode ,
            JobName ,
            CustomerName ,
            OrderDatePersian ,
            OrderCount ,
            OrderReceiverName ,
            LevelName ,
            DeliveryCount ,
            DeliveryDatePersian ,
            InputInvoiceNum ,
            InputInvoiceCost ,
            InputInvoiceDatePersian
    FROM    #tmpReportData
    WHERE   ( JobTypesId = @JobTypeId
              OR @JobTypeId IS NULL
            )
            AND ( OrderReceiversId = @OrderReceiverId
                  OR @OrderReceiverId IS NULL
                )
            AND ( ( InputInvoiceNum <> ''
                    AND InputInvoiceNum LIKE '%' + @InputInvoiceNum + '%'
                  )
                  OR @InputInvoiceNum IS NULL
                )
            AND ( CustomerId = @CustomerId
                  OR @CustomerId IS NULL
                )
            AND ( JobName LIKE '%' + @JobName + '%'
                  OR @JobName IS NULL
                )
            AND ( JobCode LIKE '%' + @JobCode + '%'
                  OR @JobCode IS NULL
                )
            AND ( ( OrderDate IS NOT NULL
                    AND OrderDate >= @StartDate
                  )
                  OR @StartDate IS NULL
                )
            AND ( OrderDate IS NOT NULL
                  AND OrderDate <= @EndDate
                  OR @EndDate IS NULL
                )
            AND ( LevelName LIKE '%' + @LevelName + '%'
                  OR @LevelName IS NULL
                )
            AND ( ( InputInvoiceStatus IS NOT NULL
                    AND InputInvoiceStatus = @InputInvoiceStatus
                  )
                  OR @InputInvoiceStatus IS NULL
                )
            AND ( ( DeliveryStatus IS NOT NULL
                    AND DeliveryStatus = @DeliveryStatus
                  )
                  OR @DeliveryStatus IS NULL
                )
    ORDER BY OrderDate DESC

   








GO
/****** Object:  StoredProcedure [dbo].[Cartex_Report_ProductStock]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Cartex_Report_ProductStock]
    @OrderReceiverId INT = NULL ,
    @JobName NVARCHAR(MAX) = NULL ,
    @JobCode NVARCHAR(MAX) = NULL ,
    @JobTypeId INT = NULL
AS
    SELECT  o.Name AS OrderReceiverName ,
            j.Name AS JobTypeName ,
            c.JobCode ,
            c.JobName ,
            c.Stock AS Remain
    INTO    #tmpReportData
    FROM    dbo.Cartexes c
            LEFT JOIN dbo.View_PrimaryStock ps ON ps.CartexId = c.Id
            INNER JOIN dbo.OrderReceivers o ON o.Id = ps.ToOrderReceiversId
            INNER JOIN dbo.JobTypes j ON ps.JobTypesId = j.Id
    WHERE   ( ps.ToOrderReceiversId = @OrderReceiverId
              OR @OrderReceiverId IS NULL
            )
            AND ( c.JobName LIKE '%' + @JobName + '%'
                  OR @JobName IS NULL
                )
            AND ( c.JobCode LIKE '%' + @JobCode + '%'
                  OR @JobCode IS NULL
                )
            AND ( ps.JobTypesId = @JobTypeId
                  OR @JobTypeId IS NULL
                )

    SELECT  CAST(ROW_NUMBER() OVER ( ORDER BY JobName ) AS NVARCHAR(50)) AS RowNum ,
            OrderReceiverName ,
            JobTypeName ,
            JobCode ,
            JobName ,
            Remain
    FROM    #tmpReportData
    ORDER BY JobName           








GO
/****** Object:  StoredProcedure [dbo].[Cartexes_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Cartexes_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[Cartexes] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)




GO
/****** Object:  StoredProcedure [dbo].[Cartexes_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Cartexes_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[Cartexes]
 WHERE 
	[Id] = @Id




GO
/****** Object:  StoredProcedure [dbo].[Cartexes_GetTotalCount]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Cartexes_GetTotalCount]
    @JobName NVARCHAR(MAX) = NULL ,
    @JobCode NVARCHAR(MAX) = NULL
AS
    SELECT  COUNT(*)
    FROM    [dbo].[Cartexes] cartexes
            INNER JOIN [dbo].[Customers] customers ON cartexes.CustomerId = Customers.Id
    WHERE   ( cartexes.JobName LIKE '%' + @JobName + '%'
              OR @JobName IS NULL
            )
            AND ( cartexes.JobCode LIKE '%' + @JobCode + '%'
                  OR @JobCode IS NULL
                )






GO
/****** Object:  StoredProcedure [dbo].[Cartexes_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Cartexes_Insert]
	@Id int output,
	@CustomerId int ,
	@JobName nvarchar(MAX) ,
	@JobCode nvarchar(MAX) ,
	@Description nvarchar(MAX) = null ,
	@StoreCode INT = NULL ,
	@Stock BIGINT

AS

INSERT [dbo].[Cartexes]
(
	[CustomerId],
	[JobName],
	[JobCode],
	[Description],
	[StoreCode],
	[Stock]
	

)
VALUES
(
	@CustomerId,
	@JobName,
	@JobCode,
	@Description,
	@StoreCode,
	@Stock

)
	SELECT @Id=SCOPE_IDENTITY();





GO
/****** Object:  StoredProcedure [dbo].[Cartexes_OperationBeforeDelete]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Cartexes_OperationBeforeDelete] @CartexId INT
AS
    DECLARE @JobCode NVARCHAR(MAX)

    SELECT  @JobCode = [JobCode]
    FROM    [dbo].[Cartexes]
    WHERE   Id = @CartexId

    UPDATE  p
    SET     p.IsUse = 0
    FROM    dbo.Printings p
            INNER JOIN dbo.Jobs j ON p.JobId = j.Id
    WHERE   j.Code = @JobCode




GO
/****** Object:  StoredProcedure [dbo].[Cartexes_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Cartexes_SelectAll]
AS
    SELECT  [Id] ,
            [CustomerId] ,
            [JobName] ,
            [JobCode] ,
            [Description] ,
            [StoreCode] ,
            [Stock]
    FROM    [dbo].[Cartexes]




GO
/****** Object:  StoredProcedure [dbo].[Cartexes_SelectAll_ForGrid]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Cartexes_SelectAll_ForGrid]
    @JobName NVARCHAR(MAX) = NULL ,
    @JobCode NVARCHAR(MAX) = NULL ,
    @StartIndex INT = 1 ,
    @PageSize INT = 10
AS
    DECLARE @Tirazh INT;
    SELECT  cartexes.[Id] ,
            customers.Name AS CustomerName ,
            [JobName] ,
            [JobCode] ,
            cartexes.[Description] ,
            ROW_NUMBER() OVER ( ORDER BY [JobName] ) AS rownum ,
            cartexes.Stock AS Remain
    INTO    #tmpTable
    FROM    [dbo].[Cartexes] cartexes
            INNER JOIN [dbo].[Customers] customers ON cartexes.CustomerId = customers.Id
    WHERE   ( cartexes.JobName LIKE '%' + @JobName + '%'
              OR @JobName IS NULL
            )
            AND ( cartexes.JobCode LIKE '%' + @JobCode + '%'
                  OR @JobCode IS NULL
                )
    ORDER BY [JobName]
            

    SELECT  *
    FROM    #tmpTable
    WHERE   rownum BETWEEN @StartIndex
                   AND     @StartIndex + @PageSize
        









GO
/****** Object:  StoredProcedure [dbo].[Cartexes_SelectAllJobCodes]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Cartexes_SelectAllJobCodes]
AS
    SELECT  [Id] ,
            [CustomerId] ,
            [JobName] ,
            [JobCode] ,
            [Description] ,
            [StoreCode] ,
            [Stock]
    FROM    [dbo].[Cartexes]
	ORDER BY [JobCode]




GO
/****** Object:  StoredProcedure [dbo].[Cartexes_SelectAllJobNames]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Cartexes_SelectAllJobNames]
AS
    SELECT  [Id] ,
            [CustomerId] ,
            [JobName] ,
            [JobCode] ,
            [Description] ,
            [StoreCode] ,
            [Stock]
    FROM    [dbo].[Cartexes]
	ORDER BY [JobName]




GO
/****** Object:  StoredProcedure [dbo].[Cartexes_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Cartexes_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [CustomerId], [JobName], [JobCode], [Description],[StoreCode],[Stock] FROM [dbo].[Cartexes] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)
	
	



GO
/****** Object:  StoredProcedure [dbo].[Cartexes_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Cartexes_SelectByPrimaryKey] @Id INT
AS
    SELECT  [Id] ,
            [CustomerId] ,
            [JobName] ,
            [JobCode] ,
            [Description] ,
            StoreCode ,
            Stock
    FROM    [dbo].[Cartexes]
    WHERE   [Id] = @Id




GO
/****** Object:  StoredProcedure [dbo].[Cartexes_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Cartexes_Update]
    @Id INT ,
    @CustomerId INT ,
    @JobName NVARCHAR(MAX) ,
    @JobCode NVARCHAR(MAX) ,
    @Description NVARCHAR(MAX) = NULL ,
    @StoreCode INT = NULL ,
    @Stock BIGINT
AS
    UPDATE  [dbo].[Cartexes]
    SET     [CustomerId] = @CustomerId ,
            [JobName] = @JobName ,
            [JobCode] = @JobCode ,
            [Description] = @Description ,
            [StoreCode] = @StoreCode ,
            [Stock] = @Stock
    WHERE   [Id] = @Id




GO
/****** Object:  StoredProcedure [dbo].[CopyZinks_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CopyZinks_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[CopyZinks] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[CopyZinks_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CopyZinks_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[CopyZinks]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[CopyZinks_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CopyZinks_Insert]
	@Id int output,
	@JobId int ,
	@OrderReceiverId int ,
	@DimensionId int ,
	@LpiId int ,
	@MainColorCountId int = null ,
	@ExportColorId int ,
	@SpotColorCountId int = null ,
	@SpotColors nvarchar(MAX) = null ,
	@OverPrintBlackColor bit ,
	@DeviceCount int = null ,
	@FormEvertCount float = null ,
	@Description nvarchar(MAX) = null ,
	@InvoiceRow nvarchar(50) = null ,
	@InvoiceNum nvarchar(50) = null ,
	@InvoiceCost money = null 

AS

INSERT [dbo].[CopyZinks]
(
	[JobId],
	[OrderReceiverId],
	[DimensionId],
	[LpiId],
	[MainColorCountId],
	[ExportColorId],
	[SpotColorCountId],
	[SpotColors],
	[OverPrintBlackColor],
	[DeviceCount],
	[FormEvertCount],
	[Description],
	[InvoiceRow],
	[InvoiceNum],
	[InvoiceCost]

)
VALUES
(
	@JobId,
	@OrderReceiverId,
	@DimensionId,
	@LpiId,
	@MainColorCountId,
	@ExportColorId,
	@SpotColorCountId,
	@SpotColors,
	@OverPrintBlackColor,
	@DeviceCount,
	@FormEvertCount,
	@Description,
	@InvoiceRow,
	@InvoiceNum,
	@InvoiceCost

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[CopyZinks_ReportById]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CopyZinks_ReportById]
@Id int
AS

SELECT CP.[Id],J.Name AS job,j.Code,J.Id AS JobId,dbo.CalculatePersianDate(j.CreateDate) AS CreateDatePersian,
	c.NAME AS CustomerName,o.Name AS OrderReceiver,d.Name AS Dimension
      ,l.Name AS Lpi,
     (CASE WHEN mc.Name IS NULL THEN N'ندارد'  ELSE mc.Name END) AS MainColorCount
      ,ex.Name AS ExportColor
     ,(CASE WHEN sp.Name IS NULL THEN N'ندارد'  ELSE sp.Name END) AS SpotColorCount
      ,CP.[SpotColors],
      (CASE WHEN CP.[OverPrintBlackColor] = 1 THEN N'دارد' ELSE N'ندارد' END) AS OverPrintBlackColor
      ,CP.[DeviceCount],CP.[FormEvertCount],CP.[Description]
      ,CP.[InvoiceRow],CP.[InvoiceNum],CP.[InvoiceCost]
  FROM [dbo].[CopyZinks] CP
  INNER JOIN dbo.Jobs J ON J.Id = CP.JobId
  INNER JOIN dbo.Customers c ON c.Id = j.CustomerId
  INNER JOIN dbo.OrderReceivers O ON O.Id = CP.OrderReceiverId
  INNER JOIN dbo.Dimensions D ON D.Id = CP.DimensionId
  INNER JOIN dbo.LPI L ON L.Id = CP.LpiId
  LEFT JOIN dbo.MainColorCount MC ON MC.Id = CP.MainColorCountId
  INNER JOIN dbo.ExportColors EX ON EX.Id = CP.ExportColorId
  LEFT JOIN dbo.MainColorCount SP ON SP.Id = CP.SpotColorCountId
  
WHERE CP.Id = @Id





GO
/****** Object:  StoredProcedure [dbo].[CopyZinks_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CopyZinks_SelectAll]
AS

	SELECT 
		[Id], [JobId], [OrderReceiverId], [DimensionId], [LpiId], [MainColorCountId], [ExportColorId], [SpotColorCountId], [SpotColors], [OverPrintBlackColor], [DeviceCount], [FormEvertCount], [Description], [InvoiceRow], [InvoiceNum], [InvoiceCost]
	FROM [dbo].[CopyZinks]






GO
/****** Object:  StoredProcedure [dbo].[CopyZinks_SelectAll_ForGrid]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CopyZinks_SelectAll_ForGrid]
@JobId int
AS

	SELECT 
		p.[Id], o.Name as OrderReceiverName, d.Name as DimensionName,l.Name AS LpiName, [Description]
	FROM [dbo].[CopyZinks] p 
	inner join [dbo].[OrderReceivers] o on p.OrderReceiverId = o.Id
	inner join [dbo].[Dimensions] d on p.DimensionId = d.Id
	inner join [dbo].[LPI] l on p.LpiId = l.Id
	where p.JobId = @JobId






GO
/****** Object:  StoredProcedure [dbo].[CopyZinks_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CopyZinks_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [JobId], [OrderReceiverId], [DimensionId], [LpiId], [MainColorCountId], [ExportColorId], [SpotColorCountId], [SpotColors], [OverPrintBlackColor], [DeviceCount], [FormEvertCount], [Description], [InvoiceRow], [InvoiceNum], [InvoiceCost] FROM [dbo].[CopyZinks] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[CopyZinks_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CopyZinks_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [JobId], [OrderReceiverId], [DimensionId], [LpiId], [MainColorCountId], [ExportColorId], [SpotColorCountId], [SpotColors], [OverPrintBlackColor], [DeviceCount], [FormEvertCount], [Description], [InvoiceRow], [InvoiceNum], [InvoiceCost]
	FROM [dbo].[CopyZinks]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[CopyZinks_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CopyZinks_Update]
	@Id int,
	@JobId int,
	@OrderReceiverId int,
	@DimensionId int,
	@LpiId int,
	@MainColorCountId int = null,
	@ExportColorId int,
	@SpotColorCountId int = null,
	@SpotColors nvarchar(MAX) = null,
	@OverPrintBlackColor bit,
	@DeviceCount int = null,
	@FormEvertCount float = null,
	@Description nvarchar(MAX) = null,
	@InvoiceRow nvarchar(50) = null,
	@InvoiceNum nvarchar(50) = null,
	@InvoiceCost money = null

AS

UPDATE [dbo].[CopyZinks]
SET
	[JobId] = @JobId,
	[OrderReceiverId] = @OrderReceiverId,
	[DimensionId] = @DimensionId,
	[LpiId] = @LpiId,
	[MainColorCountId] = @MainColorCountId,
	[ExportColorId] = @ExportColorId,
	[SpotColorCountId] = @SpotColorCountId,
	[SpotColors] = @SpotColors,
	[OverPrintBlackColor] = @OverPrintBlackColor,
	[DeviceCount] = @DeviceCount,
	[FormEvertCount] = @FormEvertCount,
	[Description] = @Description,
	[InvoiceRow] = @InvoiceRow,
	[InvoiceNum] = @InvoiceNum,
	[InvoiceCost] = @InvoiceCost
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Customers_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Customers_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[Customers] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[Customers_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Customers_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[Customers]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Customers_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Customers_Insert]
	@Id int output,
	@Name nvarchar(MAX) 

AS

INSERT [dbo].[Customers]
(
	[Name]

)
VALUES
(
	@Name

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[Customers_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Customers_SelectAll]
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[Customers]
	order by Name






GO
/****** Object:  StoredProcedure [dbo].[Customers_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Customers_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [Name] FROM [dbo].[Customers] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[Customers_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Customers_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[Customers]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Customers_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Customers_Update]
	@Id int,
	@Name nvarchar(MAX)

AS

UPDATE [dbo].[Customers]
SET
	[Name] = @Name
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[DeliveryReceivers_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeliveryReceivers_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[DeliveryReceivers] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)




GO
/****** Object:  StoredProcedure [dbo].[DeliveryReceivers_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeliveryReceivers_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[DeliveryReceivers]
 WHERE 
	[Id] = @Id




GO
/****** Object:  StoredProcedure [dbo].[DeliveryReceivers_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeliveryReceivers_Insert]
	@Id int output,
	@Name nvarchar(MAX) 

AS

INSERT [dbo].[DeliveryReceivers]
(
	[Name]

)
VALUES
(
	@Name

)
	SELECT @Id=SCOPE_IDENTITY();





GO
/****** Object:  StoredProcedure [dbo].[DeliveryReceivers_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeliveryReceivers_SelectAll]
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[DeliveryReceivers]
	ORDER BY Name




GO
/****** Object:  StoredProcedure [dbo].[DeliveryReceivers_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeliveryReceivers_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [Name] FROM [dbo].[DeliveryReceivers] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)




GO
/****** Object:  StoredProcedure [dbo].[DeliveryReceivers_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeliveryReceivers_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[DeliveryReceivers]
	WHERE 
			[Id] = @Id




GO
/****** Object:  StoredProcedure [dbo].[DeliveryReceivers_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeliveryReceivers_Update]
	@Id int,
	@Name nvarchar(MAX)

AS

UPDATE [dbo].[DeliveryReceivers]
SET
	[Name] = @Name
 WHERE 
	[Id] = @Id




GO
/****** Object:  StoredProcedure [dbo].[Dimensions_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Dimensions_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[Dimensions] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[Dimensions_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Dimensions_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[Dimensions]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Dimensions_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Dimensions_Insert]
	@Id int output,
	@Name nvarchar(MAX) 

AS

INSERT [dbo].[Dimensions]
(
	[Name]

)
VALUES
(
	@Name

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[Dimensions_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Dimensions_SelectAll]
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[Dimensions]






GO
/****** Object:  StoredProcedure [dbo].[Dimensions_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Dimensions_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [Name] FROM [dbo].[Dimensions] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[Dimensions_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Dimensions_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[Dimensions]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Dimensions_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Dimensions_Update]
	@Id int,
	@Name nvarchar(MAX)

AS

UPDATE [dbo].[Dimensions]
SET
	[Name] = @Name
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[ExportColors_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ExportColors_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[ExportColors] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[ExportColors_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ExportColors_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[ExportColors]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[ExportColors_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ExportColors_Insert]
	@Id int output,
	@Name nvarchar(MAX) 

AS

INSERT [dbo].[ExportColors]
(
	[Name]

)
VALUES
(
	@Name

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[ExportColors_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ExportColors_SelectAll]
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[ExportColors]






GO
/****** Object:  StoredProcedure [dbo].[ExportColors_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ExportColors_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [Name] FROM [dbo].[ExportColors] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[ExportColors_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ExportColors_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[ExportColors]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[ExportColors_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ExportColors_Update]
	@Id int,
	@Name nvarchar(MAX)

AS

UPDATE [dbo].[ExportColors]
SET
	[Name] = @Name
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Films_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Films_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[Films] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[Films_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Films_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[Films]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Films_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Films_Insert]
	@Id int output,
	@JobId int ,
	@OrderReceiverId int ,
	@Dimension nvarchar(MAX) = null ,
	@LpiId int ,
	@MainColorCountId int = null ,
	@ExportColor int ,
	@SpotColorCountId int = null ,
	@SpotColors nvarchar(MAX) = null ,
	@OverPrintBlackColor bit ,
	@DeviceCount int = null ,
	@FormEvertCount float = null ,
	@Film bit ,
	@Description nvarchar(MAX) = null ,
	@InvoiceRow nvarchar(50) = null ,
	@InvoiceNum nvarchar(50) = null ,
	@InvoiceCost money = null 

AS

INSERT [dbo].[Films]
(
	[JobId],
	[OrderReceiverId],
	[Dimension],
	[LpiId],
	[MainColorCountId],
	[ExportColor],
	[SpotColorCountId],
	[SpotColors],
	[OverPrintBlackColor],
	[DeviceCount],
	[FormEvertCount],
	[Film],
	[Description],
	[InvoiceRow],
	[InvoiceNum],
	[InvoiceCost]

)
VALUES
(
	@JobId,
	@OrderReceiverId,
	@Dimension,
	@LpiId,
	@MainColorCountId,
	@ExportColor,
	@SpotColorCountId,
	@SpotColors,
	@OverPrintBlackColor,
	@DeviceCount,
	@FormEvertCount,
	@Film,
	@Description,
	@InvoiceRow,
	@InvoiceNum,
	@InvoiceCost

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[Films_ReportById]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Films_ReportById]
@Id int
AS

SELECT F.[Id],J.Name AS JOB,j.Code,J.Id AS JobId,dbo.CalculatePersianDate(j.CreateDate) AS CreateDatePersian,
		c.NAME AS CustomerName,o.Name AS OrderReceiver,F.Dimension
      ,l.Name AS Lpi,
      (CASE WHEN mc.Name IS NULL THEN N'ندارد'  ELSE mc.Name END) AS MainColorCount
      ,ex.Name AS ExportColor
      ,(CASE WHEN sp.Name IS NULL THEN N'ندارد'  ELSE sp.Name END) AS SpotColorCount
      ,F.[SpotColors],
      (CASE WHEN F.[OverPrintBlackColor] = 1 THEN N'دارد' ELSE N'ندارد' END) AS OverPrintBlackColor
      ,F.[DeviceCount],F.[FormEvertCount],
      (CASE WHEN F.Film = 1 THEN N'خوانا' ELSE N'ناخوانا' END) AS Film
      ,F.[Description]
      ,F.[InvoiceRow],F.[InvoiceNum],F.[InvoiceCost]
  FROM [dbo].[Films] F
  INNER JOIN dbo.Jobs J ON J.Id = F.JobId
  INNER JOIN dbo.Customers c ON c.Id = j.CustomerId
  INNER JOIN dbo.OrderReceivers O ON O.Id = F.OrderReceiverId
  INNER JOIN dbo.LPI L ON L.Id = F.LpiId
  LEFT JOIN dbo.MainColorCount MC ON MC.Id = F.MainColorCountId
  INNER JOIN dbo.ExportColors EX ON EX.Id = F.ExportColor
  LEFT JOIN dbo.MainColorCount SP ON SP.Id = F.SpotColorCountId
  
WHERE F.Id = @Id





GO
/****** Object:  StoredProcedure [dbo].[Films_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Films_SelectAll]
AS

	SELECT 
		[Id], [JobId], [OrderReceiverId], [Dimension], [LpiId], [MainColorCountId], [ExportColor], [SpotColorCountId], [SpotColors], [OverPrintBlackColor], [DeviceCount], [FormEvertCount], [Film], [Description], [InvoiceRow], [InvoiceNum], [InvoiceCost]
	FROM [dbo].[Films]






GO
/****** Object:  StoredProcedure [dbo].[Films_SelectAll_ForGrid]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Films_SelectAll_ForGrid]
@JobId int
AS

	SELECT 
		f.[Id], o.Name as OrderReceiverName, [Dimension],l.Name AS LpiName, [Description]
	FROM [dbo].[Films] f
	inner join [dbo].[OrderReceivers] o on f.OrderReceiverId = o.Id
	inner join [dbo].[LPI] l on f.LpiId = l.Id
	
	where f.JobId = @JobId






GO
/****** Object:  StoredProcedure [dbo].[Films_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Films_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [JobId], [OrderReceiverId], [Dimension], [LpiId], [MainColorCountId], [ExportColor], [SpotColorCountId], [SpotColors], [OverPrintBlackColor], [DeviceCount], [FormEvertCount], [Film], [Description], [InvoiceRow], [InvoiceNum], [InvoiceCost] FROM [dbo].[Films] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[Films_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Films_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [JobId], [OrderReceiverId], [Dimension], [LpiId], [MainColorCountId], [ExportColor], [SpotColorCountId], [SpotColors], [OverPrintBlackColor], [DeviceCount], [FormEvertCount], [Film], [Description], [InvoiceRow], [InvoiceNum], [InvoiceCost]
	FROM [dbo].[Films]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Films_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Films_Update]
	@Id int,
	@JobId int,
	@OrderReceiverId int,
	@Dimension nvarchar(MAX) = null,
	@LpiId int,
	@MainColorCountId int = null,
	@ExportColor int,
	@SpotColorCountId int = null,
	@SpotColors nvarchar(MAX) = null,
	@OverPrintBlackColor bit,
	@DeviceCount int = null,
	@FormEvertCount float = null,
	@Film bit,
	@Description nvarchar(MAX) = null,
	@InvoiceRow nvarchar(50) = null,
	@InvoiceNum nvarchar(50) = null,
	@InvoiceCost money = null

AS

UPDATE [dbo].[Films]
SET
	[JobId] = @JobId,
	[OrderReceiverId] = @OrderReceiverId,
	[Dimension] = @Dimension,
	[LpiId] = @LpiId,
	[MainColorCountId] = @MainColorCountId,
	[ExportColor] = @ExportColor,
	[SpotColorCountId] = @SpotColorCountId,
	[SpotColors] = @SpotColors,
	[OverPrintBlackColor] = @OverPrintBlackColor,
	[DeviceCount] = @DeviceCount,
	[FormEvertCount] = @FormEvertCount,
	[Film] = @Film,
	[Description] = @Description,
	[InvoiceRow] = @InvoiceRow,
	[InvoiceNum] = @InvoiceNum,
	[InvoiceCost] = @InvoiceCost
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[FinalInvoice_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[FinalInvoice_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[FinalInvoice] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[FinalInvoice_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FinalInvoice_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[FinalInvoice]
 WHERE 
	[Id] = @Id





GO
/****** Object:  StoredProcedure [dbo].[FinalInvoice_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FinalInvoice_Insert]
	@Id int output,
	@HasInvoice bit ,
	@JobId int ,
	@PlateCost money ,
	@FilmCost money ,
	@CopyZinkCost money ,
	@StereotypeCost money ,
	@PrintingCost money ,
	@BuyPaperCost money ,
	@VeneerCost money ,
	@LetterPressCost money ,
	@MakingTemplateCost money ,
	@SahafiCost money ,
	@SumAll money ,
	@Description nvarchar(MAX) = null 

AS

INSERT [dbo].[FinalInvoice]
(
	[HasInvoice],
	[JobId],
	[PlateCost],
	[FilmCost],
	[CopyZinkCost],
	[StereotypeCost],
	[PrintingCost],
	[BuyPaperCost],
	[VeneerCost],
	[LetterPressCost],
	[MakingTemplateCost],
	[SahafiCost],
	[SumAll],
	[Description]

)
VALUES
(
	@HasInvoice,
	@JobId,
	@PlateCost,
	@FilmCost,
	@CopyZinkCost,
	@StereotypeCost,
	@PrintingCost,
	@BuyPaperCost,
	@VeneerCost,
	@LetterPressCost,
	@MakingTemplateCost,
	@SahafiCost,
	@SumAll,
	@Description

)
	SELECT @Id=SCOPE_IDENTITY();






GO
/****** Object:  StoredProcedure [dbo].[FinalInvoice_ReportById]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FinalInvoice_ReportById]
@Id int
AS

SELECT f.[Id],
	   J.Name AS job,j.Code,
	   dbo.CalculatePersianDate(j.CreateDate) AS CreateDatePersian,
	   J.Id AS JobId,
	   c.NAME AS CustomerName,
	   (CASE WHEN HasInvoice=1 THEN N'دارد' ELSE N'ندارد' END) AS HasInvoice,
	   [PlateCost]
      ,[FilmCost]
      ,[CopyZinkCost]
      ,[StereotypeCost]
      ,[PrintingCost]
      ,[BuyPaperCost]
      ,[VeneerCost]
      ,[LetterPressCost]
      ,[MakingTemplateCost]
      ,[SahafiCost]
      ,[SumAll]
      ,f.[Description]   
	 	
       
  FROM [dbo].FinalInvoice f
  INNER JOIN dbo.Jobs J ON J.Id = f.JobId
  INNER JOIN dbo.Customers c ON c.Id = j.CustomerId
  
    
WHERE f.Id = @Id





GO
/****** Object:  StoredProcedure [dbo].[FinalInvoice_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[FinalInvoice_SelectAll]
AS

	SELECT 
		[Id], [HasInvoice], [JobId], [PlateCost], [FilmCost], [CopyZinkCost], [StereotypeCost], [PrintingCost], [BuyPaperCost], [VeneerCost], [LetterPressCost], [MakingTemplateCost], [SahafiCost], [SumAll], [Description]
	FROM [dbo].[FinalInvoice]






GO
/****** Object:  StoredProcedure [dbo].[FinalInvoice_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FinalInvoice_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [HasInvoice], [JobId], [PlateCost], [FilmCost], [CopyZinkCost], [StereotypeCost], [PrintingCost], [BuyPaperCost], [VeneerCost], [LetterPressCost], [MakingTemplateCost], [SahafiCost], [SumAll], [Description] FROM [dbo].[FinalInvoice] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[FinalInvoice_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FinalInvoice_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [HasInvoice], [JobId], [PlateCost], [FilmCost], [CopyZinkCost], [StereotypeCost], [PrintingCost], [BuyPaperCost], [VeneerCost], [LetterPressCost], [MakingTemplateCost], [SahafiCost], [SumAll], [Description]
	FROM [dbo].[FinalInvoice]
	WHERE 
			[Id] = @Id




GO
/****** Object:  StoredProcedure [dbo].[FinalInvoice_SelectInputCosts]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FinalInvoice_SelectInputCosts]
@JobId int
AS

SELECT
CASE WHEN EXISTS(SELECT * FROM dbo.[Plates] where JobId = @JobId) 
	 THEN(select CAST(SUM(InvoiceCost) AS VARCHAR(max)) from dbo.[Plates] where JobId = @JobId group by JobId)
	 ELSE N'ندارد' END as PlateInputCost,
	 
CASE WHEN EXISTS(SELECT * FROM dbo.[Films] where JobId = @JobId) 
	 THEN(select CAST(SUM(InvoiceCost) AS VARCHAR(max)) from dbo.[Films] where JobId = @JobId group by JobId)
	 ELSE N'ندارد' END as FilmInputCost,
	 	 
CASE WHEN EXISTS(SELECT * FROM dbo.[CopyZinks] where JobId = @JobId) 
	 THEN(select CAST(SUM(InvoiceCost) AS VARCHAR(max)) from dbo.[CopyZinks] where JobId = @JobId group by JobId)
	 ELSE N'ندارد' END as CopyZinkInputCost,
	 
CASE WHEN EXISTS(SELECT * FROM dbo.[Stereotypes] where JobId = @JobId) 
	 THEN(select CAST(SUM(InvoiceCost) AS VARCHAR(max)) from dbo.[Stereotypes] where JobId = @JobId group by JobId)
	 ELSE N'ندارد' END as StereotypeInputCost,
	 
CASE WHEN EXISTS(SELECT * FROM dbo.[Printings] where JobId = @JobId) 
	 THEN(select CAST(SUM(InvoiceCost) AS VARCHAR(max)) from dbo.[Printings] where JobId = @JobId group by JobId)
	 ELSE N'ندارد' END as PrintingInputCost,

CASE WHEN EXISTS(SELECT * FROM dbo.[BuyPaper] where JobId = @JobId) 
	 THEN(select CAST(SUM(InvoiceCost) AS VARCHAR(max)) from dbo.[BuyPaper] where JobId = @JobId group by JobId)
	 ELSE N'ندارد' END as BuyPaperInputCost,
	 
CASE WHEN EXISTS(SELECT * FROM dbo.[Veneers] where JobId = @JobId) 
	 THEN(select CAST(SUM(InvoiceCost) AS VARCHAR(max)) from dbo.[Veneers] where JobId = @JobId group by JobId)
	 ELSE N'ندارد' END as VeneerInputCost,
	 
CASE WHEN EXISTS(SELECT * FROM dbo.[LetterPresses] where JobId = @JobId) 
	 THEN(select CAST(SUM(InvoiceCost) AS VARCHAR(max)) from dbo.[LetterPresses] where JobId = @JobId group by JobId)
	 ELSE N'ندارد' END as LetterPressInputCost,

CASE WHEN EXISTS(SELECT * FROM dbo.[MakingTemplates] where JobId = @JobId) 
	 THEN(select CAST(SUM(InvoiceCost) AS VARCHAR(max)) from dbo.[MakingTemplates] where JobId = @JobId group by JobId)
	 ELSE N'ندارد' END as MakingTemplateInputCost,
	 	 
CASE WHEN EXISTS(SELECT * FROM dbo.[Sahafies] where JobId = @JobId) 
	 THEN(select CAST(SUM(InvoiceCost) AS VARCHAR(max)) from dbo.[Sahafies] where JobId = @JobId group by JobId)
	 ELSE N'ندارد' END as SahafiInputCost





		
	






GO
/****** Object:  StoredProcedure [dbo].[FinalInvoice_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FinalInvoice_Update]
	@Id int,
	@HasInvoice bit,
	@JobId int,
	@PlateCost money,
	@FilmCost money,
	@CopyZinkCost money,
	@StereotypeCost money,
	@PrintingCost money,
	@BuyPaperCost money,
	@VeneerCost money,
	@LetterPressCost money,
	@MakingTemplateCost money,
	@SahafiCost money,
	@SumAll money,
	@Description nvarchar(MAX) = null

AS

UPDATE [dbo].[FinalInvoice]
SET
	[HasInvoice] = @HasInvoice,
	[JobId] = @JobId,
	[PlateCost] = @PlateCost,
	[FilmCost] = @FilmCost,
	[CopyZinkCost] = @CopyZinkCost,
	[StereotypeCost] = @StereotypeCost,
	[PrintingCost] = @PrintingCost,
	[BuyPaperCost] = @BuyPaperCost,
	[VeneerCost] = @VeneerCost,
	[LetterPressCost] = @LetterPressCost,
	[MakingTemplateCost] = @MakingTemplateCost,
	[SahafiCost] = @SahafiCost,
	[SumAll] = @SumAll,
	[Description] = @Description
 WHERE 
	[Id] = @Id




GO
/****** Object:  StoredProcedure [dbo].[Institute_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Institute_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[Institute] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[Institute_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Institute_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[Institute]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Institute_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Institute_Insert]
	@Id int output,
	@Name nvarchar(MAX) 
	

AS

INSERT [dbo].[Institute]
(
	[Name]


)
VALUES
(
	@Name
	

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[Institute_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Institute_SelectAll]
AS
    SELECT  [Id] ,
            [Name]
    FROM    [dbo].[Institute]
    ORDER BY Name






GO
/****** Object:  StoredProcedure [dbo].[Institute_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Institute_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [Name] FROM [dbo].[Institute] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[Institute_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Institute_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[Institute]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Institute_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Institute_Update]
	@Id int,
	@Name nvarchar(MAX)
	

AS

UPDATE [dbo].[Institute]
SET
	[Name] = @Name
	
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Job_Report_BaseOnCustomer]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Job_Report_BaseOnCustomer]
@InvoiceStatus NVARCHAR(max) = NULL,
@CutomerId int = NULL,
@JobName NVARCHAR(max) = NULL,
@JobNum INT = NULL,
@StartDate DATETIME = NULL,
@EndDate DATETIME = NULL
AS

SELECT    cast(Row_number() OVER(ORDER BY JobNum) as nvarchar(50)) AS RowNum,*
			
FROM        dbo.View_BaseOnCustomer 
			
WHERE		(InvoiceStatus LIKE '%' +  @InvoiceStatus + '%' OR @InvoiceStatus IS NULL) AND
			(CustomerId =@CutomerId OR @CutomerId IS NULL) AND
			(JobName LIKE '%' + @JobName + '%' OR @JobName IS NULL) AND
			(CreateDateMiladi >= @StartDate  OR @StartDate IS NULL) AND
			(CreateDateMiladi <= @EndDate OR @EndDate IS NULL)
			
ORDER BY JobNum,CreateDateMiladi






GO
/****** Object:  StoredProcedure [dbo].[Job_Report_BaseOnOrderReceiver]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Job_Report_BaseOnOrderReceiver]
@LevelName NVARCHAR(max) = NULL,
@OrderReceiverId  int = NULL,
@InvoiceStatus NVARCHAR(max) = NULL,
@InvoiceNum INT = NULL,
@CustomerId int = null,
@JobName NVARCHAR(max) = NULL,
@JobNum INT = NULL,
@StartDate DATETIME = NULL,
@EndDate DATETIME = NULL
AS


SELECT cast(Row_number() OVER(ORDER BY JobNum) as nvarchar(50)) AS RowNum,JobNum,CreateDate
      ,JobName,LevelName,OrderReceiverName,InvoiceStatus,InvoiceNum,InvoiceCost,CustomerName
FROM   dbo.View_BaseOnOrderReceiver
WHERE (LevelName LIKE '%' + @LevelName + '%' OR @LevelName IS NULL) AND
	  (OrderReceiverId =@OrderReceiverId OR @OrderReceiverId IS NULL) AND
	  (InvoiceStatus LIKE '%' + @InvoiceStatus + '%' OR @InvoiceStatus IS NULL) AND
	  (InvoiceNum = @InvoiceNum  OR @InvoiceNum IS NULL) AND
	  (JobName LIKE '%' + @JobName + '%' OR @JobName IS NULL) AND
	  (JobNum = @JobNum OR @JobNum IS NULL) AND
	  (CreateDateMiladi >= @StartDate  OR @StartDate IS NULL) AND
	  (CreateDateMiladi <= @EndDate OR @EndDate IS NULL) AND
	   (CustomerId =@CustomerId OR @CustomerId IS NULL)
ORDER BY JobNum,LevelName,CreateDate



			







GO
/****** Object:  StoredProcedure [dbo].[JobNames_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[JobNames_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[JobNames] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)




GO
/****** Object:  StoredProcedure [dbo].[JobNames_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[JobNames_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[JobNames]
 WHERE 
	[Id] = @Id




GO
/****** Object:  StoredProcedure [dbo].[JobNames_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[JobNames_Insert]
	@Id int output,
	@Code nvarchar(MAX) = null ,
	@Name nvarchar(MAX) = null ,
	@StoreCode int = null ,
	@CustomerId int = null ,
	@Fee1 money = null ,
	@Fee2 money = null 

AS

INSERT [dbo].[JobNames]
(
	[Code],
	[Name],
	[StoreCode],
	[CustomerId],
	[Fee1],
	[Fee2]

)
VALUES
(
	@Code,
	@Name,
	@StoreCode,
	@CustomerId,
	@Fee1,
	@Fee2

)
	SELECT @Id=SCOPE_IDENTITY();





GO
/****** Object:  StoredProcedure [dbo].[JobNames_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[JobNames_SelectAll]
AS

	SELECT 
		[Id], [Code], [Name], [StoreCode], [CustomerId], [Fee1], [Fee2]
	FROM [dbo].[JobNames]




GO
/****** Object:  StoredProcedure [dbo].[JobNames_SelectAll_ForGrid]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[JobNames_SelectAll_ForGrid]
AS

	SELECT 
		j.[Id], [Code], j.[Name], [StoreCode],c.Name AS CustomerName
	FROM [dbo].[JobNames] j INNER JOIN dbo.Customers c
	ON j.CustomerId = c.Id






GO
/****** Object:  StoredProcedure [dbo].[JobNames_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[JobNames_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [Code], [Name], [StoreCode], [CustomerId], [Fee1], [Fee2] FROM [dbo].[JobNames] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)




GO
/****** Object:  StoredProcedure [dbo].[JobNames_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[JobNames_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [Code], [Name], [StoreCode], [CustomerId], [Fee1], [Fee2]
	FROM [dbo].[JobNames]
	WHERE 
			[Id] = @Id




GO
/****** Object:  StoredProcedure [dbo].[JobNames_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[JobNames_Update]
	@Id int,
	@Code nvarchar(MAX) = null,
	@Name nvarchar(MAX) = null,
	@StoreCode int = null,
	@CustomerId int = null,
	@Fee1 money = null,
	@Fee2 money = null

AS

UPDATE [dbo].[JobNames]
SET
	[Code] = @Code,
	[Name] = @Name,
	[StoreCode] = @StoreCode,
	[CustomerId] = @CustomerId,
	[Fee1] = @Fee1,
	[Fee2] = @Fee2
 WHERE 
	[Id] = @Id




GO
/****** Object:  StoredProcedure [dbo].[Jobs_Copy]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Jobs_Copy] @JobId INT
AS
    DECLARE @InsertedJobId INT

    INSERT  INTO dbo.Jobs
            ( CustomerId ,
              Name ,
              CreateDate ,
              Description ,
              Code,
			  StoreCode
            )
            SELECT  CustomerId ,
                    Name ,
                    GETDATE() ,
                    Description ,
                    Code,
					StoreCode
            FROM    dbo.Jobs
            WHERE   Id = @JobId

    SET @InsertedJobId = SCOPE_IDENTITY()

    INSERT  INTO dbo.Plates
            ( JobId ,
              OrderReceiverId ,
              DimensionId ,
              LpiId ,
              MainColorCountId ,
              ExportColorId ,
              SpotColorCountId ,
              SpotColors ,
              OverPrintBlackColor ,
              DeviceCount ,
              FormEvertCount ,
              Description ,
              InvoiceRow ,
              InvoiceNum ,
              InvoiceCost
	        )
            SELECT  @InsertedJobId ,
                    OrderReceiverId ,
                    DimensionId ,
                    LpiId ,
                    MainColorCountId ,
                    ExportColorId ,
                    SpotColorCountId ,
                    SpotColors ,
                    OverPrintBlackColor ,
                    DeviceCount ,
                    FormEvertCount ,
                    Description ,
                    InvoiceRow ,
                    InvoiceNum ,
                    InvoiceCost
            FROM    dbo.Plates
            WHERE   JobId = @JobId


    INSERT  INTO dbo.Films
            ( JobId ,
              OrderReceiverId ,
              Dimension ,
              LpiId ,
              MainColorCountId ,
              ExportColor ,
              SpotColorCountId ,
              SpotColors ,
              OverPrintBlackColor ,
              DeviceCount ,
              FormEvertCount ,
              Film ,
              Description ,
              InvoiceRow ,
              InvoiceNum ,
              InvoiceCost
			 )
            SELECT  @InsertedJobId ,
                    OrderReceiverId ,
                    Dimension ,
                    LpiId ,
                    MainColorCountId ,
                    ExportColor ,
                    SpotColorCountId ,
                    SpotColors ,
                    OverPrintBlackColor ,
                    DeviceCount ,
                    FormEvertCount ,
                    Film ,
                    Description ,
                    InvoiceRow ,
                    InvoiceNum ,
                    InvoiceCost
            FROM    dbo.Films
            WHERE   JobId = @JobId

    INSERT  INTO dbo.CopyZinks
            ( JobId ,
              OrderReceiverId ,
              DimensionId ,
              LpiId ,
              MainColorCountId ,
              ExportColorId ,
              SpotColorCountId ,
              SpotColors ,
              OverPrintBlackColor ,
              DeviceCount ,
              FormEvertCount ,
              Description ,
              InvoiceRow ,
              InvoiceNum ,
              InvoiceCost
			 )
            SELECT  @InsertedJobId ,
                    OrderReceiverId ,
                    DimensionId ,
                    LpiId ,
                    MainColorCountId ,
                    ExportColorId ,
                    SpotColorCountId ,
                    SpotColors ,
                    OverPrintBlackColor ,
                    DeviceCount ,
                    FormEvertCount ,
                    Description ,
                    InvoiceRow ,
                    InvoiceNum ,
                    InvoiceCost
            FROM    dbo.CopyZinks
            WHERE   JobId = @JobId

    INSERT  INTO dbo.Stereotypes
            ( JobId ,
              OrderReceiverId ,
              Dimension ,
              Thickness ,
              Type ,
              stereotype ,
              StereotypeUsagesId ,
              Count ,
              Description ,
              InvoiceRow ,
              InvoiceNum ,
              InvoiceCost
			 )
            SELECT  @InsertedJobId ,
                    OrderReceiverId ,
                    Dimension ,
                    Thickness ,
                    Type ,
                    stereotype ,
                    StereotypeUsagesId ,
                    Count ,
                    Description ,
                    InvoiceRow ,
                    InvoiceNum ,
                    InvoiceCost
            FROM    dbo.Stereotypes
            WHERE   JobId = @JobId

    INSERT  INTO dbo.RePrint
            ( JobId ,
              CreateDate ,
              Description
            )
            SELECT  @InsertedJobId ,
                    GETDATE() ,
                    Description
            FROM    dbo.RePrint
            WHERE   JobId = @JobId

    INSERT  INTO dbo.Printings
            ( JobId ,
              Row ,
              Printing ,
              Dimension ,
              OrderReceiverId ,
              PrintTypeId ,
              ZinkTypeId ,
              PrintModelId ,
              MaterialTypeId ,
              MaterialTypeGramazhId ,
              LargePaperCount ,
              LargePaperSize ,
              PaperParagraphCount ,
              ParagraphLeafCount ,
              PrintingTirazh ,
              MainColorCountId ,
              ExportColorId ,
              SpotColorCountId ,
              SpotColors ,
              PrintingSupervision ,
              ColorInstance ,
              DeviceCount ,
              FormEvertCount ,
              Description ,
              InvoiceRow ,
              InvoiceNum ,
              InvoiceCost,
			  IsUse
			 )
            SELECT  @InsertedJobId ,
                    Row ,
                    Printing ,
                    Dimension ,
                    OrderReceiverId ,
                    PrintTypeId ,
                    ZinkTypeId ,
                    PrintModelId ,
                    MaterialTypeId ,
                    MaterialTypeGramazhId ,
                    LargePaperCount ,
                    LargePaperSize ,
                    PaperParagraphCount ,
                    ParagraphLeafCount ,
                    PrintingTirazh ,
                    MainColorCountId ,
                    ExportColorId ,
                    SpotColorCountId ,
                    SpotColors ,
                    PrintingSupervision ,
                    ColorInstance ,
                    DeviceCount ,
                    FormEvertCount ,
                    Description ,
                    InvoiceRow ,
                    InvoiceNum ,
                    InvoiceCost,
					0
            FROM    dbo.Printings
            WHERE   JobId = @JobId

    INSERT  INTO dbo.Veneers
            ( JobId ,
              OrderVeneer ,
              OrderReceiverId ,
              VeneerTypeId ,
              Model ,
              Tirazh ,
              Dimension ,
              PaperGramazh ,
              Description ,
              InvoiceRow ,
              InvoiceNum ,
              InvoiceCost
			 )
            SELECT  @InsertedJobId ,
                    OrderVeneer ,
                    OrderReceiverId ,
                    VeneerTypeId ,
                    Model ,
                    Tirazh ,
                    Dimension ,
                    PaperGramazh ,
                    Description ,
                    InvoiceRow ,
                    InvoiceNum ,
                    InvoiceCost
            FROM    dbo.Veneers
            WHERE   JobId = @JobId

    INSERT  INTO dbo.LetterPresses
            ( JobId ,
              OrderLetterPress ,
              OrderReceiverId ,
              LetterPressTypeId ,
              Tirazh ,
              Dimension ,
              PaperGramazh ,
              Description ,
              InvoiceRow ,
              InvoiceNum ,
              InvoiceCost
			 )
            SELECT  @InsertedJobId ,
                    OrderLetterPress ,
                    OrderReceiverId ,
                    LetterPressTypeId ,
                    Tirazh ,
                    Dimension ,
                    PaperGramazh ,
                    Description ,
                    InvoiceRow ,
                    InvoiceNum ,
                    InvoiceCost
            FROM    dbo.LetterPresses
            WHERE   JobId = @JobId

    INSERT  INTO dbo.MakingTemplates
            ( JobId ,
              OrderReceiverId ,
              LetterPressDeviceId ,
              TemplateMaterialTypeId ,
              Dimension ,
              Count ,
              BladeTypeId ,
              PorferazhModel ,
              Description ,
              InvoiceRow ,
              InvoiceNum ,
              InvoiceCost
			 )
            SELECT  @InsertedJobId ,
                    OrderReceiverId ,
                    LetterPressDeviceId ,
                    TemplateMaterialTypeId ,
                    Dimension ,
                    Count ,
                    BladeTypeId ,
                    PorferazhModel ,
                    Description ,
                    InvoiceRow ,
                    InvoiceNum ,
                    InvoiceCost
            FROM    dbo.MakingTemplates
            WHERE   JobId = @JobId

    INSERT  INTO dbo.Sahafies
            ( JobId ,
              OrderReceiverId ,
              SahafiTypeId ,
              Tirazh ,
              Dimension ,
              PocketGlue ,
              PaperGramazh ,
              TextFormCount ,
              FormSum ,
              Description ,
              InvoiceRow ,
              InvoiceNum ,
              InvoiceCost
			 )
            SELECT  @InsertedJobId ,
                    OrderReceiverId ,
                    SahafiTypeId ,
                    Tirazh ,
                    Dimension ,
                    PocketGlue ,
                    PaperGramazh ,
                    TextFormCount ,
                    FormSum ,
                    Description ,
                    InvoiceRow ,
                    InvoiceNum ,
                    InvoiceCost
            FROM    dbo.Sahafies
            WHERE   JobId = @JobId 

    INSERT  INTO dbo.FinalInvoice
            ( HasInvoice ,
              JobId ,
              PlateCost ,
              FilmCost ,
              CopyZinkCost ,
              StereotypeCost ,
              PrintingCost ,
              BuyPaperCost ,
              VeneerCost ,
              LetterPressCost ,
              MakingTemplateCost ,
              SahafiCost ,
              SumAll ,
              Description
			 )
            SELECT  HasInvoice ,
                    @InsertedJobId ,
                    PlateCost ,
                    FilmCost ,
                    CopyZinkCost ,
                    StereotypeCost ,
                    PrintingCost ,
                    BuyPaperCost ,
                    VeneerCost ,
                    LetterPressCost ,
                    MakingTemplateCost ,
                    SahafiCost ,
                    SumAll ,
                    Description
            FROM    dbo.FinalInvoice
            WHERE   JobId = @JobId




GO
/****** Object:  StoredProcedure [dbo].[Jobs_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Jobs_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[Jobs] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[Jobs_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Jobs_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[Jobs]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Jobs_GetTotalCount]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Jobs_GetTotalCount]
@Id int=null,
@Name nvarchar(max)= null,
@Code nvarchar(max)= null
AS

	SELECT COUNT(*)
		
	FROM [dbo].[Jobs]
	 where (Jobs.Id = @Id OR @Id is null)  AND 
	 (Jobs.Name LIKE  '%' +@Name + '%' OR @Name is null) AND
	 (Jobs.Code LIKE  '%' +@Code + '%' OR @Code is null)






GO
/****** Object:  StoredProcedure [dbo].[Jobs_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Jobs_Insert]
	@Id int output,
	@CustomerId int ,
	@Name nvarchar(MAX) ,
	@CreateDate datetime ,
	@Description nvarchar(MAX) = null ,
	@Code nvarchar(MAX) = null ,
	@StoreCode INT = NULL 


AS

INSERT [dbo].[Jobs]
(
	[CustomerId],
	[Name],
	[CreateDate],
	[Description],
	[Code],
	[StoreCode]

)
VALUES
(
	@CustomerId,
	@Name,
	@CreateDate,
	@Description,
	@Code,
	@StoreCode

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[Jobs_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Jobs_SelectAll] @CustomerId INT
AS
DECLARE @date DATETIME
SET @date = GETDATE()

    SELECT  DISTINCT
            1 AS Id,CustomerId,Name,@date AS CreateDate,'' AS Description,Code,StoreCode
    FROM    [dbo].[Jobs]
	WHERE CustomerId = @CustomerId
    UNION
    SELECT DISTINCT
              1 AS Id,CustomerId,Name,@date AS CreateDate,'' AS Description,Code,StoreCode
    FROM    dbo.JobNames
	WHERE CustomerId = @CustomerId 

    ORDER BY Name






GO
/****** Object:  StoredProcedure [dbo].[Jobs_SelectAll_ForGrid]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Jobs_SelectAll_ForGrid]
@Id int=null,
@Name nvarchar(max)= null,
@Code nvarchar(max)= null,
@StartIndex INT=1, 
@PageSize   INT=10
AS

WITH ctepaging 
     AS (SELECT Jobs.Id,Jobs.Name,dbo.CalculatePersianDate(CreateDate) as CreateDatePersian,Description,Customers.Name as CustomerName,[Code],
                Row_number() OVER(ORDER BY Jobs.Id DESC) AS rownum 
         FROM [dbo].[Jobs] inner join [dbo].[Customers] 
         on Jobs.CustomerId = Customers.Id
         where (Jobs.Id = @Id OR @Id is null)  AND 
         (Jobs.Name LIKE  '%' +@Name + '%' OR @Name is null) AND
		 (Jobs.Code LIKE  '%' +@Code + '%' OR @Code is null)		
		 )
SELECT * 
FROM   ctepaging 
WHERE  rownum BETWEEN @StartIndex AND @StartIndex +@PageSize









GO
/****** Object:  StoredProcedure [dbo].[Jobs_SelectAllInserted]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Jobs_SelectAllInserted] @CustomerId INT = NULL
AS
    SELECT  [Id] ,
            [CustomerId] ,
            [Name] ,
            [CreateDate] ,
            [Description] ,
            [Code] ,
            StoreCode
    FROM    [dbo].[Jobs]
    WHERE   CustomerId = @CustomerId
            OR @CustomerId IS NULL
    ORDER BY Name
	






GO
/****** Object:  StoredProcedure [dbo].[Jobs_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Jobs_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [CustomerId], [Name], [CreateDate], [Description],[Code],[StoreCode] FROM [dbo].[Jobs] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[Jobs_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Jobs_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [CustomerId], [Name], [CreateDate], [Description],[Code],StoreCode
	FROM [dbo].[Jobs]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Jobs_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Jobs_Update]
	@Id int,
	@CustomerId int,
	@Name nvarchar(MAX),
	@CreateDate datetime,
	@Description nvarchar(MAX) = null,
	@Code nvarchar(MAX) = NULL,
	@StoreCode INT = NULL 

AS

UPDATE [dbo].[Jobs]
SET
	[CustomerId] = @CustomerId,
	[Name] = @Name,
	[CreateDate] = @CreateDate,
	[Description] = @Description,
	[Code]=@Code,
	[StoreCode] =@StoreCode
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[JobStatuses_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[JobStatuses_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[JobStatuses] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[JobStatuses_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[JobStatuses_DeleteByPrimaryKey]
	@JobId int,
	@StatusId int
AS

DELETE FROM [dbo].[JobStatuses]
 WHERE 
	[JobId] = @JobId AND 
	[StatusId] = @StatusId






GO
/****** Object:  StoredProcedure [dbo].[JobStatuses_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[JobStatuses_Insert]
	@JobId int ,
	@StatusId int 

AS

INSERT [dbo].[JobStatuses]
(
	[JobId],
	[StatusId]

)
VALUES
(
	@JobId,
	@StatusId

)







GO
/****** Object:  StoredProcedure [dbo].[JobStatuses_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[JobStatuses_SelectAll]
AS

	SELECT 
		[JobId], [StatusId]
	FROM [dbo].[JobStatuses]






GO
/****** Object:  StoredProcedure [dbo].[JobStatuses_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[JobStatuses_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [JobId], [StatusId] FROM [dbo].[JobStatuses] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[JobStatuses_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[JobStatuses_SelectByPrimaryKey]
	@JobId int,
	@StatusId int
AS

	SELECT 
		[JobId], [StatusId]
	FROM [dbo].[JobStatuses]
	WHERE 
			[JobId] = @JobId AND 
	[StatusId] = @StatusId






GO
/****** Object:  StoredProcedure [dbo].[JobStatuses_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[JobStatuses_Update]
	@JobId int,
	@StatusId int

AS

UPDATE [dbo].[JobStatuses]
SET
	[JobId] = @JobId,
	[StatusId] = @StatusId
 WHERE 
	[JobId] = @JobId AND 
	[StatusId] = @StatusId






GO
/****** Object:  StoredProcedure [dbo].[JobTypes_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[JobTypes_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[JobTypes] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)




GO
/****** Object:  StoredProcedure [dbo].[JobTypes_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[JobTypes_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[JobTypes]
 WHERE 
	[Id] = @Id




GO
/****** Object:  StoredProcedure [dbo].[JobTypes_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[JobTypes_Insert]
	@Id int output,
	@Name nvarchar(MAX) 

AS

INSERT [dbo].[JobTypes]
(
	[Name]

)
VALUES
(
	@Name

)
	SELECT @Id=SCOPE_IDENTITY();





GO
/****** Object:  StoredProcedure [dbo].[JobTypes_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[JobTypes_SelectAll]
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[JobTypes]
	ORDER BY Name




GO
/****** Object:  StoredProcedure [dbo].[JobTypes_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[JobTypes_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [Name] FROM [dbo].[JobTypes] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)




GO
/****** Object:  StoredProcedure [dbo].[JobTypes_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[JobTypes_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[JobTypes]
	WHERE 
			[Id] = @Id




GO
/****** Object:  StoredProcedure [dbo].[JobTypes_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[JobTypes_Update]
	@Id int,
	@Name nvarchar(MAX)

AS

UPDATE [dbo].[JobTypes]
SET
	[Name] = @Name
 WHERE 
	[Id] = @Id




GO
/****** Object:  StoredProcedure [dbo].[LeafCount_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LeafCount_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[LeafCount] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[LeafCount_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LeafCount_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[LeafCount]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[LeafCount_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LeafCount_Insert]
	@Id int output,
	@Name nvarchar(MAX) 

AS

INSERT [dbo].[LeafCount]
(
	[Name]

)
VALUES
(
	@Name

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[LeafCount_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LeafCount_SelectAll]
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[LeafCount]






GO
/****** Object:  StoredProcedure [dbo].[LeafCount_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LeafCount_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [Name] FROM [dbo].[LeafCount] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[LeafCount_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LeafCount_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[LeafCount]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[LeafCount_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LeafCount_Update]
	@Id int,
	@Name nvarchar(MAX)

AS

UPDATE [dbo].[LeafCount]
SET
	[Name] = @Name
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[LetterPressDevices_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LetterPressDevices_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[LetterPressDevices] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[LetterPressDevices_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LetterPressDevices_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[LetterPressDevices]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[LetterPressDevices_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LetterPressDevices_Insert]
	@Id int output,
	@Name nvarchar(MAX) 

AS

INSERT [dbo].[LetterPressDevices]
(
	[Name]

)
VALUES
(
	@Name

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[LetterPressDevices_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LetterPressDevices_SelectAll]
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[LetterPressDevices]
	ORDER BY Name






GO
/****** Object:  StoredProcedure [dbo].[LetterPressDevices_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LetterPressDevices_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [Name] FROM [dbo].[LetterPressDevices] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[LetterPressDevices_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LetterPressDevices_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[LetterPressDevices]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[LetterPressDevices_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LetterPressDevices_Update]
	@Id int,
	@Name nvarchar(MAX)

AS

UPDATE [dbo].[LetterPressDevices]
SET
	[Name] = @Name
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[LetterPresses_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LetterPresses_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[LetterPresses] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[LetterPresses_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[LetterPresses_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[LetterPresses]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[LetterPresses_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[LetterPresses_Insert]
	@Id int output,
	@JobId int ,
	@OrderLetterPress int ,
	@OrderReceiverId int ,
	@LetterPressTypeId int ,
	@Tirazh int = null ,
	@Dimension nvarchar(50) = null ,
	@PaperGramazh nvarchar(50) = null ,
	@Description nvarchar(MAX) = null ,
	@InvoiceRow nvarchar(50) = null ,
	@InvoiceNum nvarchar(50) = null ,
	@InvoiceCost money = null 

AS

INSERT [dbo].[LetterPresses]
(
	[JobId],
	[OrderLetterPress],
	[OrderReceiverId],
	[LetterPressTypeId],
	[Tirazh],
	[Dimension],
	[PaperGramazh],
	[Description],
	[InvoiceRow],
	[InvoiceNum],
	[InvoiceCost]

)
VALUES
(
	@JobId,
	@OrderLetterPress,
	@OrderReceiverId,
	@LetterPressTypeId,
	@Tirazh,
	@Dimension,
	@PaperGramazh,
	@Description,
	@InvoiceRow,
	@InvoiceNum,
	@InvoiceCost

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[LetterPresses_ReportById]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LetterPresses_ReportById]
@Id int
AS
DECLARE @jobId int
SET @jobId = (SELECT JobId FROM dbo.LetterPresses WHERE Id =@Id); 

WITH cte AS (
SELECT N'دایکات ' + cast(Row_number() OVER(ORDER BY lp.Id) as nvarchar(50)) AS Row ,lp.Id
	   FROM dbo.LetterPresses lp
	   WHERE lp.JobId = @jobId)

SELECT lp.[Id],
	  (SELECT Row FROM cte WHERE Id = @Id) AS Row,
	  J.Name AS job,j.Code,J.Id AS JobId,dbo.CalculatePersianDate(j.CreateDate) AS CreateDatePersian,
	  c.NAME AS CustomerName,o.Name AS OrderReceiver,
	  lpt.Name AS LetterPressType, 
	  [Tirazh],[Dimension],[PaperGramazh],lp.[Description],[InvoiceRow]
      ,[InvoiceNum],[InvoiceCost]			
		
       
  FROM [dbo].LetterPresses lp
  INNER JOIN dbo.Jobs J ON J.Id = lp.JobId
  INNER JOIN dbo.Customers c ON c.Id = j.CustomerId
  INNER JOIN dbo.OrderReceivers O ON O.Id = lp.OrderReceiverId
  INNER JOIN dbo.LetterPressTypes lpt ON lpt.Id = lp.LetterPressTypeId
  

  
WHERE lp.Id = @Id





GO
/****** Object:  StoredProcedure [dbo].[LetterPresses_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[LetterPresses_SelectAll]
AS

	SELECT 
		[Id], [JobId], [OrderLetterPress], [OrderReceiverId], [LetterPressTypeId], [Tirazh], [Dimension], [PaperGramazh], [Description], [InvoiceRow], [InvoiceNum], [InvoiceCost]
	FROM [dbo].[LetterPresses]






GO
/****** Object:  StoredProcedure [dbo].[LetterPresses_SelectAll_ForGrid]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LetterPresses_SelectAll_ForGrid]
@JobId int
AS

	SELECT 
		p.[Id], N'دایکات ' + cast(Row_number() OVER(ORDER BY p.Id) as nvarchar(50))  as OrderSeries,
		o.Name as OrderReceiverName,[Description],lpt.Name AS LetterPressTypeName
	FROM [dbo].[LetterPresses] p 
	inner join [dbo].[OrderReceivers] o on p.OrderReceiverId = o.Id
	inner join [dbo].[LetterPressTypes] lpt on p.LetterPressTypeId = lpt.Id
	
	where p.JobId = @JobId






GO
/****** Object:  StoredProcedure [dbo].[LetterPresses_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[LetterPresses_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [JobId], [OrderLetterPress], [OrderReceiverId], [LetterPressTypeId], [Tirazh], [Dimension], [PaperGramazh], [Description], [InvoiceRow], [InvoiceNum], [InvoiceCost] FROM [dbo].[LetterPresses] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[LetterPresses_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[LetterPresses_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [JobId], [OrderLetterPress], [OrderReceiverId], [LetterPressTypeId], [Tirazh], [Dimension], [PaperGramazh], [Description], [InvoiceRow], [InvoiceNum], [InvoiceCost]
	FROM [dbo].[LetterPresses]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[LetterPresses_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[LetterPresses_Update]
	@Id int,
	@JobId int,
	@OrderLetterPress int,
	@OrderReceiverId int,
	@LetterPressTypeId int,
	@Tirazh int = null,
	@Dimension nvarchar(50) = null,
	@PaperGramazh nvarchar(50) = null,
	@Description nvarchar(MAX) = null,
	@InvoiceRow nvarchar(50) = null,
	@InvoiceNum nvarchar(50) = null,
	@InvoiceCost money = null

AS

UPDATE [dbo].[LetterPresses]
SET
	[JobId] = @JobId,
	[OrderLetterPress] = @OrderLetterPress,
	[OrderReceiverId] = @OrderReceiverId,
	[LetterPressTypeId] = @LetterPressTypeId,
	[Tirazh] = @Tirazh,
	[Dimension] = @Dimension,
	[PaperGramazh] = @PaperGramazh,
	[Description] = @Description,
	[InvoiceRow] = @InvoiceRow,
	[InvoiceNum] = @InvoiceNum,
	[InvoiceCost] = @InvoiceCost
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[LetterPressTypes_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LetterPressTypes_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[LetterPressTypes] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[LetterPressTypes_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LetterPressTypes_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[LetterPressTypes]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[LetterPressTypes_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LetterPressTypes_Insert]
	@Id int output,
	@Name nvarchar(MAX) 

AS

INSERT [dbo].[LetterPressTypes]
(
	[Name]

)
VALUES
(
	@Name

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[LetterPressTypes_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LetterPressTypes_SelectAll]
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[LetterPressTypes]
	ORDER BY Name






GO
/****** Object:  StoredProcedure [dbo].[LetterPressTypes_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LetterPressTypes_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [Name] FROM [dbo].[LetterPressTypes] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[LetterPressTypes_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LetterPressTypes_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[LetterPressTypes]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[LetterPressTypes_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LetterPressTypes_Update]
	@Id int,
	@Name nvarchar(MAX)

AS

UPDATE [dbo].[LetterPressTypes]
SET
	[Name] = @Name
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[LevelOrderReceiver_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LevelOrderReceiver_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[LevelOrderReceiver] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[LevelOrderReceiver_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LevelOrderReceiver_Insert]
	@Level_Id int ,
	@OrderReceiver_Id int 

AS

INSERT [dbo].[LevelOrderReceiver]
(
	[Level_Id],
	[OrderReceiver_Id]

)
VALUES
(
	@Level_Id,
	@OrderReceiver_Id

)







GO
/****** Object:  StoredProcedure [dbo].[LevelOrderReceiver_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LevelOrderReceiver_SelectAll]
AS

	SELECT 
		[Level_Id], [OrderReceiver_Id]
	FROM [dbo].[LevelOrderReceiver]






GO
/****** Object:  StoredProcedure [dbo].[LevelOrderReceiver_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LevelOrderReceiver_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Level_Id], [OrderReceiver_Id] FROM [dbo].[LevelOrderReceiver] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[Levels_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Levels_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[Levels] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[Levels_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Levels_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[Levels]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Levels_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Levels_Insert]
	@Id int output,
	@Name nvarchar(MAX) 

AS

INSERT [dbo].[Levels]
(
	[Name]

)
VALUES
(
	@Name

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[Levels_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Levels_SelectAll]
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[Levels]






GO
/****** Object:  StoredProcedure [dbo].[Levels_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Levels_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [Name] FROM [dbo].[Levels] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[Levels_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Levels_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[Levels]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Levels_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Levels_Update]
	@Id int,
	@Name nvarchar(MAX)

AS

UPDATE [dbo].[Levels]
SET
	[Name] = @Name
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[LogInOutHistories_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LogInOutHistories_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[LogInOutHistories] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[LogInOutHistories_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LogInOutHistories_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[LogInOutHistories]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[LogInOutHistories_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LogInOutHistories_Insert]
	@Id int output,
	@Date datetime ,
	@Type bit ,
	@UserId int 

AS

INSERT [dbo].[LogInOutHistories]
(
	[Date],
	[Type],
	[UserId]

)
VALUES
(
	@Date,
	@Type,
	@UserId

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[LogInOutHistories_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LogInOutHistories_SelectAll]
AS

	SELECT 
		[Id], [Date], [Type], [UserId]
	FROM [dbo].[LogInOutHistories]






GO
/****** Object:  StoredProcedure [dbo].[LogInOutHistories_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LogInOutHistories_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [Date], [Type], [UserId] FROM [dbo].[LogInOutHistories] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[LogInOutHistories_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LogInOutHistories_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [Date], [Type], [UserId]
	FROM [dbo].[LogInOutHistories]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[LogInOutHistories_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LogInOutHistories_Update]
	@Id int,
	@Date datetime,
	@Type bit,
	@UserId int

AS

UPDATE [dbo].[LogInOutHistories]
SET
	[Date] = @Date,
	[Type] = @Type,
	[UserId] = @UserId
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[LPI_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LPI_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[LPI] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[LPI_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LPI_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[LPI]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[LPI_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LPI_Insert]
	@Id int output,
	@Name nvarchar(MAX) 

AS

INSERT [dbo].[LPI]
(
	[Name]

)
VALUES
(
	@Name

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[LPI_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LPI_SelectAll]
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[LPI]






GO
/****** Object:  StoredProcedure [dbo].[LPI_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LPI_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [Name] FROM [dbo].[LPI] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[LPI_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LPI_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[LPI]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[LPI_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LPI_Update]
	@Id int,
	@Name nvarchar(MAX)

AS

UPDATE [dbo].[LPI]
SET
	[Name] = @Name
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[MainColorCount_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MainColorCount_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[MainColorCount] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[MainColorCount_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MainColorCount_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[MainColorCount]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[MainColorCount_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MainColorCount_Insert]
	@Id int output,
	@Name nvarchar(MAX) 

AS

INSERT [dbo].[MainColorCount]
(
	[Name]

)
VALUES
(
	@Name

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[MainColorCount_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MainColorCount_SelectAll]
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[MainColorCount]






GO
/****** Object:  StoredProcedure [dbo].[MainColorCount_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MainColorCount_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [Name] FROM [dbo].[MainColorCount] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[MainColorCount_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MainColorCount_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[MainColorCount]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[MainColorCount_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MainColorCount_Update]
	@Id int,
	@Name nvarchar(MAX)

AS

UPDATE [dbo].[MainColorCount]
SET
	[Name] = @Name
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[MakingTemplates_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MakingTemplates_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[MakingTemplates] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[MakingTemplates_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MakingTemplates_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[MakingTemplates]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[MakingTemplates_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MakingTemplates_Insert]
	@Id int output,
	@JobId int ,
	@OrderReceiverId int ,
	@LetterPressDeviceId int ,
	@TemplateMaterialTypeId int ,
	@Dimension nvarchar(50) = null ,
	@Count int = null ,
	@BladeTypeId int ,
	@PorferazhModel nvarchar(MAX) = null ,
	@Description nvarchar(MAX) = null ,
	@InvoiceRow nvarchar(50) = null ,
	@InvoiceNum nvarchar(50) = null ,
	@InvoiceCost money = null 

AS

INSERT [dbo].[MakingTemplates]
(
	[JobId],
	[OrderReceiverId],
	[LetterPressDeviceId],
	[TemplateMaterialTypeId],
	[Dimension],
	[Count],
	[BladeTypeId],
	[PorferazhModel],
	[Description],
	[InvoiceRow],
	[InvoiceNum],
	[InvoiceCost]

)
VALUES
(
	@JobId,
	@OrderReceiverId,
	@LetterPressDeviceId,
	@TemplateMaterialTypeId,
	@Dimension,
	@Count,
	@BladeTypeId,
	@PorferazhModel,
	@Description,
	@InvoiceRow,
	@InvoiceNum,
	@InvoiceCost

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[MakingTemplates_ReportById]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MakingTemplates_ReportById]
@Id int
AS

SELECT m.[Id],
	   J.Name AS job,j.Code,J.Id AS JobId,dbo.CalculatePersianDate(j.CreateDate) AS CreateDatePersian,
	   c.NAME AS CustomerName,o.Name AS OrderReceiver,
	   lpd.Name AS LetterPressDeviceId,
	   tm.Name AS TemplateMaterialType,Dimension,[Count],bt.Name AS  BladeType,
	   PorferazhModel,m.[Description],[InvoiceRow],[InvoiceNum],[InvoiceCost]
	 	
       
  FROM [dbo].MakingTemplates m
  INNER JOIN dbo.Jobs J ON J.Id = m.JobId
  INNER JOIN dbo.Customers c ON c.Id = j.CustomerId
  INNER JOIN dbo.OrderReceivers O ON O.Id = m.OrderReceiverId
  INNER JOIN dbo.LetterPressDevices lpd ON lpd.Id = m.LetterPressDeviceId
  INNER JOIN dbo.TemplateMaterialTypes tm ON tm.Id = m.TemplateMaterialTypeId
  INNER JOIN dbo.BladeTypes bt ON bt.Id = m.BladeTypeId
  

  
WHERE m.Id = @Id





GO
/****** Object:  StoredProcedure [dbo].[MakingTemplates_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MakingTemplates_SelectAll]
AS

	SELECT 
		[Id], [JobId], [OrderReceiverId], [LetterPressDeviceId], [TemplateMaterialTypeId], [Dimension], [Count], [BladeTypeId], [PorferazhModel], [Description], [InvoiceRow], [InvoiceNum], [InvoiceCost]
	FROM [dbo].[MakingTemplates]






GO
/****** Object:  StoredProcedure [dbo].[MakingTemplates_SelectAll_ForGrid]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MakingTemplates_SelectAll_ForGrid]
@JobId int
AS

	SELECT 
		p.[Id],o.Name as OrderReceiverName,[Description],lpd.Name AS LetterPressDeviceName
	FROM [dbo].[MakingTemplates] p  
	inner join [dbo].[OrderReceivers] o on p.OrderReceiverId = o.Id
	inner join [dbo].LetterPressDevices lpd on p.LetterPressDeviceId = lpd.Id
	
	where p.JobId = @JobId






GO
/****** Object:  StoredProcedure [dbo].[MakingTemplates_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MakingTemplates_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [JobId], [OrderReceiverId], [LetterPressDeviceId], [TemplateMaterialTypeId], [Dimension], [Count], [BladeTypeId], [PorferazhModel], [Description], [InvoiceRow], [InvoiceNum], [InvoiceCost] FROM [dbo].[MakingTemplates] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[MakingTemplates_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MakingTemplates_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [JobId], [OrderReceiverId], [LetterPressDeviceId], [TemplateMaterialTypeId], [Dimension], [Count], [BladeTypeId], [PorferazhModel], [Description], [InvoiceRow], [InvoiceNum], [InvoiceCost]
	FROM [dbo].[MakingTemplates]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[MakingTemplates_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MakingTemplates_Update]
	@Id int,
	@JobId int,
	@OrderReceiverId int,
	@LetterPressDeviceId int,
	@TemplateMaterialTypeId int,
	@Dimension nvarchar(50) = null,
	@Count int = null,
	@BladeTypeId int,
	@PorferazhModel nvarchar(MAX) = null,
	@Description nvarchar(MAX) = null,
	@InvoiceRow nvarchar(50) = null,
	@InvoiceNum nvarchar(50) = null,
	@InvoiceCost money = null

AS

UPDATE [dbo].[MakingTemplates]
SET
	[JobId] = @JobId,
	[OrderReceiverId] = @OrderReceiverId,
	[LetterPressDeviceId] = @LetterPressDeviceId,
	[TemplateMaterialTypeId] = @TemplateMaterialTypeId,
	[Dimension] = @Dimension,
	[Count] = @Count,
	[BladeTypeId] = @BladeTypeId,
	[PorferazhModel] = @PorferazhModel,
	[Description] = @Description,
	[InvoiceRow] = @InvoiceRow,
	[InvoiceNum] = @InvoiceNum,
	[InvoiceCost] = @InvoiceCost
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[MaterialTypeGramazh_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MaterialTypeGramazh_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[MaterialTypeGramazh] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[MaterialTypeGramazh_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MaterialTypeGramazh_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[MaterialTypeGramazh]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[MaterialTypeGramazh_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MaterialTypeGramazh_Insert]
	@Id int output,
	@Name nvarchar(MAX) 

AS

INSERT [dbo].[MaterialTypeGramazh]
(
	[Name]

)
VALUES
(
	@Name

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[MaterialTypeGramazh_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MaterialTypeGramazh_SelectAll]
AS --SELECT  [Id] ,
    --        [Name]
    --FROM    [dbo].[MaterialTypeGramazh]
    --WHERE   ISNUMERIC(Name) = 0
    --UNION ALL
    --SELECT  *
    --FROM    ( SELECT TOP 5000000
    --                    [Id] ,
    --                    [Name]
    --          FROM      [dbo].[MaterialTypeGramazh]
    --          WHERE     ISNUMERIC(Name) = 1
    --          ORDER BY  REPLICATE('0', 100 - LEN([Name])) + [Name]
    --        ) tbl2

  
 

    SELECT  [Id] ,
            [Name]
    FROM    [dbo].[MaterialTypeGramazh]
    ORDER BY REPLICATE('0', 100 - LEN([Name])) + [Name]
    



	






GO
/****** Object:  StoredProcedure [dbo].[MaterialTypeGramazh_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MaterialTypeGramazh_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [Name] FROM [dbo].[MaterialTypeGramazh] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[MaterialTypeGramazh_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MaterialTypeGramazh_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[MaterialTypeGramazh]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[MaterialTypeGramazh_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MaterialTypeGramazh_Update]
	@Id int,
	@Name nvarchar(MAX)

AS

UPDATE [dbo].[MaterialTypeGramazh]
SET
	[Name] = @Name
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[MaterialTypes_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MaterialTypes_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[MaterialTypes] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[MaterialTypes_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MaterialTypes_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[MaterialTypes]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[MaterialTypes_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MaterialTypes_Insert]
	@Id int output,
	@Name nvarchar(MAX) 

AS

INSERT [dbo].[MaterialTypes]
(
	[Name]

)
VALUES
(
	@Name

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[MaterialTypes_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MaterialTypes_SelectAll]
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[MaterialTypes]
	order by Name






GO
/****** Object:  StoredProcedure [dbo].[MaterialTypes_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MaterialTypes_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [Name] FROM [dbo].[MaterialTypes] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[MaterialTypes_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MaterialTypes_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[MaterialTypes]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[MaterialTypes_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MaterialTypes_Update]
	@Id int,
	@Name nvarchar(MAX)

AS

UPDATE [dbo].[MaterialTypes]
SET
	[Name] = @Name
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Messages_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Messages_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[Messages] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[Messages_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Messages_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[Messages]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Messages_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Messages_Insert]
	@Id int output,
	@Title nvarchar(MAX) ,
	@Body nvarchar(MAX) ,
	@Date datetime ,
	@SenderId int ,
	@ReceiverId int ,
	@SenderDeleted bit ,
	@ReceiverDeleted bit ,
	@Read bit 

AS

INSERT [dbo].[Messages]
(
	[Title],
	[Body],
	[Date],
	[SenderId],
	[ReceiverId],
	[SenderDeleted],
	[ReceiverDeleted],
	[Read]

)
VALUES
(
	@Title,
	@Body,
	@Date,
	@SenderId,
	@ReceiverId,
	@SenderDeleted,
	@ReceiverDeleted,
	@Read

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[Messages_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Messages_SelectAll]
AS

	SELECT 
		[Id], [Title], [Body], [Date], [SenderId], [ReceiverId], [SenderDeleted], [ReceiverDeleted], [Read]
	FROM [dbo].[Messages]






GO
/****** Object:  StoredProcedure [dbo].[Messages_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Messages_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [Title], [Body], [Date], [SenderId], [ReceiverId], [SenderDeleted], [ReceiverDeleted], [Read] FROM [dbo].[Messages] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[Messages_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Messages_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [Title], [Body], [Date], [SenderId], [ReceiverId], [SenderDeleted], [ReceiverDeleted], [Read]
	FROM [dbo].[Messages]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Messages_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Messages_Update]
	@Id int,
	@Title nvarchar(MAX),
	@Body nvarchar(MAX),
	@Date datetime,
	@SenderId int,
	@ReceiverId int,
	@SenderDeleted bit,
	@ReceiverDeleted bit,
	@Read bit

AS

UPDATE [dbo].[Messages]
SET
	[Title] = @Title,
	[Body] = @Body,
	[Date] = @Date,
	[SenderId] = @SenderId,
	[ReceiverId] = @ReceiverId,
	[SenderDeleted] = @SenderDeleted,
	[ReceiverDeleted] = @ReceiverDeleted,
	[Read] = @Read
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[OperationHistories_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OperationHistories_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[OperationHistories] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[OperationHistories_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OperationHistories_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[OperationHistories]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[OperationHistories_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OperationHistories_Insert]
	@Id int output,
	@Date datetime ,
	@Description nvarchar(MAX) ,
	@UserId int 

AS

INSERT [dbo].[OperationHistories]
(
	[Date],
	[Description],
	[UserId]

)
VALUES
(
	@Date,
	@Description,
	@UserId

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[OperationHistories_Search]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OperationHistories_Search]
@UserId INT = NULL,
@StartDate DATETIME = NULL,
@EndDate DATETIME = NULL,
@Search NVARCHAR(max) = NULL
AS

	SELECT 
		u.Name AS [User],dbo.CalculatePersianDate([Date]) AS [Date],CONVERT(VARCHAR(5),[Date],108) AS [Time] , [Description]
	FROM [dbo].[OperationHistories] o
	INNER JOIN dbo.Users u ON o.UserId = u.Id
	WHERE (u.Id = @UserId OR @UserId IS NULL) AND
		  ([Date] >= @StartDate  OR @StartDate IS NULL) AND
		  ([Date] <= @EndDate OR @EndDate IS NULL)AND
		  ([Description] LIKE '%' + @Search + '%' OR [Description] IS NULL)






GO
/****** Object:  StoredProcedure [dbo].[OperationHistories_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OperationHistories_SelectAll]
AS

	SELECT 
		[Id], [Date], [Description], [UserId]
	FROM [dbo].[OperationHistories]






GO
/****** Object:  StoredProcedure [dbo].[OperationHistories_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OperationHistories_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [Date], [Description], [UserId] FROM [dbo].[OperationHistories] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[OperationHistories_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OperationHistories_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [Date], [Description], [UserId]
	FROM [dbo].[OperationHistories]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[OperationHistories_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OperationHistories_Update]
	@Id int,
	@Date datetime,
	@Description nvarchar(MAX),
	@UserId int

AS

UPDATE [dbo].[OperationHistories]
SET
	[Date] = @Date,
	[Description] = @Description,
	[UserId] = @UserId
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[OrderReceivers_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OrderReceivers_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[OrderReceivers] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[OrderReceivers_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OrderReceivers_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[OrderReceivers]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[OrderReceivers_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OrderReceivers_Insert]
	@Id int output,
	@Name nvarchar(MAX) 

AS

INSERT [dbo].[OrderReceivers]
(
	[Name]

)
VALUES
(
	@Name

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[OrderReceivers_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OrderReceivers_SelectAll]
AS
    SELECT  [Id] ,
            [Name]
    FROM    [dbo].[OrderReceivers]
    ORDER BY Name

	




GO
/****** Object:  StoredProcedure [dbo].[OrderReceivers_SelectAll_ByLevel]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OrderReceivers_SelectAll_ByLevel] @LevelId INT
AS
    SELECT  o.[Id] ,
            o.[Name]
    FROM    [dbo].[OrderReceivers] o
            INNER JOIN [dbo].[LevelOrderReceiver] l ON l.OrderReceiver_Id = o.Id
    WHERE   l.Level_Id = @LevelId
    ORDER BY Name
	






GO
/****** Object:  StoredProcedure [dbo].[OrderReceivers_SelectAllForGrid]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OrderReceivers_SelectAllForGrid]
AS

	SELECT 
		[OrderReceivers].[Id], [OrderReceivers].[Name],[Levels].Name as LevelName
	FROM [dbo].[OrderReceivers]
	inner join [dbo].[LevelOrderReceiver]  on [OrderReceivers].Id = [LevelOrderReceiver].OrderReceiver_Id
	inner join [dbo].[Levels] on [LevelOrderReceiver].Level_Id = [Levels].Id






GO
/****** Object:  StoredProcedure [dbo].[OrderReceivers_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OrderReceivers_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [Name] FROM [dbo].[OrderReceivers] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[OrderReceivers_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OrderReceivers_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[OrderReceivers]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[OrderReceivers_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OrderReceivers_Update]
	@Id int,
	@Name nvarchar(MAX)

AS

UPDATE [dbo].[OrderReceivers]
SET
	[Name] = @Name
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Pages_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Pages_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[Pages] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[Pages_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Pages_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[Pages]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Pages_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Pages_Insert]
	@Id int output,
	@Name nvarchar(MAX) ,
	@Path nvarchar(MAX) ,
	@Icon nvarchar(MAX) ,
	@GroupId smallint 

AS

INSERT [dbo].[Pages]
(
	[Name],
	[Path],
	[Icon],
	[GroupId]

)
VALUES
(
	@Name,
	@Path,
	@Icon,
	@GroupId

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[Pages_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Pages_SelectAll]
AS

	SELECT 
		[Id], [Name], [Path], [Icon], [GroupId]
	FROM [dbo].[Pages]






GO
/****** Object:  StoredProcedure [dbo].[Pages_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Pages_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [Name], [Path], [Icon], [GroupId] FROM [dbo].[Pages] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[Pages_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Pages_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [Name], [Path], [Icon], [GroupId]
	FROM [dbo].[Pages]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Pages_SelectByUserPermissions]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Pages_SelectByUserPermissions]
@UserId int,
@GroupId int
AS

	SELECT 
		p.[Id], p.[Name], p.[Path], p.[Icon], p.[GroupId]
	FROM [dbo].[Pages] p  inner join [dbo].[UserPage] us
	on p.Id = us.Page_Id
	where us.[User_Id] = @UserId AND p.GroupId=@GroupId
	order by [Id]






GO
/****** Object:  StoredProcedure [dbo].[Pages_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Pages_Update]
	@Id int,
	@Name nvarchar(MAX),
	@Path nvarchar(MAX),
	@Icon nvarchar(MAX),
	@GroupId smallint

AS

UPDATE [dbo].[Pages]
SET
	[Name] = @Name,
	[Path] = @Path,
	[Icon] = @Icon,
	[GroupId] = @GroupId
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[PaperHeight_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PaperHeight_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[PaperHeight] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[PaperHeight_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PaperHeight_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[PaperHeight]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[PaperHeight_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PaperHeight_Insert]
	@Id int output,
	@Name nvarchar(MAX) 

AS

INSERT [dbo].[PaperHeight]
(
	[Name]

)
VALUES
(
	@Name

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[PaperHeight_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PaperHeight_SelectAll]
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[PaperHeight]
	ORDER BY CAST(Name AS DECIMAL)






GO
/****** Object:  StoredProcedure [dbo].[PaperHeight_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PaperHeight_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [Name] FROM [dbo].[PaperHeight] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[PaperHeight_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PaperHeight_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[PaperHeight]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[PaperHeight_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PaperHeight_Update]
	@Id int,
	@Name nvarchar(MAX)

AS

UPDATE [dbo].[PaperHeight]
SET
	[Name] = @Name
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[PaperTypes_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PaperTypes_Update]
	@Id int,
	@Name nvarchar(MAX)

AS

UPDATE [dbo].[PaperTypes]
SET
	[Name] = @Name
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[PaperWidth_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PaperWidth_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[PaperWidth] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[PaperWidth_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PaperWidth_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[PaperWidth]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[PaperWidth_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PaperWidth_Insert]
	@Id int output,
	@Name nvarchar(MAX) 

AS

INSERT [dbo].[PaperWidth]
(
	[Name]

)
VALUES
(
	@Name

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[PaperWidth_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PaperWidth_SelectAll]
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[PaperWidth]
	ORDER BY CAST(Name AS DECIMAL)






GO
/****** Object:  StoredProcedure [dbo].[PaperWidth_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PaperWidth_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [Name] FROM [dbo].[PaperWidth] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[PaperWidth_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PaperWidth_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[PaperWidth]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[PaperWidth_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PaperWidth_Update]
	@Id int,
	@Name nvarchar(MAX)

AS

UPDATE [dbo].[PaperWidth]
SET
	[Name] = @Name
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Plates_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Plates_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[Plates] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[Plates_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Plates_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[Plates]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Plates_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Plates_Insert]
	@Id int output,
	@JobId int ,
	@OrderReceiverId int ,
	@DimensionId int ,
	@LpiId int ,
	@MainColorCountId int = null ,
	@ExportColorId int ,
	@SpotColorCountId int = null ,
	@SpotColors nvarchar(MAX) = null ,
	@OverPrintBlackColor bit ,
	@DeviceCount int = null ,
	@FormEvertCount float = null ,
	@Description nvarchar(MAX) = null ,
	@InvoiceRow nvarchar(50) = null ,
	@InvoiceNum nvarchar(50) = null ,
	@InvoiceCost money = null 

AS

INSERT [dbo].[Plates]
(
	[JobId],
	[OrderReceiverId],
	[DimensionId],
	[LpiId],
	[MainColorCountId],
	[ExportColorId],
	[SpotColorCountId],
	[SpotColors],
	[OverPrintBlackColor],
	[DeviceCount],
	[FormEvertCount],
	[Description],
	[InvoiceRow],
	[InvoiceNum],
	[InvoiceCost]

)
VALUES
(
	@JobId,
	@OrderReceiverId,
	@DimensionId,
	@LpiId,
	@MainColorCountId,
	@ExportColorId,
	@SpotColorCountId,
	@SpotColors,
	@OverPrintBlackColor,
	@DeviceCount,
	@FormEvertCount,
	@Description,
	@InvoiceRow,
	@InvoiceNum,
	@InvoiceCost

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[Plates_ReportById]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Plates_ReportById]
@Id int
AS

SELECT P.[Id],J.Name AS job,j.Code,J.Id AS JobId,dbo.CalculatePersianDate(j.CreateDate) AS CreateDatePersian,
	   c.NAME AS CustomerName,o.Name AS OrderReceiver,d.Name AS Dimension
      ,l.Name AS Lpi,
      (CASE WHEN mc.Name IS NULL THEN N'ندارد'  ELSE mc.Name END) AS MainColorCount
      ,ex.Name AS ExportColor
      ,(CASE WHEN sp.Name IS NULL THEN N'ندارد'  ELSE sp.Name END) AS SpotColorCount
      ,P.[SpotColors],
      (CASE WHEN P.[OverPrintBlackColor] = 1 THEN N'دارد' ELSE N'ندارد' END) AS OverPrintBlackColor
      ,P.[DeviceCount],P.[FormEvertCount],P.[Description]
      ,P.[InvoiceRow],P.[InvoiceNum],P.[InvoiceCost]
  FROM [dbo].[Plates] P
  INNER JOIN dbo.Jobs J ON J.Id = P.JobId
  INNER JOIN dbo.Customers c ON c.Id = j.CustomerId
  INNER JOIN dbo.OrderReceivers O ON O.Id = P.OrderReceiverId
  INNER JOIN dbo.Dimensions D ON D.Id = P.DimensionId
  INNER JOIN dbo.LPI L ON L.Id = P.LpiId
  LEFT JOIN dbo.MainColorCount MC ON MC.Id = P.MainColorCountId
  INNER JOIN dbo.ExportColors EX ON EX.Id = P.ExportColorId
  LEFT JOIN dbo.MainColorCount SP ON SP.Id = P.SpotColorCountId
  
WHERE p.Id = @Id





GO
/****** Object:  StoredProcedure [dbo].[Plates_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Plates_SelectAll]
AS

	SELECT 
		[Id], [JobId], [OrderReceiverId], [DimensionId], [LpiId], [MainColorCountId], [ExportColorId], [SpotColorCountId], [SpotColors], [OverPrintBlackColor], [DeviceCount], [FormEvertCount], [Description], [InvoiceRow], [InvoiceNum], [InvoiceCost]
	FROM [dbo].[Plates]






GO
/****** Object:  StoredProcedure [dbo].[Plates_SelectAll_ForGrid]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Plates_SelectAll_ForGrid]
@JobId int
AS

	SELECT 
		p.[Id], o.Name as OrderReceiverName, d.Name as DimensionName,l.Name AS LpiName, [Description]
	FROM [dbo].[Plates] p
	inner join [dbo].[OrderReceivers] o on p.OrderReceiverId = o.Id
	inner join [dbo].[Dimensions] d on p.DimensionId = d.Id
	inner join [dbo].[LPI] l on p.LpiId = l.Id
	
	where p.JobId = @JobId






GO
/****** Object:  StoredProcedure [dbo].[Plates_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Plates_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [JobId], [OrderReceiverId], [DimensionId], [LpiId], [MainColorCountId], [ExportColorId], [SpotColorCountId], [SpotColors], [OverPrintBlackColor], [DeviceCount], [FormEvertCount], [Description], [InvoiceRow], [InvoiceNum], [InvoiceCost] FROM [dbo].[Plates] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[Plates_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Plates_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [JobId], [OrderReceiverId], [DimensionId], [LpiId], [MainColorCountId], [ExportColorId], [SpotColorCountId], [SpotColors], [OverPrintBlackColor], [DeviceCount], [FormEvertCount], [Description], [InvoiceRow], [InvoiceNum], [InvoiceCost]
	FROM [dbo].[Plates]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Plates_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Plates_Update]
	@Id int,
	@JobId int,
	@OrderReceiverId int,
	@DimensionId int,
	@LpiId int,
	@MainColorCountId int = null,
	@ExportColorId int,
	@SpotColorCountId int = null,
	@SpotColors nvarchar(MAX) = null,
	@OverPrintBlackColor bit,
	@DeviceCount int = null,
	@FormEvertCount float = null,
	@Description nvarchar(MAX) = null,
	@InvoiceRow nvarchar(50) = null,
	@InvoiceNum nvarchar(50) = null,
	@InvoiceCost money = null

AS

UPDATE [dbo].[Plates]
SET
	[JobId] = @JobId,
	[OrderReceiverId] = @OrderReceiverId,
	[DimensionId] = @DimensionId,
	[LpiId] = @LpiId,
	[MainColorCountId] = @MainColorCountId,
	[ExportColorId] = @ExportColorId,
	[SpotColorCountId] = @SpotColorCountId,
	[SpotColors] = @SpotColors,
	[OverPrintBlackColor] = @OverPrintBlackColor,
	[DeviceCount] = @DeviceCount,
	[FormEvertCount] = @FormEvertCount,
	[Description] = @Description,
	[InvoiceRow] = @InvoiceRow,
	[InvoiceNum] = @InvoiceNum,
	[InvoiceCost] = @InvoiceCost
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[PreparingPaper_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PreparingPaper_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[PreparingPaper] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[PreparingPaper_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PreparingPaper_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[PreparingPaper]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[PreparingPaper_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PreparingPaper_Insert]
	@Id int output,
	@JobId int ,
	@FromInstituteId int ,
	@ToInstituteId int ,
	@MaterialTypeId int ,
	@MaterialTypeGramazhId int ,
	@PaperWidthId int ,
	@PaperHeightId int ,
	@LeafCount int,
	@Description nvarchar(MAX) = null

AS

INSERT [dbo].[PreparingPaper]
(
	[JobId],
	[FromInstituteId],
	[ToInstituteId],
	[MaterialTypeId],
	[MaterialTypeGramazhId],
	[PaperWidthId],
	[PaperHeightId],
	[LeafCount],
	[Description]

)
VALUES
(
	@JobId,
	@FromInstituteId,
	@ToInstituteId,
	@MaterialTypeId,
	@MaterialTypeGramazhId,
	@PaperWidthId,
	@PaperHeightId,
	@LeafCount,
	@Description

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[PreparingPaper_ReportById]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PreparingPaper_ReportById]
@Id int
AS


SELECT p.[Id],
	   J.Name AS job,j.Code,J.Id AS JobId,dbo.CalculatePersianDate(j.CreateDate) AS CreateDatePersian,
	   c.NAME AS CustomerName,
	   fi.Name AS FromInstitute,ti.Name AS ToInstitute,mt.Name AS MaterialType,
	   mtg.Name AS MaterialTypeGramazh,
	   pw.Name AS  PaperWidth,ph.Name AS PaperHeight,LeafCount,p.Description
       
  FROM [dbo].PreparingPaper p
  INNER JOIN dbo.Jobs J ON J.Id = p.JobId
   INNER JOIN dbo.Customers c ON c.Id = j.CustomerId
  INNER JOIN dbo.Institute fi ON fi.Id = p.FromInstituteId
  INNER JOIN dbo.Institute ti ON ti.Id = p.ToInstituteId
    INNER JOIN dbo.MaterialTypes mt ON mt.Id = p.MaterialTypeId
  INNER JOIN dbo.MaterialTypeGramazh mtg ON mtg.Id = p.MaterialTypeGramazhId
  INNER JOIN dbo.PaperWidth pw ON pw.Id = p.PaperWidthId
  INNER JOIN dbo.PaperHeight ph ON ph.Id = p.PaperHeightId
  

  
WHERE p.Id = @Id





GO
/****** Object:  StoredProcedure [dbo].[PreparingPaper_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PreparingPaper_SelectAll]
AS

	SELECT 
		[Id], [JobId], [FromInstituteId], [ToInstituteId], [MaterialTypeId], [MaterialTypeGramazhId], [PaperWidthId], [PaperHeightId], [LeafCount],[Description]
	FROM [dbo].[PreparingPaper]






GO
/****** Object:  StoredProcedure [dbo].[PreparingPaper_SelectAll_ForGrid]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PreparingPaper_SelectAll_ForGrid]
@JobId int
AS

	SELECT 
		[PreparingPaper].[Id],(select Name From dbo.Institute where Id =[FromInstituteId] ) as FromInstituteName,
		(select Name From dbo.Institute where Id =[ToInstituteId] ) as ToInstituteName, [LeafCount]
		,mt.Name AS MaterialTypeName
	FROM [dbo].[PreparingPaper]
	inner join [dbo].[MaterialTypes] mt on [PreparingPaper].MaterialTypeId = mt.Id
	where JobId = @JobId
	






GO
/****** Object:  StoredProcedure [dbo].[PreparingPaper_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PreparingPaper_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [JobId], [FromInstituteId], [ToInstituteId], [MaterialTypeId], [MaterialTypeGramazhId], [PaperWidthId], [PaperHeightId], [LeafCount],[Description] FROM [dbo].[PreparingPaper] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[PreparingPaper_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PreparingPaper_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [JobId], [FromInstituteId], [ToInstituteId], [MaterialTypeId], [MaterialTypeGramazhId], [PaperWidthId], [PaperHeightId], [LeafCount],[Description]
	FROM [dbo].[PreparingPaper]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[PreparingPaper_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PreparingPaper_Update]
	@Id int,
	@JobId int,
	@FromInstituteId int,
	@ToInstituteId int,
	@MaterialTypeId int,
	@MaterialTypeGramazhId int,
	@PaperWidthId int,
	@PaperHeightId int,
	@LeafCount int,
	@Description nvarchar(max) = null

AS

UPDATE [dbo].[PreparingPaper]
SET
	[JobId] = @JobId,
	[FromInstituteId] = @FromInstituteId,
	[ToInstituteId] = @ToInstituteId,
	[MaterialTypeId] = @MaterialTypeId,
	[MaterialTypeGramazhId] = @MaterialTypeGramazhId,
	[PaperWidthId] = @PaperWidthId,
	[PaperHeightId] = @PaperHeightId,
	[LeafCount] = @LeafCount,
	[Description] = @Description
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[PrimaryStock_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PrimaryStock_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[PrimaryStock] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)




GO
/****** Object:  StoredProcedure [dbo].[PrimaryStock_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PrimaryStock_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[PrimaryStock]
 WHERE 
	[Id] = @Id




GO
/****** Object:  StoredProcedure [dbo].[PrimaryStock_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PrimaryStock_Insert]
	@Id int output,
	@CartexId int ,
	@FromOrderReceiversId int ,
	@ToOrderReceiversId int ,
	@JobTypesId int ,
	@JobCount int = null ,
	@Description nvarchar(MAX) = null 
	

AS

INSERT [dbo].[PrimaryStock]
(
	[CartexId],
	[FromOrderReceiversId],
	[ToOrderReceiversId],
	[JobTypesId],
	[JobCount],
	[Description]

)
VALUES
(
	@CartexId,
	@FromOrderReceiversId,
	@ToOrderReceiversId,
	@JobTypesId,
	@JobCount,
	@Description

)
	SELECT @Id=SCOPE_IDENTITY();





GO
/****** Object:  StoredProcedure [dbo].[PrimaryStock_ReportById]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PrimaryStock_ReportById] @Id INT
AS
    SELECT  c.JobCode ,
            c.JobName ,
            cu.Name AS CustomerName ,
            o1.Name AS FromOrderReceiverName ,
            o2.Name AS ToOrderReceiverName ,
            j.Name AS JobTypeName ,
            [JobCount] ,
            ps.[Description]
    FROM    [dbo].[PrimaryStock] ps
            INNER JOIN dbo.Cartexes c ON c.Id = ps.CartexId
            INNER JOIN dbo.Customers cu ON c.CustomerId = cu.Id
            INNER JOIN dbo.OrderReceivers o1 ON o1.Id = FromOrderReceiversId
            INNER JOIN dbo.OrderReceivers o2 ON o2.Id = ToOrderReceiversId
            INNER JOIN dbo.JobTypes j ON j.Id = ps.JobTypesId
    WHERE   ps.Id = @Id




GO
/****** Object:  StoredProcedure [dbo].[PrimaryStock_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PrimaryStock_SelectAll]
AS
    SELECT  [Id] ,
            [CartexId] ,
            [FromOrderReceiversId] ,
            [ToOrderReceiversId] ,
            [JobTypesId] ,
            [JobCount] ,
            [Description]
    FROM    [dbo].[PrimaryStock]




GO
/****** Object:  StoredProcedure [dbo].[PrimaryStock_SelectAll_ForGrid]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PrimaryStock_SelectAll_ForGrid] @CartexId INT
AS
    SELECT  p.[Id] ,
            N'موجودی '
            + CAST(ROW_NUMBER() OVER ( ORDER BY p.Id ) AS NVARCHAR(50)) AS Series ,
            o1.Name AS FromOrderReceivers ,
            o2.Name AS ToOrderReceivers ,
            j.Name AS JobTypes ,
            [JobCount]
    FROM    [dbo].[PrimaryStock] p
            INNER JOIN dbo.OrderReceivers o1 ON p.FromOrderReceiversId = o1.Id
            INNER JOIN dbo.OrderReceivers o2 ON p.ToOrderReceiversId = o2.Id
            INNER JOIN dbo.JobTypes j ON p.JobTypesId = j.Id
    WHERE   p.CartexId = @CartexId




GO
/****** Object:  StoredProcedure [dbo].[PrimaryStock_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PrimaryStock_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [CartexId], [FromOrderReceiversId], [ToOrderReceiversId], [JobTypesId], [JobCount], [Description] FROM [dbo].[PrimaryStock] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)




GO
/****** Object:  StoredProcedure [dbo].[PrimaryStock_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PrimaryStock_SelectByPrimaryKey] @Id INT
AS
    SELECT  [Id] ,
            [CartexId] ,
            [FromOrderReceiversId] ,
            [ToOrderReceiversId] ,
            [JobTypesId] ,
            [JobCount] ,
            [Description]
			
    FROM    [dbo].[PrimaryStock]
    WHERE   [Id] = @Id




GO
/****** Object:  StoredProcedure [dbo].[PrimaryStock_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PrimaryStock_Update]
	@Id int,
	@CartexId int,
	@FromOrderReceiversId int,
	@ToOrderReceiversId int,
	@JobTypesId int,
	@JobCount int = null,
	@Description nvarchar(MAX) = NULL
 

AS

UPDATE [dbo].[PrimaryStock]
SET
	[CartexId] = @CartexId,
	[FromOrderReceiversId] = @FromOrderReceiversId,
	[ToOrderReceiversId] = @ToOrderReceiversId,
	[JobTypesId] = @JobTypesId,
	[JobCount] = @JobCount,
	[Description] = @Description

 WHERE 
	[Id] = @Id




GO
/****** Object:  StoredProcedure [dbo].[Printings_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Printings_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[Printings] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[Printings_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Printings_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[Printings]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Printings_HasCartex]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Printings_HasCartex]
    @Id INT ,
    @Result BIT OUTPUT
AS
    DECLARE @JobCode NVARCHAR(MAX)
    SELECT  @JobCode = j.Code
    FROM    dbo.Printings p INNER JOIN dbo.Jobs j ON p.JobId = j.Id
    WHERE   p.Id = @Id

    IF EXISTS ( SELECT  *
                FROM    dbo.Cartexes
                WHERE   JobCode = @JobCode)
        SELECT  @Result = CAST(1 AS BIT)
    ELSE
        SELECT  @Result = CAST(0 AS BIT)








GO
/****** Object:  StoredProcedure [dbo].[Printings_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Printings_Insert]
    @Id INT OUTPUT ,
    @JobId INT ,
    @Row INT ,
    @Printing INT ,
    @Dimension NVARCHAR(MAX) = NULL ,
    @OrderReceiverId INT ,
    @PrintTypeId INT ,
    @ZinkTypeId INT ,
    @PrintModelId INT ,
    @MaterialTypeId INT ,
    @MaterialTypeGramazhId INT ,
    @LargePaperCount INT = NULL ,
    @LargePaperSize NVARCHAR(50) = NULL ,
    @PaperParagraphCount INT = NULL ,
    @ParagraphLeafCount INT = NULL ,
    @PrintingTirazh INT = NULL ,
    @MainColorCountId INT = NULL ,
    @ExportColorId INT ,
    @SpotColorCountId INT = NULL ,
    @SpotColors NVARCHAR(MAX) = NULL ,
    @PrintingSupervision BIT ,
    @ColorInstance INT ,
    @DeviceCount INT = NULL ,
    @FormEvertCount FLOAT = NULL ,
    @Description NVARCHAR(MAX) = NULL ,
    @InvoiceRow NVARCHAR(50) = NULL ,
    @InvoiceNum NVARCHAR(50) = NULL ,
    @InvoiceCost MONEY = NULL ,
    @IsUse BIT ,
    @PaperWidthId INT = NULL ,
    @PaperHeightId INT = NULL,
	@FromInstituteId int 
AS
    INSERT  [dbo].[Printings]
            ( [JobId] ,
              [Row] ,
              [Printing] ,
              [Dimension] ,
              [OrderReceiverId] ,
              [PrintTypeId] ,
              [ZinkTypeId] ,
              [PrintModelId] ,
              [MaterialTypeId] ,
              [MaterialTypeGramazhId] ,
              [LargePaperCount] ,
              [LargePaperSize] ,
              [PaperParagraphCount] ,
              [ParagraphLeafCount] ,
              [PrintingTirazh] ,
              [MainColorCountId] ,
              [ExportColorId] ,
              [SpotColorCountId] ,
              [SpotColors] ,
              [PrintingSupervision] ,
              [ColorInstance] ,
              [DeviceCount] ,
              [FormEvertCount] ,
              [Description] ,
              [InvoiceRow] ,
              [InvoiceNum] ,
              [InvoiceCost] ,
              [IsUse] ,
              [PaperWidthId] ,
              [PaperHeightId],
			  [FromInstituteId]

            )
    VALUES  ( @JobId ,
              @Row ,
              @Printing ,
              @Dimension ,
              @OrderReceiverId ,
              @PrintTypeId ,
              @ZinkTypeId ,
              @PrintModelId ,
              @MaterialTypeId ,
              @MaterialTypeGramazhId ,
              @LargePaperCount ,
              @LargePaperSize ,
              @PaperParagraphCount ,
              @ParagraphLeafCount ,
              @PrintingTirazh ,
              @MainColorCountId ,
              @ExportColorId ,
              @SpotColorCountId ,
              @SpotColors ,
              @PrintingSupervision ,
              @ColorInstance ,
              @DeviceCount ,
              @FormEvertCount ,
              @Description ,
              @InvoiceRow ,
              @InvoiceNum ,
              @InvoiceCost ,
              @IsUse ,
              @PaperWidthId ,
              @PaperHeightId,
			  @FromInstituteId

            )
    SELECT  @Id = SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[Printings_IsSend]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Printings_IsSend]
    @Id INT ,
    @Result BIT OUTPUT
AS
    DECLARE @JobId INT
    SELECT  @JobId = JobId
    FROM    dbo.Printings
    WHERE   Id = @Id

    IF EXISTS ( SELECT  *
                FROM    dbo.Printings
                WHERE   JobId = @JobId
                        AND IsUse = 1 )
        SELECT  @Result = CAST(1 AS BIT)
    ELSE
        SELECT  @Result = CAST(0 AS BIT)








GO
/****** Object:  StoredProcedure [dbo].[Printings_ReportById]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Printings_ReportById]
@Id int
AS
DECLARE @jobId int
SET @jobId = (SELECT JobId FROM dbo.Printings WHERE Id =@Id); 

WITH cte AS (
SELECT N'چاپ سری' + cast(Row_number() OVER(ORDER BY pr.Id) as nvarchar(50)) AS Row ,pr.Id
	   FROM dbo.Printings pr
	   WHERE pr.JobId = @jobId)

SELECT p.[Id],
	  (SELECT Row FROM cte WHERE Id = @Id) AS Row,
	  J.Name AS job,j.Code,J.Id AS JobId,dbo.CalculatePersianDate(j.CreateDate) AS CreateDatePersian,
	  c.NAME AS CustomerName,
	  (CASE WHEN Printing=1 THEN N'چاپ جدید (زینک جدید دارد)' ELSE N'تجدید چاپ' END) AS Printing
      ,o.Name AS OrderReceiver,pt.Name AS PrintType, zt.Name AS ZinkType,
      pm.Name AS PrintModel,mt.Name AS MaterialType,mtg.Name AS MaterialTypeGramazh,
      LargePaperCount,LargePaperSize,PaperParagraphCount,ParagraphLeafCount,PrintingTirazh,
      (CASE WHEN mc.Name IS NULL THEN N'ندارد'  ELSE mc.Name  END) AS MainColorCount
      ,ex.Name AS ExportColor
      ,(CASE WHEN sp.Name IS NULL THEN N'ندارد'  ELSE sp.Name END) AS SpotColorCount,
      SpotColors,
      (CASE WHEN PrintingSupervision=1 THEN N'دارد' ELSE N'ندارد' END ) AS PrintingSupervision,
      (CASE WHEN ColorInstance = 1 THEN N'طبق نمونه ارسالی' ELSE N'طبق رنگ پنتون' END) AS ColorInstance,
      DeviceCount,FormEvertCount,p.Dimension
      ,p.[Description],p.[InvoiceRow],p.[InvoiceNum],p.[InvoiceCost],[PaperWidthId], [PaperHeightId]
  
  FROM [dbo].Printings P
  INNER JOIN dbo.Jobs J ON J.Id = p.JobId
  INNER JOIN dbo.Customers c ON c.Id = j.CustomerId
  INNER JOIN dbo.OrderReceivers O ON O.Id = p.OrderReceiverId
  INNER JOIN dbo.PrintTypes pt ON pt.Id = p.PrintTypeId
  INNER JOIN dbo.ZinkTypes zt ON zt.Id = p.ZinkTypeId
  INNER JOIN dbo.PrintModels pm ON pm.Id = p.PrintModelId
  INNER JOIN dbo.MaterialTypes mt ON mt.Id = p.MaterialTypeId
  INNER JOIN dbo.MaterialTypeGramazh mtg ON mtg.Id = p.MaterialTypeGramazhId
  LEFT JOIN dbo.MainColorCount mc ON mc.Id = p.MainColorCountId
  INNER JOIN dbo.ExportColors ex ON ex.Id = p.ExportColorId
  LEFT JOIN dbo.MainColorCount sp ON sp.Id = p.SpotColorCountId
  

  
WHERE p.Id = @Id





GO
/****** Object:  StoredProcedure [dbo].[Printings_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Printings_SelectAll]
AS
    SELECT  [Id] ,
            [JobId] ,
            [Row] ,
            [Printing] ,
            [Dimension] ,
            [OrderReceiverId] ,
            [PrintTypeId] ,
            [ZinkTypeId] ,
            [PrintModelId] ,
            [MaterialTypeId] ,
            [MaterialTypeGramazhId] ,
            [LargePaperCount] ,
            [LargePaperSize] ,
            [PaperParagraphCount] ,
            [ParagraphLeafCount] ,
            [PrintingTirazh] ,
            [MainColorCountId] ,
            [ExportColorId] ,
            [SpotColorCountId] ,
            [SpotColors] ,
            [PrintingSupervision] ,
            [ColorInstance] ,
            [DeviceCount] ,
            [FormEvertCount] ,
            [Description] ,
            [InvoiceRow] ,
            [InvoiceNum] ,
            [InvoiceCost] ,
            [IsUse] ,
            [PaperWidthId] ,
            [PaperHeightId],
			[FromInstituteId]
    FROM    [dbo].[Printings]






GO
/****** Object:  StoredProcedure [dbo].[Printings_SelectAll_ForGrid]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Printings_SelectAll_ForGrid]
@JobId int
AS

	SELECT 
		p.[Id], N'چاپ سری' + cast(Row_number() OVER(ORDER BY p.Id) as nvarchar(50))  as PrintSeries,
		o.Name as OrderReceiverName,pt.Name AS PrintTypeName,[Description],p.JobId
	FROM [dbo].[Printings] p
	inner join [dbo].[OrderReceivers] o on p.OrderReceiverId = o.Id
	inner join [dbo].[PrintTypes] pt on p.PrintTypeId = pt.Id
	
	where p.JobId = @JobId






GO
/****** Object:  StoredProcedure [dbo].[Printings_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Printings_SelectByField]
    @FieldName VARCHAR(100) ,
    @Value VARCHAR(1000)
AS
    DECLARE @query VARCHAR(2000);

    SET @query = 'SELECT [Id], [JobId], [Row], [Printing], [Dimension], [OrderReceiverId], [PrintTypeId], [ZinkTypeId], [PrintModelId], [MaterialTypeId], [MaterialTypeGramazhId], [LargePaperCount], [LargePaperSize], [PaperParagraphCount], [ParagraphLeafCount], [PrintingTirazh], [MainColorCountId], [ExportColorId], [SpotColorCountId], [SpotColors], [PrintingSupervision], [ColorInstance], [DeviceCount], [FormEvertCount], [Description], [InvoiceRow], [InvoiceNum], [InvoiceCost],[IsUse],[PaperWidthId],[PaperHeightId],[FromInstituteId] FROM [dbo].[Printings] WHERE ['
        + @FieldName + '] = ''' + @Value + ''''
    EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[Printings_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Printings_SelectByPrimaryKey] @Id INT
AS
    SELECT  [Id] ,
            [JobId] ,
            [Row] ,
            [Printing] ,
            [Dimension] ,
            [OrderReceiverId] ,
            [PrintTypeId] ,
            [ZinkTypeId] ,
            [PrintModelId] ,
            [MaterialTypeId] ,
            [MaterialTypeGramazhId] ,
            [LargePaperCount] ,
            [LargePaperSize] ,
            [PaperParagraphCount] ,
            [ParagraphLeafCount] ,
            [PrintingTirazh] ,
            [MainColorCountId] ,
            [ExportColorId] ,
            [SpotColorCountId] ,
            [SpotColors] ,
            [PrintingSupervision] ,
            [ColorInstance] ,
            [DeviceCount] ,
            [FormEvertCount] ,
            [Description] ,
            [InvoiceRow] ,
            [InvoiceNum] ,
            [InvoiceCost] ,
            [IsUse] ,
            [PaperWidthId] ,
            [PaperHeightId],
			[FromInstituteId]
    FROM    [dbo].[Printings]
    WHERE   [Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Printings_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Printings_Update]
	@Id int,
	@JobId int,
	@Row int,
	@Printing int,
	@Dimension nvarchar(MAX) = null,
	@OrderReceiverId int,
	@PrintTypeId int,
	@ZinkTypeId int,
	@PrintModelId int,
	@MaterialTypeId int,
	@MaterialTypeGramazhId int,
	@LargePaperCount int = null,
	@LargePaperSize nvarchar(50) = null,
	@PaperParagraphCount int = null,
	@ParagraphLeafCount int = null,
	@PrintingTirazh int = null,
	@MainColorCountId int = null,
	@ExportColorId int,
	@SpotColorCountId int = null,
	@SpotColors nvarchar(MAX) = null,
	@PrintingSupervision bit,
	@ColorInstance int,
	@DeviceCount int = null,
	@FormEvertCount float = null,
	@Description nvarchar(MAX) = null,
	@InvoiceRow nvarchar(50) = null,
	@InvoiceNum nvarchar(50) = null,
	@InvoiceCost money = NULL,
	@IsUse bit,
	@PaperWidthId int =NULL,
	@PaperHeightId INT = NULL,
	@FromInstituteId int

AS

UPDATE [dbo].[Printings]
SET
	[JobId] = @JobId,
	[Row] = @Row,
	[Printing] = @Printing,
	[Dimension] = @Dimension,
	[OrderReceiverId] = @OrderReceiverId,
	[PrintTypeId] = @PrintTypeId,
	[ZinkTypeId] = @ZinkTypeId,
	[PrintModelId] = @PrintModelId,
	[MaterialTypeId] = @MaterialTypeId,
	[MaterialTypeGramazhId] = @MaterialTypeGramazhId,
	[LargePaperCount] = @LargePaperCount,
	[LargePaperSize] = @LargePaperSize,
	[PaperParagraphCount] = @PaperParagraphCount,
	[ParagraphLeafCount] = @ParagraphLeafCount,
	[PrintingTirazh] = @PrintingTirazh,
	[MainColorCountId] = @MainColorCountId,
	[ExportColorId] = @ExportColorId,
	[SpotColorCountId] = @SpotColorCountId,
	[SpotColors] = @SpotColors,
	[PrintingSupervision] = @PrintingSupervision,
	[ColorInstance] = @ColorInstance,
	[DeviceCount] = @DeviceCount,
	[FormEvertCount] = @FormEvertCount,
	[Description] = @Description,
	[InvoiceRow] = @InvoiceRow,
	[InvoiceNum] = @InvoiceNum,
	[InvoiceCost] = @InvoiceCost,
	[IsUse] = @IsUse,
	[PaperWidthId] = @PaperWidthId,
	[PaperHeightId] = @PaperHeightId,
	[FromInstituteId] = @FromInstituteId
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Printings_UpdateCartexStock]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Printings_UpdateCartexStock] @Id INT
AS
    DECLARE @JobCode NVARCHAR(MAX)
    DECLARE @PrintingTirazh INT 
 

    SELECT  @JobCode = j.Code
    FROM    dbo.Printings p
            INNER JOIN dbo.Jobs j ON p.JobId = j.Id
    WHERE   p.Id = @Id

    SELECT  @PrintingTirazh = ISNULL(PrintingTirazh, 0)
    FROM    dbo.Printings
    WHERE   Id = @Id
            AND IsUse = 0   


    UPDATE  dbo.Cartexes
    SET     Stock = Stock + ( @PrintingTirazh * [dbo].[ReturnCode](@JobCode) )         
    WHERE   JobCode = @JobCode

    UPDATE  dbo.Printings
    SET     IsUse = 1
    WHERE   Id = @Id

    





GO
/****** Object:  StoredProcedure [dbo].[Printings_UpdateCartexStockSub]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Printings_UpdateCartexStockSub] @Id INT
AS
    DECLARE @JobCode NVARCHAR(MAX)
    DECLARE @PrintingTirazh INT 
 

    SELECT  @JobCode = j.Code
    FROM    dbo.Printings p
            INNER JOIN dbo.Jobs j ON p.JobId = j.Id
    WHERE   p.Id = @Id

    SELECT  @PrintingTirazh = ISNULL(PrintingTirazh, 0)
    FROM    dbo.Printings
    WHERE   Id = @Id
             


    UPDATE  dbo.Cartexes
    SET     Stock = Stock - ( @PrintingTirazh * [dbo].[ReturnCode](@JobCode) )         
    WHERE   JobCode = @JobCode

    
    





GO
/****** Object:  StoredProcedure [dbo].[PrintModels_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PrintModels_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[PrintModels] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[PrintModels_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PrintModels_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[PrintModels]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[PrintModels_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PrintModels_Insert]
	@Id int output,
	@Name nvarchar(MAX) 

AS

INSERT [dbo].[PrintModels]
(
	[Name]

)
VALUES
(
	@Name

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[PrintModels_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PrintModels_SelectAll]
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[PrintModels]






GO
/****** Object:  StoredProcedure [dbo].[PrintModels_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PrintModels_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [Name] FROM [dbo].[PrintModels] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[PrintModels_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PrintModels_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[PrintModels]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[PrintModels_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PrintModels_Update]
	@Id int,
	@Name nvarchar(MAX)

AS

UPDATE [dbo].[PrintModels]
SET
	[Name] = @Name
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[PrintTypes_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PrintTypes_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[PrintTypes] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[PrintTypes_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PrintTypes_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[PrintTypes]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[PrintTypes_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PrintTypes_Insert]
	@Id int output,
	@Name nvarchar(MAX) 

AS

INSERT [dbo].[PrintTypes]
(
	[Name]

)
VALUES
(
	@Name

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[PrintTypes_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PrintTypes_SelectAll]
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[PrintTypes]
	ORDER BY Name






GO
/****** Object:  StoredProcedure [dbo].[PrintTypes_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PrintTypes_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [Name] FROM [dbo].[PrintTypes] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[PrintTypes_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PrintTypes_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[PrintTypes]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[PrintTypes_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PrintTypes_Update]
	@Id int,
	@Name nvarchar(MAX)

AS

UPDATE [dbo].[PrintTypes]
SET
	[Name] = @Name
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[ProductDelivery_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProductDelivery_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[ProductDelivery] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)




GO
/****** Object:  StoredProcedure [dbo].[ProductDelivery_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProductDelivery_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[ProductDelivery]
 WHERE 
	[Id] = @Id




GO
/****** Object:  StoredProcedure [dbo].[ProductDelivery_HasPermissionToInsert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProductDelivery_HasPermissionToInsert] @CartexId INT
AS
    DECLARE @ProductionOrderCount INT 
    DECLARE @ProductDeliveryCount INT 

    SELECT  @ProductionOrderCount = COUNT(*)
    FROM    dbo.ProductionOrder
    WHERE   CartexId = @CartexId

    SELECT  @ProductDeliveryCount = COUNT(*)
    FROM    dbo.ProductDelivery
    WHERE   CartexId = @CartexId

    IF ( @ProductionOrderCount > @ProductDeliveryCount )
        BEGIN
            SELECT  CAST(1 AS BIT) 
        END
    ELSE
        BEGIN
            SELECT  CAST(0 AS BIT) 
        END

  




GO
/****** Object:  StoredProcedure [dbo].[ProductDelivery_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProductDelivery_Insert]
    @Id INT OUTPUT ,
    @CartexId INT ,
    @DeliveryReceiversId INT = NULL ,
    @DeliveryCount INT ,
    @Fee1 MONEY ,
    @DeliveryDate DATETIME ,
    @Description NVARCHAR(MAX) = NULL ,
    @InputInvoiceDate DATETIME = NULL ,
    @InputInvoiceRow NVARCHAR(50) = NULL ,
    @InputInvoiceNum NVARCHAR(50) = NULL ,
    @InputInvoiceCost MONEY = NULL ,
    @OutputInvoiceDate DATETIME = NULL ,
    @OutputInvoiceRow NVARCHAR(50) = NULL ,
    @OutputInvoiceNum NVARCHAR(50) = NULL ,
    @OutputInvoiceCost MONEY = NULL 
AS
    INSERT  [dbo].[ProductDelivery]
            ( [CartexId] ,
              [DeliveryReceiversId] ,
              [DeliveryCount] ,
              [Fee1] ,
              [DeliveryDate] ,
              [Description] ,
              [InputInvoiceDate] ,
              [InputInvoiceRow] ,
              [InputInvoiceNum] ,
              [InputInvoiceCost] ,
              [OutputInvoiceDate] ,
              [OutputInvoiceRow] ,
              [OutputInvoiceNum] ,
              [OutputInvoiceCost] 

            )
    VALUES  ( @CartexId ,
              @DeliveryReceiversId ,
              @DeliveryCount ,
              @Fee1 ,
              @DeliveryDate ,
              @Description ,
              @InputInvoiceDate ,
              @InputInvoiceRow ,
              @InputInvoiceNum ,
              @InputInvoiceCost ,
              @OutputInvoiceDate ,
              @OutputInvoiceRow ,
              @OutputInvoiceNum ,
              @OutputInvoiceCost 

            )
    SELECT  @Id = SCOPE_IDENTITY();





GO
/****** Object:  StoredProcedure [dbo].[ProductDelivery_ReportById]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProductDelivery_ReportById] @Id INT
AS
    SELECT  c.JobCode ,
            c.JobName ,
            cu.Name AS CustomerName ,
            o.Name AS OrderReceiverName ,
            d.Name AS [DeliveryReceiverName] ,
            j.Name AS JobTypeName ,
            [DeliveryCount] ,
            [Fee1] ,
            ( ISNULL(Fee1, 0) * ISNULL(DeliveryCount, 0) ) AS CostSum ,
            [dbo].[CalculatePersianDate]([DeliveryDate]) AS DeliveryDatePersian ,
            p.[Description] ,
            [dbo].[CalculatePersianDate]([InputInvoiceDate]) AS InputInvoiceDatePersian ,
            [InputInvoiceRow] ,
            [InputInvoiceNum] ,
            [InputInvoiceCost] ,
            [dbo].[CalculatePersianDate]([OutputInvoiceDate]) AS OutputInvoiceDatePersian ,
            [OutputInvoiceRow] ,
            [OutputInvoiceNum] ,
            [OutputInvoiceCost]
    FROM    [dbo].[ProductDelivery] p
            INNER JOIN dbo.Cartexes c ON c.Id = p.CartexId
            INNER JOIN dbo.Customers cu ON c.CustomerId = cu.Id
            LEFT JOIN dbo.View_PrimaryStock vps ON vps.CartexId = p.CartexId
            INNER JOIN dbo.OrderReceivers o ON o.Id = vps.ToOrderReceiversId
            INNER JOIN dbo.JobTypes j ON j.Id = vps.JobTypesId
            LEFT JOIN dbo.DeliveryReceivers d ON d.Id = p.DeliveryReceiversId
    WHERE   p.Id = @Id


GO
/****** Object:  StoredProcedure [dbo].[ProductDelivery_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProductDelivery_SelectAll]
AS
    SELECT  [Id] ,
            [CartexId] ,
            [DeliveryReceiversId] ,
            [DeliveryCount] ,
            [Fee1] ,
            [DeliveryDate] ,
            [Description] ,
            [InputInvoiceDate] ,
            [InputInvoiceRow] ,
            [InputInvoiceNum] ,
            [InputInvoiceCost] ,
            [OutputInvoiceDate] ,
            [OutputInvoiceRow] ,
            [OutputInvoiceNum] ,
            [OutputInvoiceCost]
		
    FROM    [dbo].[ProductDelivery]




GO
/****** Object:  StoredProcedure [dbo].[ProductDelivery_SelectAll_ForGrid]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProductDelivery_SelectAll_ForGrid] @CartexId INT
AS
    SELECT  p.[Id] ,
            N'تحویل '
            + CAST(ROW_NUMBER() OVER ( ORDER BY p.Id ) AS NVARCHAR(50)) AS Series ,
            o.Name AS OrderReceivers ,
            j.Name AS JobTypes ,
            DeliveryCount ,
            [InputInvoiceCost] ,
            [InputInvoiceNum] ,
            [OutputInvoiceCost] ,
            [OutputInvoiceNum]
    FROM    [dbo].[ProductDelivery] p
            LEFT JOIN dbo.View_PrimaryStock vps ON vps.CartexId = p.CartexId
            INNER JOIN dbo.OrderReceivers o ON o.Id = vps.ToOrderReceiversId
            INNER JOIN dbo.JobTypes j ON j.Id = vps.JobTypesId
    WHERE   p.CartexId = @CartexId




GO
/****** Object:  StoredProcedure [dbo].[ProductDelivery_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProductDelivery_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [CartexId], [DeliveryReceiversId], [DeliveryCount], [Fee1], [DeliveryDate], [Description], [InputInvoiceDate], [InputInvoiceRow], [InputInvoiceNum], [InputInvoiceCost], [OutputInvoiceDate], [OutputInvoiceRow], [OutputInvoiceNum], [OutputInvoiceCost] FROM [dbo].[ProductDelivery] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)




GO
/****** Object:  StoredProcedure [dbo].[ProductDelivery_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProductDelivery_SelectByPrimaryKey] @Id INT
AS
    SELECT  [Id] ,
            [CartexId] ,
            [DeliveryReceiversId] ,
            [DeliveryCount] ,
            [Fee1] ,
            [DeliveryDate] ,
            [Description] ,
            [InputInvoiceDate] ,
            [InputInvoiceRow] ,
            [InputInvoiceNum] ,
            [InputInvoiceCost] ,
            [OutputInvoiceDate] ,
            [OutputInvoiceRow] ,
            [OutputInvoiceNum] ,
            [OutputInvoiceCost] 
            
    FROM    [dbo].[ProductDelivery]
    WHERE   [Id] = @Id




GO
/****** Object:  StoredProcedure [dbo].[ProductDelivery_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProductDelivery_Update]
    @Id INT ,
    @CartexId INT ,
    @DeliveryReceiversId INT = NULL ,
    @DeliveryCount INT ,
    @Fee1 MONEY ,
    @DeliveryDate DATETIME ,
    @Description NVARCHAR(MAX) = NULL ,
    @InputInvoiceDate DATETIME = NULL ,
    @InputInvoiceRow NVARCHAR(50) = NULL ,
    @InputInvoiceNum NVARCHAR(50) = NULL ,
    @InputInvoiceCost MONEY = NULL ,
    @OutputInvoiceDate DATETIME = NULL ,
    @OutputInvoiceRow NVARCHAR(50) = NULL ,
    @OutputInvoiceNum NVARCHAR(50) = NULL ,
    @OutputInvoiceCost MONEY = NULL 
   
AS
    UPDATE  [dbo].[ProductDelivery]
    SET     [CartexId] = @CartexId ,
            [DeliveryReceiversId] = @DeliveryReceiversId ,
            [DeliveryCount] = @DeliveryCount ,
            [Fee1] = @Fee1 ,
            [DeliveryDate] = @DeliveryDate ,
            [Description] = @Description ,
            [InputInvoiceDate] = @InputInvoiceDate ,
            [InputInvoiceRow] = @InputInvoiceRow ,
            [InputInvoiceNum] = @InputInvoiceNum ,
            [InputInvoiceCost] = @InputInvoiceCost ,
            [OutputInvoiceDate] = @OutputInvoiceDate ,
            [OutputInvoiceRow] = @OutputInvoiceRow ,
            [OutputInvoiceNum] = @OutputInvoiceNum ,
            [OutputInvoiceCost] = @OutputInvoiceCost 
    WHERE   [Id] = @Id




GO
/****** Object:  StoredProcedure [dbo].[ProductionOrder_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProductionOrder_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[ProductionOrder] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)




GO
/****** Object:  StoredProcedure [dbo].[ProductionOrder_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProductionOrder_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[ProductionOrder]
 WHERE 
	[Id] = @Id




GO
/****** Object:  StoredProcedure [dbo].[ProductionOrder_HasPermissionToDelete]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[ProductionOrder_HasPermissionToDelete] @CartexId INT
AS
    DECLARE @ProductionOrderCount INT 
    DECLARE @ProductDeliveryCount INT 

    SELECT  @ProductionOrderCount = COUNT(*)
    FROM    dbo.ProductionOrder
    WHERE   CartexId = @CartexId

    SELECT  @ProductDeliveryCount = COUNT(*)
    FROM    dbo.ProductDelivery
    WHERE   CartexId = @CartexId


	 IF ( @ProductionOrderCount > @ProductDeliveryCount )
        BEGIN
            SELECT  CAST(1 AS BIT) 
        END
    ELSE
        BEGIN
            SELECT  CAST(0 AS BIT) 
        END

GO
/****** Object:  StoredProcedure [dbo].[ProductionOrder_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProductionOrder_Insert]
    @Id INT OUTPUT ,
    @CartexId INT ,
    @OrderDate DATETIME ,
    @OrderCount INT ,
    @Description NVARCHAR(MAX) = NULL
AS
    INSERT  [dbo].[ProductionOrder]
            ( [CartexId] ,
              [OrderDate] ,
              [OrderCount] ,
              [Description]

            )
    VALUES  ( @CartexId ,
              @OrderDate ,
              @OrderCount ,
              @Description

            )
    SELECT  @Id = SCOPE_IDENTITY();





GO
/****** Object:  StoredProcedure [dbo].[ProductionOrder_ReportById]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProductionOrder_ReportById] @Id INT
AS
    SELECT  c.JobCode ,
            c.JobName ,
            cu.Name AS CustomerName ,
            o.Name AS OrderReceiverName ,
            j.Name AS JobTypeName ,
            [dbo].[CalculatePersianDate]([OrderDate]) AS OrderDatePersian ,
            [OrderCount] ,
            po.[Description]
    FROM    [dbo].[ProductionOrder] po
            INNER JOIN dbo.Cartexes c ON c.Id = po.CartexId
            INNER JOIN dbo.Customers cu ON c.CustomerId = cu.Id
            LEFT JOIN dbo.View_PrimaryStock vps ON vps.CartexId = po.CartexId
            INNER JOIN dbo.OrderReceivers o ON o.Id = vps.ToOrderReceiversId
            INNER JOIN dbo.JobTypes j ON j.Id = vps.JobTypesId
    WHERE   po.Id = @Id


GO
/****** Object:  StoredProcedure [dbo].[ProductionOrder_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProductionOrder_SelectAll]
AS
    SELECT  [Id] ,
            [CartexId] ,
         
            [OrderDate] ,
            [OrderCount] ,
            [Description]
			
    FROM    [dbo].[ProductionOrder]




GO
/****** Object:  StoredProcedure [dbo].[ProductionOrder_SelectAll_ForGrid]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProductionOrder_SelectAll_ForGrid] @CartexId INT
AS
    SELECT  p.[Id] ,
            N'سفارش '
            + CAST(ROW_NUMBER() OVER ( ORDER BY p.Id ) AS NVARCHAR(50)) AS Series ,
            o.Name AS OrderReceivers ,
            j.Name AS JobTypes ,
            [OrderCount] ,
            dbo.CalculatePersianDate(OrderDate) AS OrderDatePersian
    FROM    [dbo].[ProductionOrder] p
             LEFT JOIN dbo.View_PrimaryStock vps ON vps.CartexId = p.CartexId
            INNER JOIN dbo.OrderReceivers o ON o.Id = vps.ToOrderReceiversId
            INNER JOIN dbo.JobTypes j ON j.Id = vps.JobTypesId
    WHERE   p.CartexId = @CartexId 




GO
/****** Object:  StoredProcedure [dbo].[ProductionOrder_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProductionOrder_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [CartexId], [OrderDate], [OrderCount], [Description] FROM [dbo].[ProductionOrder] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)




GO
/****** Object:  StoredProcedure [dbo].[ProductionOrder_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProductionOrder_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [CartexId], [OrderDate], [OrderCount], [Description]
	FROM [dbo].[ProductionOrder]
	WHERE 
			[Id] = @Id




GO
/****** Object:  StoredProcedure [dbo].[ProductionOrder_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProductionOrder_Update]
	@Id int,
	@CartexId int,	
	@OrderDate datetime,
	@OrderCount int,
	@Description nvarchar(MAX) = null

AS

UPDATE [dbo].[ProductionOrder]
SET
	[CartexId] = @CartexId,
	[OrderDate] = @OrderDate,
	[OrderCount] = @OrderCount,
	[Description] = @Description
 WHERE 
	[Id] = @Id




GO
/****** Object:  StoredProcedure [dbo].[RePrint_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RePrint_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[RePrint] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[RePrint_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RePrint_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[RePrint]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[RePrint_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RePrint_Insert]
	@Id int output,
	@JobId int ,
	@CreateDate datetime ,
	@Description nvarchar(MAX) = null 

AS

INSERT [dbo].[RePrint]
(
	
	[JobId],
	[CreateDate],
	[Description]

)
VALUES
(
	
	@JobId,
	@CreateDate,
	@Description

)
SELECT @Id=SCOPE_IDENTITY();






GO
/****** Object:  StoredProcedure [dbo].[RePrint_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RePrint_SelectAll]
AS

	SELECT 
		[Id], [JobId], [CreateDate], [Description]
	FROM [dbo].[RePrint]






GO
/****** Object:  StoredProcedure [dbo].[RePrint_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RePrint_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [JobId], [CreateDate], [Description] FROM [dbo].[RePrint] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[RePrint_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RePrint_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [JobId], [CreateDate], [Description]
	FROM [dbo].[RePrint]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[RePrint_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RePrint_Update]
	@Id int,
	@JobId int,
	@CreateDate datetime,
	@Description nvarchar(MAX) = null

AS

UPDATE [dbo].[RePrint]
SET
	
	[JobId] = @JobId,
	[CreateDate] = @CreateDate,
	[Description] = @Description
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Sahafies_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sahafies_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[Sahafies] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[Sahafies_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sahafies_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[Sahafies]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Sahafies_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sahafies_Insert]
	@Id int output,
	@JobId int ,
	@OrderReceiverId int ,
	@SahafiTypeId int ,
	@Tirazh int = null ,
	@Dimension nvarchar(50) = null ,
	@PocketGlue bit = null ,
	@PaperGramazh nvarchar(50) = null ,
	@TextFormCount int = null ,
	@FormSum int = null ,
	@Description nvarchar(MAX) = null ,
	@InvoiceRow nvarchar(50) = null ,
	@InvoiceNum nvarchar(50) = null ,
	@InvoiceCost money = null 

AS

INSERT [dbo].[Sahafies]
(
	[JobId],
	[OrderReceiverId],
	[SahafiTypeId],
	[Tirazh],
	[Dimension],
	[PocketGlue],
	[PaperGramazh],
	[TextFormCount],
	[FormSum],
	[Description],
	[InvoiceRow],
	[InvoiceNum],
	[InvoiceCost]

)
VALUES
(
	@JobId,
	@OrderReceiverId,
	@SahafiTypeId,
	@Tirazh,
	@Dimension,
	@PocketGlue,
	@PaperGramazh,
	@TextFormCount,
	@FormSum,
	@Description,
	@InvoiceRow,
	@InvoiceNum,
	@InvoiceCost

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[Sahafies_ReportById]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sahafies_ReportById]
@Id int
AS

SELECT s.[Id],
	   J.Name AS job,j.Code,J.Id AS JobId,dbo.CalculatePersianDate(j.CreateDate) AS CreateDatePersian,
	   c.NAME AS CustomerName,o.Name AS OrderReceiver,st.Name AS SahafiType,
	   [Tirazh],[Dimension],
	   (CASE WHEN [PocketGlue]=1 THEN N'دارد'
			 WHEN [PocketGlue]=0 THEN N'ندارد'
			 ELSE N'هیچ کدام' END) AS PocketGlue
	   ,[PaperGramazh],[TextFormCount]
      ,[FormSum],s.[Description],[InvoiceRow],[InvoiceNum],[InvoiceCost]
	   
	 	
       
  FROM [dbo].Sahafies s
  INNER JOIN dbo.Jobs J ON J.Id = s.JobId
  INNER JOIN dbo.Customers c ON c.Id = j.CustomerId
  INNER JOIN dbo.OrderReceivers O ON O.Id = s.OrderReceiverId
  INNER JOIN dbo.SahafiTypes st ON st.Id = s.SahafiTypeId  

  
WHERE s.Id = @Id





GO
/****** Object:  StoredProcedure [dbo].[Sahafies_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sahafies_SelectAll]
AS

	SELECT 
		[Id], [JobId], [OrderReceiverId], [SahafiTypeId], [Tirazh], [Dimension], [PocketGlue], [PaperGramazh], [TextFormCount], [FormSum], [Description], [InvoiceRow], [InvoiceNum], [InvoiceCost]
	FROM [dbo].[Sahafies]






GO
/****** Object:  StoredProcedure [dbo].[Sahafies_SelectAll_ForGrid]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sahafies_SelectAll_ForGrid]
@JobId int
AS

	SELECT 
		s.[Id],o.Name as OrderReceiverName,st.Name as SahafiTypeName,[Description]
	FROM [dbo].[Sahafies] s   
	inner join [dbo].[OrderReceivers] o on s.OrderReceiverId = o.Id
	inner join [dbo].[SahafiTypes] st on s.SahafiTypeId = st.Id 
	where s.JobId = @JobId






GO
/****** Object:  StoredProcedure [dbo].[Sahafies_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sahafies_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [JobId], [OrderReceiverId], [SahafiTypeId], [Tirazh], [Dimension], [PocketGlue], [PaperGramazh], [TextFormCount], [FormSum], [Description], [InvoiceRow], [InvoiceNum], [InvoiceCost] FROM [dbo].[Sahafies] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[Sahafies_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sahafies_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [JobId], [OrderReceiverId], [SahafiTypeId], [Tirazh], [Dimension], [PocketGlue], [PaperGramazh], [TextFormCount], [FormSum], [Description], [InvoiceRow], [InvoiceNum], [InvoiceCost]
	FROM [dbo].[Sahafies]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Sahafies_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sahafies_Update]
	@Id int,
	@JobId int,
	@OrderReceiverId int,
	@SahafiTypeId int,
	@Tirazh int = null,
	@Dimension nvarchar(50) = null,
	@PocketGlue bit = null,
	@PaperGramazh nvarchar(50) = null,
	@TextFormCount int = null,
	@FormSum int = null,
	@Description nvarchar(MAX) = null,
	@InvoiceRow nvarchar(50) = null,
	@InvoiceNum nvarchar(50) = null,
	@InvoiceCost money = null

AS

UPDATE [dbo].[Sahafies]
SET
	[JobId] = @JobId,
	[OrderReceiverId] = @OrderReceiverId,
	[SahafiTypeId] = @SahafiTypeId,
	[Tirazh] = @Tirazh,
	[Dimension] = @Dimension,
	[PocketGlue] = @PocketGlue,
	[PaperGramazh] = @PaperGramazh,
	[TextFormCount] = @TextFormCount,
	[FormSum] = @FormSum,
	[Description] = @Description,
	[InvoiceRow] = @InvoiceRow,
	[InvoiceNum] = @InvoiceNum,
	[InvoiceCost] = @InvoiceCost
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[SahafiTypes_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SahafiTypes_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[SahafiTypes] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[SahafiTypes_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SahafiTypes_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[SahafiTypes]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[SahafiTypes_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SahafiTypes_Insert]
	@Id int output,
	@Name nvarchar(MAX) 

AS

INSERT [dbo].[SahafiTypes]
(
	[Name]

)
VALUES
(
	@Name

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[SahafiTypes_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SahafiTypes_SelectAll]
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[SahafiTypes]






GO
/****** Object:  StoredProcedure [dbo].[SahafiTypes_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SahafiTypes_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [Name] FROM [dbo].[SahafiTypes] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[SahafiTypes_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SahafiTypes_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[SahafiTypes]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[SahafiTypes_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SahafiTypes_Update]
	@Id int,
	@Name nvarchar(MAX)

AS

UPDATE [dbo].[SahafiTypes]
SET
	[Name] = @Name
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Source_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROCEDURE [dbo].[Source_SelectAll]
AS
    SELECT  *
    INTO    #tmp
    FROM    ( SELECT    o.[Id] ,
                        o.[Name]
              FROM      [dbo].[OrderReceivers] o
                        INNER JOIN [dbo].[LevelOrderReceiver] l ON l.OrderReceiver_Id = o.Id
              WHERE     l.Level_Id = 3
              UNION
              SELECT    Id ,
                        Name
              FROM      dbo.Institute
            ) AS t
			ORDER BY  Name

    SELECT  0 AS Id ,
            N'همه موارد' AS NAME
    UNION
    SELECT  *
    FROM    #tmp
    

	






GO
/****** Object:  StoredProcedure [dbo].[Statuses_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Statuses_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[Statuses] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[Statuses_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Statuses_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[Statuses]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Statuses_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Statuses_Insert]
	@Id int output,
	@Name nvarchar(MAX) 

AS

INSERT [dbo].[Statuses]
(
	[Name]

)
VALUES
(
	@Name

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[Statuses_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Statuses_SelectAll]
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[Statuses]






GO
/****** Object:  StoredProcedure [dbo].[Statuses_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Statuses_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [Name] FROM [dbo].[Statuses] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[Statuses_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Statuses_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[Statuses]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Statuses_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Statuses_Update]
	@Id int,
	@Name nvarchar(MAX)

AS

UPDATE [dbo].[Statuses]
SET
	[Name] = @Name
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Stereotypes_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Stereotypes_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[Stereotypes] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[Stereotypes_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Stereotypes_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[Stereotypes]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Stereotypes_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Stereotypes_Insert]
	@Id int output,
	@JobId int ,
	@OrderReceiverId int ,
	@Dimension nvarchar(50) = null ,
	@Thickness int ,
	@Type int ,
	@stereotype bit ,
	@StereotypeUsagesId int ,
	@Count int = null ,
	@Description nvarchar(MAX) = null ,
	@InvoiceRow nvarchar(50) = null ,
	@InvoiceNum nvarchar(50) = null ,
	@InvoiceCost money = null 

AS

INSERT [dbo].[Stereotypes]
(
	[JobId],
	[OrderReceiverId],
	[Dimension],
	[Thickness],
	[Type],
	[stereotype],
	[StereotypeUsagesId],
	[Count],
	[Description],
	[InvoiceRow],
	[InvoiceNum],
	[InvoiceCost]

)
VALUES
(
	@JobId,
	@OrderReceiverId,
	@Dimension,
	@Thickness,
	@Type,
	@stereotype,
	@StereotypeUsagesId,
	@Count,
	@Description,
	@InvoiceRow,
	@InvoiceNum,
	@InvoiceCost

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[Stereotypes_ReportById]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Stereotypes_ReportById]
@Id int
AS

SELECT ST.[Id],J.Name AS JOB,j.Code,J.Id AS JobId,dbo.CalculatePersianDate(j.CreateDate) AS CreateDatePersian,
c.NAME AS CustomerName,o.Name AS OrderReceiver,ST.Dimension
      ,(CASE WHEN ST.Thickness = 1 THEN N'1/5 mm' ELSE N'3 mm' END) AS Thickness
      ,(CASE WHEN ST.[Type] = 1 THEN N'نر' 
		     WHEN ST.[Type] = 2 THEN N'ماده' 
		     WHEN ST.[Type] = 3 THEN N'نر و ماده' END) AS [Type]
      ,(CASE WHEN ST.stereotype = 1 THEN N'خوانا' ELSE N'ناخوانا-آئینه' END) AS stereotype
      ,SU.Name AS StereotypeUsage
      ,ST.[Count],ST.[Description]
      ,ST.[InvoiceRow],ST.[InvoiceNum],ST.[InvoiceCost]
  
  FROM [dbo].[Stereotypes] ST
  INNER JOIN dbo.Jobs J ON J.Id = ST.JobId
  INNER JOIN dbo.Customers c ON c.Id = j.CustomerId
  INNER JOIN dbo.OrderReceivers O ON O.Id = ST.OrderReceiverId
  INNER JOIN dbo.StereotypeUsages SU ON SU.Id = ST.StereotypeUsagesId

  
WHERE ST.Id = @Id





GO
/****** Object:  StoredProcedure [dbo].[Stereotypes_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Stereotypes_SelectAll]
AS

	SELECT 
		[Id], [JobId], [OrderReceiverId], [Dimension], [Thickness], [Type], [stereotype], [StereotypeUsagesId], [Count], [Description], [InvoiceRow], [InvoiceNum], [InvoiceCost]
	FROM [dbo].[Stereotypes]






GO
/****** Object:  StoredProcedure [dbo].[Stereotypes_SelectAll_ForGrid]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Stereotypes_SelectAll_ForGrid]
@JobId int
AS

	SELECT 
		p.[Id], o.Name as OrderReceiverName,
		(CASE WHEN [Type] = 1 THEN N'نر'
			  WHEN [Type] = 2 THEN N'ماده'
			  WHEN [Type]=3 THEN N'نر و ماده' END) AS [Type]
		, Dimension, [Description]
	FROM [dbo].[Stereotypes] p 
	inner join [dbo].[OrderReceivers] o on p.OrderReceiverId = o.Id
			
	where p.JobId = @JobId





GO
/****** Object:  StoredProcedure [dbo].[Stereotypes_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Stereotypes_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [JobId], [OrderReceiverId], [Dimension], [Thickness], [Type], [stereotype], [StereotypeUsagesId], [Count], [Description], [InvoiceRow], [InvoiceNum], [InvoiceCost] FROM [dbo].[Stereotypes] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[Stereotypes_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Stereotypes_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [JobId], [OrderReceiverId], [Dimension], [Thickness], [Type], [stereotype], [StereotypeUsagesId], [Count], [Description], [InvoiceRow], [InvoiceNum], [InvoiceCost]
	FROM [dbo].[Stereotypes]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Stereotypes_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Stereotypes_Update]
	@Id int,
	@JobId int,
	@OrderReceiverId int,
	@Dimension nvarchar(50) = null,
	@Thickness int,
	@Type int,
	@stereotype bit,
	@StereotypeUsagesId int,
	@Count int = null,
	@Description nvarchar(MAX) = null,
	@InvoiceRow nvarchar(50) = null,
	@InvoiceNum nvarchar(50) = null,
	@InvoiceCost money = null

AS

UPDATE [dbo].[Stereotypes]
SET
	[JobId] = @JobId,
	[OrderReceiverId] = @OrderReceiverId,
	[Dimension] = @Dimension,
	[Thickness] = @Thickness,
	[Type] = @Type,
	[stereotype] = @stereotype,
	[StereotypeUsagesId] = @StereotypeUsagesId,
	[Count] = @Count,
	[Description] = @Description,
	[InvoiceRow] = @InvoiceRow,
	[InvoiceNum] = @InvoiceNum,
	[InvoiceCost] = @InvoiceCost
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[StereotypeUsages_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[StereotypeUsages_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[StereotypeUsages] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[StereotypeUsages_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[StereotypeUsages_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[StereotypeUsages]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[StereotypeUsages_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[StereotypeUsages_Insert]
	@Id int output,
	@Name nvarchar(MAX) 

AS

INSERT [dbo].[StereotypeUsages]
(
	[Name]

)
VALUES
(
	@Name

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[StereotypeUsages_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[StereotypeUsages_SelectAll]
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[StereotypeUsages]






GO
/****** Object:  StoredProcedure [dbo].[StereotypeUsages_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[StereotypeUsages_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [Name] FROM [dbo].[StereotypeUsages] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[StereotypeUsages_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[StereotypeUsages_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[StereotypeUsages]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[StereotypeUsages_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[StereotypeUsages_Update]
	@Id int,
	@Name nvarchar(MAX)

AS

UPDATE [dbo].[StereotypeUsages]
SET
	[Name] = @Name
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Stock_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Stock_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[Stock] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[Stock_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Stock_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[Stock]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Stock_GetStockOfInstitute]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Stock_GetStockOfInstitute]
@InstituteId int,
@MaterialTypeId int,
@MaterialTypeGramazhId int,
@PaperWidthId int,
@PaperHeightId int
AS

	SELECT 
		i.Name AS InstituteName,[LeafCount]
	FROM [dbo].[Stock] s INNER JOIN dbo.Institute i ON s.InstituteId = i.Id

	Where ([InstituteId] = @InstituteId OR @InstituteId = 0) AND
		  [MaterialTypeId] = @MaterialTypeId AND
		  [MaterialTypeGramazhId] = @MaterialTypeGramazhId AND 
		  [PaperWidthId] = @PaperWidthId AND
		  [PaperHeightId] = @PaperHeightId
	






GO
/****** Object:  StoredProcedure [dbo].[Stock_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Stock_Insert]
	@Id int output,
	@InstituteId int ,
	@MaterialTypeId int ,
	@MaterialTypeGramazhId int ,
	@PaperWidthId int ,
	@PaperHeightId int ,
	@LeafCount int 

AS

INSERT [dbo].[Stock]
(
	[InstituteId],
	[MaterialTypeId],
	[MaterialTypeGramazhId],
	[PaperWidthId],
	[PaperHeightId],
	[LeafCount]

)
VALUES
(
	@InstituteId,
	@MaterialTypeId,
	@MaterialTypeGramazhId,
	@PaperWidthId,
	@PaperHeightId,
	@LeafCount

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[Stock_ReportByInstitute]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Stock_ReportByInstitute]
@InstituteId INT = NULL
AS

	SELECT cast(Row_number() OVER(ORDER BY dbo.Stock.Id) as nvarchar(50)) AS RowNum,
		dbo.Institute.Name AS InstituteName, dbo.MaterialTypes.Name AS MaterialTypeName,
	    dbo.MaterialTypeGramazh.Name AS MaterialTypeGramazhName, dbo.PaperWidth.Name AS PaperWidthName,
	    dbo.PaperHeight.Name AS PaperHeightName, [LeafCount]
	FROM [dbo].[Stock] 
	INNER JOIN dbo.Institute ON dbo.Stock.InstituteId = dbo.Institute.Id
	INNER JOIN dbo.MaterialTypes ON dbo.Stock.MaterialTypeId = dbo.MaterialTypes.Id
	INNER JOIN dbo.MaterialTypeGramazh ON dbo.Stock.MaterialTypeGramazhId = dbo.MaterialTypeGramazh.Id
	INNER JOIN dbo.PaperWidth ON dbo.Stock.PaperWidthId = dbo.PaperWidth.Id
	INNER JOIN dbo.PaperHeight ON dbo.Stock.PaperHeightId = dbo.PaperHeight.Id
	
	where (InstituteId = @InstituteId OR @InstituteId IS NULL) AND
		  ([LeafCount]>0)






GO
/****** Object:  StoredProcedure [dbo].[Stock_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Stock_SelectAll]
AS

	SELECT 
		[Id], [InstituteId], [MaterialTypeId], [MaterialTypeGramazhId], [PaperWidthId], [PaperHeightId], [LeafCount]
	FROM [dbo].[Stock]






GO
/****** Object:  StoredProcedure [dbo].[Stock_SelectAllByInstitute]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Stock_SelectAllByInstitute]
@InstituteId int,
@MaterialTypeId int,
@MaterialTypeGramazhId int,
@PaperWidthId int,
@PaperHeightId int
AS

	SELECT 
		[Id], [InstituteId], [MaterialTypeId], [MaterialTypeGramazhId], [PaperWidthId], [PaperHeightId], [LeafCount]
	FROM [dbo].[Stock]
	where InstituteId = @InstituteId AND MaterialTypeId  = @MaterialTypeId AND
	MaterialTypeGramazhId = @MaterialTypeGramazhId AND PaperWidthId = @PaperWidthId
	AND PaperHeightId = @PaperHeightId






GO
/****** Object:  StoredProcedure [dbo].[Stock_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Stock_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [InstituteId], [MaterialTypeId], [MaterialTypeGramazhId], [PaperWidthId], [PaperHeightId], [LeafCount] FROM [dbo].[Stock] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[Stock_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Stock_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [InstituteId], [MaterialTypeId], [MaterialTypeGramazhId], [PaperWidthId], [PaperHeightId], [LeafCount]
	FROM [dbo].[Stock]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Stock_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Stock_Update]
	@Id int,
	@InstituteId int,
	@MaterialTypeId int,
	@MaterialTypeGramazhId int,
	@PaperWidthId int,
	@PaperHeightId int,
	@LeafCount int

AS

UPDATE [dbo].[Stock]
SET
	[InstituteId] = @InstituteId,
	[MaterialTypeId] = @MaterialTypeId,
	[MaterialTypeGramazhId] = @MaterialTypeGramazhId,
	[PaperWidthId] = @PaperWidthId,
	[PaperHeightId] = @PaperHeightId,
	[LeafCount] = @LeafCount
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[TemplateMaterialTypes_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TemplateMaterialTypes_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[TemplateMaterialTypes] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[TemplateMaterialTypes_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TemplateMaterialTypes_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[TemplateMaterialTypes]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[TemplateMaterialTypes_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TemplateMaterialTypes_Insert]
	@Id int output,
	@Name nvarchar(MAX) 

AS

INSERT [dbo].[TemplateMaterialTypes]
(
	[Name]

)
VALUES
(
	@Name

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[TemplateMaterialTypes_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TemplateMaterialTypes_SelectAll]
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[TemplateMaterialTypes]






GO
/****** Object:  StoredProcedure [dbo].[TemplateMaterialTypes_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TemplateMaterialTypes_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [Name] FROM [dbo].[TemplateMaterialTypes] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[TemplateMaterialTypes_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TemplateMaterialTypes_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[TemplateMaterialTypes]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[TemplateMaterialTypes_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TemplateMaterialTypes_Update]
	@Id int,
	@Name nvarchar(MAX)

AS

UPDATE [dbo].[TemplateMaterialTypes]
SET
	[Name] = @Name
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[UsePaper_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UsePaper_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[UsePaper] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[UsePaper_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UsePaper_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[UsePaper]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[UsePaper_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UsePaper_Insert]
	@Id int output,
	@JobId int ,
	@FromInstituteId int ,
	@MaterialTypeId int ,
	@MaterialTypeGramazhId int ,
	@PaperWidthId int ,
	@PaperHeightId int ,
	@LeafCount int ,
	@Description nvarchar(max)

AS

INSERT [dbo].[UsePaper]
(
	[JobId],
	[FromInstituteId],
	[MaterialTypeId],
	[MaterialTypeGramazhId],
	[PaperWidthId],
	[PaperHeightId],
	[LeafCount],
	[Description]

)
VALUES
(
	@JobId,
	@FromInstituteId,
	@MaterialTypeId,
	@MaterialTypeGramazhId,
	@PaperWidthId,
	@PaperHeightId,
	@LeafCount,
	@Description

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[UsePaper_ReportById]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UsePaper_ReportById]
@Id int
AS


SELECT p.[Id],J.Id AS JobId,c.NAME AS CustomerName,dbo.CalculatePersianDate(j.CreateDate) AS CreateDatePersian,
	   J.Name AS JOB,j.Code,fi.Name AS FromInstitute,mt.Name AS MaterialType,
	   mtg.Name AS MaterialTypeGramazh,
	   pw.Name AS  PaperWidth,ph.Name AS PaperHeight,LeafCount,p.Description
       
  FROM [dbo].UsePaper p
  INNER JOIN dbo.Jobs J ON J.Id = p.JobId
  INNER JOIN dbo.Customers c ON c.Id = j.CustomerId
  INNER JOIN dbo.Institute fi ON fi.Id = p.FromInstituteId
  INNER JOIN dbo.MaterialTypes mt ON mt.Id = p.MaterialTypeId
  INNER JOIN dbo.MaterialTypeGramazh mtg ON mtg.Id = p.MaterialTypeGramazhId
  INNER JOIN dbo.PaperWidth pw ON pw.Id = p.PaperWidthId
  INNER JOIN dbo.PaperHeight ph ON ph.Id = p.PaperHeightId
  

  
WHERE p.Id = @Id





GO
/****** Object:  StoredProcedure [dbo].[UsePaper_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UsePaper_SelectAll]
AS

	SELECT 
		[Id], [JobId], [FromInstituteId], [MaterialTypeId], [MaterialTypeGramazhId], [PaperWidthId], [PaperHeightId], [LeafCount],[Description]
	FROM [dbo].[UsePaper]






GO
/****** Object:  StoredProcedure [dbo].[UsePaper_SelectAll_ForGrid]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UsePaper_SelectAll_ForGrid]
@JobId int
AS

	SELECT 
		[UsePaper].[Id],(select Name From dbo.Institute where Id =[FromInstituteId] ) as FromInstituteName,
		 [LeafCount],mt.Name AS MaterialTypeName
	FROM [dbo].[UsePaper] 
	inner join [dbo].[MaterialTypes] mt on [UsePaper].MaterialTypeId = mt.Id
	where JobId = @JobId
	






GO
/****** Object:  StoredProcedure [dbo].[UsePaper_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UsePaper_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [JobId], [FromInstituteId], [MaterialTypeId], [MaterialTypeGramazhId], [PaperWidthId], [PaperHeightId], [LeafCount],[Description] FROM [dbo].[UsePaper] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[UsePaper_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UsePaper_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [JobId], [FromInstituteId], [MaterialTypeId], [MaterialTypeGramazhId], [PaperWidthId], [PaperHeightId], [LeafCount],[Description]
	FROM [dbo].[UsePaper]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[UsePaper_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UsePaper_Update]
	@Id int,
	@JobId int,
	@FromInstituteId int,
	@MaterialTypeId int,
	@MaterialTypeGramazhId int,
	@PaperWidthId int,
	@PaperHeightId int,
	@LeafCount int,
	@Description nvarchar(max)

AS

UPDATE [dbo].[UsePaper]
SET
	[JobId] = @JobId,
	[FromInstituteId] = @FromInstituteId,
	[MaterialTypeId] = @MaterialTypeId,
	[MaterialTypeGramazhId] = @MaterialTypeGramazhId,
	[PaperWidthId] = @PaperWidthId,
	[PaperHeightId] = @PaperHeightId,
	[LeafCount] = @LeafCount,
	[Description]=@Description
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[UserPage_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UserPage_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[UserPage] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[UserPage_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UserPage_DeleteByPrimaryKey]
	@User_Id int,
	@Page_Id int
AS

DELETE FROM [dbo].[UserPage]
 WHERE 
	[User_Id] = @User_Id AND 
	[Page_Id] = @Page_Id






GO
/****** Object:  StoredProcedure [dbo].[UserPage_HasPermission]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UserPage_HasPermission]

@UserId int,
@Path nvarchar(max)

AS
If Exists(
	SELECT 
		up.[User_Id], up.[Page_Id]
	FROM [dbo].[UserPage] up inner join [dbo].[Pages] p 
	on up.Page_Id = p.Id
	where up.[User_Id]=@UserId AND p.[Path] like '%' + @Path + '%'
	)
	
	Select CAST(1 as bit)
Else
	Select CAST(0 as bit)





GO
/****** Object:  StoredProcedure [dbo].[UserPage_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UserPage_Insert]
	@User_Id int ,
	@Page_Id int 

AS

INSERT [dbo].[UserPage]
(
	[User_Id],
	[Page_Id]

)
VALUES
(
	@User_Id,
	@Page_Id

)







GO
/****** Object:  StoredProcedure [dbo].[UserPage_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UserPage_SelectAll]
AS

	SELECT 
		[User_Id], [Page_Id]
	FROM [dbo].[UserPage]






GO
/****** Object:  StoredProcedure [dbo].[UserPage_SelectBy_UserId_PageId]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UserPage_SelectBy_UserId_PageId]
@UserId int,
@PageId int
AS

	SELECT 
		[User_Id], [Page_Id]
	FROM [dbo].[UserPage]
	where [User_Id] = @UserId AND [Page_Id]=@PageId






GO
/****** Object:  StoredProcedure [dbo].[UserPage_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UserPage_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [User_Id], [Page_Id] FROM [dbo].[UserPage] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[UserPage_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UserPage_SelectByPrimaryKey]
	@User_Id int,
	@Page_Id int
AS

	SELECT 
		[User_Id], [Page_Id]
	FROM [dbo].[UserPage]
	WHERE 
			[User_Id] = @User_Id AND 
	[Page_Id] = @Page_Id






GO
/****** Object:  StoredProcedure [dbo].[UserPage_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UserPage_Update]
	@User_Id int,
	@Page_Id int

AS

UPDATE [dbo].[UserPage]
SET
	[User_Id] = @User_Id,
	[Page_Id] = @Page_Id
 WHERE 
	[User_Id] = @User_Id AND 
	[Page_Id] = @Page_Id






GO
/****** Object:  StoredProcedure [dbo].[Users_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Users_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[Users] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[Users_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Users_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[Users]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Users_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Users_Insert]
	@Id int output,
	@Name nvarchar(MAX) ,
	@UserName nvarchar(MAX) ,
	@Password nvarchar(MAX) ,
	@CreateDate datetime ,
	@Enable bit ,
	@Email nvarchar(MAX) ,
	@Mobile nvarchar(MAX) 

AS

INSERT [dbo].[Users]
(
	[Name],
	[UserName],
	[Password],
	[CreateDate],
	[Enable],
	[Email],
	[Mobile]

)
VALUES
(
	@Name,
	@UserName,
	@Password,
	@CreateDate,
	@Enable,
	@Email,
	@Mobile

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[Users_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Users_SelectAll]
AS

	SELECT 
		[Id], [Name], [UserName], [Password], [CreateDate], [Enable], [Email], [Mobile]
	FROM [dbo].[Users]






GO
/****** Object:  StoredProcedure [dbo].[Users_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Users_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [Name], [UserName], [Password], [CreateDate], [Enable], [Email], [Mobile] FROM [dbo].[Users] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[Users_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Users_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [Name], [UserName], [Password], [CreateDate], [Enable], [Email], [Mobile]
	FROM [dbo].[Users]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Users_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Users_Update]
	@Id int,
	@Name nvarchar(MAX),
	@UserName nvarchar(MAX),
	@Password nvarchar(MAX),
	@CreateDate datetime,
	@Enable bit,
	@Email nvarchar(MAX),
	@Mobile nvarchar(MAX)

AS

UPDATE [dbo].[Users]
SET
	[Name] = @Name,
	[UserName] = @UserName,
	[Password] = @Password,
	[CreateDate] = @CreateDate,
	[Enable] = @Enable,
	[Email] = @Email,
	[Mobile] = @Mobile
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Veneers_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Veneers_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[Veneers] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[Veneers_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Veneers_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[Veneers]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Veneers_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Veneers_Insert]
	@Id int output,
	@JobId int ,
	@OrderVeneer int ,
	@OrderReceiverId int ,
	@VeneerTypeId int ,
	@Model int ,
	@Tirazh int = null ,
	@Dimension nvarchar(50) = null ,
	@PaperGramazh nvarchar(50) = null ,
	@Description nvarchar(MAX) = null ,
	@InvoiceRow nvarchar(50) = null ,
	@InvoiceNum nvarchar(50) = null ,
	@InvoiceCost money = null 

AS

INSERT [dbo].[Veneers]
(
	[JobId],
	[OrderVeneer],
	[OrderReceiverId],
	[VeneerTypeId],
	[Model],
	[Tirazh],
	[Dimension],
	[PaperGramazh],
	[Description],
	[InvoiceRow],
	[InvoiceNum],
	[InvoiceCost]

)
VALUES
(
	@JobId,
	@OrderVeneer,
	@OrderReceiverId,
	@VeneerTypeId,
	@Model,
	@Tirazh,
	@Dimension,
	@PaperGramazh,
	@Description,
	@InvoiceRow,
	@InvoiceNum,
	@InvoiceCost

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[Veneers_ReportById]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Veneers_ReportById]
@Id int
AS
DECLARE @jobId int
SET @jobId = (SELECT JobId FROM dbo.Veneers WHERE Id =@Id); 

WITH cte AS (
SELECT N'سفارش روکش ' + cast(Row_number() OVER(ORDER BY v.Id) as nvarchar(50)) AS Row ,v.Id
	   FROM dbo.Veneers v
	   WHERE v.JobId = @jobId)

SELECT v.[Id],
	  (SELECT Row FROM cte WHERE Id = @Id) AS Row,dbo.CalculatePersianDate(j.CreateDate) AS CreateDatePersian,
	  J.Name AS JOB,j.Code,J.Id AS JobId,c.NAME AS CustomerName,o.Name AS OrderReceiver,vt.Name AS VeneerType, 
	  (CASE WHEN Model=1 THEN N'یک رو'
			WHEN Model=2 THEN N'دو رو' END) AS Model,
	  [Tirazh],[Dimension],[PaperGramazh],v.[Description],[InvoiceRow]
      ,[InvoiceNum],[InvoiceCost]
				
		
       
  FROM [dbo].Veneers v
  INNER JOIN dbo.Jobs J ON J.Id = v.JobId
  INNER JOIN dbo.Customers c ON c.Id = j.CustomerId
  INNER JOIN dbo.OrderReceivers O ON O.Id = v.OrderReceiverId
  INNER JOIN dbo.VeneerTypes vt ON vt.Id = v.VeneerTypeId
  

  
WHERE v.Id = @Id





GO
/****** Object:  StoredProcedure [dbo].[Veneers_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Veneers_SelectAll]
AS

	SELECT 
		[Id], [JobId], [OrderVeneer], [OrderReceiverId], [VeneerTypeId], [Model], [Tirazh], [Dimension], [PaperGramazh], [Description], [InvoiceRow], [InvoiceNum], [InvoiceCost]
	FROM [dbo].[Veneers]






GO
/****** Object:  StoredProcedure [dbo].[Veneers_SelectAll_ForGrid]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Veneers_SelectAll_ForGrid]
@JobId int
AS

	SELECT 
		p.[Id], N'سفارش روکش ' + cast(Row_number() OVER(ORDER BY p.Id) as nvarchar(50))  as OrderSeries,
		o.Name as OrderReceiverName,[Description],v.Name AS VeneerTypeName
	FROM [dbo].[Veneers] p
	inner join [dbo].[OrderReceivers] o on p.OrderReceiverId = o.Id
	inner join [dbo].[VeneerTypes] v on p.VeneerTypeId = v.Id
	
	where p.JobId = @JobId






GO
/****** Object:  StoredProcedure [dbo].[Veneers_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Veneers_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [JobId], [OrderVeneer], [OrderReceiverId], [VeneerTypeId], [Model], [Tirazh], [Dimension], [PaperGramazh], [Description], [InvoiceRow], [InvoiceNum], [InvoiceCost] FROM [dbo].[Veneers] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[Veneers_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Veneers_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [JobId], [OrderVeneer], [OrderReceiverId], [VeneerTypeId], [Model], [Tirazh], [Dimension], [PaperGramazh], [Description], [InvoiceRow], [InvoiceNum], [InvoiceCost]
	FROM [dbo].[Veneers]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Veneers_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Veneers_Update]
	@Id int,
	@JobId int,
	@OrderVeneer int,
	@OrderReceiverId int,
	@VeneerTypeId int,
	@Model int,
	@Tirazh int = null,
	@Dimension nvarchar(50) = null,
	@PaperGramazh nvarchar(50) = null,
	@Description nvarchar(MAX) = null,
	@InvoiceRow nvarchar(50) = null,
	@InvoiceNum nvarchar(50) = null,
	@InvoiceCost money = null

AS

UPDATE [dbo].[Veneers]
SET
	[JobId] = @JobId,
	[OrderVeneer] = @OrderVeneer,
	[OrderReceiverId] = @OrderReceiverId,
	[VeneerTypeId] = @VeneerTypeId,
	[Model] = @Model,
	[Tirazh] = @Tirazh,
	[Dimension] = @Dimension,
	[PaperGramazh] = @PaperGramazh,
	[Description] = @Description,
	[InvoiceRow] = @InvoiceRow,
	[InvoiceNum] = @InvoiceNum,
	[InvoiceCost] = @InvoiceCost
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[VeneerTypes_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VeneerTypes_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[VeneerTypes] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[VeneerTypes_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VeneerTypes_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[VeneerTypes]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[VeneerTypes_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VeneerTypes_Insert]
	@Id int output,
	@Name nvarchar(MAX) 

AS

INSERT [dbo].[VeneerTypes]
(
	[Name]

)
VALUES
(
	@Name

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[VeneerTypes_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VeneerTypes_SelectAll]
AS
    SELECT  [Id] ,
            [Name]
    FROM    [dbo].[VeneerTypes]
    ORDER BY Name





GO
/****** Object:  StoredProcedure [dbo].[VeneerTypes_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VeneerTypes_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [Name] FROM [dbo].[VeneerTypes] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[VeneerTypes_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VeneerTypes_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[VeneerTypes]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[VeneerTypes_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VeneerTypes_Update]
	@Id int,
	@Name nvarchar(MAX)

AS

UPDATE [dbo].[VeneerTypes]
SET
	[Name] = @Name
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Zinks_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Zinks_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[Zinks] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[Zinks_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Zinks_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[Zinks]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Zinks_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Zinks_Insert]
	@Id int output,
	@JobId int ,
	@OrderReceiverId int = null ,
	@OtherOrderReceiver nvarchar(MAX) = null ,
	@Dimension nvarchar(50) ,
	@MainColorCount nvarchar(50) ,
	@ExportColor nvarchar(50) ,
	@SpotColorCount nvarchar(50) ,
	@SpotColors nvarchar(MAX) = null ,
	@OverPrintBlackColor int ,
	@DeviceCount nvarchar(MAX) = null ,
	@FormEvertCount nvarchar(MAX) = null ,
	@Description nvarchar(MAX) = null 

AS

INSERT [dbo].[Zinks]
(
	[JobId],
	[OrderReceiverId],
	[OtherOrderReceiver],
	[Dimension],
	[MainColorCount],
	[ExportColor],
	[SpotColorCount],
	[SpotColors],
	[OverPrintBlackColor],
	[DeviceCount],
	[FormEvertCount],
	[Description]

)
VALUES
(
	@JobId,
	@OrderReceiverId,
	@OtherOrderReceiver,
	@Dimension,
	@MainColorCount,
	@ExportColor,
	@SpotColorCount,
	@SpotColors,
	@OverPrintBlackColor,
	@DeviceCount,
	@FormEvertCount,
	@Description

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[Zinks_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Zinks_SelectAll]
AS

	SELECT 
		[Id], [JobId], [OrderReceiverId], [OtherOrderReceiver], [Dimension], [MainColorCount], [ExportColor], [SpotColorCount], [SpotColors], [OverPrintBlackColor], [DeviceCount], [FormEvertCount], [Description]
	FROM [dbo].[Zinks]






GO
/****** Object:  StoredProcedure [dbo].[Zinks_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Zinks_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [JobId], [OrderReceiverId], [OtherOrderReceiver], [Dimension], [MainColorCount], [ExportColor], [SpotColorCount], [SpotColors], [OverPrintBlackColor], [DeviceCount], [FormEvertCount], [Description] FROM [dbo].[Zinks] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[Zinks_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Zinks_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [JobId], [OrderReceiverId], [OtherOrderReceiver], [Dimension], [MainColorCount], [ExportColor], [SpotColorCount], [SpotColors], [OverPrintBlackColor], [DeviceCount], [FormEvertCount], [Description]
	FROM [dbo].[Zinks]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[Zinks_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Zinks_Update]
	@Id int,
	@JobId int,
	@OrderReceiverId int = null,
	@OtherOrderReceiver nvarchar(MAX) = null,
	@Dimension nvarchar(50),
	@MainColorCount nvarchar(50),
	@ExportColor nvarchar(50),
	@SpotColorCount nvarchar(50),
	@SpotColors nvarchar(MAX) = null,
	@OverPrintBlackColor int,
	@DeviceCount nvarchar(MAX) = null,
	@FormEvertCount nvarchar(MAX) = null,
	@Description nvarchar(MAX) = null

AS

UPDATE [dbo].[Zinks]
SET
	[JobId] = @JobId,
	[OrderReceiverId] = @OrderReceiverId,
	[OtherOrderReceiver] = @OtherOrderReceiver,
	[Dimension] = @Dimension,
	[MainColorCount] = @MainColorCount,
	[ExportColor] = @ExportColor,
	[SpotColorCount] = @SpotColorCount,
	[SpotColors] = @SpotColors,
	[OverPrintBlackColor] = @OverPrintBlackColor,
	[DeviceCount] = @DeviceCount,
	[FormEvertCount] = @FormEvertCount,
	[Description] = @Description
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[ZinkTypes_DeleteByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ZinkTypes_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[ZinkTypes] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[ZinkTypes_DeleteByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ZinkTypes_DeleteByPrimaryKey]
	@Id int
AS

DELETE FROM [dbo].[ZinkTypes]
 WHERE 
	[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[ZinkTypes_Insert]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ZinkTypes_Insert]
	@Id int output,
	@Name nvarchar(MAX) 

AS

INSERT [dbo].[ZinkTypes]
(
	[Name]

)
VALUES
(
	@Name

)
	SELECT @Id=SCOPE_IDENTITY();







GO
/****** Object:  StoredProcedure [dbo].[ZinkTypes_SelectAll]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ZinkTypes_SelectAll]
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[ZinkTypes]






GO
/****** Object:  StoredProcedure [dbo].[ZinkTypes_SelectByField]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ZinkTypes_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [Id], [Name] FROM [dbo].[ZinkTypes] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)






GO
/****** Object:  StoredProcedure [dbo].[ZinkTypes_SelectByPrimaryKey]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ZinkTypes_SelectByPrimaryKey]
	@Id int
AS

	SELECT 
		[Id], [Name]
	FROM [dbo].[ZinkTypes]
	WHERE 
			[Id] = @Id






GO
/****** Object:  StoredProcedure [dbo].[ZinkTypes_Update]    Script Date: 5/29/2017 7:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ZinkTypes_Update]
	@Id int,
	@Name nvarchar(MAX)

AS

UPDATE [dbo].[ZinkTypes]
SET
	[Name] = @Name
 WHERE 
	[Id] = @Id






GO
