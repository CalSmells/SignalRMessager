connection.on("GetGroups", (groups, list) => {
    var gList = document.getElementById(list);

    if (gList.hasChildNodes()) {
        gList.innerHTML = "";
    }
    for (group of groups) {
        var a = document.createElement("a");
        var li = document.createElement("li");
        a.setAttribute("href", "/Group/Group/" + group.groupId);
        a.textContent = group.name;
        gList.appendChild(li);
        li.appendChild(a);
    }
    if (!gList.hasChildNodes()) {
        var li = document.createElement("li");
        li.textContent = "NO GROUPS FOUND";
        console.error(li.textContent);
        gList.appendChild(li);
    }
});
function getGroup(DM, list, search) {
    if (list === "searchList") {
        DM = Boolean(DMDropDown.value === "true");
        search = searchInput.value;
    }
    if(!DM) {
        connection.invoke("GetGroups", currentUserId, list, search);
    }
    if (DM) {
        connection.invoke("GetContacts", currentUserId, list, search);
    }
}