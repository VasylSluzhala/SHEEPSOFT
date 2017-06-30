
function redirectTo(loc) {
    var path = window.location.pathname;
    if (path.indexOf("Partnership") != -1 || path.indexOf("Portfolio") != -1) {
        window.location.href = "/" + loc;
    }
}