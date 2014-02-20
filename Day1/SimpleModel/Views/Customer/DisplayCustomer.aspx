<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<SimpleModel.Models.Customer>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>DisplayCustomer</title>
</head>
<body>
    <div>
    The customer name is <%= Model.Name %> <br />
    
    The Customer Code is <%= Model.Code %> <br />

    <% if (Model.Amount > 100)
       {
     %>  This is a privliged customer
     <%} else {
     %>  This is a normal customer
     <%}%> 
         
    </div>
</body>
</html>
