#pragma checksum "E:\source\repos\FinTracker\FinTracker\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6f8d9b9e8b425a3f00e8ed3ce627471d8cd4d2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6f8d9b9e8b425a3f00e8ed3ce627471d8cd4d2f", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68cba5c2acd778a81fc7864861affd1896f23b52", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "7", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "15", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "30", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("app"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ng-app", new global::Microsoft.AspNetCore.Html.HtmlString("dashboardApp"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ng-controller", new global::Microsoft.AspNetCore.Html.HtmlString("dashboardCtrl"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ng-init", new global::Microsoft.AspNetCore.Html.HtmlString("GetNarration();GetDashData();"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\source\repos\FinTracker\FinTracker\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6f8d9b9e8b425a3f00e8ed3ce627471d8cd4d2f5670", async() => {
                WriteLiteral(@"

    <div class=""flex"">

        <div class=""content"">

            <!-- BEGIN: General Report -->
            <div class=""col-span-12 mt-8"">
                <div class=""intro-y flex items-center h-10"">
                    <h2 class=""text-lg font-medium truncate mr-5"">
                        General Report
                    </h2>
                </div>
                <div class=""grid grid-cols-12 gap-6 mt-5"">
                    <div class=""col-span-12 sm:col-span-6 xl:col-span-3 intro-y"">
                        <div class=""report-box zoom-in"">
                            <div class=""box p-5"">
                                <div class=""flex"">
                                    <i data-feather=""briefcase"" class=""report-box__icon text-theme-9""></i>

                                </div>
                                <div class=""text-3xl font-bold leading-8 mt-6"" ng-bind=""totalExpense""></div>
                                <div class=""text-base text-gray-600 mt-1"">Total Expenses");
                WriteLiteral(@"(This Month)</div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-span-12 sm:col-span-6 xl:col-span-3 intro-y"">
                        <div class=""report-box zoom-in"">
                            <div class=""box p-5"">
                                <div class=""flex"">
                                    <i data-feather=""credit-card"" class=""report-box__icon text-theme-11""></i>
                                </div>
                                <div class=""text-3xl font-bold leading-8 mt-6"" ng-bind=""totalEmi""></div>
                                <div class=""text-base text-gray-600 mt-1"">Total Emi (This Month)</div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-span-12 sm:col-span-6 xl:col-span-3 intro-y"">
                        <div class=""report-box zoom-in"">
                            <div class=""box p-5"">
               ");
                WriteLiteral(@"                 <div class=""flex"">
                                    <i data-feather=""monitor"" class=""report-box__icon text-theme-12""></i>

                                </div>
                                <div class=""text-3xl font-bold leading-8 mt-6"" ng-bind=""totalIncome""></div>
                                <div class=""text-base text-gray-600 mt-1"">Total Income(This Month)</div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-span-12 sm:col-span-6 xl:col-span-3 intro-y"">
                        <div class=""report-box zoom-in"">
                            <div class=""box p-5"">
                                <div class=""flex"">
                                    <i data-feather=""activity"" class=""report-box__icon text-theme-10""></i>
                                </div>
                                <div class=""text-3xl font-bold leading-8 mt-6"" ng-bind=""totalOutstanding""></div>
                     ");
                WriteLiteral(@"           <div class=""text-base text-gray-600 mt-1"">Total Outstanding</div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
            <!-- END: General Report -->
            <div class=""intro-y grid grid-cols-12 gap-6 mt-5"">
                <div class=""col-span-12 lg:col-span-6"">
                    <!-- BEGIN: Vertical Bar Chart -->
                    <div class=""intro-y box"">
                        <div class=""flex flex-col sm:flex-row items-center p-5 border-b border-gray-200 dark:border-dark-5"">
                            <h2 class=""font-medium text-base mr-auto"">
                                Your Debt Summary
                            </h2>

                        </div>
                        <div class=""p-5"" id=""vertical-bar-chart"">
                            <div class=""preview"">
                                <div id=""piechart"" height=""400""></div>
                            </");
                WriteLiteral(@"div>

                        </div>
                    </div>
                </div>
                <div class=""col-span-12 lg:col-span-6"">
                    <!-- BEGIN: Stacked Bar Chart -->
                    <div class=""intro-y box"">
                        <div class=""flex flex-col sm:flex-row items-center p-5 border-b border-gray-200 dark:border-dark-5"">
                            <h2 class=""font-medium text-base mr-auto"">
                                Upcoming EMIs
                            </h2>
                            <div class="" dropdown sm:w-auto flex items-center sm:ml-auto mt-3 sm:mt-0"">
                                <select ng-change=""GetNarration()"" name=""numbers"" ng-model=""number"" >
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6f8d9b9e8b425a3f00e8ed3ce627471d8cd4d2f11060", async() => {
                    WriteLiteral("7");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6f8d9b9e8b425a3f00e8ed3ce627471d8cd4d2f12638", async() => {
                    WriteLiteral("15");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6f8d9b9e8b425a3f00e8ed3ce627471d8cd4d2f13894", async() => {
                    WriteLiteral("30");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </select>
                            </div>
                        </div>
                        <div class=""p-5"" id=""stacked-bar-chart"">

                            <div ng-show=""narrationList.length == 0"">
                                <h2 class=""text-3xl text-gray-700 dark:text-gray-600 font-medium leading-none mt-3"">You Have No EMIs for the next {{number}} days!</h2>
                            </div>
                            <div class=""intro-y col-span-12 overflow-auto lg:overflow-visible"">
                                <table class=""table table-report flex -mt-2"" ng-show=""narrationList.length > 0"">
                                    <thead>
                                        <tr>
                                            <th class="" whitespace-no-wrap"">Narration</th>
                                            <th class="" whitespace-no-wrap"">EMI Date</th>
                                            <th class="" whitespace-no-wrap"">EMI</t");
                WriteLiteral(@"h>
                                            <th class="" whitespace-no-wrap"">Outstanding</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr class=""intro-x"" ng-repeat=""items in narrationList"">
                                            <td ng-bind=""items.narration"" class=""font-medium r whitespace-no-wrap""></td>
                                            <td ng-bind=""items.loanStartDate | date:'dd'"" class=""font-medium  whitespace-no-wrap""></td>
                                            <td ng-bind=""items.emi"" class=""font-medium text-center whitespace-no-wrap""></td>
                                            <td ng-bind=""items.currentOutstanding"" class=""font-medium text-center whitespace-no-wrap""></td>
                                        </tr>
                                    </tbody>
                                </table>
                            </");
                WriteLiteral("div>\r\n                        </div>\r\n                    </div>\r\n                    <!-- END: Stacked Bar Chart -->\r\n\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!-- END: Content -->\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n<script type=\"text/javascript\" src=\"https://www.gstatic.com/charts/loader.js\"></script>\r\n\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>

        var app = angular.module('dashboardApp', []);
        app.controller('dashboardCtrl', function ($scope, $http) {
            $scope.narrationList = [];
            $scope.DashData = [];
            $scope.totalOutstanding = """";
            $scope.totalEmi = """";
            $scope.totalIncome = """";
            $scope.number = ""7"";
            $scope.totalDebt = """";


            $scope.GetNarration = function () {
                $http({
                    cache: false,
                    url: ""/Dashboard/GetEmi"",
                    method: ""POST"",
                    params: { num: $scope.number },
                    async: false,


                }).then(function (data, status, headers, config) {
                    data = data.data;
                    $scope.narrationList = [];
                    $scope.narrationList = data;
                }, function errorCallback(response) {

                });
            }

            $scope.GetDashData = ");
                WriteLiteral(@"function () {
                $http({
                    cache: false,
                    url: ""/Dashboard/GetDashData"",
                    method: ""POST"",
                }).then(function (data, status, headers, config) {
                    if (data != null) {
                        data = data.data;
                        $scope.DashData = [];
                        $scope.DashData = data;
                        $scope.totalOutstanding = $scope.DashData[0];
                        $scope.totalEmi = $scope.DashData[1];
                        $scope.totalIncome = $scope.DashData[2];
                        $scope.totalExpense = $scope.DashData[3];
                        $scope.totalPaid = $scope.DashData[4];

                        google.charts.load('current', { 'packages': ['corechart'] });
                        google.charts.setOnLoadCallback(drawChart);

                        // Draw the chart and set the chart values
                        function drawChart() {
     ");
                WriteLiteral(@"                       var data = google.visualization.arrayToDataTable([
                                ['Title', 'Amount'],
                                ['Paid', $scope.totalPaid],
                                ['Outstanding', $scope.totalOutstanding],

                            ]);

                            // Optional; add a title and set the width and height of the chart
                            var options = {};

                            // Display the chart inside the <div> element with id=""piechart""
                            var chart = new google.visualization.PieChart(document.getElementById('piechart'));
                            chart.draw(data, options);
                        }
                        
                    }
                   

                    
                }, function errorCallback(response) {

                });
            }



        });




    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591