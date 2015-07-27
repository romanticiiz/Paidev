var fnObj = fnObj || {};
fnObj.fn = {
    addEvent: function (a) {
        alert(a);
    }
}, fnObj.set = function () {
    var t = '나는 변수 t이다.'
    t2 = '나는 변수 t2이다.';
    return {
        tt: t
    }
}()