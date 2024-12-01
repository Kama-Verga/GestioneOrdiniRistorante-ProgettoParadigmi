Il progetto comprende un programma per la gestione di ordini per un ristorante, prendendo in considerazioni delle API per la: 
- Creazione di un utente di tipo Cliente (anonima senza autenticazione)login
- sistema di Autenticazione/login tramite JWT
- Creazione di un ordine. creato l'ordine che restituisce il numero d'ordine e il prezzo totale, con un 10% di sconto se si prende 1 pacchetto composto da 1 primo 1 secondo 1 contorno ed 1 dolce.
- visualizzazione di uno Storico degli ordini, che cambia in base al ruolo dell'utente.
   gli utenti di tipo Cliente, visualizza l'elenco degli ordini da lui effettuato.
   gli utenti di tipo Amministratore, possono visualizzare l'elenco di tutti gli ordini effettuati o tutti gli ordini effettuat da uno specifico utente, (tramite un range di date ed un ID)


per inizializzare il progetto, il progetto sfrutta un Database hostato in macchina locale, Già esistente suggerisco l'utilizzo di SSMS ( https://learn.microsoft.com/it-it/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16)
per la creazione del DB e SQL Server su Azure per l'host in locale (https://www.microsoft.com/it-it/sql-server/sql-server-downloads)

 
