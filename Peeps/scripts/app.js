var Peeps;
(function (Peeps) {
    var MainCtrl = (function () {
        function MainCtrl($http) {
            var _this = this;
            $http.get("/peeps").success(function (data) {
                _this.peeps = data.peeps;
            });
        }
        return MainCtrl;
    })();
    Peeps.MainCtrl = MainCtrl;
})(Peeps || (Peeps = {}));
/// <reference path="mainctrl.ts" />
var Peeps;
(function (Peeps) {
    angular.module("peeps", []);
})(Peeps || (Peeps = {}));
//# sourceMappingURL=app.js.map
