<%@ Page Title="" Language="C#" MasterPageFile="~/Share.Master" AutoEventWireup="true" CodeBehind="doctorlogin.aspx.cs" Inherits="HospitalAppointmentSystem.doctorlogin" %>
<asp:Content ID="MainContentForDoctorLogin" ContentPlaceHolderID="MainContent" runat="server">
    <div class="wrap">
        <div class="col span_2_of_3">
				  <div class="login-form" style="padding-left:50px">
				  	<h2>Doctor Login</h2>
					    <form>
					    	<div>
						    	<span><label>Social Security Number</label></span>
						    	<span><input type="text" value="" placeholder="SSN"></span>
						    </div>
						    <div>
						    	<span><label>Password</label></span>
						    	<span><input type="password" value=""></span>
						    </div>
						    
						   <div>
						   		<span><input type="submit" value="Login"></span>
						  </div>
					    </form>
				    </div>
            </div>
  			</div>

</asp:Content>
