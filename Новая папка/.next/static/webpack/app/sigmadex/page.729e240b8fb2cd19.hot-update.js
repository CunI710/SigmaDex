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

eval(__webpack_require__.ts("__webpack_require__.r(__webpack_exports__);\n/* harmony export */ __webpack_require__.d(__webpack_exports__, {\n/* harmony export */   SigmaExamples: function() { return /* binding */ SigmaExamples; }\n/* harmony export */ });\n/* harmony import */ var react_jsx_dev_runtime__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! react/jsx-dev-runtime */ \"(app-pages-browser)/./node_modules/next/dist/compiled/react/jsx-dev-runtime.js\");\n/* harmony import */ var antd_es_card_Card__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! antd/es/card/Card */ \"(app-pages-browser)/../node_modules/antd/es/card/Card.js\");\n\n\nconst SigmaExamples = (param)=>{\n    let { sigmaExaples } = param;\n    return /*#__PURE__*/ (0,react_jsx_dev_runtime__WEBPACK_IMPORTED_MODULE_0__.jsxDEV)(\"div\", {\n        className: \"flex\",\n        children: sigmaExaples.map((sigma)=>/*#__PURE__*/ (0,react_jsx_dev_runtime__WEBPACK_IMPORTED_MODULE_0__.jsxDEV)(antd_es_card_Card__WEBPACK_IMPORTED_MODULE_1__[\"default\"], {\n                title: sigma.name,\n                className: \"w-32 m-2\",\n                cover: /*#__PURE__*/ (0,react_jsx_dev_runtime__WEBPACK_IMPORTED_MODULE_0__.jsxDEV)(\"img\", {\n                    alt: \"example\",\n                    src: \"https://upload.wikimedia.org/wikipedia/commons/thumb/4/4e/Macaca_nigra_self-portrait_large.jpg/220px-Macaca_nigra_self-portrait_large.jpg\"\n                }, void 0, false, {\n                    fileName: \"C:\\\\Docs\\\\Kanay\\\\JS\\\\SigmaDex\\\\sigmadex\\\\app\\\\components\\\\sigmaExample.tsx\",\n                    lineNumber: 15,\n                    columnNumber: 28\n                }, void 0),\n                children: /*#__PURE__*/ (0,react_jsx_dev_runtime__WEBPACK_IMPORTED_MODULE_0__.jsxDEV)(\"div\", {\n                    children: sigma.types.map((type)=>/*#__PURE__*/ (0,react_jsx_dev_runtime__WEBPACK_IMPORTED_MODULE_0__.jsxDEV)(\"p\", {\n                            children: type\n                        }, void 0, false, {\n                            fileName: \"C:\\\\Docs\\\\Kanay\\\\JS\\\\SigmaDex\\\\sigmadex\\\\app\\\\components\\\\sigmaExample.tsx\",\n                            lineNumber: 19,\n                            columnNumber: 29\n                        }, undefined))\n                }, void 0, false, {\n                    fileName: \"C:\\\\Docs\\\\Kanay\\\\JS\\\\SigmaDex\\\\sigmadex\\\\app\\\\components\\\\sigmaExample.tsx\",\n                    lineNumber: 17,\n                    columnNumber: 21\n                }, undefined)\n            }, sigma.id, false, {\n                fileName: \"C:\\\\Docs\\\\Kanay\\\\JS\\\\SigmaDex\\\\sigmadex\\\\app\\\\components\\\\sigmaExample.tsx\",\n                lineNumber: 11,\n                columnNumber: 17\n            }, undefined))\n    }, void 0, false, {\n        fileName: \"C:\\\\Docs\\\\Kanay\\\\JS\\\\SigmaDex\\\\sigmadex\\\\app\\\\components\\\\sigmaExample.tsx\",\n        lineNumber: 9,\n        columnNumber: 9\n    }, undefined);\n};\n_c = SigmaExamples;\nvar _c;\n$RefreshReg$(_c, \"SigmaExamples\");\n\n\n;\n    // Wrapped in an IIFE to avoid polluting the global scope\n    ;\n    (function () {\n        var _a, _b;\n        // Legacy CSS implementations will `eval` browser code in a Node.js context\n        // to extract CSS. For backwards compatibility, we need to check we're in a\n        // browser context before continuing.\n        if (typeof self !== 'undefined' &&\n            // AMP / No-JS mode does not inject these helpers:\n            '$RefreshHelpers$' in self) {\n            // @ts-ignore __webpack_module__ is global\n            var currentExports = module.exports;\n            // @ts-ignore __webpack_module__ is global\n            var prevSignature = (_b = (_a = module.hot.data) === null || _a === void 0 ? void 0 : _a.prevSignature) !== null && _b !== void 0 ? _b : null;\n            // This cannot happen in MainTemplate because the exports mismatch between\n            // templating and execution.\n            self.$RefreshHelpers$.registerExportsForReactRefresh(currentExports, module.id);\n            // A module can be accepted automatically based on its exports, e.g. when\n            // it is a Refresh Boundary.\n            if (self.$RefreshHelpers$.isReactRefreshBoundary(currentExports)) {\n                // Save the previous exports signature on update so we can compare the boundary\n                // signatures. We avoid saving exports themselves since it causes memory leaks (https://github.com/vercel/next.js/pull/53797)\n                module.hot.dispose(function (data) {\n                    data.prevSignature =\n                        self.$RefreshHelpers$.getRefreshBoundarySignature(currentExports);\n                });\n                // Unconditionally accept an update to this module, we'll check if it's\n                // still a Refresh Boundary later.\n                // @ts-ignore importMeta is replaced in the loader\n                module.hot.accept();\n                // This field is set when the previous version of this module was a\n                // Refresh Boundary, letting us know we need to check for invalidation or\n                // enqueue an update.\n                if (prevSignature !== null) {\n                    // A boundary can become ineligible if its exports are incompatible\n                    // with the previous exports.\n                    //\n                    // For example, if you add/remove/change exports, we'll want to\n                    // re-execute the importing modules, and force those components to\n                    // re-render. Similarly, if you convert a class component to a\n                    // function, we want to invalidate the boundary.\n                    if (self.$RefreshHelpers$.shouldInvalidateReactRefreshBoundary(prevSignature, self.$RefreshHelpers$.getRefreshBoundarySignature(currentExports))) {\n                        module.hot.invalidate();\n                    }\n                    else {\n                        self.$RefreshHelpers$.scheduleUpdate();\n                    }\n                }\n            }\n            else {\n                // Since we just executed the code for the module, it's possible that the\n                // new exports made it ineligible for being a boundary.\n                // We only care about the case when we were _previously_ a boundary,\n                // because we already accepted this update (accidental side effect).\n                var isNoLongerABoundary = prevSignature !== null;\n                if (isNoLongerABoundary) {\n                    module.hot.invalidate();\n                }\n            }\n        }\n    })();\n//# sourceURL=[module]\n//# sourceMappingURL=data:application/json;charset=utf-8;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiKGFwcC1wYWdlcy1icm93c2VyKS8uL2FwcC9jb21wb25lbnRzL3NpZ21hRXhhbXBsZS50c3giLCJtYXBwaW5ncyI6Ijs7Ozs7OztBQUFxQztBQU05QixNQUFNQyxnQkFBZ0I7UUFBQyxFQUFFQyxZQUFZLEVBQVM7SUFDakQscUJBQ0ksOERBQUNDO1FBQUlDLFdBQVU7a0JBQ1ZGLGFBQWFHLEdBQUcsQ0FBQyxDQUFDQyxzQkFDZiw4REFBQ04seURBQUlBO2dCQUVETyxPQUFPRCxNQUFNRSxJQUFJO2dCQUNqQkosV0FBVTtnQkFDVksscUJBQU8sOERBQUNDO29CQUFJQyxLQUFJO29CQUFVQyxLQUFJOzs7Ozs7MEJBRTlCLDRFQUFDVDs4QkFDSUcsTUFBTU8sS0FBSyxDQUFDUixHQUFHLENBQUNTLENBQUFBLHFCQUNiLDhEQUFDQztzQ0FBR0Q7Ozs7Ozs7Ozs7O2VBUFBSLE1BQU1VLEVBQUU7Ozs7Ozs7Ozs7QUFjakMsRUFBRTtLQW5CV2YiLCJzb3VyY2VzIjpbIndlYnBhY2s6Ly9fTl9FLy4vYXBwL2NvbXBvbmVudHMvc2lnbWFFeGFtcGxlLnRzeD8yMGZjIl0sInNvdXJjZXNDb250ZW50IjpbImltcG9ydCBDYXJkIGZyb20gXCJhbnRkL2VzL2NhcmQvQ2FyZFwiO1xyXG5cclxuaW50ZXJmYWNlIFByb3BzIHtcclxuICAgIHNpZ21hRXhhcGxlczogU2lnbWFFeGFtcGxlW107XHJcbn1cclxuXHJcbmV4cG9ydCBjb25zdCBTaWdtYUV4YW1wbGVzID0gKHsgc2lnbWFFeGFwbGVzIH06IFByb3BzKSA9PiB7XHJcbiAgICByZXR1cm4gKFxyXG4gICAgICAgIDxkaXYgY2xhc3NOYW1lPVwiZmxleFwiPlxyXG4gICAgICAgICAgICB7c2lnbWFFeGFwbGVzLm1hcCgoc2lnbWE6IFNpZ21hRXhhbXBsZSkgPT4gKFxyXG4gICAgICAgICAgICAgICAgPENhcmRcclxuICAgICAgICAgICAgICAgICAgICBrZXk9e3NpZ21hLmlkfVxyXG4gICAgICAgICAgICAgICAgICAgIHRpdGxlPXtzaWdtYS5uYW1lfVxyXG4gICAgICAgICAgICAgICAgICAgIGNsYXNzTmFtZT1cInctMzIgbS0yXCJcclxuICAgICAgICAgICAgICAgICAgICBjb3Zlcj17PGltZyBhbHQ9XCJleGFtcGxlXCIgc3JjPVwiaHR0cHM6Ly91cGxvYWQud2lraW1lZGlhLm9yZy93aWtpcGVkaWEvY29tbW9ucy90aHVtYi80LzRlL01hY2FjYV9uaWdyYV9zZWxmLXBvcnRyYWl0X2xhcmdlLmpwZy8yMjBweC1NYWNhY2FfbmlncmFfc2VsZi1wb3J0cmFpdF9sYXJnZS5qcGdcIj48L2ltZz59XHJcbiAgICAgICAgICAgICAgICA+XHJcbiAgICAgICAgICAgICAgICAgICAgPGRpdj5cclxuICAgICAgICAgICAgICAgICAgICAgICAge3NpZ21hLnR5cGVzLm1hcCh0eXBlID0+IChcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgIDxwPnt0eXBlfTwvcD5cclxuICAgICAgICAgICAgICAgICAgICAgICAgKSl9XHJcbiAgICAgICAgICAgICAgICAgICAgPC9kaXY+XHJcbiAgICAgICAgICAgICAgICA8L0NhcmQ+XHJcbiAgICAgICAgICAgICkpfVxyXG4gICAgICAgIDwvZGl2PlxyXG4gICAgKTtcclxufTsiXSwibmFtZXMiOlsiQ2FyZCIsIlNpZ21hRXhhbXBsZXMiLCJzaWdtYUV4YXBsZXMiLCJkaXYiLCJjbGFzc05hbWUiLCJtYXAiLCJzaWdtYSIsInRpdGxlIiwibmFtZSIsImNvdmVyIiwiaW1nIiwiYWx0Iiwic3JjIiwidHlwZXMiLCJ0eXBlIiwicCIsImlkIl0sInNvdXJjZVJvb3QiOiIifQ==\n//# sourceURL=webpack-internal:///(app-pages-browser)/./app/components/sigmaExample.tsx\n"));

/***/ })

});