<%@ Page Title="Our Menu" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="MenuItems.aspx.cs" Inherits="MenuItems" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1>Our Menu</h1>
    <asp:GridView ID="MenuGridView" runat="server"></asp:GridView>
    <hr />
    <asp:Repeater ID="MenuRepeater" runat="server" ItemType="eRestaurant.Entities.DTOs.CategoryWithItems">
        <ItemTemplate>
            <div>
                <h3><%# Item.Description %></h3>
                <blockquote>
                    <asp:Repeater ID="MenuItemRepeater" runat="server" 
                        ItemType="eRestaurant.Entities.POCOs.MenuItem" 
                        DataSource="<%# Item.MenuItems %>">
                        <ItemTemplate>
                            <b><%# Item.CategoryDescription %></b> - 
                            <%# Item.Price.ToString("C") %> - 
                            <%# Item.Calories %>
                        </ItemTemplate>
                    </asp:Repeater>
                </blockquote>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>

