"use strict";
/*
 * ATTENTION: An "eval-source-map" devtool has been used.
 * This devtool is neither made for production nor for readable output files.
 * It uses "eval()" calls to create a separate source file with attached SourceMaps in the browser devtools.
 * If you are trying to read the output file, select a different devtool (https://webpack.js.org/configuration/devtool/)
 * or disable the default devtool with "devtool: false".
 * If you are looking for production-ready output files, see mode: "production" (https://webpack.js.org/configuration/mode/).
 */
self["webpackHotUpdate_N_E"]("app/sigmadex/page",{

/***/ "(app-pages-browser)/./app/components/sigmaExample.tsx":
/*!*****************************************!*\
  !*** ./app/components/sigmaExample.tsx ***!
  \*****************************************/
/***/ (function(module, __webpack_exports__, __webpack_require__) {

eval(__webpack_require__.ts("__webpack_require__.r(__webpack_exports__);\n/* harmony export */ __webpack_require__.d(__webpack_exports__, {\n/* harmony export */   SigmaExamples: function() { return /* binding */ SigmaExamples; }\n/* harmony export */ });\n/* harmony import */ var react_jsx_dev_runtime__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react/jsx-dev-runtime */ \"(app-pages-browser)/./node_modules/next/dist/compiled/react/jsx-dev-runtime.js\");\n/* harmony import */ var antd_es_card_Card__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! antd/es/card/Card */ \"(app-pages-browser)/../node_modules/antd/es/card/Card.js\");\n\n\nconst SigmaExamples = (param)=>{\n    let { sigmaExaples } = param;\n    return /*#__PURE__*/ (0,react_jsx_dev_runtime__WEBPACK_IMPORTED_MODULE_0__.jsxDEV)(\"div\", {\n        children: sigmaExaples.map((sigma)=>/*#__PURE__*/ (0,react_jsx_dev_runtime__WEBPACK_IMPORTED_MODULE_0__.jsxDEV)(antd_es_card_Card__WEBPACK_IMPORTED_MODULE_1__[\"default\"], {\n                title: sigma.name,\n                bordered: false,\n                className: \"grid\",\n                children: [\n                    /*#__PURE__*/ (0,react_jsx_dev_runtime__WEBPACK_IMPORTED_MODULE_0__.jsxDEV)(\"img\", {\n                        src: \"https://upload.wikimedia.org/wikipedia/commons/thumb/4/4e/Macaca_nigra_self-portrait_large.jpg/220px-Macaca_nigra_self-portrait_large.jpg\"\n                    }, void 0, false, {\n                        fileName: \"C:\\\\Docs\\\\Kanay\\\\JS\\\\SigmaDex\\\\sigmadex\\\\app\\\\components\\\\sigmaExample.tsx\",\n                        lineNumber: 17,\n                        columnNumber: 21\n                    }, undefined),\n                    /*#__PURE__*/ (0,react_jsx_dev_runtime__WEBPACK_IMPORTED_MODULE_0__.jsxDEV)(\"div\", {\n                        children: sigma.name\n                    }, void 0, false, {\n                        fileName: \"C:\\\\Docs\\\\Kanay\\\\JS\\\\SigmaDex\\\\sigmadex\\\\app\\\\components\\\\sigmaExample.tsx\",\n                        lineNumber: 18,\n                        columnNumber: 21\n                    }, undefined)\n                ]\n            }, sigma.id, true, {\n                fileName: \"C:\\\\Docs\\\\Kanay\\\\JS\\\\SigmaDex\\\\sigmadex\\\\app\\\\components\\\\sigmaExample.tsx\",\n                lineNumber: 11,\n                columnNumber: 17\n            }, undefined))\n    }, void 0, false, {\n        fileName: \"C:\\\\Docs\\\\Kanay\\\\JS\\\\SigmaDex\\\\sigmadex\\\\app\\\\components\\\\sigmaExample.tsx\",\n        lineNumber: 9,\n        columnNumber: 9\n    }, undefined);\n};\n_c = SigmaExamples;\nvar _c;\n$RefreshReg$(_c, \"SigmaExamples\");\n\n\n;\n    // Wrapped in an IIFE to avoid polluting the global scope\n    ;\n    (function () {\n        var _a, _b;\n        // Legacy CSS implementations will `eval` browser code in a Node.js context\n        // to extract CSS. For backwards compatibility, we need to check we're in a\n        // browser context before continuing.\n        if (typeof self !== 'undefined' &&\n            // AMP / No-JS mode does not inject these helpers:\n            '$RefreshHelpers$' in self) {\n            // @ts-ignore __webpack_module__ is global\n            var currentExports = module.exports;\n            // @ts-ignore __webpack_module__ is global\n            var prevSignature = (_b = (_a = module.hot.data) === null || _a === void 0 ? void 0 : _a.prevSignature) !== null && _b !== void 0 ? _b : null;\n            // This cannot happen in MainTemplate because the exports mismatch between\n            // templating and execution.\n            self.$RefreshHelpers$.registerExportsForReactRefresh(currentExports, module.id);\n            // A module can be accepted automatically based on its exports, e.g. when\n            // it is a Refresh Boundary.\n            if (self.$RefreshHelpers$.isReactRefreshBoundary(currentExports)) {\n                // Save the previous exports signature on update so we can compare the boundary\n                // signatures. We avoid saving exports themselves since it causes memory leaks (https://github.com/vercel/next.js/pull/53797)\n                module.hot.dispose(function (data) {\n                    data.prevSignature =\n                        self.$RefreshHelpers$.getRefreshBoundarySignature(currentExports);\n                });\n                // Unconditionally accept an update to this module, we'll check if it's\n                // still a Refresh Boundary later.\n                // @ts-ignore importMeta is replaced in the loader\n                module.hot.accept();\n                // This field is set when the previous version of this module was a\n                // Refresh Boundary, letting us know we need to check for invalidation or\n                // enqueue an update.\n                if (prevSignature !== null) {\n                    // A boundary can become ineligible if its exports are incompatible\n                    // with the previous exports.\n                    //\n                    // For example, if you add/remove/change exports, we'll want to\n                    // re-execute the importing modules, and force those components to\n                    // re-render. Similarly, if you convert a class component to a\n                    // function, we want to invalidate the boundary.\n                    if (self.$RefreshHelpers$.shouldInvalidateReactRefreshBoundary(prevSignature, self.$RefreshHelpers$.getRefreshBoundarySignature(currentExports))) {\n                        module.hot.invalidate();\n                    }\n                    else {\n                        self.$RefreshHelpers$.scheduleUpdate();\n                    }\n                }\n            }\n            else {\n                // Since we just executed the code for the module, it's possible that the\n                // new exports made it ineligible for being a boundary.\n                // We only care about the case when we were _previously_ a boundary,\n                // because we already accepted this update (accidental side effect).\n                var isNoLongerABoundary = prevSignature !== null;\n                if (isNoLongerABoundary) {\n                    module.hot.invalidate();\n                }\n            }\n        }\n    })();\n//# sourceURL=[module]\n//# sourceMappingURL=data:application/json;charset=utf-8;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiKGFwcC1wYWdlcy1icm93c2VyKS8uL2FwcC9jb21wb25lbnRzL3NpZ21hRXhhbXBsZS50c3giLCJtYXBwaW5ncyI6Ijs7Ozs7OztBQUFxQztBQU05QixNQUFNQyxnQkFBZ0I7UUFBQyxFQUFFQyxZQUFZLEVBQVM7SUFDakQscUJBQ0ksOERBQUNDO2tCQUNJRCxhQUFhRSxHQUFHLENBQUMsQ0FBQ0Msc0JBQ2YsOERBQUNMLHlEQUFJQTtnQkFFRE0sT0FBT0QsTUFBTUUsSUFBSTtnQkFDakJDLFVBQVU7Z0JBQ1ZDLFdBQVU7O2tDQUVWLDhEQUFDQzt3QkFBSUMsS0FBSTs7Ozs7O2tDQUNULDhEQUFDUjtrQ0FBS0UsTUFBTUUsSUFBSTs7Ozs7OztlQU5YRixNQUFNTyxFQUFFOzs7Ozs7Ozs7O0FBV2pDLEVBQUU7S0FoQldYIiwic291cmNlcyI6WyJ3ZWJwYWNrOi8vX05fRS8uL2FwcC9jb21wb25lbnRzL3NpZ21hRXhhbXBsZS50c3g/MjBmYyJdLCJzb3VyY2VzQ29udGVudCI6WyJpbXBvcnQgQ2FyZCBmcm9tIFwiYW50ZC9lcy9jYXJkL0NhcmRcIjtcclxuXHJcbmludGVyZmFjZSBQcm9wcyB7XHJcbiAgICBzaWdtYUV4YXBsZXM6IFNpZ21hRXhhbXBsZVtdO1xyXG59XHJcblxyXG5leHBvcnQgY29uc3QgU2lnbWFFeGFtcGxlcyA9ICh7IHNpZ21hRXhhcGxlcyB9OiBQcm9wcykgPT4ge1xyXG4gICAgcmV0dXJuIChcclxuICAgICAgICA8ZGl2PlxyXG4gICAgICAgICAgICB7c2lnbWFFeGFwbGVzLm1hcCgoc2lnbWE6IFNpZ21hRXhhbXBsZSkgPT4gKFxyXG4gICAgICAgICAgICAgICAgPENhcmRcclxuICAgICAgICAgICAgICAgICAgICBrZXk9e3NpZ21hLmlkfVxyXG4gICAgICAgICAgICAgICAgICAgIHRpdGxlPXtzaWdtYS5uYW1lfVxyXG4gICAgICAgICAgICAgICAgICAgIGJvcmRlcmVkPXtmYWxzZX1cclxuICAgICAgICAgICAgICAgICAgICBjbGFzc05hbWU9XCJncmlkXCJcclxuICAgICAgICAgICAgICAgID5cclxuICAgICAgICAgICAgICAgICAgICA8aW1nIHNyYz1cImh0dHBzOi8vdXBsb2FkLndpa2ltZWRpYS5vcmcvd2lraXBlZGlhL2NvbW1vbnMvdGh1bWIvNC80ZS9NYWNhY2FfbmlncmFfc2VsZi1wb3J0cmFpdF9sYXJnZS5qcGcvMjIwcHgtTWFjYWNhX25pZ3JhX3NlbGYtcG9ydHJhaXRfbGFyZ2UuanBnXCIgLz5cclxuICAgICAgICAgICAgICAgICAgICA8ZGl2PntzaWdtYS5uYW1lfTwvZGl2PlxyXG4gICAgICAgICAgICAgICAgPC9DYXJkPlxyXG4gICAgICAgICAgICApKX1cclxuICAgICAgICA8L2Rpdj5cclxuICAgICk7XHJcbn07Il0sIm5hbWVzIjpbIkNhcmQiLCJTaWdtYUV4YW1wbGVzIiwic2lnbWFFeGFwbGVzIiwiZGl2IiwibWFwIiwic2lnbWEiLCJ0aXRsZSIsIm5hbWUiLCJib3JkZXJlZCIsImNsYXNzTmFtZSIsImltZyIsInNyYyIsImlkIl0sInNvdXJjZVJvb3QiOiIifQ==\n//# sourceURL=webpack-internal:///(app-pages-browser)/./app/components/sigmaExample.tsx\n"));

/***/ })

});