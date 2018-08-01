function sendMessage() {
    const msg = document.getElementById("messageInput").value;

    document.getElementById("messageInput").value = "";
    connection.invoke("SendGeneral", uId, uName, msg).catch(err => console.error(err.toString()));
    event.preventDefault();
}

connection.on("ReceiveExternalGeneral", (user, msg) => {
    const encodedMsg = user + ": " + msg;
    const li = document.createElement("li");
    const br = document.createElement("br");
    li.textContent = encodedMsg;
    document.getElementById("extMessagesList").appendChild(li);
    document.getElementById("intMessagesList").appendChild(br);
});
connection.on("ReceiveInternalGeneral", (msg) => { //"internal" inaccurate naming
    const li = document.createElement("li");
    const br = document.createElement("br");
    li.textContent = msg;
    document.getElementById("intMessagesList").appendChild(li);
    document.getElementById("extMessagesList").appendChild(br);
    console.log(msg);
});