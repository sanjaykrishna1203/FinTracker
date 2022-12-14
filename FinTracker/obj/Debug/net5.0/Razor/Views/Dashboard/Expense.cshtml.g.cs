#pragma checksum "E:\source\repos\FinTracker\FinTracker\Views\Dashboard\Expense.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9c34f26aaec7b3d52589144a4888eae8cda5371"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Expense), @"mvc.1.0.view", @"/Views/Dashboard/Expense.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\source\repos\FinTracker\FinTracker\Views\_ViewImports.cshtml"
using FinTracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\source\repos\FinTracker\FinTracker\Views\_ViewImports.cshtml"
using FinTracker.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9c34f26aaec7b3d52589144a4888eae8cda5371", @"/Views/Dashboard/Expense.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68cba5c2acd778a81fc7864861affd1896f23b52", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Dashboard_Expense : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("expenseform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\source\repos\FinTracker\FinTracker\Views\Dashboard\Expense.cshtml"
  
    ViewData["Title"] = "AddExpense";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- BEGIN: Form Validation -->
<div class=""intro-y box"" id=""formbox"" ng-app=""ExpenseApp"" ng-controller=""ExpenseCtrl"">
    <div class=""flex flex-col sm:flex-row items-center p-5 border-b border-gray-200 dark:border-dark-5"">
        <h2 class=""font-medium text-base mr-auto"">
            Add Your Expense Here!
        </h2>
        <div class=""w-full sm:w-auto flex items-center sm:ml-auto mt-3 sm:mt-0"">
        </div>
    </div>
    <div class=""p-5"" id=""form-validation"">
        <div class=""preview"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9c34f26aaec7b3d52589144a4888eae8cda53714367", async() => {
                WriteLiteral(@"
                <div class=""input-form"">
                    <label class=""flex flex-col sm:flex-row""> Expense</label>
                    <input ng-model=""pageinputs.expensenarration"" type=""text"" class=""input w-full border mt-2"" placeholder=""Give a Title for your Expense"" required>
                </div>
                <br />
                <div class=""input-form"">
                    <label class=""flex flex-col sm:flex-row""> Expense Date </label>
                    <input ng-model-options=""{timezone:'UTC + 5:30'}"" ng-model=""pageinputs.expensedate"" type=""date"" class=""input w-full border mt-2"" data-single-mode=""true"" placeholder=""DD/MM/YYYY"" required>
                </div>

                <div class=""input-form mt-3"">
                    <label class=""flex flex-col sm:flex-row"">Amount</label>
                    <input ng-model=""pageinputs.Expenseamount"" type=""number"" class=""input w-full border mt-2"" placeholder=""???"" required>
                </div>
                <button type=""submit"" cl");
                WriteLiteral("ass=\"button bg-theme-1 text-white mt-5\" ng-click=\"FormValidator()\">Add</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n<!-- END: Form Validation -->\r\n<style>\r\n    ");
            WriteLiteral("@media (min-width:1025px) {\r\n\r\n        #formbox {\r\n            margin-top: 10px !important;\r\n            width: 50%;\r\n            margin: auto;\r\n        }\r\n    }\r\n</style>\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
    var app = angular.module('ExpenseApp', []);
        app.controller('ExpenseCtrl', function ($scope, $http) {
            $scope.pageinputs = {};
        $scope.pageinputs.expensedate = new Date();
        $scope.AddExpense = function () {
            $http({
                cache: false,
                url: ""/Dashboard/AddExpenseToDb"",
                method: ""POST"",
                params: { data: JSON.stringify($scope.pageinputs) },
                async: false,
            }).then(function (data, status, headers, config) {
                data = data.data;
                if (!data) {
                    swal(""Error"", ""Unable to Process Your Request"", ""error"");
                    $scope.pageinputs = {};
                    $scope.pageinputs.expensedate = new Date();
                }
                else {

                    swal(""Success"", ""Added Successfully"", ""success"");
                    $scope.pageinputs = {};
                    $scope.pageinputs.expens");
                WriteLiteral(@"edate = new Date();
                }
            }, function errorCallback(response) {

            });
        }

        $scope.FormValidator = function () {
            if ($scope.expenseform.$valid) {
                $scope.AddExpense();
            }
            else {
                swal(""Error"", ""Please Fill All the Required Fields"", ""warning"");
            }
        }
    });
    </script>
");
            }
            );
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
