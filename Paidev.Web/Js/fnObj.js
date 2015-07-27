var fnObj = fnObj || {};
fnObj.fn = {
    addEvent: function (a) {
        alert(a);
    },
    living: true,
    age: 33,
    getLiving: function () {
        return fnObj.fn.living;
    },
    setArticle: function (n4BoardSN, n4CommentSN) {
        this.n4BoardSN = n4BoardSN,
        this.n4CommentSN = n4CommentSN
    }
}, fnObj.set = function () {
    var t = '나는 변수 t이다.'
    t2 = '나는 변수 t2이다.';
    return {
        tt: t
    }
}()

//var codyA = new Object();
//codyA.living = true;
//codyA.age = 33;
//codyA.gender = 'mail';
//codyA.getGender = function () {
//    return codyA.gender;
//};


//var Person = function (living, age, gender) {
//    this.living = living;
//    this.age = age;
//    this.gender = gender;
//    this.getGender = function () {
//        return this.gender;
//    };
//};

//var codyB = new Person(true, 33, 'male');