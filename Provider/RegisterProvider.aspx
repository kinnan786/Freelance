<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="RegisterProvider.aspx.cs" Inherits="Provider_RegisterProvider" %>

<%@ MasterType VirtualPath="~/Site.master" %>
<asp:Content ID="RegisterProviderHeadContent" ContentPlaceHolderID="MasterHeadContent"
    runat="Server">
</asp:Content>
<asp:Content ID="RegisterProviderMainContent" ContentPlaceHolderID="MasterMainContent"
    runat="Server">
    <div class="MiddleCenterAlign">
        <table class="TableStyle" width="400px">
            <tr>
                <th style=" width:20px;">
                    &nbsp;</th>
                <th>
                    &nbsp;
                </th>
               <th>
                    &nbsp;
                </th>
               <th>
                    &nbsp;
                </th>
            </tr>
            <tr>
                <td >
                 
                   </td>
                   <td colspan="2" style=" text-align:center;">
                   Registration is Currently closed at the moment kindly Put your Credential . You will be contacted when Registrations are open<br />
                   Thank You
                   </td>
                   <td></td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    First Name *&nbsp;
                </td>
                <td>
                    <asp:TextBox ID="TxtFirstName" runat="server" Width="200px" MaxLength="50" 
                        ValidationGroup="A"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldFirstName" runat="server" Text="*" 
                        ControlToValidate="TxtFirstName" ValidationGroup="A"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
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
                    &nbsp;</td>
                <td>
                    Last Name *&nbsp;
                </td>
                <td>
                    <asp:TextBox ID="TxtLastName" runat="server" Width="200px" MaxLength="50" 
                        ValidationGroup="A"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldLastName" runat="server" Text="*" 
                        ControlToValidate="TxtLastName" ValidationGroup="A"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
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
                    &nbsp;</td>
                <td>
                    Country *&nbsp;
                </td>
                <td>
                 <asp:DropDownList ID="DListCountry" runat="server" Width="200px" ValidationGroup="A">
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
              
                    <asp:RequiredFieldValidator ID="RequiredFieldCountry" runat="server" Text="*" 
                        ControlToValidate="DListCountry" ValidationGroup="A"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
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
                    &nbsp;</td>
                <td>
                    Email *&nbsp;
                </td>
                <td>
                    <asp:TextBox ID="TxtEmail" runat="server" Width="200px" ValidationGroup="A"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldEmail" runat="server" Text="*" 
                        ControlToValidate="TxtEmail" ValidationGroup="A"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
<%--            <tr>
                <td>
                    &nbsp;</td>
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
                    &nbsp;</td>
                <td>
                    Password *&nbsp;
                </td>
                <td>
                    <asp:TextBox ID="TxtRPassword" runat="server" Width="200px" MaxLength="50" 
                        TextMode="Password" ValidationGroup="A"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldPassword" runat="server" Text="*" 
                        ControlToValidate="TxtRPassword" ValidationGroup="A"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
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
                    &nbsp;</td>
                <td>
                    Retype Password *&nbsp;
                </td>
                <td>
                    <asp:TextBox ID="TxtRRetypePassword" runat="server" Width="200px" 
                        MaxLength="50" TextMode="Password" ValidationGroup="A"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldVRetypePassword" runat="server" 
                        Text="*" ControlToValidate="TxtRRetypePassword" ValidationGroup="A"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;
                </td>--%>
                <tr>
                <td></td>
                <td></td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" 
                        runat="server" ControlToValidate="TxtEmail"
                        ErrorMessage="Email Not In Correct Format" SetFocusOnError="True" 
                        ValidationGroup="A" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    <br />
                 <%--   <asp:CompareValidator ID="CompareValidatorPassword" runat="server" 
                        ControlToCompare="TxtRPassword" ControlToValidate="TxtRRetypePassword" 
                        ErrorMessage="Password Donot Match" SetFocusOnError="True" 
                        ValidationGroup="A"></asp:CompareValidator>--%>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;
                </td>
                <td>
                    <asp:Button ID="BtnRegister" runat="server" Text="Send Request" Width="100px" 
                        OnClick="BtnRegister_Click" ValidationGroup="A" />
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </div>
</asp:Content>
