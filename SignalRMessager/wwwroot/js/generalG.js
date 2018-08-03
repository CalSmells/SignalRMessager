function sendGeneral() {
    const msg = document.getElementById("messageInput").value;

    document.getElementById("messageInput").value = "";
    connection.invoke("SendGeneral", uId, uName, msg).catch(err => console.error(err.toString()));
    event.preventDefault();
}

connection.on("ReceivegGeneral", (msg, int) => { //"internal" inaccurate naming
    const li = document.createElement("li");
    li.textContent = msg;
    li.setAttribute("class", `well well-sm well-${int}`);
    document.getElementById("messagesList").appendChild(li);
    //scroll(0);
});