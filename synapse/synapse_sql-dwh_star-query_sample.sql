SELECT
    Coalesce(p.[ModelName], p.[EnglishProductName]) AS [Model]
    ,g.City AS ResellerCity
    ,g.StateProvinceName AS StateProvince
    ,Year(f.OrderDate) AS CalendarYear
    ,CASE
        WHEN Month(f.OrderDate) < 7 THEN Year(f.OrderDate)
        ELSE Year(f.OrderDate) + 1
    END AS FiscalYear -- Fiscal year runs from Jul to June)
    ,Month(f.OrderDate) AS [Month]
    ,Sum(f.OrderQuantity) AS Quantity
    ,Sum(f.ExtendedAmount) AS Amount
    ,Approx_count_distinct(f.SalesOrderNumber) AS UniqueOrders  
FROM
    [dbo].[FactResellerSales] f
INNER JOIN [dbo].[DimReseller] r
    ON f.ResellerKey = r.ResellerKey
INNER JOIN [dbo].[DimGeography] g
    ON r.GeographyKey = g.GeographyKey
INNER JOIN [dbo].[DimProduct] p
    ON f.[ProductKey] = p.[ProductKey]
GROUP BY
    Coalesce(p.[ModelName], p.[EnglishProductName])
    ,g.City
    ,g.StateProvinceName
    ,Year(f.OrderDate)
    ,CASE
        WHEN Month(f.OrderDate) < 7 THEN Year(f.OrderDate)
        ELSE Year(f.OrderDate) + 1
    END
    ,Month(f.OrderDate)
ORDER BY Amount DESC