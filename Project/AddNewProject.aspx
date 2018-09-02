<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="AddNewProject.aspx.cs" Inherits="Project_AddNewProject" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ MasterType VirtualPath="~/Site.master" %>
<asp:Content ID="AddNewProjectHeadContent" ContentPlaceHolderID="MasterHeadContent"
    runat="Server">
    <script type="text/javascript" language="javascript">
        function ShowCountry(flag) {
            if (flag == false) {
                document.getElementById("TblCountry").style.display = "none";
                document.getElementById("<%= drplstCountry.ClientID%>").options[0].selected = "selected";
            }
            else
                document.getElementById("TblCountry").style.display = "block";

        }

        function ShowStartDateTextBox(flag) {
            if (flag == false) {
                document.getElementById("<%= TxtStartDate.ClientID%>").value = "";
                document.getElementById("<%= TxtStartDate.ClientID%>").style.display = "none";
            }
            else {
                document.getElementById("<%= TxtStartDate.ClientID%>").style.display = "block";
            }
        }

    </script>
</asp:Content>
<asp:Content ID="AddNewProjectMainContent" ContentPlaceHolderID="MasterMainContent"
    runat="Server">
    <table width="100%" class="gray_container">
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <b>Project Name</b>
            </td>
            <td>
                <asp:TextBox ID="TxtProjectName" Width="250px" runat="server" ValidationGroup="A"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RqrfldvalProjectName" runat="server" ControlToValidate="TxtProjectName"
                    ErrorMessage="sdfsdfds" SetFocusOnError="True">*</asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <b>Category</b>
            </td>
            <td>
                <asp:UpdatePanel runat="server" ID="UpdatePanel2" UpdateMode="Conditional">
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="DrpdlstCategory" EventName="SelectedIndexChanged" />
                    </Triggers>
                    <ContentTemplate>
                        <asp:Label ID="LblCategory" runat="server" Visible="false"></asp:Label>
                        
                        <asp:DropDownList ID="DrpdlstCategory" runat="server" Width="250px" AutoPostBack="true" DataTextField="CategoryName" DataValueField="CategoryId"
                            OnSelectedIndexChanged="DrpdlstCategory_SelectedIndexChanged" ValidationGroup="A" AppendDataBoundItems="true">
                            <asp:ListItem Value="0" Selected="True">--- Select Category ---</asp:ListItem>
                        </asp:DropDownList>

                        <%--<asp:CompareValidator ID="CmpvalCategory" runat="server" ControlToValidate="DrpdlstCategory"
                            ErrorMessage="*" SetFocusOnError="True" ValidationGroup="A" ValueToCompare="--- Select Category ---"></asp:CompareValidator>--%>
                        <br />
                        <table>
                            <tr>
                                <td>
                                    <b>Sub Category</b>
                                </td>
                                <td>
                                    <asp:Label ID="Lblsubcategory" runat="server" Visible="false"></asp:Label>
                                    <asp:DropDownList ID="DrpdlstSubcategory" DataTextField="SubCategoryName" DataValueField="SubCategoryId"
                                        runat="server" Width="250px" >
                                        <asp:ListItem Selected="True" Value="0">--- Select SubCategory ---</asp:ListItem>
                                    </asp:DropDownList>
                                    <%--<asp:CompareValidator ID="Cmpvalsubcategory" runat="server" ControlToValidate="DrpdlstSubcategory"
                                        ErrorMessage="*" SetFocusOnError="True" ValidationGroup="A" ValueToCompare="--- Select SubCategory ---">*</asp:CompareValidator>--%>
                                </td>
                            </tr>
                        </table>
                   </ContentTemplate>
                </asp:UpdatePanel>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td valign="top">
                <b>Skill</b>
            </td>
            <td>
                <asp:UpdatePanel runat="server" ID="UpdtPanelSkill" UpdateMode="Conditional">
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="BtnAddskill" EventName="Click" />
                    </Triggers>
                    <ContentTemplate>
                        <asp:TextBox ID="TxtSkill" runat="server" Width="250px" ValidationGroup="B"></asp:TextBox>
                        <asp:Button ID="BtnAddskill" runat="server" Text="Add skill" OnClick="BtnAddskill_Click"
                            ValidationGroup="B" />
                        <br />
                        <asp:ListBox ID="ListBoxSkills" runat="server" Width="250px" Height="90px" ValidationGroup="B"
                            OnSelectedIndexChanged="ListBoxSkills_SelectedIndexChanged"></asp:ListBox>
                        <asp:Button ID="BtnRemoveSkill" runat="server" OnClick="BtnRemoveSkill_Click" Text="Remove"
                            ValidationGroup="B" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <b>Budget</b>
            </td>
            <td>
                <asp:UpdatePanel runat="server" ID="UpdatePanel1" UpdateMode="Conditional">
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="DdlBudget" EventName="SelectedIndexChanged" />
                    </Triggers>
                    <ContentTemplate>
                        <asp:DropDownList ID="DdlBudget" runat="server" Width="250px" ValidationGroup="A"
                            OnSelectedIndexChanged="DdlBudget_SelectedIndexChanged" AutoPostBack="true">
                            <asp:ListItem Value="--- Select Budget ---">--- Select Budget ---</asp:ListItem>
                            <asp:ListItem Value="Less than $100">Less than $100</asp:ListItem>
                            <asp:ListItem Value="Less than $500">Less than $500</asp:ListItem>
                            <asp:ListItem Value="Between $500 and $1000">Between $500 and $1000</asp:ListItem>
                            <asp:ListItem Value="Between $1000 and $5000">Between $1000 and $5000</asp:ListItem>
                            <asp:ListItem Value="Between $5000 and $10,000">Between $5000 and $10,000</asp:ListItem>
                            <asp:ListItem Value="More Than $10,000">More Than $10,000</asp:ListItem>
                            <asp:ListItem Value="Not Sure">Not Sure</asp:ListItem>
                            <asp:ListItem Value="Enter My Own Ranges">Enter My Own Ranges</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RqrfldvalTxtBudget" runat="server" ControlToValidate="DdlBudget"
                            ErrorMessage="*" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Budget Not Selected"
                            ValidationGroup="A" ValueToCompare="--- Select Budget ---" ControlToValidate="DdlBudget"
                            Operator="NotEqual">*</asp:CompareValidator>
                        <br />
                        <table>
                            <tr>
                                <td>
                                    <%-- <asp:DropDownList ID="DdlOwnRange" runat="server" Width="170px" ValidationGroup="A" Visible="false" Enabled="true" >
                                    <asp:ListItem Value="--- Select Budget ---">--- Select Budget ---</asp:ListItem>
                                    <asp:ListItem Value="Less than">Less than</asp:ListItem>
                                    <asp:ListItem Value="Greater than">Greater than</asp:ListItem>
                                    <asp:ListItem Value="Equal">Equal</asp:ListItem>
                                </asp:DropDownList>--%>
                                    <label id="LblMyownRange" runat="server" visible="false">
                                        <b>My Budget</b></label>&nbsp;&nbsp;
                                    <asp:TextBox ID="TxtOwnRange" runat="server" Width="70px" ValidationGroup="A" Visible="false"
                                        Enabled="true"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="TxtOwnRangeRequiredFieldValidator" ControlToValidate="TxtOwnRange"
                                        runat="server" ErrorMessage="Range Required" Text="*" ValidationGroup="A" ></asp:RequiredFieldValidator>
                                    <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ValidationGroup="A" Visible="false" Enabled="true"
                                    ControlToValidate="DdlBudget" ErrorMessage="*" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                                <asp:CompareValidator ID="CompareValidator2" runat="server" 
                                    ErrorMessage="Budget Not Selected" ValidationGroup="A" Visible="false" Enabled="true"
                                    ValueToCompare="--- Select Budget ---" ControlToValidate="DdlBudget" 
                                    Operator="NotEqual">*</asp:CompareValidator>--%>
                                </td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <b>Bid Open Till</b>
            </td>
            <td>
                <asp:TextBox ID="TxtBidOpenTill" runat="server" Width="220px" ValidationGroup="A" ></asp:TextBox>
                <asp:ImageButton ID="ImgBtCalender" ImageUrl="~/Images/calendar_icon.png" ValidationGroup="C" runat="server" />
               <asp:RequiredFieldValidator ID="RqrfldvalBidOpenTill" runat="server" ControlToValidate="TxtBidOpenTill"
                    ErrorMessage="*" SetFocusOnError="True" >*</asp:RequiredFieldValidator>
                <asp:CalendarExtender runat="server" ID="calenderextender" PopupButtonID="ImgBtCalender"
                    TargetControlID="TxtBidOpenTill"  Format="MM/dd/yyyy">
                </asp:CalendarExtender>
                <br />
               <asp:RangeValidator runat="server" ID="RangeValidator1" Type="Date" ControlToValidate="TxtBidOpenTill" Display="Dynamic" />
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <b>Attachments</b>
            </td>
            <td>
                &nbsp;<asp:FileUpload ID="FileUpload1" runat="server" Width="250px" />
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td valign="top">
                <b>location</b>
            </td>
            <td>
                <asp:RadioButton ID="RadioBtnPrefrence" runat="server" Text="No Preference" Checked="True"
                    GroupName="Location" OnCheckedChanged="RadioBtnPrefrence_CheckedChanged" onclick="ShowCountry(False)" />
                <br />
                <asp:RadioButton ID="RadioBtnPreferredlocation" runat="server" Text="Preferred Location"
                    GroupName="Location" OnCheckedChanged="RadioBtnPreferredlocation_CheckedChanged"
                    onclick="ShowCountry(True)" />
                <table id="TblCountry" width="100%" style="display: none;">
                    <tr>
                        <td>
                            <b>Country</b>
                        </td>
                        <td>
                            <asp:DropDownList ID="drplstCountry" Width="250px" runat="server">
                                <asp:ListItem Value="--- Select Country ---">--- Select Country ---</asp:ListItem>
                                <asp:ListItem Value="Albania">Albania</asp:ListItem>
                                <asp:ListItem Value="Algeria">Algeria</asp:ListItem>
                                <asp:ListItem Value="American Samoa">American Samoa</asp:ListItem>
                                <asp:ListItem Value="Andorra">Andorra</asp:ListItem>
                                <asp:ListItem Value="Angola">Angola</asp:ListItem>
                                <asp:ListItem Value="Anguilla">Anguilla</asp:ListItem>
                                <asp:ListItem Value="Antigua">Antigua</asp:ListItem>
                                <asp:ListItem Value="Argentina">Argentina</asp:ListItem>
                                <asp:ListItem Value="Armenia">Armenia</asp:ListItem>
                                <asp:ListItem Value="Aruba">Aruba</asp:ListItem>
                                <asp:ListItem Value="Australia">Australia</asp:ListItem>
                                <asp:ListItem Value="Austria">Austria</asp:ListItem>
                                <asp:ListItem Value="Azerbaijan">Azerbaijan</asp:ListItem>
                                <asp:ListItem Value="Bahamas">Bahamas</asp:ListItem>
                                <asp:ListItem Value="Bahrain">Bahrain</asp:ListItem>
                                <asp:ListItem Value="Bangladesh">Bangladesh</asp:ListItem>
                                <asp:ListItem Value="Barbados">Barbados</asp:ListItem>
                                <asp:ListItem Value="Barbuda">Barbuda</asp:ListItem>
                                <asp:ListItem Value="Belgium">Belgium</asp:ListItem>
                                <asp:ListItem Value="Belize">Belize</asp:ListItem>
                                <asp:ListItem Value="Benin">Benin</asp:ListItem>
                                <asp:ListItem Value="Bermuda">Bermuda</asp:ListItem>
                                <asp:ListItem Value="Bhutan">Bhutan</asp:ListItem>
                                <asp:ListItem Value="Bolivia">Bolivia</asp:ListItem>
                                <asp:ListItem Value="Bonaire">Bonaire</asp:ListItem>
                                <asp:ListItem Value="Botswana">Botswana</asp:ListItem>
                                <asp:ListItem Value="Brazil">Brazil</asp:ListItem>
                                <asp:ListItem Value="Virgin islands">British Virgin isl.</asp:ListItem>
                                <asp:ListItem Value="Brunei">Brunei</asp:ListItem>
                                <asp:ListItem Value="Bulgaria">Bulgaria</asp:ListItem>
                                <asp:ListItem Value="Burundi">Burundi</asp:ListItem>
                                <asp:ListItem Value="Cambodia">Cambodia</asp:ListItem>
                                <asp:ListItem Value="Cameroon">Cameroon</asp:ListItem>
                                <asp:ListItem Value="Canada">Canada</asp:ListItem>
                                <asp:ListItem Value="Cape Verde">Cape Verde</asp:ListItem>
                                <asp:ListItem Value="Cayman isl">Cayman Islands</asp:ListItem>
                                <asp:ListItem Value="Central African Rep">Central African Rep.</asp:ListItem>
                                <asp:ListItem Value="Chad">Chad</asp:ListItem>
                                <asp:ListItem Value="Channel isl">Channel Islands</asp:ListItem>
                                <asp:ListItem Value="Chile">Chile</asp:ListItem>
                                <asp:ListItem Value="China">China</asp:ListItem>
                                <asp:ListItem Value="Colombia">Colombia</asp:ListItem>
                                <asp:ListItem Value="Congo">Congo</asp:ListItem>
                                <asp:ListItem Value="cook isl">Cook Islands</asp:ListItem>
                                <asp:ListItem Value="Costa Rica">Costa Rica</asp:ListItem>
                                <asp:ListItem Value="Croatia">Croatia</asp:ListItem>
                                <asp:ListItem Value="Curacao">Curacao</asp:ListItem>
                                <asp:ListItem Value="Cyprus">Cyprus</asp:ListItem>
                                <asp:ListItem Value="Czech Republic">Czech Republic</asp:ListItem>
                                <asp:ListItem Value="Denmark">Denmark</asp:ListItem>
                                <asp:ListItem Value="Djibouti">Djibouti</asp:ListItem>
                                <asp:ListItem Value="Dominica">Dominica</asp:ListItem>
                                <asp:ListItem Value="Dominican Republic">Dominican Republic</asp:ListItem>
                                <asp:ListItem Value="Ecuador">Ecuador</asp:ListItem>
                                <asp:ListItem Value="Egypt">Egypt</asp:ListItem>
                                <asp:ListItem Value="El Salvador">El Salvador</asp:ListItem>
                                <asp:ListItem Value="Equatorial Guinea">Equatorial Guinea</asp:ListItem>
                                <asp:ListItem Value="Eritrea">Eritrea</asp:ListItem>
                                <asp:ListItem Value="Estonia">Estonia</asp:ListItem>
                                <asp:ListItem Value="Ethiopia">Ethiopia</asp:ListItem>
                                <asp:ListItem Value="Faeroe isl">Faeroe Islands</asp:ListItem>
                                <asp:ListItem Value="Fiji">Fiji</asp:ListItem>
                                <asp:ListItem Value="Finland">Finland</asp:ListItem>
                                <asp:ListItem Value="France">France</asp:ListItem>
                                <asp:ListItem Value="French Guiana">French Guiana</asp:ListItem>
                                <asp:ListItem Value="French Polynesia">French Polynesia</asp:ListItem>
                                <asp:ListItem Value="Gabon">Gabon</asp:ListItem>
                                <asp:ListItem Value="Gambia">Gambia</asp:ListItem>
                                <asp:ListItem Value="Georgia">Georgia</asp:ListItem>
                                <asp:ListItem Value="Gemany">Germany</asp:ListItem>
                                <asp:ListItem Value="Ghana">Ghana</asp:ListItem>
                                <asp:ListItem Value="Gibraltar">Gibraltar</asp:ListItem>
                                <asp:ListItem Value="GB">Great Britain</asp:ListItem>
                                <asp:ListItem Value="Greece">Greece</asp:ListItem>
                                <asp:ListItem Value="Greenland">Greenland</asp:ListItem>
                                <asp:ListItem Value="Grenada">Grenada</asp:ListItem>
                                <asp:ListItem Value="Guadeloupe">Guadeloupe</asp:ListItem>
                                <asp:ListItem Value="Guam">Guam</asp:ListItem>
                                <asp:ListItem Value="Guatemala">Guatemala</asp:ListItem>
                                <asp:ListItem Value="Guinea">Guinea</asp:ListItem>
                                <asp:ListItem Value="Guinea Bissau">Guinea Bissau</asp:ListItem>
                                <asp:ListItem Value="Guyana">Guyana</asp:ListItem>
                                <asp:ListItem Value="Haiti">Haiti</asp:ListItem>
                                <asp:ListItem Value="Honduras">Honduras</asp:ListItem>
                                <asp:ListItem Value="Hong Kong">Hong Kong</asp:ListItem>
                                <asp:ListItem Value="Hungary">Hungary</asp:ListItem>
                                <asp:ListItem Value="Iceland">Iceland</asp:ListItem>
                                <asp:ListItem Value="India">India</asp:ListItem>
                                <asp:ListItem Value="Indonesia">Indonesia</asp:ListItem>
                                <asp:ListItem Value="Irak">Irak</asp:ListItem>
                                <asp:ListItem Value="Iran">Iran</asp:ListItem>
                                <asp:ListItem Value="Ireland">Ireland</asp:ListItem>
                                <asp:ListItem Value="Northern Ireland">Ireland, Northern</asp:ListItem>
                                <asp:ListItem Value="Israel">Israel</asp:ListItem>
                                <asp:ListItem Value="Italy">Italy</asp:ListItem>
                                <asp:ListItem Value="Ivory Coast">Ivory Coast</asp:ListItem>
                                <asp:ListItem Value="Jamaica">Jamaica</asp:ListItem>
                                <asp:ListItem Value="Japan">Japan</asp:ListItem>
                                <asp:ListItem Value="Jordan">Jordan</asp:ListItem>
                                <asp:ListItem Value="Kazakhstan">Kazakhstan</asp:ListItem>
                                <asp:ListItem Value="Kenya">Kenya</asp:ListItem>
                                <asp:ListItem Value="Kuwait">Kuwait</asp:ListItem>
                                <asp:ListItem Value="Kyrgyzstan">Kyrgyzstan</asp:ListItem>
                                <asp:ListItem Value="Latvia">Latvia</asp:ListItem>
                                <asp:ListItem Value="Lebanon">Lebanon</asp:ListItem>
                                <asp:ListItem Value="Liberia">Liberia</asp:ListItem>
                                <asp:ListItem Value="Liechtenstein">Liechtenstein</asp:ListItem>
                                <asp:ListItem Value="Lithuania">Lithuania</asp:ListItem>
                                <asp:ListItem Value="Luxembourg">Luxembourg</asp:ListItem>
                                <asp:ListItem Value="Macau">Macau</asp:ListItem>
                                <asp:ListItem Value="Macedonia">Macedonia</asp:ListItem>
                                <asp:ListItem Value="Madagascar">Madagascar</asp:ListItem>
                                <asp:ListItem Value="Malawi">Malawi</asp:ListItem>
                                <asp:ListItem Value="Malaysia">Malaysia</asp:ListItem>
                                <asp:ListItem Value="Maldives">Maldives</asp:ListItem>
                                <asp:ListItem Value="Mali">Mali</asp:ListItem>
                                <asp:ListItem Value="Malta">Malta</asp:ListItem>
                                <asp:ListItem Value="Marshall isl">Marshall Islands</asp:ListItem>
                                <asp:ListItem Value="Martinique">Martinique</asp:ListItem>
                                <asp:ListItem Value="Mauritania">Mauritania</asp:ListItem>
                                <asp:ListItem Value="Mauritius">Mauritius</asp:ListItem>
                                <asp:ListItem Value="Mexico">Mexico</asp:ListItem>
                                <asp:ListItem Value="Micronesia">Micronesia</asp:ListItem>
                                <asp:ListItem Value="Moldova">Moldova</asp:ListItem>
                                <asp:ListItem Value="Monaco">Monaco</asp:ListItem>
                                <asp:ListItem Value="Mongolia">Mongolia</asp:ListItem>
                                <asp:ListItem Value="Montserrat">Montserrat</asp:ListItem>
                                <asp:ListItem Value="Morocco">Morocco</asp:ListItem>
                                <asp:ListItem Value="Mozambique">Mozambique</asp:ListItem>
                                <asp:ListItem Value="Myanmar">Myanmar/Burma</asp:ListItem>
                                <asp:ListItem Value="Namibia">Namibia</asp:ListItem>
                                <asp:ListItem Value="Nepal">Nepal</asp:ListItem>
                                <asp:ListItem Value="Netherlands">Netherlands</asp:ListItem>
                                <asp:ListItem Value="Netherlands Antilles">Netherlands Antilles</asp:ListItem>
                                <asp:ListItem Value="New Caledonia">New Caledonia</asp:ListItem>
                                <asp:ListItem Value="New Zealand">New Zealand</asp:ListItem>
                                <asp:ListItem Value="Nicaragua">Nicaragua</asp:ListItem>
                                <asp:ListItem Value="Niger">Niger</asp:ListItem>
                                <asp:ListItem Value="Nigeria">Nigeria</asp:ListItem>
                                <asp:ListItem Value="Norway">Norway</asp:ListItem>
                                <asp:ListItem Value="Oman">Oman</asp:ListItem>
                                <asp:ListItem Value="Palau">Palau</asp:ListItem>
                                <asp:ListItem Value="Panama">Panama</asp:ListItem>
                                <asp:ListItem Value="Papua New Guinea">Papua New Guinea</asp:ListItem>
                                <asp:ListItem Value="Paraguay">Paraguay</asp:ListItem>
                                <asp:ListItem Value="Peru">Peru</asp:ListItem>
                                <asp:ListItem Value="Philippines">Philippines</asp:ListItem>
                                <asp:ListItem Value="Poland">Poland</asp:ListItem>
                                <asp:ListItem Value="Portugal">Portugal</asp:ListItem>
                                <asp:ListItem Value="Puerto Rico">Puerto Rico</asp:ListItem>
                                <asp:ListItem Value="Qatar">Qatar</asp:ListItem>
                                <asp:ListItem Value="Reunion">Reunion</asp:ListItem>
                                <asp:ListItem Value="Rwanda">Rwanda</asp:ListItem>
                                <asp:ListItem Value="Saba">Saba</asp:ListItem>
                                <asp:ListItem Value="Saipan">Saipan</asp:ListItem>
                                <asp:ListItem Value="Saudi Arabia">Saudi Arabia</asp:ListItem>
                                <asp:ListItem Value="Scotland">Scotland</asp:ListItem>
                                <asp:ListItem Value="Senegal">Senegal</asp:ListItem>
                                <asp:ListItem Value="Seychelles">Seychelles</asp:ListItem>
                                <asp:ListItem Value="Sierra Leone">Sierra Leone</asp:ListItem>
                                <asp:ListItem Value="Singapore">Singapore</asp:ListItem>
                                <asp:ListItem Value="Slovac Republic">Slovak Republic</asp:ListItem>
                                <asp:ListItem Value="Slovenia">Slovenia</asp:ListItem>
                                <asp:ListItem Value="South Africa">South Africa</asp:ListItem>
                                <asp:ListItem Value="South Korea">South Korea</asp:ListItem>
                                <asp:ListItem Value="Spain">Spain</asp:ListItem>
                                <asp:ListItem Value="Sri Lanka">Sri Lanka</asp:ListItem>
                                <asp:ListItem Value="Sudan">Sudan</asp:ListItem>
                                <asp:ListItem Value="Suriname">Suriname</asp:ListItem>
                                <asp:ListItem Value="Swaziland">Swaziland</asp:ListItem>
                                <asp:ListItem Value="Sweden">Sweden</asp:ListItem>
                                <asp:ListItem Value="Switzerland">Switzerland</asp:ListItem>
                                <asp:ListItem Value="Syria">Syria</asp:ListItem>
                                <asp:ListItem Value="Taiwan">Taiwan</asp:ListItem>
                                <asp:ListItem Value="Tanzania">Tanzania</asp:ListItem>
                                <asp:ListItem Value="Thailand">Thailand</asp:ListItem>
                                <asp:ListItem Value="Togo">Togo</asp:ListItem>
                                <asp:ListItem Value="Trinidad-Tobago">Trinidad-Tobago</asp:ListItem>
                                <asp:ListItem Value="Tunesia">Tunisia</asp:ListItem>
                                <asp:ListItem Value="Turkey">Turkey</asp:ListItem>
                                <asp:ListItem Value="Turkmenistan">Turkmenistan</asp:ListItem>
                                <asp:ListItem Value="United Arab Emirates">United Arab Emirates</asp:ListItem>
                                <asp:ListItem Value="U.S. Virgin isl">U.S. Virgin Islands</asp:ListItem>
                                <asp:ListItem Value="U.S.A">U.S.A.</asp:ListItem>
                                <asp:ListItem Value="Uganda">Uganda</asp:ListItem>
                                <asp:ListItem Value="United Kingdom">United Kingdom</asp:ListItem>
                                <asp:ListItem Value="Urugay">Uruguay</asp:ListItem>
                                <asp:ListItem Value="Uzbekistan">Uzbekistan</asp:ListItem>
                                <asp:ListItem Value="Vanuatu">Vanuatu</asp:ListItem>
                                <asp:ListItem Value="Vatican City">Vatican City</asp:ListItem>
                                <asp:ListItem Value="Venezuela">Venezuela</asp:ListItem>
                                <asp:ListItem Value="Vietnam">Vietnam</asp:ListItem>
                                <asp:ListItem Value="Wales">Wales</asp:ListItem>
                                <asp:ListItem Value="Yemen">Yemen</asp:ListItem>
                                <asp:ListItem Value="Zaire">Zaire</asp:ListItem>
                                <asp:ListItem Value="Zambia">Zambia</asp:ListItem>
                                <asp:ListItem Value="Zimbabwe">Zimbabwe</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="Lbl" runat="server" Visible="false" ForeColor="Red">Country Not selected</asp:Label>
                        </td>
                    </tr>
                </table>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <b>Planned Start</b>
            </td>
            <td>
                <asp:RadioButton ID="RdBtnStartImmediately" runat="server" Text="Start Immediately"
                    ValidationGroup="A" Checked="True" GroupName="Plannedstart" />
                <br />
               
                <asp:RadioButton ID="RdioBtnStartDate" runat="server" Text="Planned Start" ValidationGroup="A"
                    GroupName="Plannedstart"/>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TxtStartDate" runat="server" Width="100px" ValidationGroup="A" ReadOnly="true" style="display: none;"></asp:TextBox>
                &nbsp; 
                <asp:CalendarExtender runat="server" ID="CalendarExtender1" PopupButtonID="TxtStartDate"
                    TargetControlID="TxtStartDate" Format="dd/MM/yyyy">
                </asp:CalendarExtender>
               
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <b>Description</b>
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <CKEditor:CKEditorControl ID="TxtDescription" Width="100%" Height="200px" 
                    runat="server" ValidationGroup="A"></CKEditor:CKEditorControl>
                <%-- <asp:TextBox ID="TxtDescription" runat="server" Width="100%" ValidationGroup="A"
                    Height="200px" TextMode="MultiLine" MaxLength="10000"></asp:TextBox>--%>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                <asp:Button ID="BtnPost" runat="server" Text="Post" Width="150px" OnClick="BtnPost_Click" />
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <%--<asp:ObjectDataSource ID="ObjectDataSourceCategory" runat="server" 
        SelectMethod="GetAllSkillCategory" TypeName="SkillCategoryBL">
    </asp:ObjectDataSource>--%>
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <%-- <asp:ObjectDataSource ID="ObjectDataSourceSkill" runat="server" 
        SelectMethod="GetSkillByCategory" TypeName="ProviderSkillBL">
        <SelectParameters>
            <asp:ControlParameter ControlID="DllCategory" Name="SkillCategoryId" 
                PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>--%>
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
    </table>
</asp:Content>
