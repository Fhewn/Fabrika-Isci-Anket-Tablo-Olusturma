    <%@ Page Title="" Language="C#" MasterPageFile="~/Anket.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="SoruIslemleri.aspx.cs" Inherits="Denim_Anket.Yonetim.SoruIslemleri" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class="row">
    <div class="col-md-6">
      <div class="card card-primary">
        <div class="card-header">
          <h3 class="card-title">Soru Bankasi Soru Ekleme Sayfasi</h3>
        </div>
        <div>
          <div class="card-body">
            <div class="form-group">
              <label for="exampleInputEmail1">Soru</label>
              <asp:TextBox ID="txtSoru" CssClass="form-control" placeholder="Lutfen Soruyu Yaziniz..." runat="server"></asp:TextBox>
            </div>
          </div>
          <div class="card-footer">
            <asp:Button ID="btnSoruKayit" CssClass="btn btn-success swalDefaultSuccess" OnClick="btnSoruKayit_Click" runat="server" Text="Soruyu Kaydet." />
          </div>
        </div>
      </div>
    </div>
    <div class="col-md-6">
      <div class="card card-primary">
        <div class="card-header">
          <h3 class="card-title">Soru Bankasi Soru Silme</h3>
          <asp:DropDownList ID="drpSoruListesi" CssClass="form-control" OnSelectedIndexChanged="drpSoruListesi_SelectedIndexChanged" AutoPostBack="true" runat="server"></asp:DropDownList>
        </div>
        <div>
          <div class="card-body">
            <div class="form-group">
              <label for="exampleInputEmail1">Soru Sil</label></br>
           <asp:Label ID="Label1" runat="server" Text="" ClientIDMode="Inherit"></asp:Label>
            </div>
            <div class="card-footer">
              <asp:Button ID="btnSoruSil" runat="server" CssClass="btn btn-success swalDefaultDelete" OnClick="btnSoruSil_Click" Text="Sorulari Sil." />
            </div>
          </div>
        </div>
      </div>
    </div>
    <div class="col-md-6">
      <div class="card card-primary">
        <div class="card-header">
          <h3 class="card-title">Soru Bankasi Soru Listeleme</h3>
        </div>
        <div>
          <div class="card-body">
            <div class="form-group">
              <label for="exampleInputEmail1">Soru Listele</label>
              <asp:DataList ID="dtSoruList" CssClass=" table table-responsive" runat="server">
                <ItemTemplate>
                  <%# DataBinder.Eval(Container.DataItem, "Soru") %>
                </ItemTemplate>
              </asp:DataList>
            </div>
          </div>
          <div class="card-footer">
            <asp:Button ID="btnSoruList" runat="server" CssClass="btn btn-success swalDefaultSuccess" OnClick="btnSoruList_Click" Text="Sorulari Listeleyiniz." />
          </div>
        </div>
      </div>
    </div>
    <div class="col-md-6">
      <div class="card card-primary">
        <div class="card-header">
          <h3 class="card-title">Soru Bankasi Soru Guncelleme</h3>
          <asp:DropDownList ID="drpSoruGuncelle"  CssClass="form-control" OnSelectedIndexChanged="drpSoruGuncelle_SelectedIndexChanged" AutoPostBack="true" runat="server"></asp:DropDownList>
          </div>
        <div>
          <div class="card-body">
            <div class="form-group">
              <label for="exampleInputEmail1">Soru Guncelle</label>
               <asp:TextBox ID="txtSoruGuncelle" CssClass="form-control"  runat="server"></asp:TextBox><br />
              <asp:Label ID="lblSecilenSoruId" runat="server" Text=""></asp:Label>
            </div>
          </div>
          <div class="card-footer">
            <asp:Button ID="btnSoruGuncel" runat="server" CssClass="btn btn-success swalDefaultUpdate" OnClick="btnSoruGuncel_Click"  Text="Soruyu Guncellle." />
          </div>
        </div>
      </div>
                
</asp:Content>
