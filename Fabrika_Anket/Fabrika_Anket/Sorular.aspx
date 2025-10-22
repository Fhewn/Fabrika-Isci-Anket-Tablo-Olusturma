<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Sorular.Master" CodeBehind="Sorular.aspx.cs" Inherits="Denim_Anket.SoruGor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <audio id="oynatici1" src="bgSound.mp3"></audio>
    <script>
      const player = document.querySelector("#oynatici1");
      window.onload = function () {

        //sure deðiþkeni yoksa 0 varsa olan süreden baþlayacak
        let sure = 0;
        if (localStorage.getItem('sure')) {
          sure = localStorage.getItem('sure');
        }

        player.play();
        player.currentTime = sure;
      }

      window.onbeforeunload = function () {

        sure = player.currentTime;
        localStorage.setItem('sure', sure);
      }
    </script>
    <asp:Label ID="lblSayi" runat="server" Visible="false" Text="0"></asp:Label>
    <div class="wrapper position-relative overflow-hidden">
        <div class="container-md-fluid p-3 p-lg-0 me-5">
            <div class="row">
                <div class="col-xl-4">
                  <%--  <div class="form_logo position-absolute">
                        <a href="javascript:void(0)">
                            <img src="assets/images/logo/DynamoLogo.svg" style="width:170px; height:170px; text-align:center; "alt="image-not-found">
                        </a>
                    </div>--%>
                    <div class="steps_area step_area_fixed d-none d-xl-block">
                        <div class="image_holder">
                            <img class="overflow-hidden" src="assets/images/background/form-wizard-1_2.png" alt="image-not-found">
                        </div>
                    </div>
                </div>
                <div class="col-xl-7 ps-5 pt-5">
                    <div class="multisteps_form_panel" style="display: block;">
                        <div class="step_content d-flex justify-content-between pt-2 pb-2">
                            <h4><asp:Label ID="lblKullanici" ForeColor="Black" CssClass="" runat="server" Text="Label"></asp:Label></h4>
                            <span class="text-end text-uppercase">Kalan Soru : <asp:Label ID="lblSayi2" runat="server" Text="Label"></asp:Label> to 71</span>
                        </div>
                        <div class="step_progress_bar">
                            <div class="progress rounded-pill">
                                <div class="progress-bar" style="width: 100%"></div>
                            </div>
                        </div>
                        <div class="form_content">
                            <div class="question_title py-5">
                                <h3 class="text-capitalize">
                                    <asp:Label ID="lblSoruGetir" runat="server" Text=""></asp:Label></h3>
                            </div>
                            <div class="row row-cols-1 row-cols-sm-2 row-cols-md-4 form_items">
                                <div class="col col-2">
                                    <div id="opt_1" class="step_1 d-flex flex-column bg-white text-center animate__animated animate__fadeInRight animate_25ms" data-id="1">
                                        <div class="step_box_icon">
                                            <asp:ImageButton ID="imgBtn1" CssClass="step_box_icon" ImageUrl="~/assets/images/item-img/DoubleCheck.png" runat="server" Width="75px" Height="75px" OnClick="imgBtn1_Click" AlternateText="Kesinlikle Katýlýyorum" />
                                        </div>

                                        <asp:Label ID="lbl1" runat="server" Text="Label" Visible="false"></asp:Label>
                                        <br />
                                        <span class="step_box_text" style="font-size: 15px;">Kesinlikle Katýlýyorum </span>


                                    </div>
                                </div>
                                <div class="col col-2">
                                    <div id="opt_2" class="step_1 d-flex flex-column bg-white text-center animate__animated animate__fadeInRight animate_50ms active" data-id="2">

                                        <div class="step_box_icon">
                                            <asp:ImageButton ID="imgkatilmiyom" CssClass="step_box_icon" ImageUrl="~/assets/images/item-img/check.png" Width="75px" Height="75px" runat="server" OnClick="imgkatilmiyom_Click" AlternateText="Katýlýyorum" />
                                        </div>
                                        <asp:Label ID="lbl2" runat="server" Text="Label" Visible="false"></asp:Label>
                                        <br />
                                        <span class="step_box_text" style="font-size: 15px;">Katýlýyorum </span>

                                    </div>
                                </div>
                                <div class="col col-2">
                                    <div id="opt_3" class="step_1 d-flex flex-column bg-white text-center animate__animated animate__fadeInRight animate_100ms" data-id="3">
                                        <div class="step_box_icon">
                                            <asp:ImageButton ID="imgkararsiz" runat="server" CssClass="step_box_icon" ImageUrl="~/assets/images/item-img/Notr.png" Width="75px" Height="75px" OnClick="imgkararsiz_Click" AlternateText="Kararsizim" />
                                        </div>
                                        <asp:Label ID="lbl3" runat="server" Text="Label" Visible="false"></asp:Label>
                                        <br />
                                        <span class="step_box_text" style="font-size: 15px;">Kararsizim</span>
                                    </div>
                                </div>
                                <div class="col col-2">
                                    <div id="opt_4" class="step_1 d-flex flex-column bg-white text-center animate__animated animate__fadeInRight animate_150ms" data-id="4">
                                        <div class="step_box_icon">
                                            <asp:ImageButton ID="imgkatiliyom" runat="server" CssClass="step_box_icon" ImageUrl="~/assets/images/item-img/Disagree.png" Width="75px" Height="75px" OnClick="imgkatiliyom_Click" AlternateText="Katýlmýyorum" />
                                        </div>
                                        <asp:Label ID="lbl4" runat="server" Text="Label" Visible="false"></asp:Label>
                                        <br />
                                        <span class="step_box_text " style="font-size: 15px;">Katýlmýyorum</span>
                                    </div>
                                </div>
                                <div class="col col-2">
                                    <div id="opt_4" class="step_1 d-flex flex-column bg-white text-center animate__animated animate__fadeInRight animate_150ms" data-id="5">
                                        <div class="step_box_icon">
                                            <asp:ImageButton ID="imgkkatiliyom" runat="server" CssClass="step_box_icon" ImageUrl="~/assets/images/item-img/DoubleDisagree.png" Width="75px" Height="75px" OnClick="imgkkatiliyom_Click" AlternateText="Kesinlikle Katýlmýyorum" />
                                        </div>
                                        <asp:Label ID="lbl5" runat="server" Text="Label" Visible="false"></asp:Label>
                                        <br />
                                        <span class="step_box_text" style="font-size: 15px;">Kesinlikle Katýlmýyorum</span>
                                    </div>
                                </div>




                            </div>
                        </div>
                        <div class="form_btn pt-5 d-flex justify-content-between">
                            <button type="button" class="" id="prevBtn" onclick="nextPrev(-1)" style="display: none;">
                                <span><i class="fas fa-arrow-left"></i></span>Bi
                            </button>
                            <asp:Label ID="lblCevap" runat="server" Text="Label" Visible="false"></asp:Label>
                            <asp:Label ID="lblSicilId" runat="server" Text="0" Visible="false" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

