#pragma checksum "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd846678ca89e00f5d00eb6cbabd12dad15985cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Reservations_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Reservations/Details.cshtml")]
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
#line 1 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\_ViewImports.cshtml"
using ReservationRestaurantAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\_ViewImports.cshtml"
using ReservationRestaurantAdmin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd846678ca89e00f5d00eb6cbabd12dad15985cb", @"/Areas/Admin/Views/Reservations/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d0e554417c8c77bada32b4f8f5ef1789f3dd69e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Reservations_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReservationRestaurantAdmin.Models.Reservation>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary m-r-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3 >Details of Booking ID: ");
#nullable restore
#line 7 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Details.cshtml"
                           Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
<div class=""card-body"">
    <div class=""table-responsive"">
        <table class=""product-info-table m-t-20"">
            <tbody>
                <tr>
                    <td>ID</td>
                    <td class=""text-dark font-weight-semibold"">");
#nullable restore
#line 14 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Details.cshtml"
                                                          Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Phone</td>\r\n                    <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 18 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Details.cshtml"
                                                          Write(Model.IdNavigation.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Name</td>\r\n                    <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 22 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Details.cshtml"
                                                          Write(Model.IdNavigation.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Date</td>\r\n                    <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 26 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Details.cshtml"
                                                          Write(Model.Date.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Start Time</td>\r\n                    <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 30 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Details.cshtml"
                                                          Write(Model.StartTime.Value.ToString("hh:mm:ss tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>End Time</td>\r\n                    <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 34 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Details.cshtml"
                                                          Write(Model.EndTime.Value.ToString("hh:mm:ss tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Number Guest</td>\r\n                    <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 38 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Details.cshtml"
                                                          Write(Model.NumGuest);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Description</td>\r\n                    <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 42 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Details.cshtml"
                                                          Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Price</td>\r\n                    <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 46 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Details.cshtml"
                                                          Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Discount</td>\r\n                    <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 50 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Details.cshtml"
                                                          Write(Model.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n\r\n\r\n");
#nullable restore
#line 54 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Details.cshtml"
                 if (string.IsNullOrEmpty(Model.PhoneGuest))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>PhoneGuest</td>\r\n                        <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 58 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Details.cshtml"
                                                              Write(Model.IdNavigation.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 60 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Details.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>PhoneGuest</td>\r\n                        <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 65 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Details.cshtml"
                                                              Write(Model.PhoneGuest);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 67 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Details.cshtml"
                 if (string.IsNullOrEmpty(Model.Feedback))
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>Feedback</td>\r\n                        <td class=\"text-dark font-weight-semibold\"> Chưa có feedback </td>\r\n                    </tr>\r\n");
#nullable restore
#line 75 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Details.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>Feedback</td>\r\n                        <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 80 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Details.cshtml"
                                                              Write(Model.Feedback);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    </tr>\r\n");
#nullable restore
#line 82 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 86 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Details.cshtml"
                 if (Model.Status.Equals(true))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>Status</td>\r\n                        <td style=\"color:green\" class=\"text-dark font-weight-semibold\">Approved</td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 93 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Details.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>Status</td>\r\n                        <td style=\"color:red\" class=\"text-dark font-weight-semibold\">Pending</td>\r\n                    </tr>\r\n");
#nullable restore
#line 100 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </tbody>\r\n        </table>\r\n\r\n    </div>\r\n   \r\n        <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd846678ca89e00f5d00eb6cbabd12dad15985cb14911", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 109 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Details.cshtml"
                                                                    WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd846678ca89e00f5d00eb6cbabd12dad15985cb17232", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    \r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReservationRestaurantAdmin.Models.Reservation> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591