const uId = document.getElementById("userId").value;
const uName = document.getElementById("userName").value;

function sendMessage() {
    const msg = document.getElementById("messageInput").value;
    document.getElementById("messageInput").value = "";
    connection.invoke("SendMessage", gId, uId, uName, msg).catch(err => console.error(err.toString()));
    event.preventDefault();
}
connection.on("ToGroup", msg => {
    const li = document.createElement("li");
    const br = document.createElement("br");
    li.textContent = msg;
    document.getElementById("extMessagesList").appendChild(li);
    document.getElementById("intMessagesList").appendChild(br);
});
connection.on("Refresh", () => {
    location.reload();
});
connection.on("UserOnline", (userId) => {
    var li = document.getElementById(userId);
    var dot = li.getElementsByClassName("dot");
    dot[0].setAttribute("id", "online");
});
connection.on("UserOffline", (userId) => {
    var li = document.getElementById(userId);
    var dot = li.getElementsByClassName("dot");
    dot[0].setAttribute("id", "offline");
});
function userOnline() {
    connection.invoke("UserOnline", gId, uId).catch (err => console.error(err.toString()));
}
function userOffline() {
    connection.invoke("UserOffline", gId, uId).catch (err => console.error(err.toString()));
}


connection.on("ReceiveMessage", (msg, int) => { //"internal" inaccurate naming
    const li = document.createElement("li");
    li.textContent = msg;
    li.setAttribute("class", `well well-sm well-${int}`);
    document.getElementById("messagesList").appendChild(li);
    scroll(0);
});

function scroll(pos) {
    window.scrollTo(pos, document.body.scrollHeight);
}