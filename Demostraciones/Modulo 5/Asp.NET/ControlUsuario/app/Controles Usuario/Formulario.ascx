<%@ Control Language="C#" 
            AutoEventWireup="true" 
            CodeFile="~/app/Controles Usuario/Formulario.ascx.cs"
            CodeBehind="~/app/Controles Usuario/Formulario.ascx.cs"
            Inherits="app_Controles_Usuario_Formulario" %>
<table>
    <tr>
        <td> Nombre </td>
        <td> 
            <asp:TextBox ID="tbNombre" 
                            MaxLength="100"
                            runat="server" /> 
            <asp:RequiredFieldValidator ID="rfvNombre" 
                                        runat="server" 
                                        Display="Dynamic"
                                        ForeColor="Red"
                                        ValidationGroup="Curso"
                                        ControlToValidate="tbNombre" />

            <asp:CustomValidator ID="cvNombre" 
                                    runat="server"
                                    ValidationGroup="Curso"
                                    Display="Dynamic"
                                    ForeColor="Red"
                                    ControlToValidate="tbNombre"  
                                    ClientValidationFunction="caracteresInvalidos"/>
        </td>
    </tr>
    <tr>
        <td> Apellido </td>
        <td> 
            <asp:TextBox ID="tbApellido" 
                            MaxLength="100"
                            runat="server" /> 
            <asp:RequiredFieldValidator ID="rfvApellido" 
                                        runat="server" 
                                        Display="Dynamic"
                                        ForeColor="Red"
                                        ValidationGroup="Curso"
                                        ControlToValidate="tbApellido" />
            <asp:CustomValidator ControlToValidate="tbApellido"  
                                    ID="cvApellido" 
                                    runat="server"
                                    ValidationGroup="Curso"
                                    ForeColor="Red"
                                    Display="Dynamic"
                                    ClientValidationFunction="caracteresInvalidos"/>
        </td>
    </tr>
    <tr>
        <td> Cuit </td>
        <td> 
            <asp:TextBox ID="tbCuit" 
                            MaxLength="11"
                            runat="server" />
            <asp:RequiredFieldValidator ID="rfvCuit" 
                                        runat="server" 
                                        Display="Dynamic"
                                        ValidationGroup="Curso"
                                        ForeColor="Red"
                                        ControlToValidate="tbCuit" />                    
            <asp:CustomValidator ID="cvCuit" 
                                    runat="server" 
                                    Display="Dynamic" 
                                    ForeColor="Red"
                                    EnableClientScript="true" 
                                    ClientValidationFunction="CuitValido" 
                                    ValidationGroup="Curso"
                                    ControlToValidate="tbCuit" />
            <asp:CustomValidator ID="cvCuitCaracteresInvalidos" 
                                    runat="server"
                                    ControlToValidate="tbCuit"  
                                    ValidationGroup="Curso"
                                    ForeColor="Red"
                                    Display="Dynamic"
                                    ClientValidationFunction="caracteresInvalidos"/> 
        </td>
    </tr>
    <tr>
        <td> Fecha de Nacimiento </td>
        <td>
            <asp:TextBox ID="tbFechaNacimiento"
                            runat="server"
                            MaxLength="10" />

            <asp:RegularExpressionValidator ID="revFechaNacimiento" 
                                            Display="Dynamic" 
                                            ControlToValidate="tbFechaNacimiento" 
                                            ValidationGroup="Curso"
                                            ForeColor="Red"
                                            runat="server"/>

        </td>
    </tr>
    <tr>
        <td> Tipo </td>
        <td>
            <asp:DropDownList ID="ddlTipo"
                                runat="server">
                <asp:ListItem Text="<< Seleccionar >>" Value="0" Selected="True"/>
                <asp:ListItem Text="Empleado" Value="1"/>
                <asp:ListItem Text="Cliente" Value="2"/>
                <asp:ListItem Text="Proveedor" Value="3"/>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="rfvTipo" 
                                        runat="server" 
                                        ControlToValidate="ddlTipo" 
                                        Display="Dynamic"
                                        ForeColor="Red"
                                        ValidationGroup="Curso"
                                        InitialValue="0"/>
        </td>
    </tr>
        
</table>