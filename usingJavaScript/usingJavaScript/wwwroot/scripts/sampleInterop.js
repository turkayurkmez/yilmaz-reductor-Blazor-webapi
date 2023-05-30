var interopObject = {};
interopObject.getWindowSize = function () {
    var size = {
        width: window.innerWidth,
        height: window.innerHeight
    };
    return size;
}

interopObject.setLocalStorage = function (key, data) {
    localStorage.setItem(key, data);
}
interopObject.getLocalStorage = function (key) {
    return localStorage.getItem(key);
}