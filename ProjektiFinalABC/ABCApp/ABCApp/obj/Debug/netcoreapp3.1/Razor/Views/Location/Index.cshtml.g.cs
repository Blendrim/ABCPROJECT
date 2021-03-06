#pragma checksum "D:\Projects\ABCAPP\ABCApp\ABCApp\Views\Location\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8335dacc603f167267078f50ef973a2a0e582388"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Location_Index), @"mvc.1.0.view", @"/Views/Location/Index.cshtml")]
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
#line 1 "D:\Projects\ABCAPP\ABCApp\ABCApp\Views\_ViewImports.cshtml"
using ABCApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\ABCAPP\ABCApp\ABCApp\Views\_ViewImports.cshtml"
using ABCApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8335dacc603f167267078f50ef973a2a0e582388", @"/Views/Location/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"806487b06d58bc4dedfe0e00a99e8891186a4be2", @"/Views/_ViewImports.cshtml")]
    public class Views_Location_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Projects\ABCAPP\ABCApp\ABCApp\Views\Location\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8335dacc603f167267078f50ef973a2a0e5823883529", async() => {
                WriteLiteral(@"
    <style>
        #semester {
            background-color: antiquewhite;
            width: 202px;
            padding: 10px;
        }

        #dates {
            display: flex;
            flex-direction: column;
            flex-wrap: nowrap;
            justify-content: space-around;
            align-items: flex-start;
            align-content: stretch;
        }

        button {
            margin-left: 20px;
        }

        #map-canvas {
            margin: 0;
            padding: 0;
            height: 100%;
        }
    </style>


");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8335dacc603f167267078f50ef973a2a0e5823885079", async() => {
                WriteLiteral(@"
    <div class=""modal fade"" id=""modalLocationForm"" studentId=""0"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel""
         aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"" style=""width:675px;"">
                <div class=""modal-header text-center"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body col-md-12"">
                    <div>
                        <input type=""hidden"" name=""LocationName"" id=""locationID""><br>
                    </div>

                    <div>
                        <label for=""locationName""> Name:</label>
                        <input type=""text"" name=""locationName"" id=""locationName""><br>
                    </div>

                    <div>
                        <label for=""address""> ");
                WriteLiteral(@"Address:</label>
                        <input type=""text"" name=""address"" id=""address""><br>
                    </div>


                    <div>
                        <label for=""cityId"">Choose a City:</label>
                        <select name=""cityName"" id=""cityId"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8335dacc603f167267078f50ef973a2a0e5823886770", async() => {
                    WriteLiteral("Please select City...");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
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

                    <div>
                        <label for=""longitudeId""> Longitude:</label>
                        <input type=""text"" id=""longitudeId"" />
                    </div>

                    <div>
                        <label for=""latitudeId"">Latitude:</label>
                        <input type=""text"" id=""latitudeId"" />
                    </div>



                </div>



                <div class=""modal-footer d-flex justify-content-center"">

                    <button class=""btn btn-primary"" id=""btnSaveLocationDetail"">Save</button>
                    <button class=""btn btn-danger"" id=""btnCancelLocationDetail"">Cancel</button>

                </div>
            </div>
        </div>
    </div>







    <h2>Locations Table</h2>

    <table class=""table table-hover"" id=""locations"">
        <thead>
            <tr>

                <th scope=""col"">Name</th>
                <th scop");
                WriteLiteral(@"e=""col"">Address</th>
                <th scope=""col"">City</th>
                <th scope=""col"">Latitude</th>
                <th scope=""col"">Longitude</th>
                <th scope=""col"">Delete Row</th>



            </tr>
        </thead>
        <tbody>

            <tr id=""locationId"">

                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>


            </tr>

        </tbody>
    </table>

    <button id=""btnAddLocation"" class=""btn btn-primary"">Create Location</button>


");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n\r\n\r\n    <script type=\"text/javascript\">\r\n\r\n        showAllLocations();\r\n        fillCities();\r\n\r\n            function showAllLocations() {\r\n\r\n                $.ajax({\r\n                    type: \"GET\",\r\n                    url: \'");
#nullable restore
#line 155 "D:\Projects\ABCAPP\ABCApp\ABCApp\Views\Location\Index.cshtml"
                     Write(Url.Action("GetAllLocations", "Location"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                    dataType: 'json',
                    success: function (result) {
                        var table = $(""#locations tbody"");

                        $.each(result.data, function (id, elem) {
                            table.append('<tr><td>' + '<a href=/LocationDetails/Index/' + elem.locationId + '>' + elem.name + '</a>' + '</td><td>' + elem.address + '</td><td>' + elem.cityName + '</td><td>' + elem.latitude + '</td><td>' + elem.longitude + '</td>' +
                                '<td>' + '<button type = ""button"" onclick=""deleteLocation(' + elem.locationId + ')""+  id =""delete""   class=""btn btn-danger"">' + ""Delete"" + '</td > ' + '</tr > ');

                        });

                    }
                });

            }


            // On click  Create Location btn

        $(document).ready(function ()
        {

                //Ngjarja kur te klikohet butoni Create
                $('button[id=btnAddLocation]').click(function () {
                 ");
                WriteLiteral(@"   debugger;
                    $(""#modalLocationForm"").modal('show');

                });

                //Ngjarja kur klikohet butoni save ne modal

                $('button[id=btnSaveLocationDetail]').click(function () {

                    var locationFromControls =
                    {
                        LocationId: $('#locationID').val(),
                        Name: $('#locationName').val(),
                        Address: $(""#address"").val(),
                        CityId: $('#cityId :selected').val(),
                        Longitude: $('#longitudeId').val(),
                        Latitude: $('#latitudeId').val(),


                    }
                    $.ajax({
                        type: ""POST"",
                        url: '");
#nullable restore
#line 201 "D:\Projects\ABCAPP\ABCApp\ABCApp\Views\Location\Index.cshtml"
                         Write(Url.Action("SaveLocationDetails", "Location"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                        dataType: 'json',
                        data: { l: locationFromControls },

                        success: function (result) {

                            alert(""Location  saved successfully!"");
                            $('#modalLocationForm').modal('hide');
                            location.reload();


                        }
                    });


                });

            $('button[id=btnCancelLocationDetail]').click(function () {
                $('#modalLocationForm').modal('hide');

            });

            });

            function deleteLocation(locationID) {

                if (confirm(""Are you sure you want to delete this?"")) {
                    $.ajax({
                        type: ""DELETE"",
                        url: '");
#nullable restore
#line 230 "D:\Projects\ABCAPP\ABCApp\ABCApp\Views\Location\Index.cshtml"
                         Write(Url.Action("DeleteLocation", "Location"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                        dataType: 'json',
                        data: { locationId: locationID },
                        success: function (result) {
                            alert(""Deleted Successfully"");
                            location.reload();

                        }
                    });




                }

            }

            function fillCities() {
                debugger;
                $.ajax({
                    type: ""GET"",
                    url: '");
#nullable restore
#line 251 "D:\Projects\ABCAPP\ABCApp\ABCApp\Views\Location\Index.cshtml"
                     Write(Url.Action("GetAllCities", "Location"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                    dataType: 'json',
                    success: function (result) {
                        $(result.data).each(function () {
                            var aa = result.data;
                            var option = $('<option />');
                            option.attr('value', this.cityId).text(this.name);

                            $('#cityId').append(option);
                        });

                    }
                });

            }


    </script>





");
            }
            );
            WriteLiteral("\r\n\r\n");
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
