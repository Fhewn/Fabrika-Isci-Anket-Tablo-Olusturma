<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="kullaniciGirisi.aspx.cs" Inherits="Denim_Anket.kullaniciGirisi" %>


<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <title>Denim Kumas Kullanici Giris</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="author" content="colorlib.com">

    <!-- MATERIAL DESIGN ICONIC FONT -->
    <link rel="stylesheet" href="fonts/material-design-iconic-font/css/material-design-iconic-font.css">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" crossorigin="anonymous">
    <!-- STYLE CSS -->

    <link href="css/style.css" rel="stylesheet" />
</head>
<body>
    <div class="wrapper">
        <form id="form" runat="server">
            <!-- SECTION 1 -->
            <h2></h2>
            <div class="inner">
                <div class="image-holder">
                    <img src="images/form-wizard-1_2.png" alt="" height="521px">
                </div>
                <div class="form-content">
                    <div class="form-header">
                        <h5><strong>Denim Kumas Çalışan Memnuniyet Anketi</strong></h5>
                    </div>
                    <br />
                    <p></p>
                    <div class="form-row">
                        <asp:Label ID="lblmesaj" runat="server" Text=""></asp:Label>
                        <div class="col-lg-6">
                            <div class="col-lg-12">
                                <h6><strong>İsim Soyisim </strong></h6>
                            </div>
                            <div class="col-lg-12">
                                <div class="form-holder" style="width: 90%;">
                                    <asp:DropDownList ID="drpAdsoy" runat="server" CssClass="form-control">
                             
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-12">
                            <div class="col-lg-12">
                                <h6><strong>Departman Bilgisi </strong></h6>
                            </div>
                            <div class="col-lg-12">
                                <div class="form-holder">
                                    <asp:DropDownList ID="drpDepartman" runat="server" CssClass="form-control">
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>

                    </div>
                    <div class="col-lg-12">
                         <div class="col-lg-12">
                                <h6><strong>Yaş </strong></h6>
                            </div>
                    <div class="form-row">
                        <asp:DropDownList ID="drpyas" runat="server" CssClass="form-control">
                            <asp:ListItem Text="18 ve alti" Value="18 alt"></asp:ListItem>
                            <asp:ListItem Text="21-25" Value="21 25 arasi"></asp:ListItem>
                            <asp:ListItem Text="26-35" Value="26 35 arasi "></asp:ListItem>
                            <asp:ListItem Text="36-45" Value="36 45  arasi"></asp:ListItem>
                            <asp:ListItem Text="46-55" Value="46 55 arasi"></asp:ListItem>
                            <asp:ListItem Text="55 ve ustu" Value="55 ust"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    </div>


                    <div class="col-lg-12">
                        <div class="row">
                            <div class="col-lg-6">
                                <asp:RadioButtonList ID="rdrstat" runat="server" AutoPostBack="true" RepeatDirection="Vertical" CssClass="form-check">
                                    <asp:ListItem Text="Beyaz Yaka" Value="Beyaz Yaka"></asp:ListItem>
                                    <asp:ListItem Text="Mavi Yaka" Value="Mavi Yaka"></asp:ListItem>
                                    <asp:ListItem Text="Belirtmek İstemiyor" Value="Belirtmek İstemiyor"></asp:ListItem>
                                </asp:RadioButtonList>
                            </div>
                            <div class="col-lg-6">
                                <asp:RadioButtonList ID="rdrCinsiyet" runat="server" AutoPostBack="True" RepeatDirection="Vertical" CssClass="form-check">
                                    <asp:ListItem>Kadın</asp:ListItem>
                                    <asp:ListItem>Erkek</asp:ListItem>
                                    <asp:ListItem>Belirtmek İstemiyor</asp:ListItem>
                                </asp:RadioButtonList>
                            </div>

                        </div>
                    </div>


                    <div class="form-holder" style="align-self: flex-end; transform: translateY(4px);">
                        <asp:Button ID="btnKayit" CssClass="form-control btn btn-success" ForeColor="Black" Font-Bold="true" OnClick="btnKayit_Click" runat="server" Text="İsim Belirterek Devam Ediniz !" />
                        <asp:Button ID="btnMisafir" CssClass="form-control btn btn-secondary" ForeColor="Black" Font-Bold="true" runat="server" OnClick="btnMisafir_Click" Text="İsim Belirtmenden Devam Ediniz !" />
                        <asp:Button ID="btnDepartmanAdi" CssClass="form-control btn btn-primary" ForeColor="Black" Font-Bold="true" runat="server" OnClick="btnDepartmanAdi_Click" Text="Departman Adı İle Devam Ediniz !" />
                    </div>
                </div>
            </div>
        </form>
    </div>
    <!-- JQUERY -->
    <script src="js/jquery-3.3.1.min.js"></script>
    <!-- JQUERY STEP -->
    <script src="js/jquery.steps.js"></script>
    <script src="js/main.js"></script>
    <!-- Template created and distributed by Colorlib -->
</body>
</html>
