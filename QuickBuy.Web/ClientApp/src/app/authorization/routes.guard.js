"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var KeepRoutes = /** @class */ (function () {
    function KeepRoutes() {
    }
    KeepRoutes.prototype.canActivate = function (route, state) {
        //se user autenticado
        return true;
    };
    return KeepRoutes;
}());
exports.KeepRoutes = KeepRoutes;
//# sourceMappingURL=keep.routes.js.map