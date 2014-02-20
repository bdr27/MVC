<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script runat="server">
</script>
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>FillCustomer</title>
</head>
<body>
    <form method="post" action="DisplayCustomer">
    Customer Name :- <input type="text" name="CustomerName" /> <br />
    Customer Code :- <input type="text" name="CustomerCode" /> <br />
    Customer Amount :- <input type="text" name="CustomerAmount" /> <br />
    <input type="submit" value="Click Here" />
    </form>
</body>
</html>
