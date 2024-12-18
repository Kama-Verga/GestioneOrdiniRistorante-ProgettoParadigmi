SELECT TOP (1000) [Id]
	  ,[Mail]
      ,[Nome]
      ,[Cognome]
      ,[Password]
      ,[Ruolo]
  FROM [master].[dbo].[Utente]

  SELECT TOP (1000) [OrdineId]
      ,[ProdottoId]
  FROM [master].[dbo].[ProdottoInOrdine]

  SELECT TOP (1000) [Id]
      ,[Nome]
      ,[Prezzo]
      ,[Tipo]
  FROM [master].[dbo].[Prodotto]

  SELECT TOP (1000) [Numero_Ordine]
      ,[UtenteId]
      ,[Data_creazione]
      ,[Indirizzo_Di_Consegna]
      ,[Prezzo]
  FROM [master].[dbo].[Ordine]

