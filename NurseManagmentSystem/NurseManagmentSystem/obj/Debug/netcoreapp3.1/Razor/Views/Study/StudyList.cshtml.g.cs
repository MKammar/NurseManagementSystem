#pragma checksum "C:\Users\ammar\OneDrive\Documents\files for me\cardio test\NurseManagmentSystem\NurseManagmentSystem\Views\Study\StudyList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be9e874442f83240095cfca2cea389ff182d0b87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Study_StudyList), @"mvc.1.0.view", @"/Views/Study/StudyList.cshtml")]
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
#line 1 "C:\Users\ammar\OneDrive\Documents\files for me\cardio test\NurseManagmentSystem\NurseManagmentSystem\Views\_ViewImports.cshtml"
using NurseManagmentSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ammar\OneDrive\Documents\files for me\cardio test\NurseManagmentSystem\NurseManagmentSystem\Views\_ViewImports.cshtml"
using NurseManagmentSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be9e874442f83240095cfca2cea389ff182d0b87", @"/Views/Study/StudyList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3113a448211e400e56fd0251999b7ac3a099259f", @"/Views/_ViewImports.cshtml")]
    public class Views_Study_StudyList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NurseManagmentSystem.Models.Study>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateStudy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ammar\OneDrive\Documents\files for me\cardio test\NurseManagmentSystem\NurseManagmentSystem\Views\Study\StudyList.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-12 m-3\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be9e874442f83240095cfca2cea389ff182d0b874897", async() => {
                WriteLiteral("Add New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-12 table-responsive\">\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 19 "C:\Users\ammar\OneDrive\Documents\files for me\cardio test\NurseManagmentSystem\NurseManagmentSystem\Views\Study\StudyList.cshtml"
                   Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 22 "C:\Users\ammar\OneDrive\Documents\files for me\cardio test\NurseManagmentSystem\NurseManagmentSystem\Views\Study\StudyList.cshtml"
                   Write(Html.DisplayNameFor(model => model.patient.fullname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 25 "C:\Users\ammar\OneDrive\Documents\files for me\cardio test\NurseManagmentSystem\NurseManagmentSystem\Views\Study\StudyList.cshtml"
                   Write(Html.DisplayNameFor(model => model.device.serialNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 28 "C:\Users\ammar\OneDrive\Documents\files for me\cardio test\NurseManagmentSystem\NurseManagmentSystem\Views\Study\StudyList.cshtml"
                   Write(Html.DisplayNameFor(model => model.startTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        Status\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\ammar\OneDrive\Documents\files for me\cardio test\NurseManagmentSystem\NurseManagmentSystem\Views\Study\StudyList.cshtml"
                 foreach (var item in Model)
                {




#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 44 "C:\Users\ammar\OneDrive\Documents\files for me\cardio test\NurseManagmentSystem\NurseManagmentSystem\Views\Study\StudyList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 47 "C:\Users\ammar\OneDrive\Documents\files for me\cardio test\NurseManagmentSystem\NurseManagmentSystem\Views\Study\StudyList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.patient.fullname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 50 "C:\Users\ammar\OneDrive\Documents\files for me\cardio test\NurseManagmentSystem\NurseManagmentSystem\Views\Study\StudyList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.device.serialNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 53 "C:\Users\ammar\OneDrive\Documents\files for me\cardio test\NurseManagmentSystem\NurseManagmentSystem\Views\Study\StudyList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.startTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 54 "C:\Users\ammar\OneDrive\Documents\files for me\cardio test\NurseManagmentSystem\NurseManagmentSystem\Views\Study\StudyList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.heartRates.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 59 "C:\Users\ammar\OneDrive\Documents\files for me\cardio test\NurseManagmentSystem\NurseManagmentSystem\Views\Study\StudyList.cshtml"
                             if (item.duration == 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"text-danger\">Ended</p>\r\n");
#nullable restore
#line 62 "C:\Users\ammar\OneDrive\Documents\files for me\cardio test\NurseManagmentSystem\NurseManagmentSystem\Views\Study\StudyList.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\ammar\OneDrive\Documents\files for me\cardio test\NurseManagmentSystem\NurseManagmentSystem\Views\Study\StudyList.cshtml"
                             if (item.duration == 1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"text-success\">OnGoing</p>\r\n");
#nullable restore
#line 66 "C:\Users\ammar\OneDrive\Documents\files for me\cardio test\NurseManagmentSystem\NurseManagmentSystem\Views\Study\StudyList.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <a type=\"button\" class=\"btn btn-primary open-chart\" data-toggle=\"modal\" data-id=\"");
#nullable restore
#line 70 "C:\Users\ammar\OneDrive\Documents\files for me\cardio test\NurseManagmentSystem\NurseManagmentSystem\Views\Study\StudyList.cshtml"
                                                                                                        Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-target=\"#heartRateModel\">View Graph</a> |\r\n\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 74 "C:\Users\ammar\OneDrive\Documents\files for me\cardio test\NurseManagmentSystem\NurseManagmentSystem\Views\Study\StudyList.cshtml"


                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>

<div class=""modal fade"" id=""heartRateModel"" tabindex=""-1"" role=""dialog"" aria-labelledby=""heartRateModelLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Heart Rate Graph</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be9e874442f83240095cfca2cea389ff182d0b8713434", async() => {
                WriteLiteral(@"
                <div class=""modal-body"">
                    <div id=""container""></div>
                    <input type=""hidden"" name=""sId"" id=""sId""/>
                    <input class=""form-control"" id=""comment"" type=""text"" name=""comment"" placeholder=""add comment"" />
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <input id=""Add"" type=""submit"" value=""Add"" class=""btn btn-primary"" />
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            \r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
<script>
    
    $(document).on(""click"", "".open-chart"", function () {
        var studyId = $(this).data('id');
        document.getElementById(""sId"").value = studyId;
        //console.log(studyId);
        $.getJSON(""/Study/ChartHeartRate/"", { id: studyId }, function (data) {
            var rates = [];
            for (var i = 0; i < data.length; i++) {
                rates.push(data[i].hr);
                //console.log(data[i].hr);
            }
            Highcharts.chart('container', {

                title: {
                    text: 'Chart Heart Rate'
                },

                subtitle: {
                    text: 'Chart Heart Rate'
                },

                yAxis: {
                    title: {
                        text: ''
                    }
                },

                xAxis: {
                    accessibility: {
                        rangeDescription: 'Range: 12 to 12'
                    }
                },

          ");
                WriteLiteral(@"      legend: {
                    layout: 'vertical',
                    align: 'right',
                    verticalAlign: 'middle'
                },

                plotOptions: {
                    series: {
                        label: {
                            connectorAllowed: false
                        },
                        pointStart: 0
                    }
                },

                series: [{
                    name: 'Heart Rate',
                    data: rates
                }, ],

               
                responsive: {
                    rules: [{
                        condition: {
                            maxWidth: 500
                        },
                        chartOptions: {
                            legend: {
                                layout: 'horizontal',
                                align: 'center',
                                verticalAlign: 'bottom'
                            }
            ");
                WriteLiteral("            }\r\n                    }]\r\n                }\r\n\r\n            }\r\n            );\r\n        });\r\n\r\n    });\r\n    \r\n</script>\r\n   \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NurseManagmentSystem.Models.Study>> Html { get; private set; }
    }
}
#pragma warning restore 1591
