const connection = new signalR.HubConnectionBuilder()
    .withUrl("/chatHub")
    .build();
connection.start().catch(err => console.error(err.toString()));