
function redirectTo(loc) {
    var path = window.location.pathname;
    if (loc === "#partnership") {
        if (path.indexOf("Partnership") === -1)
            window.location.href = "/Partnership";
    }
    else if (loc === "#portfolio") {
        if (path.indexOf("Portfolio") === -1)
            window.location.href = "/Portfolio";
    }
    // redirect to home
    else if (path.indexOf("Partnership") !== -1 || path.indexOf("Portfolio") !== -1) {
        window.location.href = "/" + loc;
    }
}