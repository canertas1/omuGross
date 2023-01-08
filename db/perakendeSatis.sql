/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [id]
      ,[urunID]
      ,[satisTarih]
      ,[satisMiktar]
  FROM [omuGross].[dbo].[perakendeSatis]