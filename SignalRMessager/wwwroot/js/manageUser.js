function add(userId, userName) {
    console.log("add");
    connection.invoke("AddUser", userId, groupId, userName);
}
function remove(userId, userName) {
    console.log("remove");
    connection.invoke("RemoveUser", userId, groupId, userName);
}



connection.on("PostAdd", (userId, userName) => {
    const btn = document.createElement("button");
    const b = document.createElement("b");
    const add = document.getElementById(`${userId}add`);
    const rem = document.getElementById(`${userId}remove`);
    const remB = document.getElementById(`${userId}remB`);

    add.innerHTML = "";
    b.textContent = "Nope";
    b.setAttribute("id", `${userId}addB`);
    add.appendChild(b);

    if (remB.textContent == "Nope") {
        btn.innerHTML = "";
        remB.innerHTML = "";
        btn.setAttribute("onclick", `remove('${userId}', '${userName}');`);
        btn.textContent = "Remove";
        rem.appendChild(btn);
    }
});


connection.on("PostRemove", (userId, userName) => {
    const btn = document.createElement("button");
    const b = document.createElement("b");
    const rem = document.getElementById(`${userId}remove`);
    const add = document.getElementById(`${userId}add`);
    const addB = document.getElementById(`${userId}addB`);

    rem.innerHTML = "";
    b.textContent = "Nope";
    b.setAttribute("id", `${userId}remB`);
    rem.appendChild(b);

    if (addB.textContent == "Nope") {
        btn.innerHTML = "";
        addB.innerHTML = "";
        btn.setAttribute("onclick", `add('${userId}', '${userName}');`);
        btn.textContent = "Add";
        add.appendChild(btn);
    }
});