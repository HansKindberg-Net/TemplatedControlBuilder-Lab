<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication.Default" %>
<%@ Register TagPrefix="HansKindberg" Namespace="HansKindberg.Web.UI" Assembly="HansKindberg" %>
<!DOCTYPE html>
<html>
	<head>
		<title>Default</title>
	</head>
	<body>
		<div>
			<h2>StringTemplatedControl</h2>
			<HansKindberg:StringTemplatedControl id="stringTemplatedControl" DataSource="<%# this.StringDataSource %>" runat="server" />
		</div>
		<div>
			<h2>IntegerTemplatedControl</h2>
			<HansKindberg:IntegerTemplatedControl id="integerTemplatedControl" DataSource="<%# this.IntegerDataSource %>" runat="server" />
		</div>
	</body>
</html>